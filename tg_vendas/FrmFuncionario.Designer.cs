namespace LES_15_II_N
{
    partial class FrmFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnincluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblcodfuncao = new System.Windows.Forms.Label();
            this.txtcodfuncao = new System.Windows.Forms.TextBox();
            this.lblendereco = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.lblcidade = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.lbluf = new System.Windows.Forms.Label();
            this.txtestuf = new System.Windows.Forms.TextBox();
            this.lblcep = new System.Windows.Forms.Label();
            this.txtcep = new System.Windows.Forms.TextBox();
            this.lbldatanasci = new System.Windows.Forms.Label();
            this.lblcpf = new System.Windows.Forms.Label();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.lblrg = new System.Windows.Forms.Label();
            this.txtrg = new System.Windows.Forms.TextBox();
            this.lblfone = new System.Windows.Forms.Label();
            this.txtfone = new System.Windows.Forms.TextBox();
            this.lblcel1 = new System.Windows.Forms.Label();
            this.txtcelular1 = new System.Windows.Forms.TextBox();
            this.lblcel2 = new System.Windows.Forms.Label();
            this.txtcelular2 = new System.Windows.Forms.TextBox();
            this.txtnomefuncao = new System.Windows.Forms.TextBox();
            this.txtnomeuf = new System.Windows.Forms.TextBox();
            this.lblhorario = new System.Windows.Forms.Label();
            this.txtsala = new System.Windows.Forms.TextBox();
            this.lblbairro = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.txtdtnasc = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(646, 12);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(88, 23);
            this.btnincluir.TabIndex = 18;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(646, 50);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(89, 23);
            this.btngravar.TabIndex = 20;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(646, 96);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(88, 23);
            this.btndeletar.TabIndex = 21;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(17, 280);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(86, 23);
            this.btnvoltar.TabIndex = 19;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(64, 21);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(57, 20);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.Leave += new System.EventHandler(this.txtcodigo_Leave);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(14, 24);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(46, 13);
            this.lblcodigo.TabIndex = 1;
            this.lblcodigo.Text = "Codigo :";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(131, 25);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(41, 13);
            this.lblnome.TabIndex = 3;
            this.lblnome.Text = "Nome :";
            // 
            // txtnome
            // 
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome.Location = new System.Drawing.Point(174, 21);
            this.txtnome.MaxLength = 50;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(426, 20);
            this.txtnome.TabIndex = 2;
            // 
            // lblcodfuncao
            // 
            this.lblcodfuncao.AutoSize = true;
            this.lblcodfuncao.Location = new System.Drawing.Point(14, 227);
            this.lblcodfuncao.Name = "lblcodfuncao";
            this.lblcodfuncao.Size = new System.Drawing.Size(49, 13);
            this.lblcodfuncao.TabIndex = 22;
            this.lblcodfuncao.Text = "Função :";
            // 
            // txtcodfuncao
            // 
            this.txtcodfuncao.Location = new System.Drawing.Point(64, 225);
            this.txtcodfuncao.Name = "txtcodfuncao";
            this.txtcodfuncao.Size = new System.Drawing.Size(57, 20);
            this.txtcodfuncao.TabIndex = 16;
            this.txtcodfuncao.Leave += new System.EventHandler(this.txtcodfuncao_Leave);
            // 
            // lblendereco
            // 
            this.lblendereco.AutoSize = true;
            this.lblendereco.Location = new System.Drawing.Point(192, 59);
            this.lblendereco.Name = "lblendereco";
            this.lblendereco.Size = new System.Drawing.Size(59, 13);
            this.lblendereco.TabIndex = 7;
            this.lblendereco.Text = "Endereço :";
            // 
            // txtendereco
            // 
            this.txtendereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtendereco.Location = new System.Drawing.Point(253, 57);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.ReadOnly = true;
            this.txtendereco.Size = new System.Drawing.Size(347, 20);
            this.txtendereco.TabIndex = 4;
            // 
            // lblcidade
            // 
            this.lblcidade.AutoSize = true;
            this.lblcidade.Location = new System.Drawing.Point(200, 101);
            this.lblcidade.Name = "lblcidade";
            this.lblcidade.Size = new System.Drawing.Size(46, 13);
            this.lblcidade.TabIndex = 11;
            this.lblcidade.Text = "Cidade :";
            // 
            // txtcidade
            // 
            this.txtcidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcidade.Location = new System.Drawing.Point(249, 97);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.ReadOnly = true;
            this.txtcidade.Size = new System.Drawing.Size(135, 20);
            this.txtcidade.TabIndex = 6;
            // 
            // lbluf
            // 
            this.lbluf.AutoSize = true;
            this.lbluf.Location = new System.Drawing.Point(385, 101);
            this.lbluf.Name = "lbluf";
            this.lbluf.Size = new System.Drawing.Size(27, 13);
            this.lbluf.TabIndex = 13;
            this.lbluf.Text = "UF :";
            // 
            // txtestuf
            // 
            this.txtestuf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtestuf.Location = new System.Drawing.Point(413, 97);
            this.txtestuf.Name = "txtestuf";
            this.txtestuf.ReadOnly = true;
            this.txtestuf.Size = new System.Drawing.Size(36, 20);
            this.txtestuf.TabIndex = 7;
            this.txtestuf.Leave += new System.EventHandler(this.txtuf_Leave);
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.Location = new System.Drawing.Point(14, 60);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(34, 13);
            this.lblcep.TabIndex = 5;
            this.lblcep.Text = "CEP :";
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(64, 57);
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(105, 20);
            this.txtcep.TabIndex = 3;
            this.txtcep.Leave += new System.EventHandler(this.txtcep_Leave);
            // 
            // lbldatanasci
            // 
            this.lbldatanasci.AutoSize = true;
            this.lbldatanasci.Location = new System.Drawing.Point(120, 141);
            this.lbldatanasci.Name = "lbldatanasci";
            this.lbldatanasci.Size = new System.Drawing.Size(52, 13);
            this.lbldatanasci.TabIndex = 10;
            this.lbldatanasci.Text = "Dt Nasc :";
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.Location = new System.Drawing.Point(251, 141);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(33, 13);
            this.lblcpf.TabIndex = 12;
            this.lblcpf.Text = "CPF :";
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(288, 137);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(148, 20);
            this.txtcpf.TabIndex = 11;
            // 
            // lblrg
            // 
            this.lblrg.AutoSize = true;
            this.lblrg.Location = new System.Drawing.Point(439, 140);
            this.lblrg.Name = "lblrg";
            this.lblrg.Size = new System.Drawing.Size(29, 13);
            this.lblrg.TabIndex = 14;
            this.lblrg.Text = "RG :";
            // 
            // txtrg
            // 
            this.txtrg.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtrg.Location = new System.Drawing.Point(474, 137);
            this.txtrg.Name = "txtrg";
            this.txtrg.Size = new System.Drawing.Size(126, 20);
            this.txtrg.TabIndex = 12;
            // 
            // lblfone
            // 
            this.lblfone.AutoSize = true;
            this.lblfone.Location = new System.Drawing.Point(14, 180);
            this.lblfone.Name = "lblfone";
            this.lblfone.Size = new System.Drawing.Size(37, 13);
            this.lblfone.TabIndex = 16;
            this.lblfone.Text = "Fone :";
            // 
            // txtfone
            // 
            this.txtfone.Location = new System.Drawing.Point(64, 176);
            this.txtfone.Name = "txtfone";
            this.txtfone.Size = new System.Drawing.Size(100, 20);
            this.txtfone.TabIndex = 13;
            // 
            // lblcel1
            // 
            this.lblcel1.AutoSize = true;
            this.lblcel1.Location = new System.Drawing.Point(187, 180);
            this.lblcel1.Name = "lblcel1";
            this.lblcel1.Size = new System.Drawing.Size(54, 13);
            this.lblcel1.TabIndex = 18;
            this.lblcel1.Text = "Celular 1 :";
            // 
            // txtcelular1
            // 
            this.txtcelular1.Location = new System.Drawing.Point(243, 176);
            this.txtcelular1.Name = "txtcelular1";
            this.txtcelular1.Size = new System.Drawing.Size(137, 20);
            this.txtcelular1.TabIndex = 14;
            // 
            // lblcel2
            // 
            this.lblcel2.AutoSize = true;
            this.lblcel2.Location = new System.Drawing.Point(399, 179);
            this.lblcel2.Name = "lblcel2";
            this.lblcel2.Size = new System.Drawing.Size(54, 13);
            this.lblcel2.TabIndex = 20;
            this.lblcel2.Text = "Celular 2 :";
            // 
            // txtcelular2
            // 
            this.txtcelular2.Location = new System.Drawing.Point(453, 176);
            this.txtcelular2.Name = "txtcelular2";
            this.txtcelular2.Size = new System.Drawing.Size(147, 20);
            this.txtcelular2.TabIndex = 15;
            // 
            // txtnomefuncao
            // 
            this.txtnomefuncao.Location = new System.Drawing.Point(126, 225);
            this.txtnomefuncao.Name = "txtnomefuncao";
            this.txtnomefuncao.ReadOnly = true;
            this.txtnomefuncao.Size = new System.Drawing.Size(310, 20);
            this.txtnomefuncao.TabIndex = 17;
            this.txtnomefuncao.TabStop = false;
            // 
            // txtnomeuf
            // 
            this.txtnomeuf.Location = new System.Drawing.Point(452, 97);
            this.txtnomeuf.Name = "txtnomeuf";
            this.txtnomeuf.ReadOnly = true;
            this.txtnomeuf.Size = new System.Drawing.Size(148, 20);
            this.txtnomeuf.TabIndex = 8;
            this.txtnomeuf.TabStop = false;
            // 
            // lblhorario
            // 
            this.lblhorario.AutoSize = true;
            this.lblhorario.Location = new System.Drawing.Point(14, 141);
            this.lblhorario.Name = "lblhorario";
            this.lblhorario.Size = new System.Drawing.Size(34, 13);
            this.lblhorario.TabIndex = 7;
            this.lblhorario.Text = "Sala :";
            // 
            // txtsala
            // 
            this.txtsala.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsala.Location = new System.Drawing.Point(64, 137);
            this.txtsala.Name = "txtsala";
            this.txtsala.Size = new System.Drawing.Size(41, 20);
            this.txtsala.TabIndex = 9;
            // 
            // lblbairro
            // 
            this.lblbairro.AutoSize = true;
            this.lblbairro.Location = new System.Drawing.Point(14, 104);
            this.lblbairro.Name = "lblbairro";
            this.lblbairro.Size = new System.Drawing.Size(40, 13);
            this.lblbairro.TabIndex = 9;
            this.lblbairro.Text = "Bairro :";
            // 
            // txtbairro
            // 
            this.txtbairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbairro.Location = new System.Drawing.Point(55, 101);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.ReadOnly = true;
            this.txtbairro.Size = new System.Drawing.Size(139, 20);
            this.txtbairro.TabIndex = 5;
            // 
            // txtdtnasc
            // 
            this.txtdtnasc.Location = new System.Drawing.Point(174, 137);
            this.txtdtnasc.Mask = "00/00/0000";
            this.txtdtnasc.Name = "txtdtnasc";
            this.txtdtnasc.Size = new System.Drawing.Size(70, 20);
            this.txtdtnasc.TabIndex = 10;
            this.txtdtnasc.ValidatingType = typeof(System.DateTime);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(646, 141);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 23);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(774, 315);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtdtnasc);
            this.Controls.Add(this.txtbairro);
            this.Controls.Add(this.lblbairro);
            this.Controls.Add(this.txtsala);
            this.Controls.Add(this.lblhorario);
            this.Controls.Add(this.txtnomeuf);
            this.Controls.Add(this.txtnomefuncao);
            this.Controls.Add(this.txtcelular2);
            this.Controls.Add(this.lblcel2);
            this.Controls.Add(this.txtcelular1);
            this.Controls.Add(this.lblcel1);
            this.Controls.Add(this.txtfone);
            this.Controls.Add(this.lblfone);
            this.Controls.Add(this.txtrg);
            this.Controls.Add(this.lblrg);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.lblcpf);
            this.Controls.Add(this.lbldatanasci);
            this.Controls.Add(this.txtcep);
            this.Controls.Add(this.lblcep);
            this.Controls.Add(this.txtestuf);
            this.Controls.Add(this.lbluf);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.lblcidade);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.lblendereco);
            this.Controls.Add(this.txtcodfuncao);
            this.Controls.Add(this.lblcodfuncao);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.btnincluir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados de Funcionarios ";
            this.Load += new System.EventHandler(this.FrmFuncionario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFuncionario_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblcodfuncao;
        private System.Windows.Forms.TextBox txtcodfuncao;
        private System.Windows.Forms.Label lblendereco;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label lblcidade;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label lbluf;
        private System.Windows.Forms.TextBox txtestuf;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.TextBox txtcep;
        private System.Windows.Forms.Label lbldatanasci;
        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Label lblrg;
        private System.Windows.Forms.TextBox txtrg;
        private System.Windows.Forms.Label lblfone;
        private System.Windows.Forms.TextBox txtfone;
        private System.Windows.Forms.Label lblcel1;
        private System.Windows.Forms.TextBox txtcelular1;
        private System.Windows.Forms.Label lblcel2;
        private System.Windows.Forms.TextBox txtcelular2;
        private System.Windows.Forms.TextBox txtnomefuncao;
        private System.Windows.Forms.TextBox txtnomeuf;
        private System.Windows.Forms.Label lblhorario;
        private System.Windows.Forms.TextBox txtsala;
        private System.Windows.Forms.Label lblbairro;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.MaskedTextBox txtdtnasc;
        private System.Windows.Forms.Button btnLimpar;
    }
}