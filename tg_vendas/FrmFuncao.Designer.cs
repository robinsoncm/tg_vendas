namespace LES_15_II_N
{
    partial class FrmFuncao
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
            this.lblcodfuncao = new System.Windows.Forms.Label();
            this.txtcodfuncao = new System.Windows.Forms.TextBox();
            this.lblnomefuncao = new System.Windows.Forms.Label();
            this.txtnomefuncao = new System.Windows.Forms.TextBox();
            this.btnincluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.lblcbo = new System.Windows.Forms.Label();
            this.txtcodigocbo = new System.Windows.Forms.TextBox();
            this.txtdescricaocbo = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcodfuncao
            // 
            this.lblcodfuncao.AutoSize = true;
            this.lblcodfuncao.Location = new System.Drawing.Point(24, 26);
            this.lblcodfuncao.Name = "lblcodfuncao";
            this.lblcodfuncao.Size = new System.Drawing.Size(46, 13);
            this.lblcodfuncao.TabIndex = 0;
            this.lblcodfuncao.Text = "Codigo :";
            // 
            // txtcodfuncao
            // 
            this.txtcodfuncao.Location = new System.Drawing.Point(74, 23);
            this.txtcodfuncao.Name = "txtcodfuncao";
            this.txtcodfuncao.Size = new System.Drawing.Size(82, 20);
            this.txtcodfuncao.TabIndex = 1;
            this.txtcodfuncao.Leave += new System.EventHandler(this.txtcodfuncao_Leave);
            // 
            // lblnomefuncao
            // 
            this.lblnomefuncao.AutoSize = true;
            this.lblnomefuncao.Location = new System.Drawing.Point(24, 69);
            this.lblnomefuncao.Name = "lblnomefuncao";
            this.lblnomefuncao.Size = new System.Drawing.Size(95, 13);
            this.lblnomefuncao.TabIndex = 2;
            this.lblnomefuncao.Text = "Nome da Função :";
            // 
            // txtnomefuncao
            // 
            this.txtnomefuncao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnomefuncao.Location = new System.Drawing.Point(123, 66);
            this.txtnomefuncao.MaxLength = 50;
            this.txtnomefuncao.Name = "txtnomefuncao";
            this.txtnomefuncao.Size = new System.Drawing.Size(270, 20);
            this.txtnomefuncao.TabIndex = 3;
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(428, 12);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(68, 23);
            this.btnincluir.TabIndex = 10;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(428, 41);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(68, 23);
            this.btngravar.TabIndex = 11;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(428, 70);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(68, 23);
            this.btndeletar.TabIndex = 12;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(27, 200);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(61, 23);
            this.btnvoltar.TabIndex = 14;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // lblcbo
            // 
            this.lblcbo.AutoSize = true;
            this.lblcbo.Location = new System.Drawing.Point(24, 113);
            this.lblcbo.Name = "lblcbo";
            this.lblcbo.Size = new System.Drawing.Size(35, 13);
            this.lblcbo.TabIndex = 4;
            this.lblcbo.Text = "CBO :";
            // 
            // txtcodigocbo
            // 
            this.txtcodigocbo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodigocbo.Location = new System.Drawing.Point(65, 110);
            this.txtcodigocbo.Name = "txtcodigocbo";
            this.txtcodigocbo.Size = new System.Drawing.Size(82, 20);
            this.txtcodigocbo.TabIndex = 5;
            this.txtcodigocbo.Leave += new System.EventHandler(this.txtcbo_Leave);
            // 
            // txtdescricaocbo
            // 
            this.txtdescricaocbo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdescricaocbo.Location = new System.Drawing.Point(65, 143);
            this.txtdescricaocbo.Name = "txtdescricaocbo";
            this.txtdescricaocbo.ReadOnly = true;
            this.txtdescricaocbo.Size = new System.Drawing.Size(328, 20);
            this.txtdescricaocbo.TabIndex = 8;
            this.txtdescricaocbo.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(428, 103);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(68, 23);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // FrmFuncao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(545, 245);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtdescricaocbo);
            this.Controls.Add(this.txtcodigocbo);
            this.Controls.Add(this.lblcbo);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.txtnomefuncao);
            this.Controls.Add(this.lblnomefuncao);
            this.Controls.Add(this.txtcodfuncao);
            this.Controls.Add(this.lblcodfuncao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFuncao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados de Funções";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFuncao_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodfuncao;
        private System.Windows.Forms.TextBox txtcodfuncao;
        private System.Windows.Forms.Label lblnomefuncao;
        private System.Windows.Forms.TextBox txtnomefuncao;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblcbo;
        private System.Windows.Forms.TextBox txtcodigocbo;
        private System.Windows.Forms.TextBox txtdescricaocbo;
        private System.Windows.Forms.Button btnLimpar;
    }
}