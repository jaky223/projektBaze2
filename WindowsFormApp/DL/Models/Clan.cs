using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL.Models
{
    public class Clan
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodenja { get; set; }
        public string Lozinka { get; set; }
        public string Korime { get; set; }
        public DateTime DatumUclanjenja { get; set; }
        public int ZaposlenikID { get; set; }
    }
}
