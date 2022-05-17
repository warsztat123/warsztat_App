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

        public FormZlecenia()
        {
            InitializeComponent();
            pobierzListeStatusow();
            
        }

        private void pobierzListeStatusow()
        {
            sqlConnection.ConnectionString = "Data Source=LAPTOP-442E11CB\\SQLEXPRESS;"
                                                + "Initial Catalog=Warsztat;"
                                                + "Integrated Security = true;";
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
    }
}
