namespace Prova_TestMartin
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.txtbPeso = new System.Windows.Forms.TextBox();
            this.txtbAltura = new System.Windows.Forms.TextBox();
            this.txtbIdade = new System.Windows.Forms.TextBox();
            this.dataDados = new System.Windows.Forms.DataGridView();
            this.lblAltera = new System.Windows.Forms.Label();
            this.txtbEdita = new System.Windows.Forms.TextBox();
            this.txtbEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(55, 125);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(137, 47);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(221, 125);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(144, 47);
            this.btnAlterar.TabIndex = 1;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(398, 125);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(138, 47);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(286, 22);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(31, 13);
            this.lblPeso.TabIndex = 6;
            this.lblPeso.Text = "Peso";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(283, 48);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(34, 13);
            this.lblAltura.TabIndex = 7;
            this.lblAltura.Text = "Altura";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(18, 45);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 8;
            this.lblIdade.Text = "Idade";
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(58, 16);
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(167, 20);
            this.txtbNome.TabIndex = 9;
            // 
            // txtbPeso
            // 
            this.txtbPeso.Location = new System.Drawing.Point(426, 16);
            this.txtbPeso.Name = "txtbPeso";
            this.txtbPeso.Size = new System.Drawing.Size(147, 20);
            this.txtbPeso.TabIndex = 10;
            // 
            // txtbAltura
            // 
            this.txtbAltura.Location = new System.Drawing.Point(426, 45);
            this.txtbAltura.Name = "txtbAltura";
            this.txtbAltura.Size = new System.Drawing.Size(147, 20);
            this.txtbAltura.TabIndex = 11;
            // 
            // txtbIdade
            // 
            this.txtbIdade.Location = new System.Drawing.Point(58, 42);
            this.txtbIdade.Name = "txtbIdade";
            this.txtbIdade.Size = new System.Drawing.Size(167, 20);
            this.txtbIdade.TabIndex = 14;
            // 
            // dataDados
            // 
            this.dataDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDados.Location = new System.Drawing.Point(12, 178);
            this.dataDados.Name = "dataDados";
            this.dataDados.Size = new System.Drawing.Size(561, 297);
            this.dataDados.TabIndex = 18;
            // 
            // lblAltera
            // 
            this.lblAltera.AutoSize = true;
            this.lblAltera.Location = new System.Drawing.Point(283, 78);
            this.lblAltera.Name = "lblAltera";
            this.lblAltera.Size = new System.Drawing.Size(137, 13);
            this.lblAltera.TabIndex = 19;
            this.lblAltera.Text = "digite o nome a ser alterado";
            // 
            // txtbEdita
            // 
            this.txtbEdita.Location = new System.Drawing.Point(426, 75);
            this.txtbEdita.Name = "txtbEdita";
            this.txtbEdita.Size = new System.Drawing.Size(147, 20);
            this.txtbEdita.TabIndex = 20;
            // 
            // txtbEmail
            // 
            this.txtbEmail.AutoSize = true;
            this.txtbEmail.Location = new System.Drawing.Point(18, 75);
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(35, 13);
            this.txtbEmail.TabIndex = 16;
            this.txtbEmail.Text = "E-mail";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(59, 72);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(166, 20);
            this.textBoxEmail.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 487);
            this.Controls.Add(this.lblAltera);
            this.Controls.Add(this.txtbEdita);
            this.Controls.Add(this.dataDados);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.txtbEmail);
            this.Controls.Add(this.txtbIdade);
            this.Controls.Add(this.txtbAltura);
            this.Controls.Add(this.txtbPeso);
            this.Controls.Add(this.txtbNome);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.TextBox txtbPeso;
        private System.Windows.Forms.TextBox txtbAltura;
        private System.Windows.Forms.TextBox txtbIdade;
        private System.Windows.Forms.DataGridView dataDados;
        private System.Windows.Forms.Label lblAltera;
        private System.Windows.Forms.TextBox txtbEdita;
        private System.Windows.Forms.Label txtbEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
    }
}

