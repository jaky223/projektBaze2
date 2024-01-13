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
using WindowsFormApp.Servisi;

namespace WindowsFormApp
{
    public partial class ClanHomePage : Form
    {

        private ClanServis clanSerivs;
        private OpomenaServis opomenaServis;
        private KnjigaServis knjigaServis;

        private Clan logiraniClan;
        public ClanHomePage(Clan clan)
        {
            InitializeComponent();
            clanSerivs = new ClanServis();
            opomenaServis = new OpomenaServis();
            knjigaServis = new KnjigaServis();
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

        private void Refresh()
        {
            dgvNeposudeneKnjige.DataSource = null;
            dgvNeposudeneKnjige.DataSource = knjigaServis.GetNeposudeneKnjige();
            dgvPosudeneKnjige.DataSource = null;
            dgvPosudeneKnjige.DataSource = knjigaServis.GetPosudeneKnjigeZaClana(logiraniClan);
        }

        private void ClanHomePage_Load(object sender, EventArgs e)
        {
            dgvOpomene.DataSource = opomenaServis.GetOpomeneZaClana(logiraniClan);
            PopuniPodatkeClana(logiraniClan);
            Refresh();
        }

        private void btnPromijeniPodatke_Click(object sender, EventArgs e)
        {
            logiraniClan.Lozinka = txtLozinka.Text;
            clanSerivs.PromijeniPodatkeClana(logiraniClan);
        }

        private void btnPosudiKnjigu_Click(object sender, EventArgs e)
        {
            Knjiga selektiranaKnjiga = dgvNeposudeneKnjige.SelectedRows[0].DataBoundItem as Knjiga;
            knjigaServis.PosudiKnjigu(selektiranaKnjiga, logiraniClan);
            Refresh();
        }

        private void btnVratiKnjigu_Click(object sender, EventArgs e)
        {
            Knjiga selektiranaKnjiga = dgvPosudeneKnjige.SelectedRows[0].DataBoundItem as Knjiga;
            knjigaServis.VratiKnjigu(selektiranaKnjiga);
            Refresh();
        }
    }
}
