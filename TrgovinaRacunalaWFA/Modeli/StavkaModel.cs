using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrgovinaRacunalaWFA.Modeli
{
    class StavkaModel
    {
        public int racunId { get; set; }
        public int proizvodId { get; set; }
        public int kolicina { get; set; }
        public decimal cijena { get; set; }
    }
}
