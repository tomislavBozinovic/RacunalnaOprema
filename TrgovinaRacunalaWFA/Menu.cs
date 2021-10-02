using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrgovinaRacunalaWFA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnPartneri_Click(object sender, EventArgs e)
        {
            Partneri partneri = new Partneri();
            partneri.ShowDialog();
        }

        private void btnKategorija_Click(object sender, EventArgs e)
        {
            Kategorija kategorija = new Kategorija();
            kategorija.ShowDialog();
        }

        private void btnProizvod_Click(object sender, EventArgs e)
        {
            Proizvod proizvod = new Proizvod();
            proizvod.ShowDialog();
        }

        private void btnRacun_Click(object sender, EventArgs e)
        {
            Racun racun = new Racun();
            racun.ShowDialog();
        }
    }
}
