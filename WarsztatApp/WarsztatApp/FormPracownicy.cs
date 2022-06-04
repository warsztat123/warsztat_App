using System;
using System.Data;
using System.Windows.Forms;
using WarsztatApp.Data;

namespace WarsztatApp
{
    public partial class FormPracownicy : Form
    {
        private DataRow CurrentRow => (pracownikBindingSource.Current as DataRowView).Row;
        private string ImieColumnName => imieDataGridViewTextBoxColumn.DataPropertyName;
        private string NazwiskoColumnName => nazwiskoDataGridViewTextBoxColumn.DataPropertyName;
        private string LoginColumnName => loginDataGridViewTextBoxColumn.DataPropertyName;
        private string HasloColumnName => hasloDataGridViewTextBoxColumn.DataPropertyName;


        public FormPracownicy()
        {
            InitializeComponent();
        }

        private void FormPracownicy_Load(object sender, EventArgs e)
        {
            pracownikTableAdapter.Fill(warsztatDataSet.Pracownik);
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            FormDodajPracownika formDodajPracownika = new FormDodajPracownika();

            if (formDodajPracownika.ShowDialog() == DialogResult.OK)
            {
                Pracownik pracownik = formDodajPracownika.CreatedPracownik;
                DataRow newRow = warsztatDataSet.Pracownik.NewRow();
                newRow.BeginEdit();
                newRow[ImieColumnName] = pracownik.Imie;
                newRow[NazwiskoColumnName] = pracownik.Nazwisko;
                newRow[LoginColumnName] = pracownik.Login;
                newRow[HasloColumnName] = pracownik.Haslo;

                newRow.EndEdit();
                warsztatDataSet.Pracownik.Rows.Add(newRow);
                pracownikTableAdapter.Update(warsztatDataSet);
            }
        }

        private void buttonModyfikuj_Click(object sender, EventArgs e)
        {
            CurrentRow.EndEdit();
            pracownikTableAdapter.Update(CurrentRow);
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                $"Czy na pewno usunąć pracownika - {CurrentRow[ImieColumnName]} {CurrentRow[NazwiskoColumnName]}?",
                "Potwierdź",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation
            );

            if (dr == DialogResult.OK)
            {
                pracownikBindingSource.RemoveCurrent();
                pracownikTableAdapter.Update(warsztatDataSet);
            }
        }
    }
}
