namespace LES_15_II_N
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblusuario = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblsenha = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.chbmostrar = new System.Windows.Forms.CheckBox();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblusuario.Location = new System.Drawing.Point(122, 132);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(43, 13);
            this.lblusuario.TabIndex = 0;
            this.lblusuario.Text = "&Usuário";
            // 
            // txtusuario
            // 
            this.txtusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtusuario.Location = new System.Drawing.Point(47, 149);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(193, 20);
            this.txtusuario.TabIndex = 1;
            this.txtusuario.Enter += new System.EventHandler(this.txtusuario_Enter);
            this.txtusuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtusuario_KeyDown);
            this.txtusuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtusuario_KeyPress);
            // 
            // lblsenha
            // 
            this.lblsenha.AutoSize = true;
            this.lblsenha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsenha.Location = new System.Drawing.Point(124, 179);
            this.lblsenha.Name = "lblsenha";
            this.lblsenha.Size = new System.Drawing.Size(38, 13);
            this.lblsenha.TabIndex = 3;
            this.lblsenha.Text = "Senha";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(47, 194);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(193, 20);
            this.txtsenha.TabIndex = 4;
            this.txtsenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtsenha_KeyDown);
            this.txtsenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsenha_KeyPress);
            // 
            // chbmostrar
            // 
            this.chbmostrar.AutoSize = true;
            this.chbmostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chbmostrar.Location = new System.Drawing.Point(96, 223);
            this.chbmostrar.Name = "chbmostrar";
            this.chbmostrar.Size = new System.Drawing.Size(95, 17);
            this.chbmostrar.TabIndex = 5;
            this.chbmostrar.Text = "&Mostrar Senha";
            this.chbmostrar.UseVisualStyleBackColor = true;
            this.chbmostrar.CheckStateChanged += new System.EventHandler(this.chbmostrar_CheckStateChanged);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(12, 283);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 6;
            this.btnsair.Text = "&Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(193, 244);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 7;
            this.btnok.Text = "&OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(72, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(289, 318);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.chbmostrar);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.lblsenha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.lblusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENDAS LES - LOGIN";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLogin_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblsenha;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.CheckBox chbmostrar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnok;
    }
}