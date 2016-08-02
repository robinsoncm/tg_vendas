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
    public partial class FrmDepto : Form
    {
        public FrmDepto()
        {
            InitializeComponent();
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            txtcodigo.Clear();
            txtnome.Clear();
            txtcodigo.Focus();
        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            {
                string strIncluir = "INSERT INTO DEPTO"
                                    + " VALUES("
                                    + txtcodigo.Text + " , '" + txtnome.Text + "'"
                                    + " )";
                Conexao.Active(true);
                try
                {
                    FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado com Sucesso!");
                    Limpar();
                    txtcodigo.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }

        }

        private void ConsultaDepto(FbDataReader dr)
        {
            txtcodigo.Text = dr["DEPCODI"].ToString();
            txtnome.Text = dr["DEPNOME"].ToString();

        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtcodigo.Text != "")
            {
                string strConsulta = "SELECT DEPCODI, DEPNOME FROM DEPTO WHERE DEPCODI = " + txtcodigo.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        //MessageBox.Show("oi");
                        ConsultaDepto(dr);
                        txtnome.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show(" Departamento não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            Limpar();
                        }
                        else
                        {
                            txtnome.Text = "";
                            txtnome.Focus();
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

        private void FrmDepto_KeyDown(object sender, KeyEventArgs e)
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
            string strAlterar = "UPDATE DEPTO"
                     + " SET DEPCODI = " + txtcodigo.Text + ", "
                     + " DEPNOME = '" + txtnome.Text + "'"
                     + " WHERE DEPCODI = " + txtcodigo.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Alteração Efetuada ! ");
                Limpar();
                txtcodigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM DEPTO WHERE DEPCODI = " + (txtcodigo.Text);
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                Limpar();
                txtcodigo.Focus();
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
