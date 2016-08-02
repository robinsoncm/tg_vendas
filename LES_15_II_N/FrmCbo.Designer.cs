namespace LES_15_II_N
{
    partial class FrmCbo
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
            this.txtcodigocbo = new System.Windows.Forms.TextBox();
            this.lbldescricao = new System.Windows.Forms.Label();
            this.txtdescricao = new System.Windows.Forms.TextBox();
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
            this.lblcodigo.Location = new System.Drawing.Point(31, 37);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(46, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo :";
            // 
            // txtcodigocbo
            // 
            this.txtcodigocbo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigocbo.Location = new System.Drawing.Point(94, 29);
            this.txtcodigocbo.Name = "txtcodigocbo";
            this.txtcodigocbo.Size = new System.Drawing.Size(65, 20);
            this.txtcodigocbo.TabIndex = 1;
            this.txtcodigocbo.Leave += new System.EventHandler(this.txtcodigocbo_Leave);
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Location = new System.Drawing.Point(31, 70);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(61, 13);
            this.lbldescricao.TabIndex = 2;
            this.lbldescricao.Text = "Descrição :";
            // 
            // txtdescricao
            // 
            this.txtdescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescricao.Location = new System.Drawing.Point(94, 66);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(263, 20);
            this.txtdescricao.TabIndex = 3;
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(384, 0);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(55, 23);
            this.btnincluir.TabIndex = 4;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(384, 29);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(55, 23);
            this.btngravar.TabIndex = 5;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(384, 58);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(55, 23);
            this.btndeletar.TabIndex = 6;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(34, 117);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(56, 23);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(384, 87);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(55, 23);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // FrmCbo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(485, 152);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.lbldescricao);
            this.Controls.Add(this.txtcodigocbo);
            this.Controls.Add(this.lblcodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCbo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados de CBO";
            this.Load += new System.EventHandler(this.FrmCbo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCbo_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnvoltar;
        public System.Windows.Forms.TextBox txtcodigocbo;
        public System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.Button btnLimpar;
    }
}