using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrgovinaRacunalaWFA.Modeli
{
    class StavkaModelFull
    {
        public int racunId { get; set; }
        public string kategorijaIme { get; set; }
        public string kategorijaProizvodac { get; set; } // dodano
        public string naziv { get; set; }
        public int kolicina { get; set; }
        public decimal cijena { get; set; }
    }
}
