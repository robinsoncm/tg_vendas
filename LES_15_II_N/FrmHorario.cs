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
    public partial class FrmHorario : Form
    {
        public FrmHorario()
        {
            InitializeComponent();
        }

        private void FormHorario_KeyDown(object sender, KeyEventArgs e)
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


        private void btnlimpar_Click(object sender, EventArgs e)
        {

            Limpar();
        }

        private void Limpar()
        {
            txtcodhor.Clear();
            txttipohorario.Clear();
            txthorentman.Clear();
            txthorsaiman.Clear();
            txthorenttar.Clear();
            txthorsaitar.Clear();
            txtcodhor.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Fechar a Opção ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();

        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM HORARIO WHERE HORCODI = " + (txtcodhor.Text);
            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strDelete, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                Limpar();
                txtcodhor.Focus();
                MessageBox.Show("Operação concluida!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }

        private void ConsultaHor(FbDataReader dr)
        {
            txtcodhor.Text = dr["HORCODI"].ToString();
            txttipohorario.Text = dr["TIPCODI"].ToString();
            txthorentman.Text = dr["HORENTMAN"].ToString();
            txthorsaiman.Text = dr["HORSAIMAN"].ToString();
            txthorenttar.Text = dr["HORENTTAR"].ToString();
            txthorsaitar.Text = dr["HORSAITAR"].ToString();
        }

        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtcodhor.Text != "")
            {

                string strConsulta = "SELECT HORCODI, TIPCODI , HORENTMAN , HORSAIMAN , HORENTTAR , HORSAITAR FROM HORARIO WHERE HORCODI = " + txtcodhor.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ConsultaHor(dr);
                        txttipohorario.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Horario não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
                            Limpar();
                        }
                        else
                        {
                            txtdescricaotipo.Text = "";
                            txttipohorario.Focus();
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
            string strAlterar = "UPDATE HORARIO "
                                + " SET HORCODI = " + txtcodhor.Text + ", "
                                + " TIPCODI = " + txttipohorario.Text + ", "
                                + " HORENTMAN = '" + txthorentman.Text + "' ,"
                                + " HORSAIMAN = '" + txthorsaiman.Text + "' ,"
                                + " HORENTTAR = '" + txthorenttar.Text + "' , "
                                + " HORSAITAR = '" + txthorsaitar.Text + "'  "
                                + " WHERE HORCODI = " + txtcodhor.Text;

            Conexao.Active(true);
            try
            {
                FbCommand cmd = new FbCommand(strAlterar, Conexao.FbCnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Alteração Efetuada!");
                Limpar();
                txtcodhor.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Conexao.Active(false);

        }

        private void txttipohorario_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txttipohorario.Text != "")
            {
                string strConsulta = "SELECT TIPCODI, TIPNOME FROM TIPO_HORAR WHERE TIPCODI = " + txttipohorario.Text;
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
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Conexao.Active(false);
            }
        }

        private void ConsultaTip(FbDataReader dr)
        {
            txttipohorario.Text = dr["TIPCODI"].ToString();
            txtdescricaotipo.Text = dr["TIPNOME"].ToString();

        }

        private void btnincluir_Click(object sender, EventArgs e)
        {
            {
                string strIncluir = "INSERT INTO HORARIO"
                                    + " VALUES("
                                    + txtcodhor.Text + " , " + txttipohorario.Text + " , '"
                                    + txthorentman.Text + "' , '" + txthorsaiman.Text + "' , '"
                                    + txthorenttar.Text + "' , '" + txthorsaitar.Text + "'"
                                    + " )";
                Conexao.Active(true);
                try
                {
                    FbCommand cmd = new FbCommand(strIncluir, Conexao.FbCnn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro Realizado com Sucesso!");
                    Limpar();
                    txtcodhor.Focus();
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
