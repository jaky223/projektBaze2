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
    public class ZaposlenikServis
    {

        public Zaposlenik GetZaposlenik(string korime, string lozinka)
        {
            BazaPodataka.OtvoriVezu();
            BazaPodataka.NapisiUpit($"SELECT * FROM mydb.zaposlenik WHERE korime = '{korime}' AND lozinka = '{lozinka}'");
            MySqlDataReader reader = BazaPodataka.PozoviReadera();

            Zaposlenik zaposlenik = new Zaposlenik();

            while (reader.Read())
            {
                zaposlenik.Id = MetodeReadera.SafeGetInt32(reader, 0);
                zaposlenik.Ime = MetodeReadera.SafeGetString(reader, 1);
                zaposlenik.Prezime = MetodeReadera.SafeGetString(reader, 2);
                zaposlenik.Korime = MetodeReadera.SafeGetString(reader, 3);
                zaposlenik.Lozinka = MetodeReadera.SafeGetString(reader, 4);
                zaposlenik.Kontakt = MetodeReadera.SafeGetString(reader, 5);
            }

            BazaPodataka.ZatvoriVezu();
            return zaposlenik;
        }
    }
}
