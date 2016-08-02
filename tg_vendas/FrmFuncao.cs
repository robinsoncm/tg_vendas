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
    public partial class FrmFuncao : Form
    {
        public FrmFuncao()
        {
            InitializeComponent();
        }


        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtcodfuncao.Clear();
            txtnomefuncao.Clear();
            txtcodigocbo.Clear();
            txtdescricaocbo.Clear();
        }


        private void btnincluir_Click(object sender, EventArgs e)
        {
            //OS CAMPOS SAO SEPARADOS POR VIRGULA
            //OS CAMPOS TEXTO PRECISAM DE UMA ASPAS SIMPLES PARA INSERIR

            string strIncluir = "INSERT INTO FUNCAO"
                                + " VALUES("
                                + txtcodfuncao.Text + " , ' " + txtnomefuncao.Text + " ', " + txtcodigocbo.Text + ")";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Cadastro Realizado com Sucesso ! ");
                Limpar();
                txtcodfuncao.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }

        private void ConsultaFuncao(FbDataReader dr)
        {
            txtcodfuncao.Text = dr["FUCCODI"].ToString();
            txtnomefuncao.Text = dr["FUCNOME"].ToString();
            txtcodigocbo.Text = dr["CBOCODI"].ToString();
        }


        private void txtcodfuncao_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtcodfuncao.Text != "")
            {
                string strConsulta = "SELECT FUCCODI, FUCNOME, CBOCODI FROM FUNCAO WHERE FUCCODI = " + txtcodfuncao.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        //MessageBox.Show("oi");
                        ConsultaFuncao(dr);
                        txtnomefuncao.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show(" Função não encontrada \n deseja cadastra-la?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            Limpar();
                        }
                        else
                        {
                            txtnomefuncao.Text = "";
                            txtnomefuncao.Focus();
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




        private void btnvoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Fechar a Opção ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void FrmFuncao_KeyDown(object sender, KeyEventArgs e)
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

        private void btngravar_Click(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE FUNCAO"
                                 + " SET FUCCODI = " + txtcodfuncao.Text + ", "
                                 + " FUCNOME = '" + txtnomefuncao.Text + "' , "
                                 + " CBOCODI = " + txtcodigocbo.Text
                                 + " WHERE FUCCODI = " + txtcodfuncao.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Alteração Efetuada ! ");
                Limpar();
                txtcodfuncao.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM FUNCAO WHERE FUCCODI = '" + (txtcodfuncao.Text) + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                Limpar();
                txtcodfuncao.Focus();
                MessageBox.Show("Operação concluida!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }



        private void ConsultaCbo(FbDataReader dr)
        {
            txtcodigocbo.Text = dr["CBOCODI"].ToString();
            txtdescricaocbo.Text = dr["CBONOME"].ToString();
        }



        private void txtcbo_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtcodigocbo.Text != "")
            {
                string strConsulta = "SELECT CBOCODI, CBONOME FROM CBO WHERE CBOCODI = '"
                    + txtcodigocbo.Text + "'";
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        //MessageBox.Show("oi");
                        ConsultaCbo(dr);
                        txtcodigocbo.Focus();
                    }
                    else
                    {

                        FrmCbo cbo = new FrmCbo();
                        cbo.Visible = true;
                        cbo.Show();
                        cbo.txtcodigocbo.Text = txtcodigocbo.Text;
                        cbo.txtdescricao.Focus();
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

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
    



