using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarsztatApp
{
    public partial class FormCepik : Form
    {
        public FormCepik()
        {
            InitializeComponent();
            webBrowserCepik.ScriptErrorsSuppressed = true;
            webBrowserCepik.Navigate("https://historiapojazdu.gov.pl/");
        }
    }
}
