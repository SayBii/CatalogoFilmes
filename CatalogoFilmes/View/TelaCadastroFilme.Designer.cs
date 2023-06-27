namespace CatalogoFilmes.View
{
    partial class TelaCadastroFilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastroFilme));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbox_filme = new System.Windows.Forms.TextBox();
            this.txbox_estreia = new System.Windows.Forms.TextBox();
            this.txbox_duracao = new System.Windows.Forms.TextBox();
            this.cbox_categoria = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(193, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE FILME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(83, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Filme:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(83, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estreia do Filme:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(325, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria do Filme:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(83, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Duração:";
            // 
            // txbox_filme
            // 
            this.txbox_filme.Location = new System.Drawing.Point(83, 103);
            this.txbox_filme.Name = "txbox_filme";
            this.txbox_filme.Size = new System.Drawing.Size(240, 23);
            this.txbox_filme.TabIndex = 5;
            // 
            // txbox_estreia
            // 
            this.txbox_estreia.Location = new System.Drawing.Point(83, 204);
            this.txbox_estreia.Name = "txbox_estreia";
            this.txbox_estreia.Size = new System.Drawing.Size(152, 23);
            this.txbox_estreia.TabIndex = 6;
            // 
            // txbox_duracao
            // 
            this.txbox_duracao.Location = new System.Drawing.Point(83, 310);
            this.txbox_duracao.Name = "txbox_duracao";
            this.txbox_duracao.Size = new System.Drawing.Size(152, 23);
            this.txbox_duracao.TabIndex = 7;
            // 
            // cbox_categoria
            // 
            this.cbox_categoria.FormattingEnabled = true;
            this.cbox_categoria.Items.AddRange(new object[] {
            "Terror",
            "Romance",
            "Comédia",
            "Ficção",
            "Ação",
            "Suspense",
            "Drama",
            "Animação"});
            this.cbox_categoria.Location = new System.Drawing.Point(344, 202);
            this.cbox_categoria.Name = "cbox_categoria";
            this.cbox_categoria.Size = new System.Drawing.Size(154, 23);
            this.cbox_categoria.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::CatalogoFilmes.Properties.Resources.badalo__1_;
            this.button1.Location = new System.Drawing.Point(360, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 83);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(371, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cadastro";
            // 
            // TelaCadastroFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 477);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbox_categoria);
            this.Controls.Add(this.txbox_duracao);
            this.Controls.Add(this.txbox_estreia);
            this.Controls.Add(this.txbox_filme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaCadastroFilme";
            this.Text = "Sistema de Catálogo de Filmes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txbox_filme;
        private TextBox txbox_estreia;
        private TextBox txbox_duracao;
        private ComboBox cbox_categoria;
        private Button button1;
        private Label label6;
    }
}