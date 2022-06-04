namespace WarsztatApp
{
    partial class FormPracownicy
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
            this.components = new System.ComponentModel.Container();
            this.pracownikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warsztatDataSet = new WarsztatApp.WarsztatDataSet();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonModyfikuj = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pracownikIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracownikTableAdapter = new WarsztatApp.WarsztatDataSetTableAdapters.PracownikTableAdapter();
            this.textID = new System.Windows.Forms.TextBox();
            this.textImie = new System.Windows.Forms.TextBox();
            this.textNazwisko = new System.Windows.Forms.TextBox();
            this.textLogin = new System.Windows.Forms.TextBox();
            this.textHaslo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warsztatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pracownikBindingSource
            // 
            this.pracownikBindingSource.DataMember = "Pracownik";
            this.pracownikBindingSource.DataSource = this.warsztatDataSet;
            // 
            // warsztatDataSet
            // 
            this.warsztatDataSet.DataSetName = "WarsztatDataSet";
            this.warsztatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonUsun
            // 
            this.buttonUsun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUsun.Location = new System.Drawing.Point(12, 532);
            this.buttonUsun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(351, 59);
            this.buttonUsun.TabIndex = 31;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // buttonModyfikuj
            // 
            this.buttonModyfikuj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonModyfikuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonModyfikuj.Location = new System.Drawing.Point(12, 596);
            this.buttonModyfikuj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModyfikuj.Name = "buttonModyfikuj";
            this.buttonModyfikuj.Size = new System.Drawing.Size(351, 59);
            this.buttonModyfikuj.TabIndex = 30;
            this.buttonModyfikuj.Text = "Modyfikuj";
            this.buttonModyfikuj.UseVisualStyleBackColor = true;
            this.buttonModyfikuj.Click += new System.EventHandler(this.buttonModyfikuj_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodaj.Location = new System.Drawing.Point(12, 661);
            this.buttonDodaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(351, 59);
            this.buttonDodaj.TabIndex = 29;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pracownikIDDataGridViewTextBoxColumn,
            this.imieDataGridViewTextBoxColumn,
            this.nazwiskoDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.hasloDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pracownikBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(383, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(805, 705);
            this.dataGridView1.TabIndex = 28;
            // 
            // pracownikIDDataGridViewTextBoxColumn
            // 
            this.pracownikIDDataGridViewTextBoxColumn.DataPropertyName = "Pracownik_ID";
            this.pracownikIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.pracownikIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pracownikIDDataGridViewTextBoxColumn.Name = "pracownikIDDataGridViewTextBoxColumn";
            this.pracownikIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imieDataGridViewTextBoxColumn
            // 
            this.imieDataGridViewTextBoxColumn.DataPropertyName = "Imie";
            this.imieDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.imieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.imieDataGridViewTextBoxColumn.Name = "imieDataGridViewTextBoxColumn";
            // 
            // nazwiskoDataGridViewTextBoxColumn
            // 
            this.nazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.nazwiskoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazwiskoDataGridViewTextBoxColumn.Name = "nazwiskoDataGridViewTextBoxColumn";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // hasloDataGridViewTextBoxColumn
            // 
            this.hasloDataGridViewTextBoxColumn.DataPropertyName = "Haslo";
            this.hasloDataGridViewTextBoxColumn.HeaderText = "Haslo";
            this.hasloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hasloDataGridViewTextBoxColumn.Name = "hasloDataGridViewTextBoxColumn";
            this.hasloDataGridViewTextBoxColumn.Visible = false;
            // 
            // pracownikTableAdapter
            // 
            this.pracownikTableAdapter.ClearBeforeFill = true;
            // 
            // textID
            // 
            this.textID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "Pracownik_ID", true));
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textID.Location = new System.Drawing.Point(151, 15);
            this.textID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textID.Name = "textID";
            this.textID.ReadOnly = true;
            this.textID.Size = new System.Drawing.Size(212, 30);
            this.textID.TabIndex = 32;
            // 
            // textImie
            // 
            this.textImie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "Imie", true));
            this.textImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textImie.Location = new System.Drawing.Point(151, 69);
            this.textImie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textImie.Name = "textImie";
            this.textImie.Size = new System.Drawing.Size(212, 30);
            this.textImie.TabIndex = 33;
            // 
            // textNazwisko
            // 
            this.textNazwisko.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "Nazwisko", true));
            this.textNazwisko.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textNazwisko.Location = new System.Drawing.Point(151, 128);
            this.textNazwisko.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNazwisko.Name = "textNazwisko";
            this.textNazwisko.Size = new System.Drawing.Size(212, 30);
            this.textNazwisko.TabIndex = 34;
            // 
            // textLogin
            // 
            this.textLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "Login", true));
            this.textLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textLogin.Location = new System.Drawing.Point(151, 183);
            this.textLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textLogin.Name = "textLogin";
            this.textLogin.Size = new System.Drawing.Size(212, 30);
            this.textLogin.TabIndex = 35;
            // 
            // textHaslo
            // 
            this.textHaslo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pracownikBindingSource, "Haslo", true));
            this.textHaslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textHaslo.Location = new System.Drawing.Point(151, 236);
            this.textHaslo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textHaslo.Name = "textHaslo";
            this.textHaslo.PasswordChar = '*';
            this.textHaslo.Size = new System.Drawing.Size(212, 30);
            this.textHaslo.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 39;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 40;
            this.label2.Text = "Imię:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nazwisko:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Login:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Hasło:";
            // 
            // FormPracownicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 730);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textHaslo);
            this.Controls.Add(this.textLogin);
            this.Controls.Add(this.textNazwisko);
            this.Controls.Add(this.textImie);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.buttonModyfikuj);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPracownicy";
            this.Text = "FormKlienci";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPracownicy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pracownikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warsztatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.Button buttonModyfikuj;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WarsztatDataSet warsztatDataSet;
        private System.Windows.Forms.BindingSource pracownikBindingSource;
        private WarsztatDataSetTableAdapters.PracownikTableAdapter pracownikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pracownikIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasloDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textImie;
        private System.Windows.Forms.TextBox textNazwisko;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.TextBox textHaslo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}