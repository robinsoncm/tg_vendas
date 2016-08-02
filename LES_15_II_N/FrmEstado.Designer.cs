namespace LES_15_II_N
{
    partial class FrmEstado
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
            this.btnvoltar = new System.Windows.Forms.Button();
            this.LblSigla = new System.Windows.Forms.Label();
            this.txtestuf = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.txtestnome = new System.Windows.Forms.TextBox();
            this.btnincluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.brndeletar = new System.Windows.Forms.Button();
            this.lblicms = new System.Windows.Forms.Label();
            this.txtesticms = new System.Windows.Forms.TextBox();
            this.lblcodigouf = new System.Windows.Forms.Label();
            this.txtcodigopais = new System.Windows.Forms.TextBox();
            this.txtnomepais = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(12, 166);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(52, 23);
            this.btnvoltar.TabIndex = 20;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // LblSigla
            // 
            this.LblSigla.AutoSize = true;
            this.LblSigla.Location = new System.Drawing.Point(62, 16);
            this.LblSigla.Name = "LblSigla";
            this.LblSigla.Size = new System.Drawing.Size(36, 13);
            this.LblSigla.TabIndex = 1;
            this.LblSigla.Text = "Sigla :";
            // 
            // txtestuf
            // 
            this.txtestuf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtestuf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtestuf.Location = new System.Drawing.Point(104, 16);
            this.txtestuf.Name = "txtestuf";
            this.txtestuf.Size = new System.Drawing.Size(40, 20);
            this.txtestuf.TabIndex = 2;
            this.txtestuf.TextChanged += new System.EventHandler(this.txtestuf_TextChanged);
            this.txtestuf.Leave += new System.EventHandler(this.txtestuf_Leave);
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(6, 55);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(92, 13);
            this.LblNome.TabIndex = 3;
            this.LblNome.Text = "Nome do Estado :";
            // 
            // txtestnome
            // 
            this.txtestnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtestnome.Location = new System.Drawing.Point(104, 48);
            this.txtestnome.MaxLength = 50;
            this.txtestnome.Name = "txtestnome";
            this.txtestnome.Size = new System.Drawing.Size(157, 20);
            this.txtestnome.TabIndex = 4;
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(281, 16);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(55, 23);
            this.btnincluir.TabIndex = 15;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(281, 50);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(55, 23);
            this.btngravar.TabIndex = 16;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // brndeletar
            // 
            this.brndeletar.Location = new System.Drawing.Point(281, 82);
            this.brndeletar.Name = "brndeletar";
            this.brndeletar.Size = new System.Drawing.Size(55, 23);
            this.brndeletar.TabIndex = 17;
            this.brndeletar.Text = "Deletar";
            this.brndeletar.UseVisualStyleBackColor = true;
            this.brndeletar.Click += new System.EventHandler(this.brndeletar_Click);
            // 
            // lblicms
            // 
            this.lblicms.AutoSize = true;
            this.lblicms.Location = new System.Drawing.Point(59, 86);
            this.lblicms.Name = "lblicms";
            this.lblicms.Size = new System.Drawing.Size(39, 13);
            this.lblicms.TabIndex = 9;
            this.lblicms.Text = "ICMS :";
            // 
            // txtesticms
            // 
            this.txtesticms.Location = new System.Drawing.Point(104, 79);
            this.txtesticms.Name = "txtesticms";
            this.txtesticms.Size = new System.Drawing.Size(69, 20);
            this.txtesticms.TabIndex = 10;
            this.txtesticms.TextChanged += new System.EventHandler(this.txtesticms_TextChanged);
            // 
            // lblcodigouf
            // 
            this.lblcodigouf.AutoSize = true;
            this.lblcodigouf.Location = new System.Drawing.Point(62, 118);
            this.lblcodigouf.Name = "lblcodigouf";
            this.lblcodigouf.Size = new System.Drawing.Size(33, 13);
            this.lblcodigouf.TabIndex = 12;
            this.lblcodigouf.Text = "Pais :";
            // 
            // txtcodigopais
            // 
            this.txtcodigopais.Location = new System.Drawing.Point(103, 118);
            this.txtcodigopais.Name = "txtcodigopais";
            this.txtcodigopais.Size = new System.Drawing.Size(41, 20);
            this.txtcodigopais.TabIndex = 13;
            this.txtcodigopais.TextChanged += new System.EventHandler(this.txtcodigopais_TextChanged);
            this.txtcodigopais.Leave += new System.EventHandler(this.txtcodigopais_Leave);
            // 
            // txtnomepais
            // 
            this.txtnomepais.Location = new System.Drawing.Point(150, 118);
            this.txtnomepais.Name = "txtnomepais";
            this.txtnomepais.ReadOnly = true;
            this.txtnomepais.Size = new System.Drawing.Size(111, 20);
            this.txtnomepais.TabIndex = 21;
            this.txtnomepais.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(281, 113);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(55, 23);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(355, 205);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtnomepais);
            this.Controls.Add(this.txtcodigopais);
            this.Controls.Add(this.lblcodigouf);
            this.Controls.Add(this.txtesticms);
            this.Controls.Add(this.lblicms);
            this.Controls.Add(this.brndeletar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.txtestnome);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.txtestuf);
            this.Controls.Add(this.LblSigla);
            this.Controls.Add(this.btnvoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Estados";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmEstado_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label LblSigla;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button brndeletar;
        private System.Windows.Forms.Label lblicms;
        private System.Windows.Forms.Label lblcodigouf;
        private System.Windows.Forms.TextBox txtcodigopais;
        private System.Windows.Forms.TextBox txtnomepais;
        public System.Windows.Forms.TextBox txtestuf;
        public System.Windows.Forms.TextBox txtestnome;
        public System.Windows.Forms.TextBox txtesticms;
        private System.Windows.Forms.Button btnLimpar;
    }
}

