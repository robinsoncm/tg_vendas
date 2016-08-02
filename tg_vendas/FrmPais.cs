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
    public partial class FrmPais : Form
    {
        public FrmPais()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtcodigopais.Clear();
            txtnomepais.Clear();
            txtcodigopais.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Fechar a Opção ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();

        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            {
                string strIncluir = "INSERT INTO PAIS"
                                    + " VALUES("
                                    + "" + txtcodigopais.Text + ", '" + txtnomepais.Text + "'"
                                    + " )";
                Conexao.Active(true);
                try
                {
                    FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado com Sucesso!");
                    Limpar();
                    txtcodigopais.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
        }

        private void ConsultaPais(FbDataReader dr)
        {
            txtcodigopais.Text = dr["PAICODI"].ToString();
            txtnomepais.Text = dr["PAINOME"].ToString();
        }

        private void txtcodigopais_Leave(object sender, EventArgs e)
        {
            {
                Conexao.Active(true);
                if (txtcodigopais.Text != "")
                {
                    string strConsulta = "SELECT PAICODI, PAINOME FROM PAIS WHERE PAICODI = " + txtcodigopais.Text;
                    try
                    {
                        FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                        FbDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            //MessageBox.Show("oi");
                            ConsultaPais(dr);
                            txtnomepais.Focus();
                        }
                        else
                        {
                            if ((MessageBox.Show(" País não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                            {
                                Limpar();
                            }
                            else
                            {
                                txtnomepais.Text = "";
                                txtnomepais.Focus();
                            }
                        }
                        //Conexao.Active(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Conexao.Active(false);
                }

            }
        }


        private void FrmPais_KeyDown(object sender, KeyEventArgs e)
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

        private void btngravar_Click_1(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE PAIS"
         + " SET PAICODI = " + txtcodigopais.Text + ", "
         + " PAINOME = '" + txtnomepais.Text + "'"
         + " WHERE PAICODI = " + txtcodigopais.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Alteração Efetuada ! ");
                Limpar();
                txtcodigopais.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM PAIS WHERE PAICODI = " + (txtcodigopais.Text);
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                Limpar();
                txtcodigopais.Focus();
                MessageBox.Show("Operação concluida!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }

        private void FrmPais_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            Limpar();
        }



    }
}

