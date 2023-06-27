namespace CatalogoFilmes.View
{
    partial class TelaCadastroSerie
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
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbox_categoriaserie = new System.Windows.Forms.ComboBox();
            this.txbox_temp = new System.Windows.Forms.TextBox();
            this.txbox_estreiaserie = new System.Windows.Forms.TextBox();
            this.txt_boxserie = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(402, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cadastro";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::CatalogoFilmes.Properties.Resources.badalo__1_;
            this.button1.Location = new System.Drawing.Point(391, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 83);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbox_categoriaserie
            // 
            this.cbox_categoriaserie.FormattingEnabled = true;
            this.cbox_categoriaserie.Items.AddRange(new object[] {
            "Terror",
            "Romance",
            "Comédia",
            "Ficção",
            "Ação",
            "Suspense",
            "Drama",
            "Animação"});
            this.cbox_categoriaserie.Location = new System.Drawing.Point(375, 239);
            this.cbox_categoriaserie.Name = "cbox_categoriaserie";
            this.cbox_categoriaserie.Size = new System.Drawing.Size(154, 23);
            this.cbox_categoriaserie.TabIndex = 19;
            // 
            // txbox_temp
            // 
            this.txbox_temp.Location = new System.Drawing.Point(114, 347);
            this.txbox_temp.Name = "txbox_temp";
            this.txbox_temp.Size = new System.Drawing.Size(152, 23);
            this.txbox_temp.TabIndex = 18;
            // 
            // txbox_estreiaserie
            // 
            this.txbox_estreiaserie.Location = new System.Drawing.Point(114, 241);
            this.txbox_estreiaserie.Name = "txbox_estreiaserie";
            this.txbox_estreiaserie.Size = new System.Drawing.Size(152, 23);
            this.txbox_estreiaserie.TabIndex = 17;
            // 
            // txt_boxserie
            // 
            this.txt_boxserie.Location = new System.Drawing.Point(114, 140);
            this.txt_boxserie.Name = "txt_boxserie";
            this.txt_boxserie.Size = new System.Drawing.Size(240, 23);
            this.txt_boxserie.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(114, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "TEMPORADA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(356, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Categoria da Série:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(114, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Estreia da Série:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(114, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nome da Série:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(224, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "CADASTRO DA SÉRIE";
            // 
            // TelaCadastroSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(643, 479);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbox_categoriaserie);
            this.Controls.Add(this.txbox_temp);
            this.Controls.Add(this.txbox_estreiaserie);
            this.Controls.Add(this.txt_boxserie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastroSerie";
            this.Text = "TelaCadastroSerie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private Button button1;
        private ComboBox cbox_categoriaserie;
        private TextBox txbox_temp;
        private TextBox txbox_estreiaserie;
        private TextBox txt_boxserie;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}