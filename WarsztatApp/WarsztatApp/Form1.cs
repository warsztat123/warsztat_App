using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarsztatApp
{
    public partial class Form1 : Form
    {
        //-----------------------------------------------------------
        //zmienne globalne i referencje do obiektów
        Form2 okno_logowania;
        FormZlecenia oknoZlecenia;
        FormMagazyn oknoMagazyn;
        FormKlienci oknoKlienci;
        FormCepik oknoCepik;

        bool f_menu = true;
        bool f_zlecenia = false;
        bool f_magazyn = false;
        bool f_klienci = false;
        bool f_cepik = false;
        //-----------------------------------------------------------

        //-----------------------------------------------------------
        //tworzenie referencji do obietków w celu połączenia apki z 
        //bazą SQL i umożliwienia na niej operacji
        //-----------------------------------------------------------
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DataTable sqlDTable = new DataTable();
        String sqlQuery;
        SqlDataAdapter sqlDAdapter = new SqlDataAdapter();
        DataSet sqlDSet = new DataSet();
        SqlDataReader sqlDReader;
        //-----------------------------------------------------------

        public Form1()
        {
            InitializeComponent();

            //-----------------------------------------------------------
            //funkcja logowania w konstruktorze uruchamia drugie okno z logowaniem po 
            //czym przy pomyślnym zalogowaniu uruchamia się główne okno programu
            logowanie();
            //W nagłówku formsa pojawia się nazwa witająca zalogowanego użytkownika
            Naglowek.Text = "Witaj:" + " " + okno_logowania.textBox1.Text;
            //-----------------------------------------------------------



        }

        //-----------------------------------------------------------
        //funkcja pobiera dane z okna logowania i prowadza je do obiektu 
        //łączącego z bazą jeśli DialogResult był OK, a jesli coś innego niż OK 
        //to zamyka apke.
        //-----------------------------------------------------------
        private void logowanie()
        {
            okno_logowania = new Form2();
            
            DialogResult odp = okno_logowania.ShowDialog();
            if (odp == DialogResult.OK)
            {
                sqlConnection.ConnectionString = "Data Source=WINDOWS-D2AGQGT\\SQLEXPRESS;"
                                                + "Initial Catalog=Warsztat;"
                                                + "User ID=" + okno_logowania.textBox1.Text + ";"
                                                + "Password=" + okno_logowania.textBox2.Text + ";";
                try
                {
                    sqlConnection.Open();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Błędne dane logowania", "Bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
            else
            {
                System.Environment.Exit(0);
            }
        }

        //-----------------------------------------------------------
        //Button ze Zleceniami
        private void button1_Click(object sender, EventArgs e)
        {
            Naglowek.Text = button1.Text;
            LogoGlowne.Visible = false;
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            if (f_magazyn == true) oknoMagazyn.Close();
            if (f_klienci == true) oknoKlienci.Close();
            if (f_cepik == true) oknoCepik.Close();

            oknoZlecenia = new FormZlecenia();
            oknoZlecenia.TopLevel = false;
            panel3.Controls.Add(oknoZlecenia);
            oknoZlecenia.BringToFront();
            oknoZlecenia.Show();
            f_menu = false;
            f_zlecenia = true;
            f_magazyn= false;
            f_klienci = false;
            f_cepik = false;
        }

        //-----------------------------------------------------------
        //Button z Magazynem z Częściami
        private void button2_Click(object sender, EventArgs e)
        {
            Naglowek.Text = button2.Text;
            LogoGlowne.Visible = false;
            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
            if(f_zlecenia==true) oknoZlecenia.Close();
            if (f_klienci == true) oknoKlienci.Close();
            if (f_cepik == true) oknoCepik.Close();

            oknoMagazyn = new FormMagazyn();
            oknoMagazyn.TopLevel = false;
            panel3.Controls.Add(oknoMagazyn);
            oknoMagazyn.BringToFront();
            oknoMagazyn.Show();
            f_menu = false;
            f_zlecenia = false;
            f_magazyn = true;
            f_klienci = false;
            f_cepik = false;


        }

        //-----------------------------------------------------------
        //Button z danymi Klientów
        private void button3_Click(object sender, EventArgs e)
        {
            Naglowek.Text = button3.Text;
            LogoGlowne.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
            if (f_zlecenia == true) oknoZlecenia.Close();
            if (f_magazyn == true) oknoMagazyn.Close();
            if (f_cepik == true) oknoCepik.Close();

            oknoKlienci = new FormKlienci();
            oknoKlienci.TopLevel = false;
            panel3.Controls.Add(oknoKlienci);
            oknoKlienci.BringToFront();
            oknoKlienci.Show();
            f_menu = false;
            f_zlecenia = false;
            f_magazyn = false;
            f_klienci = true;
            f_cepik = false;
        }

        //-----------------------------------------------------------
        //Button z uruchomieniem strony CEPiK
        private void button4_Click(object sender, EventArgs e)
        {
            Naglowek.Text = button4.Text;
            LogoGlowne.Visible = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            if (f_zlecenia == true) oknoZlecenia.Close();
            if (f_klienci == true) oknoKlienci.Close();
            if (f_magazyn == true) oknoMagazyn.Close();

            oknoCepik = new FormCepik();
            oknoCepik.TopLevel = false;
            panel3.Controls.Add(oknoCepik);
            oknoCepik.BringToFront();
            oknoCepik.Show();
            f_menu = false;
            f_zlecenia = false;
            f_magazyn = false;
            f_klienci = false;
            f_cepik = true;
        }

        //-----------------------------------------------------------
        //Powrót do Menu Głownego
        private void LogoMale_Click(object sender, EventArgs e)
        {
            Naglowek.Text = "Witaj:" + " " + okno_logowania.textBox1.Text;
            LogoGlowne.Visible = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            if (f_zlecenia == true) oknoZlecenia.Close();
            if (f_cepik == true) oknoCepik.Close();
            if (f_klienci == true) oknoKlienci.Close();
            if (f_magazyn == true) oknoMagazyn.Close();
            f_zlecenia = false;
            f_magazyn = false;
            f_klienci = false;
            f_cepik = false;
            f_menu = true;
        }
    }
}
