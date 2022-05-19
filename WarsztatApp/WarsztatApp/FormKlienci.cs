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
    public partial class FormKlienci : Form
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand;
       

        public FormKlienci()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sqlConnection.ConnectionString = "Data Source=LAPTOP-442E11CB\\SQLEXPRESS;"
                                                + "Initial Catalog=Warsztat;"
                                                + "Integrated Security=True";

            try
            {
                sqlConnection.Open();
              
                string Query = "EXEC USP_WstawDaneKlienta @imie,@nazw,@tel,@ulica,@nrUlicy,@miasto,@wojew,@kodPocz";
                
               
	
                sqlCommand = new SqlCommand
                    (Query, sqlConnection);

                sqlCommand.Parameters.Add("@imie", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@nazw", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@tel", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@ulica", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@nrUlicy", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@miasto", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@wojew", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@kodPocz", SqlDbType.NVarChar);

                sqlCommand.Parameters["@imie"].Value=txtImie.Text;
                sqlCommand.Parameters["@nazw"].Value=txtNazwisko.Text;
                sqlCommand.Parameters["@tel"].Value=txtTelefon.Text;
                sqlCommand.Parameters["@ulica"].Value=txtUlica.Text;
                sqlCommand.Parameters["@NrUlicy"].Value=txtNumer.Text;
                sqlCommand.Parameters["@miasto"].Value=txtMiasto.Text;
                sqlCommand.Parameters["@wojew"].Value=txtWojewodztwo.Text;
                sqlCommand.Parameters["@kodPocz"].Value=txtKodPocztowy.Text;

                /*sqlCommand.Parameters.AddWithValue("@nazw", txtNazwisko.Text);
                sqlCommand.Parameters.AddWithValue("@tel", txtTelefon.Text);
                sqlCommand.Parameters.AddWithValue("@ulica", txtUlica.Text);
                sqlCommand.Parameters.AddWithValue("@nrUlicy", txtNumer.Text);
                sqlCommand.Parameters.AddWithValue("@misto", txtMiasto.Text);
                sqlCommand.Parameters.AddWithValue("@wojew", txtWojewodztwo.Text);
                sqlCommand.Parameters.AddWithValue("@kodPocz", txtKodPocztowy.Text);*/
                

               
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("użytkownik dodany pomyślnie");
            }
            catch (SqlException)
            {
                MessageBox.Show("Błędne dane", "Bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Application.Restart();
                //Environment.Exit(0);
            }

            finally
            {
                sqlConnection.Close();
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

