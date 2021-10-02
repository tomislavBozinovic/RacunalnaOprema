using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrgovinaRacunalaWFA.Modeli
{
    class ProizvodiModel
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
