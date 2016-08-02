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
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Fechar a Opção ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        /*private void btnlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }*/

        private void Limpar()
        {
            txtcodigo.Clear();
            txtnome.Clear();
            txtcodfuncao.Clear();
            txtnomefuncao.Clear();
            txtendereco.Clear();
            txtcpf.Clear();
            txtcep.Clear();
            txtbairro.Clear();
            txtcelular1.Clear();
            txtcelular2.Clear();
            txtcidade.Clear();
            txtestuf.Clear();
            txtnomeuf.Clear();
            txtsala.Clear();
            txtdtnasc.Clear();
            txtfone.Clear();
            txtrg.Clear();
            txtcodigo.Focus();
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {
            string strDelete = "DELETE FROM FUNCIONARIO WHERE FUNCODI = " + (txtcodigo.Text);
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

        private void btnincluir_Click(object sender, EventArgs e)
        {
            {
                string strIncluir = "INSERT INTO FUNCIONARIO "
                                    + " VALUES("
                                    + txtcodigo.Text + ", '"
                                    + txtnome.Text + "', "
                                    + txtcodfuncao.Text + ", '"
                                    + txtcidade.Text + "', '"
                                    + txtestuf.Text + "', '"
                                    + txtbairro.Text + "', '"
                                    + string.Format("{0:MM/dd/yyyy}", DateTime.Parse(txtdtnasc.Text)) + "', '"
                                    + txtcpf.Text + "', '"
                                    + txtrg.Text + "', '"
                                    + txtfone.Text + "', '"
                                    + txtcelular1.Text + "', '"
                                    + txtcelular2.Text + "',' "
                                    + txtsala.Text + "', '"
                                    + txtcep.Text + "', '"
                                    + txtendereco.Text.Trim() + "' "
                                    + ")";
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

        private void ConsultaFunc(FbDataReader dr)
        {
            txtcodigo.Text = dr["FUNCODI"].ToString();
            txtnome.Text = dr["FUNNOME"].ToString();
            txtcodfuncao.Text = dr["FUCCODI"].ToString();
            txtendereco.Text = dr["FUNENDE"].ToString();
            txtcidade.Text = dr["FUNCIDA"].ToString();
            txtestuf.Text = dr["ESTUF"].ToString();
            txtbairro.Text = dr["FUNBAIRRO"].ToString();
            txtcep.Text = dr["ENDCEP"].ToString();
            txtdtnasc.Text = dr["FUNDTNA"].ToString();
            txtcpf.Text = dr["FUNCPF"].ToString();
            txtrg.Text = dr["FUNRG"].ToString();
            txtfone.Text = dr["FUNFONE"].ToString();
            txtcelular1.Text = dr["FUNCELU"].ToString();
            txtcelular2.Text = dr["FUNCEL1"].ToString();
            txtcelular2.Text = dr["FUNCEL1"].ToString();
            txtsala.Text = dr["FUNSALA"].ToString();

        }

        private void ConsultaCEP(FbDataReader dr)
        {
            txtendereco.Text = dr["ENDENDE"].ToString();
            txtcidade.Text = dr["MUNNOME"].ToString();
            txtestuf.Text = dr["ESTUF"].ToString();
            txtnomeuf.Text = dr["ESTNOME"].ToString();
            txtbairro.Text = dr["BAINOME"].ToString();

        }



        private void ConsultaFuncao(FbDataReader dr)
        {
            txtcodfuncao.Text = dr["FUCCODI"].ToString();
            txtnomefuncao.Text = dr["FUCNOME"].ToString();
        }

        private void txtcodfuncao_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtcodfuncao.Text != "")
            {
                string strConsulta = "SELECT FUCCODI, FUCNOME FROM FUNCAO WHERE FUCCODI = " + txtcodfuncao.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        //MessageBox.Show("oi");
                        ConsultaFuncao(dr);
                        //                        txtcodfuncao.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show(" Função não encontrado ", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
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

        private void FrmFuncionario_KeyDown(object sender, KeyEventArgs e)
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

        private void ConsultaEst(FbDataReader dr)
        {
            txtestuf.Text = dr["ESTUF"].ToString();
            txtnomeuf.Text = dr["ESTNOME"].ToString();
        }


        private void txtuf_Leave(object sender, EventArgs e)
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
                        //MessageBox.Show("oi");
                        ConsultaEst(dr);
                        txtnomeuf.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show(" Estado não encontrado ", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
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

        /*private void ConsultaHorario(FbDataReader dr)
        {
            txtcodhortxtcodhorr["HORCODI"].ToString();
        }


        private void txtcodhor_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtcodhortxtcodhor"")
            {
                string strConsulta = "SELECT HORCODI  FROM HORARIO WHERE HORCODI = " + txtcodhortxtcodhor               try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        ConsultaHorario(dr);
                        txtcodhortxtcodhor
                    }
                    else
                    {
                        if ((MessageBox.Show(" Horario não encontrado ", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
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

        }*/

        private void btngravar_Click(object sender, EventArgs e)
        {
            string strAlterar = "UPDATE FUNCIONARIO SET FUNCODI = " + txtcodigo.Text + ", "
                              + " FUNNOME = '" + txtnome.Text + "', "
                              + " FUCCODI = " + txtcodfuncao.Text + ", "
                              + " FUNCIDA = '" + txtcidade.Text + "', "
                              + " ESTUF = '" + txtestuf.Text + "', "
                              + " FUNBAIRRO = '" + txtbairro.Text + "', "
                              + " FUNDTNA = '" + string.Format("{0:MM/dd/yyyy}", DateTime.Parse(txtdtnasc.Text)) + "', "
                              + " FUNCPF = '" + txtcpf.Text + "', "
                              + " FUNRG = '" + txtrg.Text + "', "
                              + " FUNFONE = '" + txtfone.Text + "', "
                              + " FUNCELU = '" + txtcelular1.Text + "', "
                              + " FUNCEL1 = '" + txtcelular2.Text + "', "
                              + " FUNSALA = '" + txtsala.Text + "', "
                              + " ENDCEP = '" + txtcep.Text + "', "
                              + " FUNENDE = '" + txtendereco.Text + "' "
                              + " WHERE FUNCODI = " + txtcodigo.Text;

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


        private void txtcodigo_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtcodigo.Text != "")
            {
                string strConsulta = "SELECT FUNCODI, FUNNOME, FUCCODI , FUNENDE , FUNCIDA , ESTUF , " +
                                      "FUNBAIRRO , ENDCEP , FUNDTNA , FUNCPF , FUNRG ,FUNFONE , FUNCELU ," +
                                      "FUNCEL1, FUNSALA FROM FUNCIONARIO WHERE FUNCODI = " + txtcodigo.Text;
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        //MessageBox.Show("oi");
                        ConsultaFunc(dr);
                        txtnome.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show("Funcionario não encontrado \n deseja cadastra-lo?", "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
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

        /*private void ConsultaBanco(FbDataReader dr)
        {
            txtbanco.Text = dr["BANCODI"].ToString();
            txtnomebanco.Text = dr["BANNOME"].ToString();
        }


        private void txtbanco_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtbanco.Text != "")
            {
                string strConsulta = "SELECT BANCODI, BANNOME FROM BANCO WHERE BANCODI = '" + txtbanco.Text + "'";
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        //MessageBox.Show("oi");
                        ConsultaBanco(dr);
                        txtconta.Focus();
                    }
                    else
                    {
                        if ((MessageBox.Show(" Banco não encontrado ", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No))
                        {
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


        }*/

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void txtcep_Leave(object sender, EventArgs e)
        {
            Conexao.Active(true);
            if (txtcep.Text != "")
            {
                string strConsulta = @"SELECT * FROM endereco e
                        inner join bairro b on b.baicodi = e.baicodi
                        inner join municipio m on m.muncodi = b.muncodi
                        inner join estado es on es.estuf = m.estuf
                        WHERE e.endcep = '" + txtcep.Text + "'";
                try
                {
                    FbCommand cmd = new FbCommand(strConsulta, Conexao.FbCnn);
                    FbDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        //MessageBox.Show("oi");
                        ConsultaCEP(dr);
                        //txtnome.Focus();
                    }
                    else
                    {
                        FrmEndereco end = new FrmEndereco();
                        end.Visible = true;
                        end.Show();
                        end.txtendcep.Text = txtcep.Text;
                        end.txtendendereco.Focus();
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



