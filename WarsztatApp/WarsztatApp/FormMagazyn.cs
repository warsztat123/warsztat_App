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
        static string ConnectionString = "Data Source=LAPTOP-442E11CB\\SQLEXPRESS;"
                                                 + "Initial Catalog=Warsztat;"
                                                 + "Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(ConnectionString);
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDAdapter = new SqlDataAdapter();
        SqlDataReader sqlDReader;
        List<string> str1 = new List<string>();
        private string s = "";
        public FormMagazyn()
        {
            InitializeComponent();
            pobierzListeKategorii();
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            
            try
            {
                sqlConnection.Open();

                string Query = "insert into CzescSamochodowa(Nazwa,Cena,Ilosc,Kategoria_ID) values(@nazwa,@cena,@ilosc,@kategoria_id);";
                sqlCommand = new SqlCommand
                    (Query, sqlConnection);

                sqlCommand.Parameters.Add("@nazwa", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@cena", SqlDbType.Decimal);
                sqlCommand.Parameters.Add("@ilosc", SqlDbType.Int);
                sqlCommand.Parameters.Add("@kategoria_id", SqlDbType.Int);

                sqlCommand.Parameters["@nazwa"].Value = txtNazwa.Text;
                sqlCommand.Parameters["@cena"].Value = txtCena.Text;
                sqlCommand.Parameters["@ilosc"].Value = txtIlosc.Text;
                sqlCommand.Parameters["@kategoria_id"].Value = s;

                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("część dodana pomyślnie");
            }
            catch
            {
                MessageBox.Show("Błędne dane", "Bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
            
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
           
            
            try
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
            }
            
        }

        private void wyswietl_Click(object sender, EventArgs e)
        {
            
        }
    }

   
}
