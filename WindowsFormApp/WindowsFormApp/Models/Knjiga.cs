using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Knjiga
    {
       public int Id { get; set; }
       public string Naziv { get; set; }
        public DateTime DatumIzdanja { get; set; }
        public bool Posudena { get; set; }
        public bool Izgubljena { get; set; }
        public int ClanID { get; set; }
    }
}
