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
    public partial class FormMagazyn : Form
    {
        static string ConnectionString = "Data Source=WINDOWS-D2AGQGT\\SQLEXPRESS;"
                                                 + "Initial Catalog=Warsztat;"
                                                 + "Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(ConnectionString);
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDAdapter = new SqlDataAdapter();
        SqlDataReader sqlDReader;
        List<string> str1 = new List<string>();
        private string s = "";
        private int index;
        public FormMagazyn()
        {
            InitializeComponent();
            pobierzListeKategorii();
            wyswietlDane();
            przyciskUsun.Enabled = false;
            przyciskModyfikuj.Enabled = false;
           
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            if (czyUzupelnionePola() == true)
            {
                try
                {
                    sqlConnection.Open();

                    string Query = "declare @katID INT = (select KategoriaCzesci_ID from KategoriaCzesci WHERE Nazwa = '"+comboBox1.SelectedItem.ToString()+"');" +
                        " insert into CzescSamochodowa(Nazwa,Cena,Ilosc,Kategoria_ID) values(@nazwa,@cena,@ilosc,@katID);";
                    sqlCommand = new SqlCommand
                        (Query, sqlConnection);

                    sqlCommand.Parameters.Add("@nazwa", SqlDbType.NVarChar);
                    sqlCommand.Parameters.Add("@cena", SqlDbType.Decimal);
                    sqlCommand.Parameters.Add("@ilosc", SqlDbType.Int);
                    //sqlCommand.Parameters.Add("@kategoria_id", SqlDbType.Int);

                    sqlCommand.Parameters["@nazwa"].Value = txtNazwa.Text;
                    sqlCommand.Parameters["@cena"].Value = txtCena.Text;
                    sqlCommand.Parameters["@ilosc"].Value = txtIlosc.Text;
                    //sqlCommand.Parameters["@kategoria_id"].Value = s;

                    sqlCommand.ExecuteNonQuery();
                    Wyszukaj();
                    MessageBox.Show("produkt dodany pomyślnie");
                }
                catch
                {
                    MessageBox.Show("Błędne dane", "Bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection.Close();
                    Wyczysc();
                    wyswietlDane();
                    przyciskUsun.Enabled = false;
                    przyciskModyfikuj.Enabled = false;
                }
            }else MessageBox.Show("Nie podano wszystkich danych", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void pobierzListeKategorii()
        {

            sqlConnection.Open();
            string Query = "SELECT * from KategoriaCzesci;";
            sqlCommand = new SqlCommand
                    (Query, sqlConnection);
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
            sqlConnection.Close();
            str1.Clear();

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {


            /*try
            {

                sqlConnection.Open();

                string Query = "SELECT ParentKategoriaCzesci_ID from KategoriaCzesci where Nazwa=@kategoria;";
                sqlCommand = new SqlCommand
                    (Query, sqlConnection);

                sqlCommand.Parameters.Add("@kategoria", SqlDbType.NVarChar);
                sqlCommand.Parameters["@kategoria"].Value = comboBox1.GetItemText(comboBox1.SelectedItem);
                sqlDReader = sqlCommand.ExecuteReader();

                while (sqlDReader.Read())
                {
                    s = sqlDReader.GetValue(0).ToString();
                }


            }
            catch
            {
                MessageBox.Show("Błąd", "Bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                
                sqlDReader.Close();
                sqlConnection.Close();
            }*/
            Wyszukaj2();

        }

        private void wyswietlDane()
        {
            try
            {
                sqlConnection.Open();
                wyswietlDaneKlientow();
            }
            catch
            {
                MessageBox.Show("Błąd", "Bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void wyswietlDaneKlientow()
        {


            string Query = "SELECT * from CzescSamochodowa;";
            sqlDAdapter = new SqlDataAdapter(Query, sqlConnection);
            DataTable dtb1 = new DataTable();
            sqlDAdapter.Fill(dtb1);
            dataGridView1.DataSource = dtb1;
        }

        private void Usun_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            try
            {
                sqlConnection.Open();
                string Query = "delete from CzescSamochodowa where CzescSamochodowa_ID=@ID;";
                sqlCommand = new SqlCommand(Query, sqlConnection);
                sqlCommand.Parameters.Add("@ID", SqlDbType.Int);
                sqlCommand.Parameters["@ID"].Value = id.ToString();
                sqlCommand.ExecuteNonQuery();
                index = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(index);
            }
            catch
            {
                MessageBox.Show("Błąd", "Bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
                Wyczysc();

            }

        }

        private void modyfikuj_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                string Query = "update CzescSamochodowa set Nazwa=@nazwa,Cena=@cena,Ilosc=@ilosc where CzescSamochodowa_ID=@id;";

                sqlCommand = new SqlCommand
                    (Query, sqlConnection);

                sqlCommand.Parameters.Add("@nazwa", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@cena", SqlDbType.Decimal);
                sqlCommand.Parameters.Add("@ilosc", SqlDbType.Int);
                sqlCommand.Parameters.Add("@id", SqlDbType.Int);

                sqlCommand.Parameters["@nazwa"].Value = txtNazwa.Text;
                sqlCommand.Parameters["@cena"].Value = txtCena.Text;
                sqlCommand.Parameters["@ilosc"].Value = txtIlosc.Text;
                sqlCommand.Parameters["@id"].Value = id.ToString();


                sqlCommand.ExecuteNonQuery();
                Wyszukaj();
                MessageBox.Show("produkt edytowany pomyślnie");
            }
            catch (SqlException)
            {
                MessageBox.Show("Błędne dane", "Bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                sqlConnection.Close();
                przyciskUsun.Enabled = false;
                przyciskModyfikuj.Enabled = false;
                Wyczysc();

            }
        }

        private void Wyczysc()
        {
            txtNazwa.Text = "";
            txtCena.Text = "";
            txtIlosc.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            przyciskUsun.Enabled = true;
            przyciskModyfikuj.Enabled = true;
            txtNazwa.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCena.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtIlosc.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();


        }

        private void Wyszukaj()
        {

            string Query = "SELECT * from CzescSamochodowa where Kategoria_ID=@Id;";

            sqlDAdapter = new SqlDataAdapter(Query, sqlConnection);
            sqlDAdapter.SelectCommand.Parameters.AddWithValue("@Id", s);

            DataTable dtb1 = new DataTable();
            sqlDAdapter.Fill(dtb1);
            dataGridView1.DataSource = dtb1;

        }

        private void Wyszukaj2()
        {
            try
            {
                sqlConnection.Open();
                string Query = "declare @katID INT = (select KategoriaCzesci_ID from KategoriaCzesci WHERE Nazwa = '" + comboBox1.SelectedItem.ToString() + "');" +
                    "SELECT * from CzescSamochodowa where Kategoria_ID=@katID;";

                sqlDAdapter = new SqlDataAdapter(Query, sqlConnection);
                //sqlDAdapter.SelectCommand.Parameters.AddWithValue("@Id", s);

                DataTable dtb1 = new DataTable();
                sqlDAdapter.Fill(dtb1);
                dataGridView1.DataSource = dtb1;
            }
            catch
            {
                MessageBox.Show("Błąd", "Bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();

            }
        }

        private bool czyUzupelnionePola()
        {
            if (txtNazwa.Text != "" &&
            txtCena.Text != "" &&
            txtIlosc.Text != "" &&
            comboBox1.Text != "") return true;
            else return false;

        }
    }
}
   

