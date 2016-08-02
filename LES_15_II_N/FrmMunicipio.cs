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
    public partial class FrmMunicipio : Form
    {
        public FrmMunicipio()
        {
            InitializeComponent();
        }

        /*private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }*/

        private void Limpar()
        {
            txtcodigo.Clear();
            txtnome.Clear();
            txtestuf.Clear();
            txtestnome.Clear();
            txtcodigo.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Fechar a Opção ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }


        private void btnincluir_Click(object sender, EventArgs e)
        {
            {
                string strIncluir = "INSERT INTO MUNICIPIO"
                                    + " VALUES("
                                    + "" + txtcodigo.Text + ", '" + txtnome.Text + "','"
                                    + txtestuf.Text + "'"
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


        private void btndeletar_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM MUNICIPIO WHERE MUNCODI = " + (txtcodigo.Text);
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


        private void FrmMunicipio_KeyDown(object sender, KeyEventArgs e)
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



        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtcodigo.Text != "")
            {
                string strConsulta = "SELECT MUNCODI, MUNNOME, ESTUF FROM MUNICIPIO WHERE MUNCODI = " + txtcodigo.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ConsultaMUN(dr);
                        txtnome.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Municipio não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
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


        private void ConsultaMUN(FbDataReader dr)
        {
            txtcodigo.Text = dr["MUNCODI"].ToString();
            txtnome.Text = dr["MUNNOME"].ToString();
            txtestuf.Text = dr["ESTUF"].ToString();
        }


        private void txtestuf_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtestuf.Text != "")
            {
                string strConsulta = "SELECT ESTUF, ESTNOME FROM ESTADO WHERE ESTUF = '" + txtestuf.Text + "'";
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ConsultaEst(dr);
                        txtestnome.Focus();
                    }
                    else
                    {
                        FrmEstado est = new FrmEstado();
                        est.Visible = true;
                        est.Show();
                        est.txtestuf.Text = txtestuf.Text;
                        est.txtestnome.Focus();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }


        }


        private void ConsultaEst(FbDataReader dr)
        {
            txtestuf.Text = dr["ESTUF"].ToString();
            txtestnome.Text = dr["ESTNOME"].ToString();

        }



        private void btngravar_Click(object sender, EventArgs e)
        {

            string strAlterar = "UPDATE MUNICIPIO"
                                + " SET MUNCODI = " + txtcodigo.Text + ","
                                + " MUNNOME = '" + txtnome.Text + "', "
                                + " ESTUF = '" + txtestuf.Text + "'"
                                + " WHERE MUNCODI = " + txtcodigo.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Alteração Efetuada!");
                Limpar();
                txtcodigo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }

        private void FrmMunicipio_Load(object sender, EventArgs e)
        {

        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtestnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtestuf_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

    }
}
