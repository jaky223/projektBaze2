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
using WindowsFormApp.Models;

namespace WindowsFormApp
{
    public partial class ZaposlenikHomePage : Form
    {
        private ClanServis clanServis;
        private OpomenaServis opomenaServis;
        private Zaposlenik logiranZaposlenik;

        private Clan selektiraniClan = new Clan();
        public ZaposlenikHomePage(Zaposlenik zaposlenik)
        {
            InitializeComponent();
            logiranZaposlenik = zaposlenik;
            clanServis = new ClanServis();
            opomenaServis = new OpomenaServis();
        }

        private void Refresh()
        {
            dgvPrikazSvihClanova.DataSource = null;
            dgvPrikazSvihClanova.DataSource = clanServis.GetClanove();
            
        }

        private void ZaposlenikHomePage_Load(object sender, EventArgs e)
        {
            Refresh();
            
        }

        private void btnDodajClana_Click(object sender, EventArgs e)
        {
            Clan clan = new Clan
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                DatumRodenja = dtpBox.Value,
                Lozinka = txtLozinka.Text,
                Korime = txtKorime.Text,
                ZaposlenikID = logiranZaposlenik.Id
            };
            clanServis.DodajClana(clan);
            Refresh();
        }

        private void btnObrisiClana_Click(object sender, EventArgs e)
        {
            selektiraniClan = dgvPrikazSvihClanova.SelectedRows[0].DataBoundItem as Clan;
            if (selektiraniClan != null)
            {
                clanServis.ObrisiClana(selektiraniClan);
                Refresh();
            }
           
        }

        private void dgvPrikazSvihClanova_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selektiraniClan = dgvPrikazSvihClanova.SelectedRows[0].DataBoundItem as Clan;
            
        }

        private void btnDodajOpomenu_Click(object sender, EventArgs e)
        {
            string naslov = txtNaslov.Text;
            string sadrzaj = txtSadrzaj.Text;
            selektiraniClan = dgvPrikazSvihClanova.SelectedRows[0].DataBoundItem as Clan;
            if (selektiraniClan != null)
            {
                opomenaServis.DodajOpomenu(naslov, sadrzaj, selektiraniClan);
            }
            dgvPrikazOpomenaZaClana.DataSource = null;
            dgvPrikazOpomenaZaClana.DataSource = opomenaServis.GetOpomeneZaClana(selektiraniClan);
        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPrikazSvihClanova.SelectedRows.Count > 0)
            {
                selektiraniClan = dgvPrikazSvihClanova.SelectedRows[0].DataBoundItem as Clan;
                if (selektiraniClan != null)
                {
                    dgvPrikazOpomenaZaClana.DataSource = null;
                    dgvPrikazOpomenaZaClana.DataSource = opomenaServis.GetOpomeneZaClana(selektiraniClan);
                }
            }
            else
            {
                dgvPrikazOpomenaZaClana.DataSource = null;
            }
        }
    }
}
