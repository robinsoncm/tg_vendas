namespace LES_15_II_N
{
    partial class FrmUsuario
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
            this.lblfunc = new System.Windows.Forms.Label();
            this.lblnomeusu = new System.Windows.Forms.Label();
            this.lblsenha = new System.Windows.Forms.Label();
            this.lblnivel = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblqtde = new System.Windows.Forms.Label();
            this.lblbloq = new System.Windows.Forms.Label();
            this.txtfunc = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.txtqtde = new System.Windows.Forms.TextBox();
            this.txtbloq = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtnomefunc = new System.Windows.Forms.TextBox();
            this.dtpusudata = new System.Windows.Forms.DateTimePicker();
            this.txtusunivel = new System.Windows.Forms.TextBox();
            this.txtususenhaconfirmar = new System.Windows.Forms.TextBox();
            this.lblconfirmar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblfunc
            // 
            this.lblfunc.AutoSize = true;
            this.lblfunc.Location = new System.Drawing.Point(41, 32);
            this.lblfunc.Name = "lblfunc";
            this.lblfunc.Size = new System.Drawing.Size(93, 13);
            this.lblfunc.TabIndex = 0;
            this.lblfunc.Text = "Cod. Funcionario :";
            // 
            // lblnomeusu
            // 
            this.lblnomeusu.AutoSize = true;
            this.lblnomeusu.Location = new System.Drawing.Point(41, 65);
            this.lblnomeusu.Name = "lblnomeusu";
            this.lblnomeusu.Size = new System.Drawing.Size(80, 13);
            this.lblnomeusu.TabIndex = 3;
            this.lblnomeusu.Text = "Nome Usuario :";
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.Location = new System.Drawing.Point(41, 104);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(44, 13);
            this.lblsenha.TabIndex = 5;
            this.lblsenha.Text = "Senha :";
            // 
            // lblnivel
            // 
            this.lblnivel.AutoSize = true;
            this.lblnivel.Location = new System.Drawing.Point(41, 201);
            this.lblnivel.Name = "lblnivel";
            this.lblnivel.Size = new System.Drawing.Size(37, 13);
            this.lblnivel.TabIndex = 7;
            this.lblnivel.Text = "Nivel :";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(200, 201);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(36, 13);
            this.lbldata.TabIndex = 9;
            this.lbldata.Text = "Data :";
            // 
            // lblqtde
            // 
            this.lblqtde.AutoSize = true;
            this.lblqtde.Location = new System.Drawing.Point(43, 239);
            this.lblqtde.Name = "lblqtde";
            this.lblqtde.Size = new System.Drawing.Size(92, 13);
            this.lblqtde.TabIndex = 11;
            this.lblqtde.Text = "Qtde troca senha:";
            // 
            // lblbloq
            // 
            this.lblbloq.AutoSize = true;
            this.lblbloq.Location = new System.Drawing.Point(217, 239);
            this.lblbloq.Name = "lblbloq";
            this.lblbloq.Size = new System.Drawing.Size(64, 13);
            this.lblbloq.TabIndex = 13;
            this.lblbloq.Text = "Bloqueado :";
            // 
            // txtfunc
            // 
            this.txtfunc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfunc.Location = new System.Drawing.Point(133, 30);
            this.txtfunc.Name = "txtfunc";
            this.txtfunc.Size = new System.Drawing.Size(62, 20);
            this.txtfunc.TabIndex = 1;
            this.txtfunc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfunc_KeyDown);
            this.txtfunc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfunc_KeyPress);
            this.txtfunc.Leave += new System.EventHandler(this.txtfunc_Leave_1);
            // 
            // txtusuario
            // 
            this.txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtusuario.Location = new System.Drawing.Point(119, 62);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(230, 20);
            this.txtusuario.TabIndex = 4;
            this.txtusuario.Leave += new System.EventHandler(this.txtusuario_Leave_1);
            // 
            // txtsenha
            // 
            this.txtsenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtsenha.Location = new System.Drawing.Point(83, 101);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(167, 20);
            this.txtsenha.TabIndex = 6;
            this.txtsenha.TextChanged += new System.EventHandler(this.txtsenha_TextChanged);
            this.txtsenha.Leave += new System.EventHandler(this.txtsenha_Leave);
            // 
            // txtqtde
            // 
            this.txtqtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtqtde.Location = new System.Drawing.Point(135, 236);
            this.txtqtde.Name = "txtqtde";
            this.txtqtde.ReadOnly = true;
            this.txtqtde.Size = new System.Drawing.Size(62, 20);
            this.txtqtde.TabIndex = 12;
            // 
            // txtbloq
            // 
            this.txtbloq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbloq.Location = new System.Drawing.Point(287, 236);
            this.txtbloq.Name = "txtbloq";
            this.txtbloq.ReadOnly = true;
            this.txtbloq.Size = new System.Drawing.Size(86, 20);
            this.txtbloq.TabIndex = 14;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(414, 142);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(55, 23);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(21, 284);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(57, 23);
            this.btnvoltar.TabIndex = 19;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(414, 104);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(55, 23);
            this.btndeletar.TabIndex = 17;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(414, 60);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(55, 23);
            this.btngravar.TabIndex = 16;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click_1);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(415, 22);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(54, 23);
            this.btnincluir.TabIndex = 15;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click_1);
            // 
            // txtnomefunc
            // 
            this.txtnomefunc.Location = new System.Drawing.Point(208, 30);
            this.txtnomefunc.Name = "txtnomefunc";
            this.txtnomefunc.ReadOnly = true;
            this.txtnomefunc.Size = new System.Drawing.Size(141, 20);
            this.txtnomefunc.TabIndex = 2;
            this.txtnomefunc.TabStop = false;
            // 
            // dtpusudata
            // 
            this.dtpusudata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpusudata.Location = new System.Drawing.Point(235, 198);
            this.dtpusudata.Margin = new System.Windows.Forms.Padding(4);
            this.dtpusudata.Name = "dtpusudata";
            this.dtpusudata.Size = new System.Drawing.Size(137, 20);
            this.dtpusudata.TabIndex = 20;
            // 
            // txtusunivel
            // 
            this.txtusunivel.Location = new System.Drawing.Point(79, 198);
            this.txtusunivel.Margin = new System.Windows.Forms.Padding(4);
            this.txtusunivel.Name = "txtusunivel";
            this.txtusunivel.Size = new System.Drawing.Size(109, 20);
            this.txtusunivel.TabIndex = 21;
            // 
            // txtususenhaconfirmar
            // 
            this.txtususenhaconfirmar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtususenhaconfirmar.Location = new System.Drawing.Point(135, 145);
            this.txtususenhaconfirmar.Name = "txtususenhaconfirmar";
            this.txtususenhaconfirmar.Size = new System.Drawing.Size(167, 20);
            this.txtususenhaconfirmar.TabIndex = 23;
            this.txtususenhaconfirmar.Leave += new System.EventHandler(this.txtususenhaconfirmar_Leave);
            // 
            // lblconfirmar
            // 
            this.lblconfirmar.AutoSize = true;
            this.lblconfirmar.Location = new System.Drawing.Point(41, 148);
            this.lblconfirmar.Name = "lblconfirmar";
            this.lblconfirmar.Size = new System.Drawing.Size(91, 13);
            this.lblconfirmar.TabIndex = 22;
            this.lblconfirmar.Text = "Confirmar Senha :";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 316);
            this.Controls.Add(this.txtususenhaconfirmar);
            this.Controls.Add(this.lblconfirmar);
            this.Controls.Add(this.txtusunivel);
            this.Controls.Add(this.dtpusudata);
            this.Controls.Add(this.txtnomefunc);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.txtbloq);
            this.Controls.Add(this.txtqtde);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.txtfunc);
            this.Controls.Add(this.lblbloq);
            this.Controls.Add(this.lblqtde);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblnivel);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.lblnomeusu);
            this.Controls.Add(this.lblfunc);
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmUsuario_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfunc;
        private System.Windows.Forms.Label lblnomeusu;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.Label lblnivel;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblqtde;
        private System.Windows.Forms.Label lblbloq;
        private System.Windows.Forms.TextBox txtfunc;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.TextBox txtqtde;
        private System.Windows.Forms.TextBox txtbloq;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TextBox txtnomefunc;
        private System.Windows.Forms.DateTimePicker dtpusudata;
        private System.Windows.Forms.TextBox txtusunivel;
        private System.Windows.Forms.TextBox txtususenhaconfirmar;
        private System.Windows.Forms.Label lblconfirmar;
    }
}