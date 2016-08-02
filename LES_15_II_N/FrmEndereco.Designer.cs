namespace LES_15_II_N
{
    partial class FrmEndereco
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
            this.lblendcep = new System.Windows.Forms.Label();
            this.lblendendereco = new System.Windows.Forms.Label();
            this.txtendcep = new System.Windows.Forms.TextBox();
            this.txtendendereco = new System.Windows.Forms.TextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btnincluir = new System.Windows.Forms.Button();
            this.txtnomebairro = new System.Windows.Forms.TextBox();
            this.txtcodigobairro = new System.Windows.Forms.TextBox();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblendcep
            // 
            this.lblendcep.AutoSize = true;
            this.lblendcep.Location = new System.Drawing.Point(12, 27);
            this.lblendcep.Name = "lblendcep";
            this.lblendcep.Size = new System.Drawing.Size(34, 13);
            this.lblendcep.TabIndex = 0;
            this.lblendcep.Text = "CEP :";
            // 
            // lblendendereco
            // 
            this.lblendendereco.AutoSize = true;
            this.lblendendereco.Location = new System.Drawing.Point(12, 69);
            this.lblendendereco.Name = "lblendendereco";
            this.lblendendereco.Size = new System.Drawing.Size(59, 13);
            this.lblendendereco.TabIndex = 2;
            this.lblendendereco.Text = "Endereço :";
            // 
            // txtendcep
            // 
            this.txtendcep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtendcep.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtendcep.Location = new System.Drawing.Point(50, 25);
            this.txtendcep.Name = "txtendcep";
            this.txtendcep.Size = new System.Drawing.Size(100, 20);
            this.txtendcep.TabIndex = 1;
            this.txtendcep.Leave += new System.EventHandler(this.txtendcep_Leave_1);
            // 
            // txtendendereco
            // 
            this.txtendendereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtendendereco.Location = new System.Drawing.Point(75, 68);
            this.txtendendereco.Name = "txtendendereco";
            this.txtendendereco.Size = new System.Drawing.Size(289, 20);
            this.txtendendereco.TabIndex = 3;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(12, 154);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(59, 23);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(409, 70);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(58, 23);
            this.btndeletar.TabIndex = 10;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(409, 41);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(58, 23);
            this.btngravar.TabIndex = 9;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(409, 12);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(58, 23);
            this.btnincluir.TabIndex = 7;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // txtnomebairro
            // 
            this.txtnomebairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnomebairro.Location = new System.Drawing.Point(104, 108);
            this.txtnomebairro.Name = "txtnomebairro";
            this.txtnomebairro.ReadOnly = true;
            this.txtnomebairro.Size = new System.Drawing.Size(260, 20);
            this.txtnomebairro.TabIndex = 6;
            this.txtnomebairro.TabStop = false;
            // 
            // txtcodigobairro
            // 
            this.txtcodigobairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigobairro.Location = new System.Drawing.Point(58, 108);
            this.txtcodigobairro.Name = "txtcodigobairro";
            this.txtcodigobairro.Size = new System.Drawing.Size(36, 20);
            this.txtcodigobairro.TabIndex = 5;
            this.txtcodigobairro.TextChanged += new System.EventHandler(this.txtcodigobairro_Leave);
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(17, 110);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(40, 13);
            this.lblcodigo.TabIndex = 4;
            this.lblcodigo.Text = "Bairro :";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(408, 98);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(58, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FrmEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(495, 211);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtnomebairro);
            this.Controls.Add(this.txtcodigobairro);
            this.Controls.Add(this.lblcodigo);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.txtendendereco);
            this.Controls.Add(this.txtendcep);
            this.Controls.Add(this.lblendendereco);
            this.Controls.Add(this.lblendcep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEndereco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados de Endereço";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblendcep;
        private System.Windows.Forms.Label lblendendereco;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.TextBox txtnomebairro;
        private System.Windows.Forms.TextBox txtcodigobairro;
        private System.Windows.Forms.Label lblcodigo;
        public System.Windows.Forms.TextBox txtendcep;
        public System.Windows.Forms.TextBox txtendendereco;
        private System.Windows.Forms.Button btnLimpar;
    }
}