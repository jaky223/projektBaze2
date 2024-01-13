using Bazapodataka;
using Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servisi
{
    public class ClanServis
    {
        public Clan GetClan(string korime, string lozinka)
        {
            BazaPodataka.OtvoriVezu();
            BazaPodataka.NapisiUpit($"SELECT * FROM mydb.clan WHERE korime = '{korime}' AND lozinka = '{lozinka}'");
            MySqlDataReader reader = BazaPodataka.PozoviReadera();

            Clan clan = new Clan();

            while (reader.Read())
            {
                clan.Id = MetodeReadera.SafeGetInt32(reader, 0);
                clan.Ime = MetodeReadera.SafeGetString(reader, 1);
                clan.Prezime = MetodeReadera.SafeGetString(reader, 2);
                clan.DatumRodenja = reader.GetDateTime(3);
                clan.Lozinka = MetodeReadera.SafeGetString(reader, 4);
                clan.Korime = MetodeReadera.SafeGetString(reader, 5);
                clan.DatumUclanjenja = reader.GetDateTime(6);
                clan.ZaposlenikID = MetodeReadera.SafeGetInt32(reader, 7);

            }

            BazaPodataka.ZatvoriVezu();
            return clan;
        }

        public List<Clan> GetClanove()
        {
            BazaPodataka.OtvoriVezu();
            BazaPodataka.NapisiUpit($"SELECT * FROM mydb.clan");
            MySqlDataReader reader = BazaPodataka.PozoviReadera();

            List<Clan> clanovi = new List<Clan>();

            while (reader.Read())
            {
                Clan clan = new Clan();
                clan.Id = MetodeReadera.SafeGetInt32(reader, 0);
                clan.Ime = MetodeReadera.SafeGetString(reader, 1);
                clan.Prezime = MetodeReadera.SafeGetString(reader, 2);
                clan.DatumRodenja = reader.GetDateTime(3);
                clan.Lozinka = MetodeReadera.SafeGetString(reader, 4);
                clan.Korime = MetodeReadera.SafeGetString(reader, 5);
                clan.DatumUclanjenja = reader.GetDateTime(6);
                clan.ZaposlenikID = MetodeReadera.SafeGetInt32(reader, 7);
                clanovi.Add(clan);
            }

            BazaPodataka.ZatvoriVezu();
            return clanovi;
        }
        public void DodajClana(Clan clan)
        {
            BazaPodataka.OtvoriVezu();
            BazaPodataka.NapisiUpit($"INSERT INTO mydb.clan (ime, prezime, datum_rodenja, lozinka, korime, Zaposlenik_zaposlenik_id) VALUES ('{clan.Ime}', '{clan.Prezime}', '{clan.DatumRodenja:yyyy-MM-dd}','{clan.Lozinka}', '{clan.Korime}', {clan.ZaposlenikID});");
            BazaPodataka.PozoviReadera();
            BazaPodataka.ZatvoriVezu();
        }

        public void PromijeniPodatkeClana(Clan clan)
        {
            BazaPodataka.OtvoriVezu();
            BazaPodataka.NapisiUpit($"UPDATE mydb.clan SET lozinka = '{clan.Lozinka}' WHERE clan_id = {clan.Id};");
            BazaPodataka.PozoviReadera();
            BazaPodataka.ZatvoriVezu();
        }

        public void ObrisiClana(Clan clan)
        {
            BazaPodataka.OtvoriVezu();
            BazaPodataka.NapisiUpit($"DELETE FROM mydb.clan WHERE clan_id = {clan.Id};");
            BazaPodataka.PozoviReadera();
            BazaPodataka.ZatvoriVezu();
        }
    }
}
