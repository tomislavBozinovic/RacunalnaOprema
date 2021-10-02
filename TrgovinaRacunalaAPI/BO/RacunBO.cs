using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrgovinaRacunalaAPI.BO
{
    public class RacunBO
    {
        public int racunId { get; set; }
        public int partnerId { get; set; }
        public DateTime datum { get; set; }
        public string brojRacuna { get; set; }
    }
}