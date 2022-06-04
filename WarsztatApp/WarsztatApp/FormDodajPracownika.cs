using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarsztatApp.Data;

namespace WarsztatApp
{
    public partial class FormDodajPracownika : Form
    {
        public Pracownik CreatedPracownik => new Pracownik
        {
            Imie = textImie.Text,
            Nazwisko = textNazwisko.Text,
            Login = textLogin.Text,
            Haslo = textHaslo.Text
        };

        public FormDodajPracownika()
        {
            InitializeComponent();
        }

        private void FormDodajPracownika_Load(object sender, System.EventArgs e)
        {
            textImie.Focus();
        }
    }
}
