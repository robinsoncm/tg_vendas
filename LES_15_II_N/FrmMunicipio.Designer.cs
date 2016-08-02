namespace LES_15_II_N
{
    partial class FrmMunicipio
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
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.txtestuf = new System.Windows.Forms.TextBox();
            this.btnincluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.txtestnome = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(26, 17);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(46, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo :";
            // 
            // txtcodigo
            // 
            this.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigo.Location = new System.Drawing.Point(77, 14);
            this.txtcodigo.MaxLength = 50;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(81, 20);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            this.txtcodigo.Leave += new System.EventHandler(this.txtcodigo_Leave);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(26, 48);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(41, 13);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Nome :";
            // 
            // txtnome
            // 
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnome.Location = new System.Drawing.Point(77, 41);
            this.txtnome.MaxLength = 50;
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(222, 20);
            this.txtnome.TabIndex = 3;
            this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(26, 77);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(46, 13);
            this.lblestado.TabIndex = 4;
            this.lblestado.Text = "Estado :";
            // 
            // txtestuf
            // 
            this.txtestuf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtestuf.Location = new System.Drawing.Point(77, 77);
            this.txtestuf.MaxLength = 2;
            this.txtestuf.Name = "txtestuf";
            this.txtestuf.Size = new System.Drawing.Size(35, 20);
            this.txtestuf.TabIndex = 5;
            this.txtestuf.TextChanged += new System.EventHandler(this.txtestuf_TextChanged);
            this.txtestuf.Leave += new System.EventHandler(this.txtestuf_Leave);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(327, 3);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(54, 23);
            this.btnincluir.TabIndex = 9;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(326, 32);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(55, 23);
            this.btngravar.TabIndex = 10;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(327, 61);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(54, 23);
            this.btndeletar.TabIndex = 11;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(29, 137);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(57, 23);
            this.btnvoltar.TabIndex = 15;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // txtestnome
            // 
            this.txtestnome.Location = new System.Drawing.Point(119, 77);
            this.txtestnome.MaxLength = 50;
            this.txtestnome.Name = "txtestnome";
            this.txtestnome.ReadOnly = true;
            this.txtestnome.Size = new System.Drawing.Size(180, 20);
            this.txtestnome.TabIndex = 8;
            this.txtestnome.TabStop = false;
            this.txtestnome.TextChanged += new System.EventHandler(this.txtestnome_TextChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(327, 90);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(51, 23);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmMunicipio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(398, 163);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtestnome);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.txtestuf);
            this.Controls.Add(this.lblestado);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblcodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMunicipio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Municipios";
            this.Load += new System.EventHandler(this.FrmMunicipio_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMunicipio_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TextBox txtestuf;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.TextBox txtestnome;
        public System.Windows.Forms.TextBox txtcodigo;
        public System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btnLimpar;
    }
}