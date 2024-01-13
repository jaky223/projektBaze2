using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bazapodataka;
using Models;
using MySql.Data.MySqlClient;

namespace WindowsFormApp.Servisi
{
    public class KnjigaServis
    {
        public List<Knjiga> GetNeposudeneKnjige()
        {
            BazaPodataka.OtvoriVezu();
            BazaPodataka.NapisiUpit($"SELECT * FROM mydb.knjiga WHERE posudena = 0");
            MySqlDataReader reader = BazaPodataka.PozoviReadera();

            List<Knjiga> knjige = new List<Knjiga>();

            while (reader.Read())
            {
                Knjiga knjiga = new Knjiga();
                knjiga.Id = MetodeReadera.SafeGetInt32(reader, 0);
                knjiga.Naziv = MetodeReadera.SafeGetString(reader, 1);
                knjiga.DatumIzdanja = reader.GetDateTime(2);
                knjiga.Posudena = MetodeReadera.SafeGetBoolean(reader, 3);
                knjiga.Izgubljena = MetodeReadera.SafeGetBoolean(reader, 4);
                knjiga.ClanID = MetodeReadera.SafeGetInt32(reader, 5);
                knjige.Add(knjiga);
            }

            BazaPodataka.ZatvoriVezu();
            return knjige;
        }

        public List<Knjiga> GetPosudeneKnjigeZaClana(Clan clan)
        {
            BazaPodataka.OtvoriVezu();
            BazaPodataka.NapisiUpit($"SELECT * FROM mydb.knjiga WHERE posudena = 1 AND Clan_clan_id = {clan.Id}");
            MySqlDataReader reader = BazaPodataka.PozoviReadera();

            List<Knjiga> knjige = new List<Knjiga>();

            while (reader.Read())
            {
                Knjiga knjiga = new Knjiga();
                knjiga.Id = MetodeReadera.SafeGetInt32(reader, 0);
                knjiga.Naziv = MetodeReadera.SafeGetString(reader, 1);
                knjiga.DatumIzdanja = reader.GetDateTime(2);
                knjiga.Posudena = MetodeReadera.SafeGetBoolean(reader, 3);
                knjiga.Izgubljena = MetodeReadera.SafeGetBoolean(reader, 4);
                knjiga.ClanID = MetodeReadera.SafeGetInt32(reader, 5);
                knjige.Add(knjiga);
            }

            BazaPodataka.ZatvoriVezu();
            return knjige;
        }

        public void PosudiKnjigu(Knjiga knjiga, Clan clan)
        {
            BazaPodataka.OtvoriVezu();
            BazaPodataka.NapisiUpit($"UPDATE mydb.knjiga SET posudena = 1, Clan_clan_id = {clan.Id} WHERE knjiga_id = {knjiga.Id};");
            BazaPodataka.PozoviReadera();
            BazaPodataka.ZatvoriVezu();
        }

        public void VratiKnjigu(Knjiga knjiga)
        {
            BazaPodataka.OtvoriVezu();
            BazaPodataka.NapisiUpit($"UPDATE mydb.knjiga SET posudena = 0, Clan_clan_id = NULL WHERE knjiga_id = {knjiga.Id};");
            BazaPodataka.PozoviReadera();
            BazaPodataka.ZatvoriVezu();
        }
    }
}
