namespace TPGrafos
{
    partial class Menu
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
            this.AbirArquivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AbirArquivo
            // 
            this.AbirArquivo.Location = new System.Drawing.Point(336, 405);
            this.AbirArquivo.Name = "AbirArquivo";
            this.AbirArquivo.Size = new System.Drawing.Size(75, 23);
            this.AbirArquivo.TabIndex = 0;
            this.AbirArquivo.Text = "Abrir arquivo";
            this.AbirArquivo.UseVisualStyleBackColor = true;
            this.AbirArquivo.Click += new System.EventHandler(this.AbirArquivo_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AbirArquivo);
            this.Name = "Menu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AbirArquivo;
    }
}

