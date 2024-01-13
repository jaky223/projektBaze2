using Models;
using Servisi;
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
        private ClanServis clanServis;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            zaposlenikServis = new ZaposlenikServis();
            clanServis = new ClanServis();
        }

        private void btnLoginZaposlenik_Click(object sender, EventArgs e)
        {
            string korime = txtKorimeZaposlenik.Text;
            string lozinka = txtLozinkaZaposlenik.Text;

            Zaposlenik zaposlenik = zaposlenikServis.GetZaposlenik(korime, lozinka);
            if (zaposlenik.Id != 0)
            {
                ZaposlenikHomePage frmZaposlenikHomePage = new ZaposlenikHomePage(zaposlenik);
                frmZaposlenikHomePage.ShowDialog();
            }
            
        }

        private void btnClanLogin_Click(object sender, EventArgs e)
        {
            string korime = txtKorimeClan.Text;
            string lozinka = txtLozinkaClan.Text;

            Clan clan = clanServis.GetClan(korime, lozinka);
            if (clan.Id != 0)
            {
                ClanHomePage frmClanHomePage = new ClanHomePage(clan);
                frmClanHomePage.ShowDialog();
            }
        }
    }
}
