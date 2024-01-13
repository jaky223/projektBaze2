using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class Form1 : Form
    {

        private ZaposlenikServis zaposlenikServis;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zaposlenikServis = new ZaposlenikServis();
        }

        private void btnLoginZaposlenik_Click(object sender, EventArgs e)
        {
            ZaposlenikHomePage frmZaposlenikHomePage = new ZaposlenikHomePage();
            frmZaposlenikHomePage.Show();
        }

        private void btnClanLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
