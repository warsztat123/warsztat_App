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
    public partial class FormZlecenia : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DataTable sqlDTable = new DataTable();
        String sqlQuery;
        SqlDataAdapter sqlDAdapter = new SqlDataAdapter();
        DataSet sqlDSet = new DataSet();
        SqlDataReader sqlDReader;
        //-----------------------------------------------

        List<string> str1 = new List<string>();
        int id_row;
        DataGridViewRow row;

        public FormZlecenia()
        {
            InitializeComponent();
            sqlConnection.ConnectionString = "Data Source=WINDOWS-D2AGQGT\\SQLEXPRESS;"
                                                + "Initial Catalog=Warsztat;"
                                                + "Integrated Security = true;";
            buttonModyf.Enabled = false;
            buttonUsun.Enabled = false;
            buttonDodajCzesci.Enabled = false;
            pobierzListeStatusow();
            pobierzListeZlecen();
        }

        //zdarzenie wyswietljące liste zleceń według ustalonej ramy dat
        private void button4_Click(object sender, EventArgs e)
        {
            pobierzListeZlecenWedlugDaty();
        }

        //zdarzenie dodające dane po kliknięciu na przycisk
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (czyUzupelnionePola() == true)
            {
                try
                {
                    sqlCommand.Connection = sqlConnection;
                    DataTable sqlDTableTemp = new DataTable();
                    SqlCommand sqlCommandDaneZlecen = new SqlCommand();
                    sqlConnection.Open();
                    sqlCommandDaneZlecen.Connection = sqlConnection;

                    sqlCommandDaneZlecen.CommandText = "EXEC USP_WstawZlecenie @imie, @nazw, @tel, @ulica, @nrUlicy, @miasto, "
                                                       + "@wojew, @kodPocz, @marka, @model, @rocznik, @kolor, @silnik, @status";
                    sqlCommandDaneZlecen.Parameters.Add("@imie", SqlDbType.NVarChar);
                    sqlCommandDaneZlecen.Parameters.Add("@nazw", SqlDbType.NVarChar);
                    sqlCommandDaneZlecen.Parameters.Add("@tel", SqlDbType.NVarChar);
                    sqlCommandDaneZlecen.Parameters.Add("@ulica", SqlDbType.NVarChar);
                    sqlCommandDaneZlecen.Parameters.Add("@nrUlicy", SqlDbType.NVarChar);
                    sqlCommandDaneZlecen.Parameters.Add("@miasto", SqlDbType.NVarChar);
                    sqlCommandDaneZlecen.Parameters.Add("@wojew", SqlDbType.NVarChar);
                    sqlCommandDaneZlecen.Parameters.Add("@kodPocz", SqlDbType.NVarChar);
                    sqlCommandDaneZlecen.Parameters.Add("@marka", SqlDbType.NVarChar);
                    sqlCommandDaneZlecen.Parameters.Add("@model", SqlDbType.NVarChar);
                    sqlCommandDaneZlecen.Parameters.Add("@rocznik", SqlDbType.Int);
                    sqlCommandDaneZlecen.Parameters.Add("@kolor", SqlDbType.NVarChar);
                    sqlCommandDaneZlecen.Parameters.Add("@silnik", SqlDbType.NVarChar);
                    sqlCommandDaneZlecen.Parameters.Add("@status", SqlDbType.NVarChar);

                    sqlCommandDaneZlecen.Parameters["@imie"].Value = textBoxImie.Text;
                    sqlCommandDaneZlecen.Parameters["@nazw"].Value = textBoxNazw.Text;
                    sqlCommandDaneZlecen.Parameters["@tel"].Value = textBoxTel.Text;
                    sqlCommandDaneZlecen.Parameters["@ulica"].Value = textBoxUlica.Text;
                    sqlCommandDaneZlecen.Parameters["@nrUlicy"].Value = textBoxNrUlicy.Text;
                    sqlCommandDaneZlecen.Parameters["@miasto"].Value = textBoxMiasto.Text;
                    sqlCommandDaneZlecen.Parameters["@wojew"].Value = textBoxWojew.Text;
                    sqlCommandDaneZlecen.Parameters["@kodPocz"].Value = textBoxKodP.Text;
                    sqlCommandDaneZlecen.Parameters["@marka"].Value = textBoxMarka.Text;
                    sqlCommandDaneZlecen.Parameters["@model"].Value = textBoxModel.Text;
                    sqlCommandDaneZlecen.Parameters["@rocznik"].Value = textBoxRocznik.Text;
                    sqlCommandDaneZlecen.Parameters["@kolor"].Value = textBoxKolor.Text;
                    sqlCommandDaneZlecen.Parameters["@silnik"].Value = textBoxSilnik.Text;
                    sqlCommandDaneZlecen.Parameters["@status"].Value = (string)comboBoxStatus.SelectedItem;

                    sqlDReader = sqlCommandDaneZlecen.ExecuteReader();
                    sqlDTableTemp.Load(sqlDReader);
                    sqlDReader.Close();
                    sqlConnection.Close();
                    MessageBox.Show("Zlecenie dodane pomyślnie");

                    pobierzListeZlecen();
                    WyczyscPola();
                    pobierzListeStatusow();
                }
                catch (Exception)
                {
                    sqlDReader.Close();
                    sqlConnection.Close();
                    str1.Clear();
                    MessageBox.Show("Wstawiono błedne dane", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Nie podano wszystkich danych", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        //zdarzenie usuwające dane po kliknięciu na przycisk
        private void buttonUsun_Click(object sender, EventArgs e)
        {
            UsunZlecenie(id_row);
        }

        //zdarzenie modyfikujące dane po kliknięciu na przycisk
        private void buttonModyf_Click(object sender, EventArgs e)
        {
            ModyfikujZlecenie(id_row);
        }

        //funkcja pobiera liste statusów z bazy
        private void pobierzListeStatusow()
        {
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "SELECT * FROM v_PobierzStatusy;";
            sqlDReader = sqlCommand.ExecuteReader();
            while (sqlDReader.Read())
            {
                str1.Add(sqlDReader.GetValue(0).ToString());
            }
            foreach (string p in str1)
            {
                comboBoxStatus.Items.Add(p);
            }
            sqlDReader.Close();
            sqlConnection.Close();
            str1.Clear();
        }

        //funckja pobierająca liste zleceń z bazy od najnoweszgo do najstarszego
        private void pobierzListeZlecen()
        {
            sqlCommand.Connection = sqlConnection;
            DataTable sqlDTableTemp = new DataTable();
            SqlCommand sqlCommandDaneZlecen = new SqlCommand();
            sqlConnection.Open();
            sqlCommandDaneZlecen.Connection = sqlConnection;

            sqlCommandDaneZlecen.CommandText = "SELECT * FROM v_PobierzListeZlecen ORDER BY DataZlecenia DESC;";

            sqlDReader = sqlCommandDaneZlecen.ExecuteReader();
            sqlDTableTemp.Load(sqlDReader);
            sqlDReader.Close();
            sqlConnection.Close();
            dataGridView1.DataSource = sqlDTableTemp;

        }

        //funckja pobierająca liste zleceń z bazy według wybranego przedziału dat od najnoweszgo do najstarszego
        private void pobierzListeZlecenWedlugDaty()
        {
            sqlCommand.Connection = sqlConnection;
            DataTable sqlDTableTemp = new DataTable();
            SqlCommand sqlCommandDaneZlecen = new SqlCommand();
            sqlConnection.Open();
            sqlCommandDaneZlecen.Connection = sqlConnection;

            sqlCommandDaneZlecen.CommandText = "SELECT * FROM v_PobierzListeZlecen WHERE DataZlecenia BETWEEN @OD AND @DO ORDER BY DataZlecenia DESC;";

            sqlCommandDaneZlecen.Parameters.Add("@OD", SqlDbType.VarChar);
            sqlCommandDaneZlecen.Parameters.Add("@DO", SqlDbType.VarChar);

            sqlCommandDaneZlecen.Parameters["@OD"].Value = dateTimePickerOd.Text;
            sqlCommandDaneZlecen.Parameters["@DO"].Value = dateTimePickerDo.Text;

            sqlDReader = sqlCommandDaneZlecen.ExecuteReader();
            sqlDTableTemp.Load(sqlDReader);
            sqlDReader.Close();
            sqlConnection.Close();
            dataGridView1.DataSource = sqlDTableTemp;

        }

        //funckja czyszcząca wszytkie pola tekstowe
        private void WyczyscPola()
        {
            textBoxImie.Text="";
            textBoxNazw.Text = "";
            textBoxTel.Text = "";
            textBoxUlica.Text = "";
            textBoxNrUlicy.Text = "";
            textBoxMiasto.Text = "";
            textBoxWojew.Text = "";
            textBoxKodP.Text = "";
            textBoxMarka.Text = "";
            textBoxModel.Text = "";
            textBoxRocznik.Text = "";
            textBoxKolor.Text = "";
            textBoxSilnik.Text = "";
            comboBoxStatus.Text = "";
            comboBoxStatus.Items.Clear();
        }

        //funkcja sprawdza czy pola tekstowe nie są puste
        private bool czyUzupelnionePola()
        {
            if (textBoxImie.Text != "" &&
            textBoxNazw.Text != "" &&
            textBoxTel.Text != "" &&
            textBoxUlica.Text != "" &&
            textBoxNrUlicy.Text != "" &&
            textBoxMiasto.Text != "" &&
            textBoxWojew.Text != "" &&
            textBoxKodP.Text != "" &&
            textBoxMarka.Text != "" &&
            textBoxModel.Text != "" &&
            textBoxRocznik.Text != "" &&
            textBoxKolor.Text != "" &&
            textBoxSilnik.Text != "" &&
            comboBoxStatus.Text != "") return true;
            else return false;

        }

        //funkcja modyfikująca wybrany wiersz według wybranego ID
        private void UsunZlecenie(int id)
        {

            sqlCommand.Connection = sqlConnection;
            DataTable sqlDTableTemp = new DataTable();
            SqlCommand sqlCommandUsunZlecenie = new SqlCommand();
            sqlConnection.Open();
            sqlCommandUsunZlecenie.Connection = sqlConnection;

            sqlCommandUsunZlecenie.CommandText = "EXEC USP_UsunZlecenie @idZlecenia;";

            sqlCommandUsunZlecenie.Parameters.Add("@idZlecenia", SqlDbType.Int);

            sqlCommandUsunZlecenie.Parameters["@idZlecenia"].Value = id;

            sqlDReader = sqlCommandUsunZlecenie.ExecuteReader();
            sqlDTableTemp.Load(sqlDReader);
            sqlDReader.Close();
            sqlConnection.Close();
            MessageBox.Show("Zlecenie usunięto pomyślnie");
            pobierzListeZlecen();

        }

        //funkcja modyfikująca wybrany wiersz według wybranego ID
        private void ModyfikujZlecenie(int id)
        {

            sqlCommand.Connection = sqlConnection;
            DataTable sqlDTableTemp = new DataTable();
            SqlCommand sqlCommandDaneZlecen = new SqlCommand();
            sqlConnection.Open();
            sqlCommandDaneZlecen.Connection = sqlConnection;

            sqlCommandDaneZlecen.CommandText = "EXEC USP_ModyfikujZlecenie @idZlecenia, @marka, @model, @rocznik, @kolor, @silnik, @status";

            sqlCommandDaneZlecen.Parameters.Add("@idZlecenia", SqlDbType.Int);
            sqlCommandDaneZlecen.Parameters.Add("@marka", SqlDbType.NVarChar);
            sqlCommandDaneZlecen.Parameters.Add("@model", SqlDbType.NVarChar);
            sqlCommandDaneZlecen.Parameters.Add("@rocznik", SqlDbType.Int);
            sqlCommandDaneZlecen.Parameters.Add("@kolor", SqlDbType.NVarChar);
            sqlCommandDaneZlecen.Parameters.Add("@silnik", SqlDbType.NVarChar);
            sqlCommandDaneZlecen.Parameters.Add("@status", SqlDbType.NVarChar);

            sqlCommandDaneZlecen.Parameters["@idZlecenia"].Value = id;
            sqlCommandDaneZlecen.Parameters["@marka"].Value = textBoxMarka.Text;
            sqlCommandDaneZlecen.Parameters["@model"].Value = textBoxModel.Text;
            sqlCommandDaneZlecen.Parameters["@rocznik"].Value = textBoxRocznik.Text;
            sqlCommandDaneZlecen.Parameters["@kolor"].Value = textBoxKolor.Text;
            sqlCommandDaneZlecen.Parameters["@silnik"].Value = textBoxSilnik.Text;
            sqlCommandDaneZlecen.Parameters["@status"].Value = (string)comboBoxStatus.SelectedItem;

            sqlDReader = sqlCommandDaneZlecen.ExecuteReader();
            sqlDTableTemp.Load(sqlDReader);
            sqlDReader.Close();
            sqlConnection.Close();
            MessageBox.Show("Zlecenie zmodyfikowano pomyślnie");

            pobierzListeZlecen();
            WyczyscPola();
            pobierzListeStatusow();

        }

        //pobiera i zapisuje w globalnych zmiennych ID klikniętego wiersza
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            { 
                if (e.RowIndex >= 0)
                {
                    buttonUsun.Enabled = true;
                    buttonModyf.Enabled = true;
                    buttonDodajCzesci.Enabled = true;
                    row = this.dataGridView1.Rows[e.RowIndex];
                    id_row = (int)row.Cells["Zlecenie_ID"].Value;
                }
                else
                {
                    buttonUsun.Enabled = false;
                    buttonModyf.Enabled = false;
                    buttonDodajCzesci.Enabled = false;
                }
                textBoxMarka.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBoxModel.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBoxRocznik.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBoxKolor.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBoxSilnik.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                comboBoxStatus.SelectedItem = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            }
            catch(Exception)
            {
                buttonUsun.Enabled = false;
                buttonModyf.Enabled = false;
                buttonDodajCzesci.Enabled = false;
                MessageBox.Show("Błednie zaznaczony wiersz", "Bląd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //zdarzenie otwierające okno gdzie dodaje się z według wybranej kategorii części samochodowe do wybranego zlecenia
        private void buttonDodajCzesci_Click(object sender, EventArgs e)
        {

        }
    }
}
