namespace LES_15_II_N
{
    partial class FrmPais
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
            this.txtcodigopais = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnomepais = new System.Windows.Forms.TextBox();
            this.btnincluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(33, 42);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(46, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo :";
            // 
            // txtcodigopais
            // 
            this.txtcodigopais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigopais.Location = new System.Drawing.Point(103, 42);
            this.txtcodigopais.Name = "txtcodigopais";
            this.txtcodigopais.Size = new System.Drawing.Size(50, 20);
            this.txtcodigopais.TabIndex = 1;
            this.txtcodigopais.Leave += new System.EventHandler(this.txtcodigopais_Leave);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(36, 79);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(41, 13);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Nome :";
            // 
            // txtnomepais
            // 
            this.txtnomepais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnomepais.Location = new System.Drawing.Point(102, 79);
            this.txtnomepais.MaxLength = 50;
            this.txtnomepais.Name = "txtnomepais";
            this.txtnomepais.Size = new System.Drawing.Size(250, 20);
            this.txtnomepais.TabIndex = 3;
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(390, 12);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(66, 23);
            this.btnincluir.TabIndex = 4;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(390, 42);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(63, 23);
            this.btngravar.TabIndex = 5;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click_1);
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(390, 74);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(68, 23);
            this.btndeletar.TabIndex = 6;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(36, 124);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(61, 23);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(390, 108);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(62, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // FrmPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 157);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.txtnomepais);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtcodigopais);
            this.Controls.Add(this.lblcodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Países";
            this.Load += new System.EventHandler(this.FrmPais_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPais_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnvoltar;
        public System.Windows.Forms.TextBox txtcodigopais;
        public System.Windows.Forms.TextBox txtnomepais;
        private System.Windows.Forms.Button btnLimpar;
    }
}