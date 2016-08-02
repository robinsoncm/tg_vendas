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
    public partial class FrmEstado : Form
    {
        public FrmEstado()
        {
            InitializeComponent();
        }


        private void btnlimpar_Click_1(object sender, EventArgs e)
        {
            Limpar();
        }

       

        private void Limpar()
        {
            txtestuf.Clear();
            txtestnome.Clear();
            txtesticms.Clear();
            txtcodigopais.Clear();
            txtnomepais.Clear();
            txtestuf.Focus();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            string strIncluir = "INSERT INTO ESTADO"
                                + " VALUES("
                                + "" + "'" 
                                + txtestuf.Text + "' , '" 
                                + txtestnome.Text + "' , "
                                + txtesticms.Text + ","
                                + txtcodigopais.Text + ", "
                                + txtcodigopais.Text + " "
                                + " )";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro Realizado com Sucesso!");
                Limpar();
                txtestuf.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);       
       }

        private void ConsultaEst(FbDataReader dr)
        {
            txtestuf.Text = dr["ESTUF"].ToString();
            txtestnome.Text = dr["ESTNOME"].ToString();
            txtesticms.Text = dr["ESTICMS"].ToString();
            txtcodigopais.Text = dr["ESTCODI"].ToString();
        }


        private void txtestuf_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtestuf.Text != "")
            {
                string strConsulta = "SELECT ESTUF, ESTNOME, ESTICMS, ESTCODI, PAICODI  FROM ESTADO WHERE ESTUF = '" 
                    + txtestuf.Text + "'";
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        //MessageBox.Show("oi");
                        ConsultaEst(dr);
                        txtestnome.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Estado não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            Limpar();
                        }
                        else
                        {
                            txtestnome.Text = "";
                            txtestnome.Focus();
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

        private void btngravar_Click(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE ESTADO"
                                + " SET ESTUF = '" + txtestuf.Text + "', "
                                + " ESTNOME = '" + txtestnome.Text + "' , "
                                + " ESTICMS = " + txtesticms.Text + ", "
                                + " ESTCODI = " + txtcodigopais.Text
                                + " WHERE ESTUF = '" + txtestuf.Text + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Alteração Efetuada ! ");
                Limpar();
                txtestuf.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }

        private void brndeletar_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM ESTADO WHERE ESTUF = '" + (txtestuf.Text) + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                Limpar();
                txtestuf.Focus();
                MessageBox.Show("Operação concluida!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Fechar a Opção ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            this.Close();
        }

        private void FrmEstado_KeyDown(object sender, KeyEventArgs e)
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

        private void ConsultaPais(FbDataReader dr)
        {
            txtcodigopais.Text = dr["PAICODI"].ToString();
            txtnomepais.Text = dr["PAINOME"].ToString();
        }

        private void txtcodigopais_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtcodigopais.Text != "")
            {
                string strConsulta = "SELECT PAICODI, PAINOME  FROM PAIS WHERE PAICODI = '"
                    + txtcodigopais.Text + "'";
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

                        FrmPais pai = new FrmPais();
                        pai.Visible = true;
                        pai.Show();
                        pai.txtcodigopais.Text = txtcodigopais.Text;
                        pai.txtnomepais.Focus();
                        /*if ((MessageBox.Show("País não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            Limpar();
                        }
                        else
                        {
                            txtnomepais.Text = "";
                            txtnomepais.Focus();
                        }*/
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

       private void txtesticms_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigopais_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnomepais_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtestuf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        

        
    }
}
