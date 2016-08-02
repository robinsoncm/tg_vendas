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
    public partial class FrmEndereco : Form
    {
        public FrmEndereco()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            txtendcep.Clear();
            txtendendereco.Clear();
            txtcodigobairro.Clear();
            txtnomebairro.Clear();
            txtendcep.Focus();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            {
                string strIncluir = "INSERT INTO ENDERECO "
                                    + " VALUES("
                                    + "" + "'" 
                                    + txtendcep.Text + "' , '"                                    
                                    + txtendendereco.Text + "' , '" 
                                    + txtcodigobairro.Text + "' "
                                    + ")";
                Conexao.Active(true);
                try
                {
                    FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado com Sucesso!");
                    Limpar();
                    txtendcep.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
        }

        private void ConsultaEnde(FbDataReader dr)
        {
            txtendcep.Text = dr["ENDCEP"].ToString();
            txtendendereco.Text = dr["ENDENDE"].ToString();
            txtcodigobairro.Text = dr["BAICODI"].ToString();          
        }


        private void FrmEndereco_KeyDown(object sender, KeyEventArgs e)
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


        private void btnvoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Fechar a Opção ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }



        private void btndeletar_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM ENDERECO WHERE ENDCEP = '" + (txtendcep.Text) + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                Limpar();
                txtendcep.Focus();
                MessageBox.Show("Operação concluida!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }



        private void btngravar_Click(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE ENDERECO"
                              + " SET ENDCEP = '" + txtendcep.Text + "', "
                              + " BAICODI = " + txtcodigobairro.Text + ", "
                              + " ENDENDE = '" + txtendendereco.Text + "'  "                                                        
                              + " WHERE ENDCEP = '" + txtendcep.Text + "' ";

            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Alteração Efetuada!");
                Limpar();
                txtendcep.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }


        private void txtendcep_Leave(object sender, EventArgs e)
        {

        }

        private void txtcodigobairro_Leave(object sender, EventArgs e)
        {

            Conexao.Active(true);
            if (txtcodigobairro.Text != "")
            {
                string strConsulta = "SELECT BAICODI, BAINOME FROM BAIRRO WHERE BAICODI = '" + txtcodigobairro.Text + "'";
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ConsultaBairro(dr);
                        txtcodigobairro.Focus();
                    }
                    else
                    {
                            FrmBairro bai = new FrmBairro();
                            bai.Visible = true;
                            bai.Show();
                            bai.txtcodigobairro.Text = txtcodigobairro.Text;
                            bai.txtnomebairro.Focus();   
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }

        }

        private void ConsultaBairro(FbDataReader dr)
        {
            txtcodigobairro.Text = dr["BAICODI"].ToString();
            txtnomebairro.Text = dr["BAINOME"].ToString();           
        }

        private void txtendcep_Leave_1(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtendcep.Text != "")
            {
                string strConsulta = "SELECT ENDCEP, ENDENDE, BAICODI FROM ENDERECO WHERE ENDCEP = '"
                    + txtendcep.Text + "'";
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        //MessageBox.Show("oi");
                        ConsultaEnde(dr);
                        txtendendereco.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show(" Endereço não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            Limpar();
                        }
                        else
                        {
                            txtendendereco.Text = "";
                            txtendendereco.Focus();
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

    }
}

