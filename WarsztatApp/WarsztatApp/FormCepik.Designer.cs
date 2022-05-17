namespace WarsztatApp
{
    partial class FormCepik
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
            this.webBrowserCepik = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowserCepik
            // 
            this.webBrowserCepik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserCepik.Location = new System.Drawing.Point(0, 0);
            this.webBrowserCepik.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserCepik.Name = "webBrowserCepik";
            this.webBrowserCepik.Size = new System.Drawing.Size(1200, 740);
            this.webBrowserCepik.TabIndex = 0;
            this.webBrowserCepik.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // FormCepik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 740);
            this.Controls.Add(this.webBrowserCepik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCepik";
            this.Text = "FormCepik";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowserCepik;
    }
}