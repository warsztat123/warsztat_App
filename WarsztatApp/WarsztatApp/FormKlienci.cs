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
       static string ConnectionString= "Data Source=LAPTOP-442E11CB\\SQLEXPRESS;"
                                                + "Initial Catalog=Warsztat;"
                                                + "Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(ConnectionString);
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDAdapter = new SqlDataAdapter();
        int index;


        public FormKlienci()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)//dodawanie
        {
           

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
                sqlCommand.Parameters["@kodPocz"].Value = txtKodPocztowy.Text;
               
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
                txtImie.Text = "";
                txtNazwisko.Text = "";
                txtTelefon.Text = "";
                txtUlica.Text = "";
                txtNumer.Text = "";
                txtMiasto.Text = "";
                txtWojewodztwo.Text = "";
                txtKodPocztowy.Text = "";
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)//wyświetlanie
        {
           
            try
            {
                sqlConnection.Open();
                string Query = "SELECT * from widok_klient;";
                sqlDAdapter = new SqlDataAdapter(Query, sqlConnection);
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

        private void button1_Click(object sender, EventArgs e)//usuwanie
        {
            
            
            int id = (int)dataGridView1.CurrentCell.Value;
            try
            {
                sqlConnection.Open();
                string Query = "delete from Klient where Klient_ID=@ID;";
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
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
        }
    }
}

