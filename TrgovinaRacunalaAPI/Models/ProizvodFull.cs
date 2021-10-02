using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrgovinaRacunalaAPI.Models
{
    public class ProizvodFull
    {
        public int proizvodId { get; set; }
        public int kategorijaId { get; set; }
        public string kategorijaNaziv { get; set; }
        public string kategorijaProizvodac { get; set; }
        public string proizvodNaziv { get; set; }
        public decimal proizvodCijena { get; set; }
        public string proizvodGarancija { get; set; }
    }
}