using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrgovinaRacunalaAPI.BO
{
    public class StavkaBO
    {
        public int racunId { get; set; }
        public int proizvodId { get; set; }
        public int kolicina { get; set; }
        public decimal cijena { get; set; }
    }
}