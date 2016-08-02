namespace LES_15_II_N
{
    partial class FrmBairro
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
            this.txtcodigobairro = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnomebairro = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
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
            this.lblcodigo.Location = new System.Drawing.Point(23, 34);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(46, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo :";
            // 
            // txtcodigobairro
            // 
            this.txtcodigobairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigobairro.Location = new System.Drawing.Point(72, 32);
            this.txtcodigobairro.Name = "txtcodigobairro";
            this.txtcodigobairro.Size = new System.Drawing.Size(66, 20);
            this.txtcodigobairro.TabIndex = 1;
            this.txtcodigobairro.Leave += new System.EventHandler(this.txtcodigobairro_Leave);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(26, 70);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(41, 13);
            this.lblnome.TabIndex = 2;
            this.lblnome.Text = "Nome :";
            // 
            // txtnomebairro
            // 
            this.txtnomebairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnomebairro.Location = new System.Drawing.Point(76, 70);
            this.txtnomebairro.MaxLength = 50;
            this.txtnomebairro.Name = "txtnomebairro";
            this.txtnomebairro.Size = new System.Drawing.Size(261, 20);
            this.txtnomebairro.TabIndex = 3;
            this.txtnomebairro.TextChanged += new System.EventHandler(this.txtnomebairro_TextChanged);
            // 
            // txtcodigo
            // 
            this.txtcodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigo.Location = new System.Drawing.Point(85, 110);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(83, 20);
            this.txtcodigo.TabIndex = 5;
            this.txtcodigo.Leave += new System.EventHandler(this.txtcodigo_Leave_1);
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Location = new System.Drawing.Point(26, 113);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(58, 13);
            this.lblMunicipio.TabIndex = 4;
            this.lblMunicipio.Text = "Municipio :";
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(187, 110);
            this.txtnome.Name = "txtnome";
            this.txtnome.ReadOnly = true;
            this.txtnome.Size = new System.Drawing.Size(150, 20);
            this.txtnome.TabIndex = 6;
            this.txtnome.TabStop = false;
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(370, 12);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(57, 23);
            this.btnincluir.TabIndex = 7;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(370, 41);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(57, 23);
            this.btngravar.TabIndex = 8;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(370, 70);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(57, 23);
            this.btndeletar.TabIndex = 9;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(26, 146);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(54, 23);
            this.btnvoltar.TabIndex = 11;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(370, 99);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(57, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmBairro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(435, 192);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.lblMunicipio);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.txtnomebairro);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtcodigobairro);
            this.Controls.Add(this.lblcodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBairro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manutenção dos Bairros";
            this.Load += new System.EventHandler(this.FrmBairro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBairro_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnvoltar;
        public System.Windows.Forms.TextBox txtcodigobairro;
        public System.Windows.Forms.TextBox txtnomebairro;
        private System.Windows.Forms.Button btnLimpar;
    }
}