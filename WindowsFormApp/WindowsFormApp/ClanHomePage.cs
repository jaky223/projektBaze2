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
    public partial class ClanHomePage : Form
    {

        private ClanServis clanSerivs;
        private OpomenaServis opomenaServis;

        private Clan logiraniClan;
        public ClanHomePage(Clan clan)
        {
            InitializeComponent();
            clanSerivs = new ClanServis();
            opomenaServis = new OpomenaServis();
            logiraniClan = clan;
        }

        private void PopuniPodatkeClana(Clan clan)
        {
            txtIme.Text = clan.Ime;
            txtPrezime.Text = clan.Prezime;
            dtpBox.Value = clan.DatumRodenja;
            txtKorime.Text = clan.Korime;
            txtLozinka.Text = clan.Lozinka;
        }

        private void ClanHomePage_Load(object sender, EventArgs e)
        {
            dgvOpomene.DataSource = opomenaServis.GetOpomeneZaClana(logiraniClan);
            PopuniPodatkeClana(logiraniClan);
        }

        private void btnPromijeniPodatke_Click(object sender, EventArgs e)
        {
            logiraniClan.Lozinka = txtLozinka.Text;
            clanSerivs.PromijeniPodatkeClana(logiraniClan);
        }
    }
}
