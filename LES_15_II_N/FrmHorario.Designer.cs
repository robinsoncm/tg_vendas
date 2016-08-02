namespace LES_15_II_N
{
    partial class FrmHorario
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
            this.txtcodhor = new System.Windows.Forms.TextBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.txttipohorario = new System.Windows.Forms.TextBox();
            this.lblhorentman = new System.Windows.Forms.Label();
            this.lblhorsaiman = new System.Windows.Forms.Label();
            this.lblhorenttar = new System.Windows.Forms.Label();
            this.lblhorsaitar = new System.Windows.Forms.Label();
            this.btnincluir = new System.Windows.Forms.Button();
            this.btngravar = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.txtdescricaotipo = new System.Windows.Forms.TextBox();
            this.txthorentman = new System.Windows.Forms.MaskedTextBox();
            this.txthorsaiman = new System.Windows.Forms.MaskedTextBox();
            this.txthorenttar = new System.Windows.Forms.MaskedTextBox();
            this.txthorsaitar = new System.Windows.Forms.MaskedTextBox();
            this.lblh1 = new System.Windows.Forms.Label();
            this.lblh2 = new System.Windows.Forms.Label();
            this.lblh3 = new System.Windows.Forms.Label();
            this.lblh4 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Location = new System.Drawing.Point(51, 29);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(46, 13);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo :";
            // 
            // txtcodhor
            // 
            this.txtcodhor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcodhor.Location = new System.Drawing.Point(102, 29);
            this.txtcodhor.Name = "txtcodhor";
            this.txtcodhor.Size = new System.Drawing.Size(51, 20);
            this.txtcodhor.TabIndex = 1;
            this.txtcodhor.Leave += new System.EventHandler(this.txtcodigo_Leave);
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(23, 64);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(74, 13);
            this.lbltipo.TabIndex = 2;
            this.lbltipo.Text = "Tipo Horario  :";
            // 
            // txttipohorario
            // 
            this.txttipohorario.Location = new System.Drawing.Point(104, 61);
            this.txttipohorario.Name = "txttipohorario";
            this.txttipohorario.Size = new System.Drawing.Size(50, 20);
            this.txttipohorario.TabIndex = 2;
            this.txttipohorario.Leave += new System.EventHandler(this.txttipohorario_Leave);
            // 
            // lblhorentman
            // 
            this.lblhorentman.AutoSize = true;
            this.lblhorentman.Location = new System.Drawing.Point(11, 94);
            this.lblhorentman.Name = "lblhorentman";
            this.lblhorentman.Size = new System.Drawing.Size(86, 13);
            this.lblhorentman.TabIndex = 6;
            this.lblhorentman.Text = "Entrada Manhã :";
            // 
            // lblhorsaiman
            // 
            this.lblhorsaiman.AutoSize = true;
            this.lblhorsaiman.Location = new System.Drawing.Point(177, 98);
            this.lblhorsaiman.Name = "lblhorsaiman";
            this.lblhorsaiman.Size = new System.Drawing.Size(78, 13);
            this.lblhorsaiman.TabIndex = 12;
            this.lblhorsaiman.Text = "Saída Manhã :";
            // 
            // lblhorenttar
            // 
            this.lblhorenttar.AutoSize = true;
            this.lblhorenttar.Location = new System.Drawing.Point(15, 120);
            this.lblhorenttar.Name = "lblhorenttar";
            this.lblhorenttar.Size = new System.Drawing.Size(81, 13);
            this.lblhorenttar.TabIndex = 15;
            this.lblhorenttar.Text = "Entrada Tarde :";
            // 
            // lblhorsaitar
            // 
            this.lblhorsaitar.AutoSize = true;
            this.lblhorsaitar.Location = new System.Drawing.Point(181, 124);
            this.lblhorsaitar.Name = "lblhorsaitar";
            this.lblhorsaitar.Size = new System.Drawing.Size(73, 13);
            this.lblhorsaitar.TabIndex = 18;
            this.lblhorsaitar.Text = "Saída Tarde :";
            // 
            // btnincluir
            // 
            this.btnincluir.Location = new System.Drawing.Point(377, 12);
            this.btnincluir.Name = "btnincluir";
            this.btnincluir.Size = new System.Drawing.Size(59, 23);
            this.btnincluir.TabIndex = 25;
            this.btnincluir.Text = "Incluir";
            this.btnincluir.UseVisualStyleBackColor = true;
            this.btnincluir.Click += new System.EventHandler(this.btnincluir_Click);
            // 
            // btngravar
            // 
            this.btngravar.Location = new System.Drawing.Point(377, 41);
            this.btngravar.Name = "btngravar";
            this.btngravar.Size = new System.Drawing.Size(60, 23);
            this.btngravar.TabIndex = 26;
            this.btngravar.Text = "Gravar";
            this.btngravar.UseVisualStyleBackColor = true;
            this.btngravar.Click += new System.EventHandler(this.btngravar_Click);
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(378, 70);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(59, 23);
            this.btndeletar.TabIndex = 27;
            this.btndeletar.Text = "Deletar";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(18, 161);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(63, 23);
            this.btnvoltar.TabIndex = 30;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // txtdescricaotipo
            // 
            this.txtdescricaotipo.Location = new System.Drawing.Point(167, 61);
            this.txtdescricaotipo.MaxLength = 50;
            this.txtdescricaotipo.Name = "txtdescricaotipo";
            this.txtdescricaotipo.ReadOnly = true;
            this.txtdescricaotipo.Size = new System.Drawing.Size(166, 20);
            this.txtdescricaotipo.TabIndex = 4;
            this.txtdescricaotipo.TabStop = false;
            // 
            // txthorentman
            // 
            this.txthorentman.Location = new System.Drawing.Point(104, 91);
            this.txthorentman.Mask = "00:00";
            this.txthorentman.Name = "txthorentman";
            this.txthorentman.Size = new System.Drawing.Size(39, 20);
            this.txthorentman.TabIndex = 10;
            this.txthorentman.ValidatingType = typeof(System.DateTime);
            // 
            // txthorsaiman
            // 
            this.txthorsaiman.Location = new System.Drawing.Point(262, 91);
            this.txthorsaiman.Mask = "00:00";
            this.txthorsaiman.Name = "txthorsaiman";
            this.txthorsaiman.Size = new System.Drawing.Size(39, 20);
            this.txthorsaiman.TabIndex = 13;
            this.txthorsaiman.ValidatingType = typeof(System.DateTime);
            // 
            // txthorenttar
            // 
            this.txthorenttar.Location = new System.Drawing.Point(104, 117);
            this.txthorenttar.Mask = "00:00";
            this.txthorenttar.Name = "txthorenttar";
            this.txthorenttar.Size = new System.Drawing.Size(39, 20);
            this.txthorenttar.TabIndex = 16;
            this.txthorenttar.ValidatingType = typeof(System.DateTime);
            // 
            // txthorsaitar
            // 
            this.txthorsaitar.Location = new System.Drawing.Point(262, 117);
            this.txthorsaitar.Mask = "00:00";
            this.txthorsaitar.Name = "txthorsaitar";
            this.txthorsaitar.Size = new System.Drawing.Size(39, 20);
            this.txthorsaitar.TabIndex = 19;
            this.txthorsaitar.ValidatingType = typeof(System.DateTime);
            // 
            // lblh1
            // 
            this.lblh1.AutoSize = true;
            this.lblh1.Location = new System.Drawing.Point(150, 97);
            this.lblh1.Name = "lblh1";
            this.lblh1.Size = new System.Drawing.Size(13, 13);
            this.lblh1.TabIndex = 11;
            this.lblh1.Text = "h";
            // 
            // lblh2
            // 
            this.lblh2.AutoSize = true;
            this.lblh2.Location = new System.Drawing.Point(308, 96);
            this.lblh2.Name = "lblh2";
            this.lblh2.Size = new System.Drawing.Size(13, 13);
            this.lblh2.TabIndex = 14;
            this.lblh2.Text = "h";
            // 
            // lblh3
            // 
            this.lblh3.AutoSize = true;
            this.lblh3.Location = new System.Drawing.Point(150, 123);
            this.lblh3.Name = "lblh3";
            this.lblh3.Size = new System.Drawing.Size(13, 13);
            this.lblh3.TabIndex = 17;
            this.lblh3.Text = "h";
            // 
            // lblh4
            // 
            this.lblh4.AutoSize = true;
            this.lblh4.Location = new System.Drawing.Point(308, 123);
            this.lblh4.Name = "lblh4";
            this.lblh4.Size = new System.Drawing.Size(13, 13);
            this.lblh4.TabIndex = 20;
            this.lblh4.Text = "h";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(377, 99);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(60, 23);
            this.btnLimpar.TabIndex = 31;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click_1);
            // 
            // FrmHorario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(450, 186);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblh4);
            this.Controls.Add(this.lblh3);
            this.Controls.Add(this.lblh2);
            this.Controls.Add(this.lblh1);
            this.Controls.Add(this.txthorsaitar);
            this.Controls.Add(this.txthorenttar);
            this.Controls.Add(this.txthorsaiman);
            this.Controls.Add(this.txthorentman);
            this.Controls.Add(this.txtdescricaotipo);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btngravar);
            this.Controls.Add(this.btnincluir);
            this.Controls.Add(this.lblhorsaitar);
            this.Controls.Add(this.lblhorenttar);
            this.Controls.Add(this.lblhorsaiman);
            this.Controls.Add(this.lblhorentman);
            this.Controls.Add(this.txttipohorario);
            this.Controls.Add(this.lbltipo);
            this.Controls.Add(this.txtcodhor);
            this.Controls.Add(this.lblcodigo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHorario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados de Horários";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormHorario_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.TextBox txtcodhor;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.TextBox txttipohorario;
        private System.Windows.Forms.Label lblhorentman;
        private System.Windows.Forms.Label lblhorsaiman;
        private System.Windows.Forms.Label lblhorenttar;
        private System.Windows.Forms.Label lblhorsaitar;
        private System.Windows.Forms.Button btnincluir;
        private System.Windows.Forms.Button btngravar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.TextBox txtdescricaotipo;
        private System.Windows.Forms.MaskedTextBox txthorentman;
        private System.Windows.Forms.MaskedTextBox txthorsaiman;
        private System.Windows.Forms.MaskedTextBox txthorenttar;
        private System.Windows.Forms.MaskedTextBox txthorsaitar;
        private System.Windows.Forms.Label lblh1;
        private System.Windows.Forms.Label lblh2;
        private System.Windows.Forms.Label lblh3;
        private System.Windows.Forms.Label lblh4;
        private System.Windows.Forms.Button btnLimpar;
    }
}