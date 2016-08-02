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
    public partial class FrmTip_Horar : Form
    {
        public FrmTip_Horar()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Fechar a Opção ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void FrmTip_Horar_KeyDown(object sender, KeyEventArgs e)
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

        private void btnincluir_Click(object sender, EventArgs e)
        {
            {
                string strIncluir = "INSERT INTO TIPO_HORAR"
                                    + " VALUES("
                                    + txtcodigotipo.Text + " , '" + txtdescricaotipo.Text + "'"
                                    + " )";
                Conexao.Active(true);
                try
                {
                    FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado com Sucesso!");
                    Limpar();
                    txtcodigotipo.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }

        }

        private void ConsultaHorario(FbDataReader dr)
        {
            txtcodigotipo.Text = dr["TIPCODI"].ToString();
            txtdescricaotipo.Text = dr["TIPNOME"].ToString();
        }


        private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }


        private void Limpar()
        {
            txtcodigotipo.Clear();
            txtdescricaotipo.Clear();
            txtcodigotipo.Focus();
        }

        private void btngravar_Click(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE TIPO_HORAR"
                                + " SET TIPCODI = " + txtcodigotipo.Text + ", "
                                + " TIPNOME = '" + txtdescricaotipo.Text + "' "
                                + " WHERE TIPCODI = " + txtcodigotipo.Text;

            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Alteração Efetuada!");
                Limpar();
                txtcodigotipo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM TIPO_HORAR WHERE TIPCODI = " + (txtcodigotipo.Text);
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                Limpar();
                txtcodigotipo.Focus();
                MessageBox.Show("Operação concluida!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }

        private void ConsultaTip(FbDataReader dr)
        {
            txtcodigotipo.Text = dr["TIPCODI"].ToString();
            txtdescricaotipo.Text = dr["TIPNOME"].ToString();

        }


        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtcodigotipo.Text != "")
            {
                string strConsulta = "SELECT TIPCODI, TIPNOME FROM TIPO_HORAR WHERE TIPCODI = " + txtcodigotipo.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ConsultaTip(dr);
                        txtdescricaotipo.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Tipo horario não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            Limpar();
                        }
                        else
                        {
                            txtdescricaotipo.Text = "";
                            txtdescricaotipo.Focus();
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

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            Limpar();
        }

    }


}
