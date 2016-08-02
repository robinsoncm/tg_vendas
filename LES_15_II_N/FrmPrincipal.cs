using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using LES_15_II_N.Properties;

namespace LES_15_II_N
{
    public partial class FrmPrincipal : Form
    {

        FrmLogin InstanciaLogin;

        public FrmPrincipal(FrmLogin login)
        {
            InitializeComponent();
            InstanciaLogin = login;
            AutoridadeUsuario(InstanciaLogin.nivel);
        }


         public FrmPrincipal()
        {
            InitializeComponent();
        }


        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstado estado = new FrmEstado();
            estado.ShowDialog();
        }


        public void AutoridadeUsuario(int pnivel)
        {
            switch (pnivel)
            {
                case 1:
                    folhaPagtoToolStripMenuItem.Enabled = true;
                    dadosComunsToolStripMenuItem.Enabled = true;
                    break;

                case 2:
                    folhaPagtoToolStripMenuItem.Enabled = true;
                    horárioToolStripMenuItem.Enabled = false;
                    dadosComunsToolStripMenuItem.Enabled = true;
                    break;

                case 3:
                    folhaPagtoToolStripMenuItem.Enabled = true;
                    funcionarioToolStripMenuItem.Enabled = false;
                    horárioToolStripMenuItem.Enabled = false;
                    dadosComunsToolStripMenuItem.Enabled = true;
                    break;

                case 4:
                    folhaPagtoToolStripMenuItem.Enabled = true;
                    funcionarioToolStripMenuItem.Enabled = false;
                    departamentoToolStripMenuItem.Enabled = false;
                    horárioToolStripMenuItem.Enabled = false;
                    dadosComunsToolStripMenuItem.Enabled = true;
                    break;

                case 5:
                    folhaPagtoToolStripMenuItem.Enabled = true;
                    funcionarioToolStripMenuItem.Enabled = false;
                    funcaoToolStripMenuItem.Enabled = false;
                    departamentoToolStripMenuItem.Enabled = false;
                    horárioToolStripMenuItem.Enabled = false;
                    dadosComunsToolStripMenuItem.Enabled = true;
                    break;

                case 6:
                    folhaPagtoToolStripMenuItem.Enabled = true;
                    departamentoToolStripMenuItem.Enabled = false;
                    horárioToolStripMenuItem.Enabled = false;
                    cBOToolStripMenuItem.Enabled = false;
                    funcaoToolStripMenuItem.Enabled = false;
                    funcionarioToolStripMenuItem.Enabled = false;
                    dadosComunsToolStripMenuItem.Enabled = true;

                    break;

                case 7:
                    folhaPagtoToolStripMenuItem.Enabled = false;
                    dadosComunsToolStripMenuItem.Enabled = true;
                    usuarioToolStripMenuItem.Enabled = false;
                    endereçosToolStripMenuItem.Enabled = false;
                    break;

                case 8:
                    folhaPagtoToolStripMenuItem.Enabled = false;
                    dadosComunsToolStripMenuItem.Enabled = true;
                    usuarioToolStripMenuItem.Enabled = false;
                    endereçosToolStripMenuItem.Enabled = true;
                    break;

                case 9:
                    folhaPagtoToolStripMenuItem.Enabled = false;
                    dadosComunsToolStripMenuItem.Enabled = true;
                    usuarioToolStripMenuItem.Enabled = false;
                    break;

                case 10:
                    folhaPagtoToolStripMenuItem.Enabled = false;
                    dadosComunsToolStripMenuItem.Enabled = false;
                    break;
            }
        }



        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FrmLogin usuario = new FrmLogin();
            //usuario.ShowDialog();

//            if (MessageBox.Show("Deseja Sair do Sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
//            {
//                this.Close();
//            }
//
            if (MessageBox.Show("Deseja encerrar a aplicação ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void FrmPrincipal_KeyDown(object sender, KeyEventArgs e)
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


        private void funcaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncao funcao = new FrmFuncao();
            funcao.ShowDialog();
        }

        private void sOBREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSobre sobre = new FrmSobre();
            sobre.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionario funcionario = new FrmFuncionario();
            funcionario.ShowDialog();
        }


        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBairro bairros = new FrmBairro();
            bairros.ShowDialog();
        }

        private void municipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMunicipio municipios = new FrmMunicipio();
            municipios.ShowDialog();
        }

        private void estadoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmEstado estados = new FrmEstado();
            estados.ShowDialog();
        }

        private void paísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPais pais = new FrmPais();
            pais.ShowDialog();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepto deptos = new FrmDepto();
            deptos.ShowDialog();
        }

        private void tipoDeHorárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTip_Horar horarios = new FrmTip_Horar();
            horarios.ShowDialog();
        
        }

        private void horárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHorario horarios = new FrmHorario();
            horarios.ShowDialog();

        }

        private void cBOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCbo cbo = new FrmCbo();
            cbo.ShowDialog();
        }

        

        private void bairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBairro bairros = new FrmBairro();
            bairros.ShowDialog();
        }

        private void municipioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmMunicipio municipios = new FrmMunicipio();
            municipios.ShowDialog();
        }

        private void estadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEstado estados = new FrmEstado();
            estados.ShowDialog();
        }

        private void paisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPais pais = new FrmPais();
            pais.ShowDialog();
        }

        private void endereçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEndereco endereco = new FrmEndereco();
            endereco.ShowDialog();
        }

        private void folhaPagtoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario usuario = new FrmUsuario();
            usuario.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        }

        
    }
