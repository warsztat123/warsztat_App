namespace WarsztatApp
{
    partial class FormZlecenia
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonModyf = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazw = new System.Windows.Forms.TextBox();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxUlica = new System.Windows.Forms.TextBox();
            this.textBoxNrUlicy = new System.Windows.Forms.TextBox();
            this.textBoxMiasto = new System.Windows.Forms.TextBox();
            this.buttonWyswietl = new System.Windows.Forms.Button();
            this.labelImie = new System.Windows.Forms.Label();
            this.labelNazw = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelUlica = new System.Windows.Forms.Label();
            this.labelNrUlicy = new System.Windows.Forms.Label();
            this.labelMiasto = new System.Windows.Forms.Label();
            this.labelWojew = new System.Windows.Forms.Label();
            this.textBoxWojew = new System.Windows.Forms.TextBox();
            this.labelMarka = new System.Windows.Forms.Label();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.labelRocznik = new System.Windows.Forms.Label();
            this.textBoxRocznik = new System.Windows.Forms.TextBox();
            this.labelKolor = new System.Windows.Forms.Label();
            this.textBoxKolor = new System.Windows.Forms.TextBox();
            this.labelSilnik = new System.Windows.Forms.Label();
            this.textBoxSilnik = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxKodP = new System.Windows.Forms.TextBox();
            this.labelKodPocz = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerOd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDo = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelDoDaty = new System.Windows.Forms.Label();
            this.labelOdDaty = new System.Windows.Forms.Label();
            this.buttonDodajCzesci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(383, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(805, 760);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodaj.Location = new System.Drawing.Point(27, 583);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(105, 29);
            this.buttonDodaj.TabIndex = 1;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonModyf
            // 
            this.buttonModyf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonModyf.Location = new System.Drawing.Point(138, 583);
            this.buttonModyf.Name = "buttonModyf";
            this.buttonModyf.Size = new System.Drawing.Size(111, 29);
            this.buttonModyf.TabIndex = 2;
            this.buttonModyf.Text = "Modyfikuj";
            this.buttonModyf.UseVisualStyleBackColor = true;
            this.buttonModyf.Click += new System.EventHandler(this.buttonModyf_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUsun.Location = new System.Drawing.Point(255, 583);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(108, 29);
            this.buttonUsun.TabIndex = 3;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // textBoxImie
            // 
            this.textBoxImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxImie.Location = new System.Drawing.Point(134, 21);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(212, 27);
            this.textBoxImie.TabIndex = 4;
            // 
            // textBoxNazw
            // 
            this.textBoxNazw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNazw.Location = new System.Drawing.Point(134, 57);
            this.textBoxNazw.Name = "textBoxNazw";
            this.textBoxNazw.Size = new System.Drawing.Size(212, 27);
            this.textBoxNazw.TabIndex = 5;
            // 
            // textBoxTel
            // 
            this.textBoxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTel.Location = new System.Drawing.Point(134, 93);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(212, 27);
            this.textBoxTel.TabIndex = 6;
            // 
            // textBoxUlica
            // 
            this.textBoxUlica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxUlica.Location = new System.Drawing.Point(134, 129);
            this.textBoxUlica.Name = "textBoxUlica";
            this.textBoxUlica.Size = new System.Drawing.Size(212, 27);
            this.textBoxUlica.TabIndex = 7;
            // 
            // textBoxNrUlicy
            // 
            this.textBoxNrUlicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxNrUlicy.Location = new System.Drawing.Point(134, 165);
            this.textBoxNrUlicy.Name = "textBoxNrUlicy";
            this.textBoxNrUlicy.Size = new System.Drawing.Size(212, 27);
            this.textBoxNrUlicy.TabIndex = 8;
            // 
            // textBoxMiasto
            // 
            this.textBoxMiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMiasto.Location = new System.Drawing.Point(134, 201);
            this.textBoxMiasto.Name = "textBoxMiasto";
            this.textBoxMiasto.Size = new System.Drawing.Size(212, 27);
            this.textBoxMiasto.TabIndex = 9;
            // 
            // buttonWyswietl
            // 
            this.buttonWyswietl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyswietl.Location = new System.Drawing.Point(31, 49);
            this.buttonWyswietl.Name = "buttonWyswietl";
            this.buttonWyswietl.Size = new System.Drawing.Size(298, 29);
            this.buttonWyswietl.TabIndex = 21;
            this.buttonWyswietl.Text = "Wyświetl";
            this.buttonWyswietl.UseVisualStyleBackColor = true;
            this.buttonWyswietl.Click += new System.EventHandler(this.button4_Click);
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelImie.Location = new System.Drawing.Point(6, 24);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(40, 20);
            this.labelImie.TabIndex = 22;
            this.labelImie.Text = "Imie";
            // 
            // labelNazw
            // 
            this.labelNazw.AutoSize = true;
            this.labelNazw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNazw.Location = new System.Drawing.Point(6, 60);
            this.labelNazw.Name = "labelNazw";
            this.labelNazw.Size = new System.Drawing.Size(81, 20);
            this.labelNazw.TabIndex = 23;
            this.labelNazw.Text = "Nazwisko";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTel.Location = new System.Drawing.Point(6, 96);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(64, 20);
            this.labelTel.TabIndex = 24;
            this.labelTel.Text = "Telefon";
            // 
            // labelUlica
            // 
            this.labelUlica.AutoSize = true;
            this.labelUlica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUlica.Location = new System.Drawing.Point(6, 132);
            this.labelUlica.Name = "labelUlica";
            this.labelUlica.Size = new System.Drawing.Size(47, 20);
            this.labelUlica.TabIndex = 25;
            this.labelUlica.Text = "Ulica";
            // 
            // labelNrUlicy
            // 
            this.labelNrUlicy.AutoSize = true;
            this.labelNrUlicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNrUlicy.Location = new System.Drawing.Point(6, 168);
            this.labelNrUlicy.Name = "labelNrUlicy";
            this.labelNrUlicy.Size = new System.Drawing.Size(64, 20);
            this.labelNrUlicy.TabIndex = 26;
            this.labelNrUlicy.Text = "NrUlicy";
            // 
            // labelMiasto
            // 
            this.labelMiasto.AutoSize = true;
            this.labelMiasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMiasto.Location = new System.Drawing.Point(6, 204);
            this.labelMiasto.Name = "labelMiasto";
            this.labelMiasto.Size = new System.Drawing.Size(59, 20);
            this.labelMiasto.TabIndex = 27;
            this.labelMiasto.Text = "Miasto";
            // 
            // labelWojew
            // 
            this.labelWojew.AutoSize = true;
            this.labelWojew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWojew.Location = new System.Drawing.Point(6, 240);
            this.labelWojew.Name = "labelWojew";
            this.labelWojew.Size = new System.Drawing.Size(112, 20);
            this.labelWojew.TabIndex = 29;
            this.labelWojew.Text = "Województwo";
            // 
            // textBoxWojew
            // 
            this.textBoxWojew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWojew.Location = new System.Drawing.Point(134, 237);
            this.textBoxWojew.Name = "textBoxWojew";
            this.textBoxWojew.Size = new System.Drawing.Size(212, 27);
            this.textBoxWojew.TabIndex = 28;
            // 
            // labelMarka
            // 
            this.labelMarka.AutoSize = true;
            this.labelMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMarka.Location = new System.Drawing.Point(6, 28);
            this.labelMarka.Name = "labelMarka";
            this.labelMarka.Size = new System.Drawing.Size(55, 20);
            this.labelMarka.TabIndex = 33;
            this.labelMarka.Text = "Marka";
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMarka.Location = new System.Drawing.Point(134, 25);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(212, 27);
            this.textBoxMarka.TabIndex = 32;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelModel.Location = new System.Drawing.Point(6, 64);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(54, 20);
            this.labelModel.TabIndex = 35;
            this.labelModel.Text = "Model";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxModel.Location = new System.Drawing.Point(134, 61);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(212, 27);
            this.textBoxModel.TabIndex = 34;
            // 
            // labelRocznik
            // 
            this.labelRocznik.AutoSize = true;
            this.labelRocznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRocznik.Location = new System.Drawing.Point(6, 100);
            this.labelRocznik.Name = "labelRocznik";
            this.labelRocznik.Size = new System.Drawing.Size(69, 20);
            this.labelRocznik.TabIndex = 37;
            this.labelRocznik.Text = "Rocznik";
            // 
            // textBoxRocznik
            // 
            this.textBoxRocznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRocznik.Location = new System.Drawing.Point(134, 97);
            this.textBoxRocznik.Name = "textBoxRocznik";
            this.textBoxRocznik.Size = new System.Drawing.Size(212, 27);
            this.textBoxRocznik.TabIndex = 36;
            // 
            // labelKolor
            // 
            this.labelKolor.AutoSize = true;
            this.labelKolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKolor.Location = new System.Drawing.Point(6, 136);
            this.labelKolor.Name = "labelKolor";
            this.labelKolor.Size = new System.Drawing.Size(48, 20);
            this.labelKolor.TabIndex = 39;
            this.labelKolor.Text = "Kolor";
            // 
            // textBoxKolor
            // 
            this.textBoxKolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKolor.Location = new System.Drawing.Point(134, 133);
            this.textBoxKolor.Name = "textBoxKolor";
            this.textBoxKolor.Size = new System.Drawing.Size(212, 27);
            this.textBoxKolor.TabIndex = 38;
            // 
            // labelSilnik
            // 
            this.labelSilnik.AutoSize = true;
            this.labelSilnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSilnik.Location = new System.Drawing.Point(6, 172);
            this.labelSilnik.Name = "labelSilnik";
            this.labelSilnik.Size = new System.Drawing.Size(49, 20);
            this.labelSilnik.TabIndex = 41;
            this.labelSilnik.Text = "Silnik";
            // 
            // textBoxSilnik
            // 
            this.textBoxSilnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSilnik.Location = new System.Drawing.Point(134, 169);
            this.textBoxSilnik.Name = "textBoxSilnik";
            this.textBoxSilnik.Size = new System.Drawing.Size(212, 27);
            this.textBoxSilnik.TabIndex = 40;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStatus.Location = new System.Drawing.Point(23, 552);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(57, 20);
            this.labelStatus.TabIndex = 43;
            this.labelStatus.Text = "Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(86, 549);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(277, 28);
            this.comboBoxStatus.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxKodP);
            this.groupBox1.Controls.Add(this.labelKodPocz);
            this.groupBox1.Controls.Add(this.labelImie);
            this.groupBox1.Controls.Add(this.textBoxImie);
            this.groupBox1.Controls.Add(this.textBoxNazw);
            this.groupBox1.Controls.Add(this.textBoxTel);
            this.groupBox1.Controls.Add(this.textBoxUlica);
            this.groupBox1.Controls.Add(this.textBoxNrUlicy);
            this.groupBox1.Controls.Add(this.textBoxMiasto);
            this.groupBox1.Controls.Add(this.labelNazw);
            this.groupBox1.Controls.Add(this.labelTel);
            this.groupBox1.Controls.Add(this.labelUlica);
            this.groupBox1.Controls.Add(this.labelNrUlicy);
            this.groupBox1.Controls.Add(this.labelMiasto);
            this.groupBox1.Controls.Add(this.textBoxWojew);
            this.groupBox1.Controls.Add(this.labelWojew);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(17, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 312);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dane Klienta";
            // 
            // textBoxKodP
            // 
            this.textBoxKodP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxKodP.Location = new System.Drawing.Point(134, 273);
            this.textBoxKodP.Name = "textBoxKodP";
            this.textBoxKodP.Size = new System.Drawing.Size(212, 27);
            this.textBoxKodP.TabIndex = 30;
            // 
            // labelKodPocz
            // 
            this.labelKodPocz.AutoSize = true;
            this.labelKodPocz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelKodPocz.Location = new System.Drawing.Point(6, 276);
            this.labelKodPocz.Name = "labelKodPocz";
            this.labelKodPocz.Size = new System.Drawing.Size(115, 20);
            this.labelKodPocz.TabIndex = 31;
            this.labelKodPocz.Text = "Kod Pocztowy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxMarka);
            this.groupBox2.Controls.Add(this.labelMarka);
            this.groupBox2.Controls.Add(this.textBoxModel);
            this.groupBox2.Controls.Add(this.labelModel);
            this.groupBox2.Controls.Add(this.labelSilnik);
            this.groupBox2.Controls.Add(this.textBoxRocznik);
            this.groupBox2.Controls.Add(this.textBoxSilnik);
            this.groupBox2.Controls.Add(this.labelRocznik);
            this.groupBox2.Controls.Add(this.labelKolor);
            this.groupBox2.Controls.Add(this.textBoxKolor);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(17, 330);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 206);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dane Auta";
            // 
            // dateTimePickerOd
            // 
            this.dateTimePickerOd.CustomFormat = "yyyy.MM.dd";
            this.dateTimePickerOd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerOd.Location = new System.Drawing.Point(63, 21);
            this.dateTimePickerOd.Name = "dateTimePickerOd";
            this.dateTimePickerOd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerOd.Size = new System.Drawing.Size(111, 22);
            this.dateTimePickerOd.TabIndex = 47;
            this.dateTimePickerOd.Value = new System.DateTime(2022, 5, 20, 12, 25, 33, 0);
            // 
            // dateTimePickerDo
            // 
            this.dateTimePickerDo.CustomFormat = "yyyy.MM.dd";
            this.dateTimePickerDo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerDo.Location = new System.Drawing.Point(214, 21);
            this.dateTimePickerDo.Name = "dateTimePickerDo";
            this.dateTimePickerDo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePickerDo.Size = new System.Drawing.Size(111, 22);
            this.dateTimePickerDo.TabIndex = 48;
            this.dateTimePickerDo.Value = new System.DateTime(2022, 5, 21, 0, 0, 0, 0);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelDoDaty);
            this.groupBox3.Controls.Add(this.labelOdDaty);
            this.groupBox3.Controls.Add(this.buttonWyswietl);
            this.groupBox3.Controls.Add(this.dateTimePickerDo);
            this.groupBox3.Controls.Add(this.dateTimePickerOd);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox3.Location = new System.Drawing.Point(17, 653);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 91);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wyszukaj wzgledem daty";
            // 
            // labelDoDaty
            // 
            this.labelDoDaty.AutoSize = true;
            this.labelDoDaty.Location = new System.Drawing.Point(180, 26);
            this.labelDoDaty.Name = "labelDoDaty";
            this.labelDoDaty.Size = new System.Drawing.Size(28, 17);
            this.labelDoDaty.TabIndex = 50;
            this.labelDoDaty.Text = "Do";
            // 
            // labelOdDaty
            // 
            this.labelOdDaty.AutoSize = true;
            this.labelOdDaty.Location = new System.Drawing.Point(28, 26);
            this.labelOdDaty.Name = "labelOdDaty";
            this.labelOdDaty.Size = new System.Drawing.Size(29, 17);
            this.labelOdDaty.TabIndex = 49;
            this.labelOdDaty.Text = "Od";
            // 
            // buttonDodajCzesci
            // 
            this.buttonDodajCzesci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDodajCzesci.Location = new System.Drawing.Point(27, 618);
            this.buttonDodajCzesci.Name = "buttonDodajCzesci";
            this.buttonDodajCzesci.Size = new System.Drawing.Size(336, 29);
            this.buttonDodajCzesci.TabIndex = 50;
            this.buttonDodajCzesci.Text = "Dodaj Części";
            this.buttonDodajCzesci.UseVisualStyleBackColor = true;
            this.buttonDodajCzesci.Click += new System.EventHandler(this.buttonDodajCzesci_Click);
            // 
            // FormZlecenia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 784);
            this.ControlBox = false;
            this.Controls.Add(this.buttonDodajCzesci);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonModyf);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormZlecenia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormZlecenia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonModyf;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazw;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.TextBox textBoxUlica;
        private System.Windows.Forms.TextBox textBoxNrUlicy;
        private System.Windows.Forms.TextBox textBoxMiasto;
        private System.Windows.Forms.Button buttonWyswietl;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.Label labelNazw;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelUlica;
        private System.Windows.Forms.Label labelNrUlicy;
        private System.Windows.Forms.Label labelMiasto;
        private System.Windows.Forms.Label labelWojew;
        private System.Windows.Forms.TextBox textBoxWojew;
        private System.Windows.Forms.Label labelMarka;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label labelRocznik;
        private System.Windows.Forms.TextBox textBoxRocznik;
        private System.Windows.Forms.Label labelKolor;
        private System.Windows.Forms.TextBox textBoxKolor;
        private System.Windows.Forms.Label labelSilnik;
        private System.Windows.Forms.TextBox textBoxSilnik;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxKodP;
        private System.Windows.Forms.Label labelKodPocz;
        private System.Windows.Forms.DateTimePicker dateTimePickerOd;
        private System.Windows.Forms.DateTimePicker dateTimePickerDo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelDoDaty;
        private System.Windows.Forms.Label labelOdDaty;
        private System.Windows.Forms.Button buttonDodajCzesci;
    }
}