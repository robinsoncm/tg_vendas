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
    public partial class FrmCbo : Form
    {
        public FrmCbo()
        {
            InitializeComponent();
        }

        private void FrmCbo_Load(object sender, EventArgs e)
        {

        }

        private void FrmCbo_KeyDown(object sender, KeyEventArgs e)
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

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtcodigocbo.Clear();
            txtdescricao.Clear();
            txtcodigocbo.Focus();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            //OS CAMPOS SAO SEPARADOS POR VIRGULA
            //OS CAMPOS TEXTO PRECISAM DE UMA ASPAS SIMPLES PARA INSERIR

            string strIncluir = "INSERT INTO CBO"
                                + " VALUES("
                                + txtcodigocbo.Text + " , ' " + txtdescricao.Text + "')";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Cadastro Realizado com Sucesso ! ");
                Limpar();
                txtcodigocbo.Focus();
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
            txtdescricao.Text = dr["CBONOME"].ToString();
        }



        private void txtcodigocbo_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtcodigocbo.Text != "")
            {
                string strConsulta = "SELECT CBOCODI, CBONOME FROM CBO WHERE CBOCODI = " + txtcodigocbo.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        //MessageBox.Show("oi");
                        ConsultaCbo(dr);
                        txtdescricao.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show(" CBO não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            Limpar();
                        }
                        else
                        {
                            txtdescricao.Text = "";
                            txtdescricao.Focus();
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
            string strAlterar = "UPDATE CBO"
                                 + " SET CBOCODI = " + txtcodigocbo.Text + ", "
                                 + " CBONOME = '" + txtdescricao.Text + "'"
                                 + " WHERE CBOCODI = " + txtcodigocbo.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Alteração Efetuada ! ");
                Limpar();
                txtcodigocbo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM CBO WHERE CBOCODI = '" + (txtcodigocbo.Text) + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                Limpar();
                txtcodigocbo.Focus();
                MessageBox.Show("Operação concluida!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}