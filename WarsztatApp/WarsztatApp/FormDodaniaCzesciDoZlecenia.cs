using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WarsztatApp
{
    public partial class FormDodaniaCzesciDoZlecenia : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();
        DataTable sqlDTable = new DataTable();
        String sqlQuery;
        SqlDataAdapter sqlDAdapter = new SqlDataAdapter();
        DataSet sqlDSet = new DataSet();
        SqlDataReader sqlDReader;

        List<string> str1 = new List<string>();
        public int id_row;
        DataGridViewRow row;

        int currentIdRowZlecenia;
        FormZlecenia oknoZlec;

        public FormDodaniaCzesciDoZlecenia(FormZlecenia KtoOknoZlecenia)
        {
            InitializeComponent();
            oknoZlec = KtoOknoZlecenia;
            pobierzIdZlecenia();

            numericUpDownIlosc.Enabled = false;
            buttonDodaj.Enabled = false;
            buttonUsun.Enabled = false;

            sqlConnection.ConnectionString = "Data Source=WINDOWS-D2AGQGT\\SQLEXPRESS;"
                                                + "Initial Catalog=Warsztat;"
                                                + "Integrated Security = true;";
            startTransakcji();
            pobierzListeKategorii();
            
        }


        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            wyszukajDostepneCzesciWedlugKategorii();
        }


        private void pobierzListeKategorii()
        {
            //sqlConnection.Open();
            string Query = "SELECT * from KategoriaCzesci;";
            sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlDReader = sqlCommand.ExecuteReader();
            while (sqlDReader.Read())
            {
                str1.Add(sqlDReader.GetValue(2).ToString());
            }
            foreach (string p in str1)
            {
                comboBox1.Items.Add(p);
            }
            sqlDReader.Close();
            //sqlConnection.Close();
            str1.Clear();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery2 = "EXEC USP_DodajCzesciDoZlecenia @IDCzesci, @IDZlecenia, @Ilosc;";
                SqlCommand sqlCommand2 = new SqlCommand(sqlQuery2, sqlConnection);
                DataTable sqlDTableTemp2 = new DataTable();
                sqlCommand2.Parameters.Add("@IDCzesci", SqlDbType.Int);
                sqlCommand2.Parameters.Add("@IDZlecenia", SqlDbType.Int);
                sqlCommand2.Parameters.Add("@Ilosc", SqlDbType.Int);
                sqlCommand2.Parameters["@IDCzesci"].Value = id_row;
                sqlCommand2.Parameters["@IDZlecenia"].Value = currentIdRowZlecenia;
                sqlCommand2.Parameters["@Ilosc"].Value = numericUpDownIlosc.Value;
                sqlDReader = sqlCommand2.ExecuteReader();
                sqlDTableTemp2.Load(sqlDReader);
                sqlDReader.Close();

                string sqlQuery3 = "SELECT Zlecenie_ID, CzescSamochodowa_ID, Ilosc, CenaZaSzt, CalkowityKoszt " +
                                    "FROM Zlecenie_CzescSamochodowa";
                SqlCommand sqlCommand3 = new SqlCommand(sqlQuery3, sqlConnection);
                DataTable sqlDTableTemp3 = new DataTable();
                sqlDReader = sqlCommand3.ExecuteReader();
                sqlDTableTemp3.Load(sqlDReader);
                sqlDReader.Close();
                dataGridView2.DataSource = sqlDTableTemp3;

                wyszukajDostepneCzesciWedlugKategorii();
            }
            catch(Exception)
            {
                MessageBox.Show("Nie ma już produktu na stanie", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {

        }

        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {
            string Query = "COMMIT TRAN;";
            sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlDReader = sqlCommand.ExecuteReader();
            sqlDReader.Close();
            sqlConnection.Close();
            Close();
        }

        private void buttonWycofaj_Click(object sender, EventArgs e)
        {
            string Query = "ROLLBACK TRAN;";
            sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlDReader = sqlCommand.ExecuteReader();
            sqlDReader.Close();
            sqlConnection.Close();
            Close();
        }

        private void startTransakcji()
        {
            sqlConnection.Open();
            string Query = "BEGIN TRAN;";
            sqlCommand = new SqlCommand(Query, sqlConnection);
            sqlDReader = sqlCommand.ExecuteReader();
            sqlDReader.Close();
        }

        private void pobierzIdZlecenia()
        {
            currentIdRowZlecenia = oknoZlec.id_row;
            //labelIlosc.Text = currentIdRowZlecenia.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    buttonDodaj.Enabled = true;
                    numericUpDownIlosc.Enabled = true;
                    row = this.dataGridView1.Rows[e.RowIndex];
                    id_row = (int)row.Cells["CzescSamochodowa_ID"].Value;
                }
                else
                {
                    buttonDodaj.Enabled = false;
                    numericUpDownIlosc.Enabled = false;
                }
                
                sqlCommand.CommandText = "SELECT Ilosc FROM CzescSamochodowa WHERE CzescSamochodowa_ID = @id";
                sqlCommand.Parameters.Add("@id", SqlDbType.Int);
                sqlCommand.Parameters["@id"].Value = id_row;
                sqlDReader = sqlCommand.ExecuteReader();
                sqlDReader.Read();
                numericUpDownIlosc.Maximum = sqlDReader.GetInt32(0);
                if (numericUpDownIlosc.Maximum == 0)
                {
                    buttonDodaj.Enabled = false;
                    sqlDReader.Close();
                }
                else
                {
                    numericUpDownIlosc.Value = 1;
                }
                sqlCommand.Parameters.Clear();
                sqlDReader.Close();
            }
            catch (Exception)
            {
                buttonDodaj.Enabled = false;
                numericUpDownIlosc.Enabled = false;
                MessageBox.Show("Błednie zaznaczony wiersz", "Bląd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void wyszukajDostepneCzesciWedlugKategorii()
        {
            sqlQuery = "SELECT CzescSamochodowa_ID, Nazwa, Cena, Ilosc " +
                       "FROM CzescSamochodowa " +
                       "WHERE Kategoria_ID IN " +
                                            "(SELECT KategoriaCzesci_ID " +
                                            "FROM KategoriaCzesci " +
                                            "WHERE Nazwa = @nazwaKat);";
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            DataTable sqlDTableTemp = new DataTable();
            //sqlConnection.Open();
            sqlCommand.Parameters.Add("@nazwaKat", SqlDbType.NVarChar);
            sqlCommand.Parameters["@nazwaKat"].Value = comboBox1.SelectedItem.ToString();
            sqlDReader = sqlCommand.ExecuteReader();
            sqlDTableTemp.Load(sqlDReader);
            sqlDReader.Close();
            //sqlConnection.Close();
            dataGridView1.DataSource = sqlDTableTemp;
            str1.Clear();
        }

    }
}
