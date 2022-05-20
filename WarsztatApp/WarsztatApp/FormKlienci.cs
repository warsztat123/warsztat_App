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
using System.Data.SqlClient;

namespace WarsztatApp
{
    public partial class FormKlienci : Form
    {


        static string ConnectionString = "Data Source=WINDOWS-D2AGQGT\\SQLEXPRESS;"
                                                 + "Initial Catalog=Warsztat;"
                                                 + "Integrated Security=True";
        SqlConnection sqlConnection = new SqlConnection(ConnectionString);
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDAdapter = new SqlDataAdapter();
        private int index;



        public FormKlienci()
        {
            InitializeComponent();
            wyswietlDane();
            button1.Enabled = false;


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

                sqlCommand.Parameters["@imie"].Value = txtImie.Text;
                sqlCommand.Parameters["@nazw"].Value = txtNazwisko.Text;
                sqlCommand.Parameters["@tel"].Value = txtTelefon.Text;
                sqlCommand.Parameters["@ulica"].Value = txtUlica.Text;
                sqlCommand.Parameters["@NrUlicy"].Value = txtNumer.Text;
                sqlCommand.Parameters["@miasto"].Value = txtMiasto.Text;
                sqlCommand.Parameters["@wojew"].Value = txtWojewodztwo.Text;
                sqlCommand.Parameters["@kodPocz"].Value = txtKodPocztowy.Text;

                sqlCommand.ExecuteNonQuery();
                wyswietlDaneKlientow();
                MessageBox.Show("klient dodany pomyślnie");
            }
            catch (SqlException)
            {
                MessageBox.Show("Błędne dane", "Bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                sqlConnection.Close();
                button1.Enabled = false;
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




        private void wyswietlDaneKlientow()
        {


            string Query = "SELECT * from widok_klient;";
            sqlDAdapter = new SqlDataAdapter(Query, sqlConnection);
            DataTable dtb1 = new DataTable();
            sqlDAdapter.Fill(dtb1);
            dataGridView1.DataSource = dtb1;


        }


        private void button1_Click(object sender, EventArgs e)//usuwanie
        {


            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // index = e.RowIndex;
            //DataGridViewRow row = dataGridView1.Rows[index];
            button1.Enabled = true;
            txtImie.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNazwisko.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtUlica.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtNumer.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtMiasto.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtWojewodztwo.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtKodPocztowy.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)//edycja
        {
            try
            {
                sqlConnection.Open();
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                string Query = "EXEC USP_EdytujDaneKlienta @id,@imie,@nazw,@tel,@ulica,@nrUlicy,@miasto,@wojew,@kodPocz";

                sqlCommand = new SqlCommand
                    (Query, sqlConnection);

                sqlCommand.Parameters.Add("@id", SqlDbType.Int);
                sqlCommand.Parameters.Add("@imie", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@nazw", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@tel", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@ulica", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@nrUlicy", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@miasto", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@wojew", SqlDbType.NVarChar);
                sqlCommand.Parameters.Add("@kodPocz", SqlDbType.NVarChar);

                sqlCommand.Parameters["@id"].Value = id.ToString();
                sqlCommand.Parameters["@imie"].Value = txtImie.Text;
                sqlCommand.Parameters["@nazw"].Value = txtNazwisko.Text;
                sqlCommand.Parameters["@tel"].Value = txtTelefon.Text;
                sqlCommand.Parameters["@ulica"].Value = txtUlica.Text;
                sqlCommand.Parameters["@NrUlicy"].Value = txtNumer.Text;
                sqlCommand.Parameters["@miasto"].Value = txtMiasto.Text;
                sqlCommand.Parameters["@wojew"].Value = txtWojewodztwo.Text;
                sqlCommand.Parameters["@kodPocz"].Value = txtKodPocztowy.Text;

                sqlCommand.ExecuteNonQuery();
                wyswietlDaneKlientow();
                MessageBox.Show("klient edytowany pomyślnie");
            }
            catch (SqlException)
            {
                MessageBox.Show("Błędne dane", "Bląd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                sqlConnection.Close();
                button1.Enabled = false;
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
    }
}



