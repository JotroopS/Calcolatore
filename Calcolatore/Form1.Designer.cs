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
            this.Classe = new System.Windows.Forms.TextBox();
            this.CDIR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SubnetDef = new System.Windows.Forms.TextBox();
            this.Subnet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            // Classe
            // 
            this.Classe.Location = new System.Drawing.Point(295, 58);
            this.Classe.Name = "Classe";
            this.Classe.Size = new System.Drawing.Size(52, 20);
            this.Classe.TabIndex = 5;
            // 
            // CDIR
            // 
            this.CDIR.Location = new System.Drawing.Point(295, 100);
            this.CDIR.Name = "CDIR";
            this.CDIR.Size = new System.Drawing.Size(40, 20);
            this.CDIR.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(292, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Classe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(292, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "CDIR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(292, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Subnet Mask di default";
            // 
            // SubnetDef
            // 
            this.SubnetDef.Location = new System.Drawing.Point(295, 142);
            this.SubnetDef.Name = "SubnetDef";
            this.SubnetDef.Size = new System.Drawing.Size(161, 20);
            this.SubnetDef.TabIndex = 10;
            // 
            // Subnet
            // 
            this.Subnet.Location = new System.Drawing.Point(295, 184);
            this.Subnet.Name = "Subnet";
            this.Subnet.Size = new System.Drawing.Size(175, 20);
            this.Subnet.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Subnet Mask di sottorete";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Subnet);
            this.Controls.Add(this.SubnetDef);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CDIR);
            this.Controls.Add(this.Classe);
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
        private System.Windows.Forms.TextBox Classe;
        private System.Windows.Forms.TextBox CDIR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SubnetDef;
        private System.Windows.Forms.TextBox Subnet;
        private System.Windows.Forms.Label label6;
    }
}

