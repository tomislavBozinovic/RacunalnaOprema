using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrgovinaRacunalaAPI.BO
{
    public class ProizvodBO
    {
        public int kategorijaId { get; set; }
        public decimal Cijena { get; set; }
        public string Naziv { get; set; }
        public string Garancija { get; set; }
    }
}