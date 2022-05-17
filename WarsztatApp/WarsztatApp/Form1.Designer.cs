namespace WarsztatApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.LogoMale = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Naglowek = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LogoGlowne = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.LogoMale);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 1033);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("SansSerif", 19.8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(3, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(334, 102);
            this.button2.TabIndex = 2;
            this.button2.Text = "Magazyn";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("SansSerif", 19.8F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(3, 449);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(334, 102);
            this.button4.TabIndex = 4;
            this.button4.Text = "CEPiK";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("SansSerif", 19.8F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(3, 341);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(334, 102);
            this.button3.TabIndex = 3;
            this.button3.Text = "Klienci";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("SansSerif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button1.Location = new System.Drawing.Point(3, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 102);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zlecenia";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogoMale
            // 
            this.LogoMale.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogoMale.AutoSize = true;
            this.LogoMale.Font = new System.Drawing.Font("Jokerman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoMale.Location = new System.Drawing.Point(40, 18);
            this.LogoMale.Name = "LogoMale";
            this.LogoMale.Size = new System.Drawing.Size(256, 70);
            this.LogoMale.TabIndex = 0;
            this.LogoMale.Text = "Warsztat";
            this.LogoMale.Click += new System.EventHandler(this.LogoMale_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.Naglowek);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(342, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1560, 100);
            this.panel2.TabIndex = 1;
            // 
            // Naglowek
            // 
            this.Naglowek.AutoSize = true;
            this.Naglowek.Font = new System.Drawing.Font("Jokerman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Naglowek.Location = new System.Drawing.Point(383, 9);
            this.Naglowek.Name = "Naglowek";
            this.Naglowek.Size = new System.Drawing.Size(105, 70);
            this.Naglowek.TabIndex = 1;
            this.Naglowek.Text = "---";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.Controls.Add(this.LogoGlowne);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(342, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1560, 933);
            this.panel3.TabIndex = 2;
            // 
            // LogoGlowne
            // 
            this.LogoGlowne.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LogoGlowne.AutoSize = true;
            this.LogoGlowne.Font = new System.Drawing.Font("Jokerman", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoGlowne.Location = new System.Drawing.Point(277, 241);
            this.LogoGlowne.Name = "LogoGlowne";
            this.LogoGlowne.Size = new System.Drawing.Size(626, 175);
            this.LogoGlowne.TabIndex = 1;
            this.LogoGlowne.Text = "Warsztat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1921, 1080);
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WarsztatApp Main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LogoMale;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LogoGlowne;
        private System.Windows.Forms.Label Naglowek;
    }
}

