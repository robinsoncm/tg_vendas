using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using LES_15_II_N.Properties;

namespace LES_15_II_N
{
    public partial class FrmLogin : Form
    {
        
        public FrmLogin()
        {
            InitializeComponent();
            tentativas = 3;
            diferencadias = 0;
        }


        static int tentativas;
        public string usuario, senha, bloqueio;
        public int qtde, funcodi;
        DateTime datacad;
        DateTime dataatual = DateTime.Now;
        int diferencadias;
        public int nivel;


        private void Limpar()
        {
            txtsenha.Clear();
            txtusuario.Clear();
            txtusuario.Focus();
        }



        public void ConsultaUsuario(FbDataReader dr)
        {
            usuario = dr["USUNOME"].ToString();
            senha = dr["USUSENHA"].ToString();
            bloqueio = dr["USUBLOQ"].ToString();
            qtde = Convert.ToInt32(dr["USUQTDE"].ToString());
            datacad = Convert.ToDateTime(dr["USUDATA"].ToString());
            funcodi = Convert.ToInt32(dr["FUNCODI"].ToString());
            nivel = Convert.ToInt32(dr["USUNIVEL"].ToString());
        }



        private void VerificarDiferencaData()
        {
            TimeSpan ts = dataatual - datacad;
            diferencadias = ts.Days;
        }



        private bool ValidacaoUsuario()
        {
            if ((usuario.ToString() == txtusuario.Text) && (senha.ToString().Trim() == txtsenha.Text))
            {
                return true;
            }
            else
            {
                tentativas--;
                return false;
            }
        }



        private void Autenticacao()
        {
            string strBusca = "SELECT * FROM USUARIO WHERE USUNOME = '" + txtusuario.Text + "'";
            try
            {
                Conexao.Active(true);
                FbCommand cmd = new FbCommand(strBusca, Conexao.FbCnn);
                FbDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ConsultaUsuario(dr);

                    VerificarDiferencaData();
                    if (tentativas > 0)
                    {
                        if (ValidacaoUsuario())
                        {
                            if (diferencadias >= 30)
                            {
                                qtde--;
                                if (bloqueio != "S")
                                {
                                    if (qtde > 0)
                                    {
                                        if ((MessageBox.Show("Senha vencida\n Deseja trocar sua senha?", "Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                                        {
                                            MessageBox.Show("Você possui " + qtde + "restantes!");
                                            string strAlterar = "UPDATE USUARIO SET USUQTDE = '" + qtde.ToString() + "' WHERE USUNOME = '" + txtusuario.Text + "' ";
                                            FbCommand cmd1 = new FbCommand(strAlterar, Conexao.FbCnn);
                                            cmd1.ExecuteNonQuery();

                                            this.Hide();
                                            FrmPrincipal principal = new FrmPrincipal(this);
                                            principal.ShowDialog();
                                            this.Close();
                                        }
                                        else
                                        {
                                            this.Hide();
                                            FrmUsuario usu = new FrmUsuario(this);
                                            usu.ShowDialog();
                                            this.Close();
                                        }
                                    }
                                    else
                                    {
                                        try
                                        {
                                            string strAlterar = "UPDATE USUARIO SET USUBLOQ = 'S' WHERE USUNOME = '" + txtusuario.Text + "' ";
                                            FbCommand cmd1 = new FbCommand(strAlterar, Conexao.FbCnn);
                                            cmd1.ExecuteNonQuery();
                                            MessageBox.Show("Usuário" + txtusuario.Text + " está sendo bloqueado!!");
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.Message);
                                        }

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Usuario Bloqueado!");
                                    Limpar();
                                }
                            }
                            else
                            {
                                if (bloqueio != "S")
                                {
                                    this.Hide();
                                    FrmPrincipal principal = new FrmPrincipal(this);
                                    principal.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Usuario Bloqueado!");
                                    Limpar();
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Senha incorreta!\n Tentativas Restantes: " + tentativas);
                            Limpar();
                        }
                    }
                    else
                    {
                        try
                        {
                            string strAlterar = "UPDATE USUARIO SET USUBLOQ = 'S' WHERE USUNOME = '" + txtusuario.Text + "' ";
                            FbCommand cmd1 = new FbCommand(strAlterar, Conexao.FbCnn);
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Usuário " + txtusuario.Text + " bloqueado!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Usuário inválido!!\n");
                    txtusuario.Clear();
                    txtusuario.Focus();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }


        private void btnok_Click(object sender, EventArgs e)
        {

            Autenticacao();

            //FrmPrincipal principal = new FrmPrincipal(); // depois de acertado apagar
            //principal.ShowDialog();
            /*Conexao.Active(true);
            if (txtusuario.Text.Trim().Length > 0 && txtsenha.Text.Trim().Length > 0)
            {
                string strConsulta = "SELECT USUNOME, USUSENHA FROM USUARIO WHERE USUNOME = '" + txtusuario.Text + "' AND USUSENHA = '" + txtsenha.Text + "'";
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if(dr.Read())
                    {
                        FrmPrincipal principal = new FrmPrincipal();
                        principal.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou Senha Incorretos");
                    }
                    //Conexao.Active(false);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
            else 
            {
                MessageBox.Show("Informe o Usuário e senha");
            }*/
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtsenha.UseSystemPasswordChar = true;
        }
           
        

        private void btnsair_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Deseja sair?", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
            {
                txtusuario.Focus();
            }
            else
            {
                Application.Exit();
            }
        }




        private void chbmostrar_CheckStateChanged(object sender, EventArgs e)
        {
            if (chbmostrar.Checked)
            {
                txtsenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtsenha.UseSystemPasswordChar = true;
            }
        }



        private void txtusuario_Enter(object sender, EventArgs e)
        {

        }




        private void txtusuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }



        private void txtsenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnok.Focus();
            }
        }



        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)39) || (e.KeyChar == (char)34))
            {
                e.Handled = true;
            }
        }


        private void txtsenha_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* if ((e.KeyChar == (char)39) || (e.KeyChar == (char)34))
            {
                e.Handled = true;
            }*/
        }
             
       



        
       

        /*private void Limpar()
        {
            txtusuario.Clear();
            txtsenha.Clear();
            txtusuario.Focus();
        }*/

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }

        


        /*private void ConsultaUsuario(FbDataReader dr)
        {
            txtusuario.Text = dr["USUNOME"].ToString();
            txtsenha.Text = dr["USUSENHA"].ToString();
        }*/

        private void txtusuario_Leave(object sender, EventArgs e)
        {
        }


       

        /*private void txtsenha_TextChanged(object sender, EventArgs e)
        {
            txtsenha.PasswordChar = '*';
        }*/

          
                
              
        
        
    }

}
