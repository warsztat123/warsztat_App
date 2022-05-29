namespace WarsztatApp
{
    partial class FormMagazyn
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
            this.Kategoria = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIlosc = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtNazwa = new System.Windows.Forms.TextBox();
            this.przyciskUsun = new System.Windows.Forms.Button();
            this.przyciskModyfikuj = new System.Windows.Forms.Button();
            this.przyciskDodaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Kategoria
            // 
            this.Kategoria.AutoSize = true;
            this.Kategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Kategoria.Location = new System.Drawing.Point(7, 418);
            this.Kategoria.Name = "Kategoria";
            this.Kategoria.Size = new System.Drawing.Size(96, 25);
            this.Kategoria.TabIndex = 61;
            this.Kategoria.Text = "Kategoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "Ilość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 25);
            this.label2.TabIndex = 57;
            this.label2.Text = "Cena";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Nazwa";
            // 
            // txtIlosc
            // 
            this.txtIlosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIlosc.Location = new System.Drawing.Point(151, 126);
            this.txtIlosc.Name = "txtIlosc";
            this.txtIlosc.Size = new System.Drawing.Size(212, 30);
            this.txtIlosc.TabIndex = 51;
            // 
            // txtCena
            // 
            this.txtCena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtCena.Location = new System.Drawing.Point(151, 67);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(212, 30);
            this.txtCena.TabIndex = 50;
            // 
            // txtNazwa
            // 
            this.txtNazwa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNazwa.Location = new System.Drawing.Point(151, 13);
            this.txtNazwa.Name = "txtNazwa";
            this.txtNazwa.Size = new System.Drawing.Size(212, 30);
            this.txtNazwa.TabIndex = 49;
            // 
            // przyciskUsun
            // 
            this.przyciskUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przyciskUsun.Location = new System.Drawing.Point(12, 549);
            this.przyciskUsun.Name = "przyciskUsun";
            this.przyciskUsun.Size = new System.Drawing.Size(351, 59);
            this.przyciskUsun.TabIndex = 48;
            this.przyciskUsun.Text = "Usuń";
            this.przyciskUsun.UseVisualStyleBackColor = true;
            this.przyciskUsun.Click += new System.EventHandler(this.Usun_Click);
            // 
            // przyciskModyfikuj
            // 
            this.przyciskModyfikuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przyciskModyfikuj.Location = new System.Drawing.Point(12, 614);
            this.przyciskModyfikuj.Name = "przyciskModyfikuj";
            this.przyciskModyfikuj.Size = new System.Drawing.Size(351, 59);
            this.przyciskModyfikuj.TabIndex = 47;
            this.przyciskModyfikuj.Text = "Modyfikuj";
            this.przyciskModyfikuj.UseVisualStyleBackColor = true;
            this.przyciskModyfikuj.Click += new System.EventHandler(this.modyfikuj_Click);
            // 
            // przyciskDodaj
            // 
            this.przyciskDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przyciskDodaj.Location = new System.Drawing.Point(12, 679);
            this.przyciskDodaj.Name = "przyciskDodaj";
            this.przyciskDodaj.Size = new System.Drawing.Size(351, 59);
            this.przyciskDodaj.TabIndex = 46;
            this.przyciskDodaj.Text = "Dodaj";
            this.przyciskDodaj.UseVisualStyleBackColor = true;
            this.przyciskDodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(383, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(805, 725);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(110, 418);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 24);
            this.comboBox1.TabIndex = 62;
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // FormMagazyn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Kategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIlosc);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtNazwa);
            this.Controls.Add(this.przyciskUsun);
            this.Controls.Add(this.przyciskModyfikuj);
            this.Controls.Add(this.przyciskDodaj);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMagazyn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormMagazyn";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIlosc;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtNazwa;
        private System.Windows.Forms.Button przyciskUsun;
        private System.Windows.Forms.Button przyciskModyfikuj;
        private System.Windows.Forms.Button przyciskDodaj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}