namespace Calcolatore
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.NHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NReti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Calcola = new System.Windows.Forms.Button();
            this.Tabella = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // NHost
            // 
            this.NHost.Location = new System.Drawing.Point(28, 58);
            this.NHost.Name = "NHost";
            this.NHost.Size = new System.Drawing.Size(179, 20);
            this.NHost.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inserisci il numero di host";
            // 
            // NReti
            // 
            this.NReti.Location = new System.Drawing.Point(28, 102);
            this.NReti.Name = "NReti";
            this.NReti.Size = new System.Drawing.Size(206, 20);
            this.NReti.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Inserisci il numero di sottoreti";
            // 
            // Calcola
            // 
            this.Calcola.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcola.Location = new System.Drawing.Point(44, 128);
            this.Calcola.Name = "Calcola";
            this.Calcola.Size = new System.Drawing.Size(163, 71);
            this.Calcola.TabIndex = 4;
            this.Calcola.Text = "Calcola";
            this.Calcola.UseVisualStyleBackColor = true;
            this.Calcola.Click += new System.EventHandler(this.Calcola_Click);
            // 
            // Tabella
            // 
            this.Tabella.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tabella.FormattingEnabled = true;
            this.Tabella.ItemHeight = 20;
            this.Tabella.Location = new System.Drawing.Point(258, 12);
            this.Tabella.Name = "Tabella";
            this.Tabella.Size = new System.Drawing.Size(499, 404);
            this.Tabella.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tabella);
            this.Controls.Add(this.Calcola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NReti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NHost);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NReti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Calcola;
        private System.Windows.Forms.ListBox Tabella;
    }
}

