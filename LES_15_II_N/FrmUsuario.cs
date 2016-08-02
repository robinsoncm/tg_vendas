using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace LES_15_II_N
{
    public partial class FrmUsuario : Form
    {

      

        FrmLogin InstanciaLogin;

        public FrmUsuario()
        {
            InitializeComponent();
        }

        public FrmUsuario(FrmLogin login){
            InitializeComponent();
            InstanciaLogin = login;
            dtpusudata.Value = DateTime.Today;
            txtbloq.CharacterCasing = CharacterCasing.Upper;
        }


        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            dtpusudata.Value = DateTime.Today;
            txtbloq.CharacterCasing = CharacterCasing.Upper;
        }


        private void ConsultaUsuario(FbDataReader dr)
        {
            txtfunc.Text = dr["FUNCODI"].ToString();
            txtusuario.Text = dr["USUNOME"].ToString();
            txtsenha.Text = dr["USUSENHA"].ToString();
            txtusunivel.Text = dr["USUNIVEL"].ToString();
            dtpusudata.Text = dr["USUDATA"].ToString();
            txtqtde.Text = dr["USUQTDE"].ToString();
            txtbloq.Text = dr["USUBLOQ"].ToString();


            if (txtbloq.Text == "N")
            {
                txtbloq.Text = "AUTORIZADO";
            }
            else
            {
                txtbloq.Text = "BLOQUEADO";
            }

        }


        private void btnvoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Fechar a Opção ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }


        
        private void Limpar()
        {
            txtfunc.Clear();
            txtusuario.Clear();
            dtpusudata.Value = DateTime.Today;
            txtbloq.Clear();
            txtqtde.Clear();
            txtsenha.Clear();
            txtusunivel.Clear();
            txtfunc.Focus();
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }


        private void txtfunc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        
        private string FormatarData(string dataformatada)
        {
            DateTime data = new DateTime();
            data = dtpusudata.Value;
            data.ToShortDateString();
            string format = "yyyy/MM/dd";
            data.ToString("d");
            dataformatada = data.ToString(format);
            return dataformatada;
        }



        private void btnincluir_Click_1(object sender, EventArgs e)
        {
            string data = DateTime.Today.ToShortDateString();
            data = FormatarData(data);
            txtqtde.Text = "10";
            txtbloq.Text = "N";
            string strIncluir = "INSERT INTO USUARIO "
                              + "VALUES('" + txtfunc.Text + "', '" + txtusuario.Text + "', '"
                              + txtsenha.Text + "', '"
                              + txtusunivel.Text + "', '"
                              + data.ToString() + "', '"
                              + txtqtde.Text + "', '"
                              + txtbloq.Text + "' )";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado com Sucesso!");
                Limpar();
                txtfunc.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }



        private void btndeletar_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM USUARIO WHERE FUNCODI = '" + (txtfunc.Text) + "'";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                Limpar();
                MessageBox.Show("Operação concluida!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }


        private void btngravar_Click_1(object sender, EventArgs e)
        {
            string data = DateTime.Today.ToShortDateString();
            data = FormatarData(data);
            string strAlterar = "UPDATE USUARIO "
                              + "SET FUNCODI = '" + txtfunc.Text + "', "
                              + "USUNOME = '" + txtusuario.Text + "', "
                              + "USUSENHA = '" + txtsenha.Text + "', "
                              + "USUNIVEL = '" + txtusunivel.Text + "', "
                              + "USUDATA = CURRENT_DATE, "
                              + "USUQTDE = 10, "
                              + "USUBLOQ = 'N' "
                              + "WHERE FUNCODI = '" + txtfunc.Text + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Alteração Efetuada com Sucesso!");
                Limpar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
            txtususenhaconfirmar.Clear();
            Limpar();
            txtfunc.Focus();
        }


        private void txtfunc_Leave_1(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtfunc.Text != "")
            {
                string strConsulta = "SELECT * FROM USUARIO WHERE FUNCODI = '" + txtfunc.Text + "'";
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        ConsultaUsuario(dr);
                        txtusuario.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Usuário não encontrado \n Deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                           

                            Limpar();
                        }
                        else
                        {
                            txtusuario.Text = "";
                            txtusuario.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
        }



        private void txtusuario_Leave_1(object sender, EventArgs e)
        {
            if (ContemLetrasNome(txtusuario.Text))
            {
                txtsenha.Focus();
            }
            else
            {

                MessageBox.Show("O nome de usuário deve conter no mínimo 1 caractere e no máximo 20 caracteres!");
                txtusuario.Clear();
                txtusuario.Focus();
            }
        }



        private bool ContemLetrasNome(string txt)
        {
            if (txt.Where(c => char.IsLetter(c)).Count() >= 1 && txt.Where(c => char.IsLetter(c)).Count() <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private bool ContemLetrasSenha(string txt)
        {
            if (txt.Where(c => char.IsLetter(c)).Count() >= 1 && txt.Where(c => char.IsLetter(c)).Count() <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private bool ContemNumeros(string txt)
        {
            if (txt.Where(c => char.IsNumber(c)).Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void txtsenha_TextChanged(object sender, EventArgs e)
        {
            txtsenha.PasswordChar = '*';
            
        }




        private void txtsenha_Leave(object sender, EventArgs e)
        {
            if (txtsenha.Text.Length >= 6 && txtsenha.Text.Length <= 10)
            {
                if (ContemLetrasSenha(txtsenha.Text) && ContemNumeros(txtsenha.Text))
                {
                    txtususenhaconfirmar.Focus();
                }
                else
                {
                    
                    MessageBox.Show("A senha deve conter letras e números!!");
                        
                    

                    txtsenha.Clear();
                    txtsenha.Focus();
                }
            }
            else
            {
                
                MessageBox.Show("A senha deve conter no mínimo 6 caracteres!");                
                              
                txtsenha.Clear();
                txtsenha.Focus();
            }
        }



                          
        
        private void ConsultaFunc(FbDataReader dr)
        {
            txtfunc.Text = dr["FUNCODI"].ToString();
            txtnomefunc.Text = dr["FUNNOME"].ToString();
        }    


        
        
        /*private void ConsultaUsu(FbDataReader dr)
        {
            txtfunc.Text = dr["FUNCODI"].ToString();
            txtusuario.Text = dr["USUNOME"].ToString();
            txtsenha.Text = dr["USUSENHA"].ToString();
            cbxnivel.Text = dr["USUNIVEL"].ToString();
            txtdata.Text = dr["USUDATA"].ToString();
            txtqtde.Text = dr["USUQTDE"].ToString();
            txtbloq.Text = dr["USUBLOQ"].ToString();

        }*/
        
        
       



        

       

        

        



        



        



        private void FrmUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }


            if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("Deseja sair do sistema ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }

            }
        }

        private void txtususenhaconfirmar_Leave(object sender, EventArgs e)
        {
            if (txtsenha.Text.Trim() != txtususenhaconfirmar.Text)
            {
                
                    MessageBox.Show("Senhas incompatíveis!!");
                    
                    txtususenhaconfirmar.Focus();
                

                //txtususenhaconfirmar.Focus();
            }
            else
            {
                txtusunivel.Focus();
            }
        }

        private void txtfunc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;
            }
        }



       

       

              
                
    }
}
