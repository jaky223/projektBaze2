using Bazapodataka;
using Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormApp.Models;

namespace Servisi
{
    public class OpomenaServis
    {
        public List<Opomena> GetOpomeneZaClana(Clan clan)
        {
               BazaPodataka.OtvoriVezu();
                BazaPodataka.NapisiUpit($"SELECT * FROM mydb.opomene WHERE Clan_clan_id = {clan.Id}");
                MySqlDataReader reader = BazaPodataka.PozoviReadera();

                List<Opomena> opomene = new List<Opomena>();

                while (reader.Read())
                {
                Opomena opomena = new Opomena();
                opomena.Id = MetodeReadera.SafeGetInt32(reader, 0);
                opomena.Naslov = MetodeReadera.SafeGetString(reader, 1);
                opomena.Sadrzaj = MetodeReadera.SafeGetString(reader, 2);
                opomena.DatumOpomene = reader.GetDateTime(3);
                opomena.ClanID = MetodeReadera.SafeGetInt32(reader, 4);
                opomene.Add(opomena);
                }

                BazaPodataka.ZatvoriVezu();
                return opomene;
        }

        public void DodajOpomenu(string naslov, string sadrzaj, Clan clan)
        {
            BazaPodataka.OtvoriVezu();
            BazaPodataka.NapisiUpit($"INSERT INTO mydb.opomene (naslov, sadrzaj, Clan_clan_id) VALUES ('{naslov}', '{sadrzaj}', {clan.Id});");
            BazaPodataka.PozoviReadera();
            BazaPodataka.ZatvoriVezu();
        }
    }
}
