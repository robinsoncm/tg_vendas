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
    public partial class FrmBairro : Form
    {
        public FrmBairro()
        {
            InitializeComponent();
        }


        /*private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }*/

        private void Limpar()
        {
            txtcodigobairro.Clear();
            txtnomebairro.Clear();
            txtcodigo.Clear();
            txtnome.Clear();
            txtcodigobairro.Focus();
        }


        private void btnincluir_Click(object sender, EventArgs e)
        {
            {
                //OS CAMPOS SAO SEPARADOS POR VIRGULA
                //OS CAMPOS TEXTO PRECISAM DE UMA ASPAS SIMPLES PARA INSERIR

                string strIncluir = "INSERT INTO BAIRRO"
                                        + " VALUES("
                                        + "" + txtcodigobairro.Text + ", '" + txtnomebairro.Text + "','"
                                        + txtcodigo.Text + "'"
                                        + " )";
                Conexao.Active(true);
                try
                {
                    FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(" Cadastro Realizado com Sucesso ! ");
                    Limpar();
                    txtcodigobairro.Focus();
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
            txtcodigo.Text = dr["MUNCODI"].ToString();


        }


        private void txtcodigobairro_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtcodigobairro.Text != "")
            {
                string strConsulta = "SELECT BAICODI, BAINOME, MUNCODI FROM BAIRRO WHERE BAICODI = " + txtcodigobairro.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        //MessageBox.Show("oi");
                        ConsultaBairro(dr);
                        txtnomebairro.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show(" Bairro não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            Limpar();
                        }
                        else
                        {
                            txtnomebairro.Text = "";
                            txtnomebairro.Focus();
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


        private void FrmBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }

           if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                if (MessageBox.Show("Deseja sair do sistema ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }

        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE BAIRRO"
                                + " SET BAICODI = " + txtcodigobairro.Text + ","
                                + " BAINOME = '" + txtnomebairro.Text + "', "
                                + " MUNCODI = " + txtcodigo.Text + ""
                                + " WHERE BAICODI = " + txtcodigobairro.Text;
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show(" Alteração Efetuada ! ");
                Limpar();
                txtcodigobairro.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM BAIRRO WHERE BAICODI = '" + (txtcodigobairro.Text) + "' ";
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                Limpar();
                txtcodigobairro.Focus();
                MessageBox.Show("Operação concluida!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }

        private void FrmBairro_Load(object sender, EventArgs e)
        {

        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {

        }

        private void ConsultaMUN(FbDataReader dr)
        {
            txtcodigo.Text = dr["MUNCODI"].ToString();
            txtnome.Text = dr["MUNNOME"].ToString();

        }

        private void txtnomebairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigo_Leave_1(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtcodigo.Text != "")
            {
                string strConsulta = "SELECT MUNCODI, MUNNOME FROM MUNICIPIO WHERE MUNCODI = '" + txtcodigo.Text + "'";
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
                        FrmMunicipio mun = new FrmMunicipio();
                        mun.Visible = true;
                        mun.Show();
                        mun.txtcodigo.Text = txtcodigo.Text;
                        mun.txtnome.Focus();
                    }

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



