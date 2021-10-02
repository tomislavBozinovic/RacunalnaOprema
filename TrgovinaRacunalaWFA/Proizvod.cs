using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using TrgovinaRacunalaWFA.Modeli;

namespace TrgovinaRacunalaWFA
{
    public partial class Proizvod : Form
    {
        public Proizvod()
        {
            InitializeComponent();
            //txtKategorijaID.Enabled = false;
            napuniCB();
        }

        private async void btnPrikaziSveProizvode_Click(object sender, EventArgs e)
        {
            async Task<string> PrikaziSveProizvode()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:54623/api/proizvodi"))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                            MessageBox.Show(statusCode);
                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                }
                return string.Empty;
            }

            try
            {
                var response = await PrikaziSveProizvode();

                var podaci = JsonConvert.DeserializeObject<List<ProizvodiModel>>(response);
                dgvProizvodi.DataSource = podaci;
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void btnPretraziProizvod_Click(object sender, EventArgs e)
        {
            async Task<string> PretraziProizvod(int id)
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:54623/api/proizvodi/" + id))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                            MessageBox.Show(statusCode);

                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                }
                return string.Empty;
            }

            try
            {
                var response = await PretraziProizvod(int.Parse(txtIdPretragaProizvod.Text.Trim()));
                var podaci = JsonConvert.DeserializeObject<List<ProizvodiModel>>(response);

                dgvProizvodi.DataSource = podaci;
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }

            catch (System.FormatException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void btnIzbrisiProizvod_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni?", "Važno", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                async Task<string> IzbrisiProizvod(int id)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        using (HttpResponseMessage res = await client.DeleteAsync("http://localhost:54623/api/proizvodi/" + id))
                        {
                            using (HttpContent content = res.Content)
                            {
                                string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                                MessageBox.Show(statusCode);

                                string data = await content.ReadAsStringAsync();

                                if (data != null)
                                {
                                    return data;
                                }
                            }
                        }
                    }
                    return string.Empty;
                }

                try
                {
                    await IzbrisiProizvod(int.Parse(txtIdPretragaProizvod.Text.Trim()));
                }
                catch (HttpRequestException x)
                {
                    MessageBox.Show(x.Message);
                }
                catch (System.FormatException x)
                {
                    MessageBox.Show(x.Message);
                }
            }
            else
            {
                MessageBox.Show("Proizvod neće biti izbrisan.");
            }
        
        }

        private async void btnDodajNoviProizvod_Click(object sender, EventArgs e)
        {
            async Task<string> DodajNoviProizvod()
            {
                string kategorijaId = txtKategorijaID.Text.Trim();
                string proizvodCijena = txtProizvodCijena.Text.Trim();
                string proizvodNaziv = txtProizvodNaziv.Text.Trim();
                string proizvodGarancija = txtProizvodGarancija.Text.Trim();

                if(kategorijaId.Length == 0 || proizvodCijena.Length == 0 || proizvodNaziv.Length == 0 || proizvodGarancija.Length == 0)
                {
                    MessageBox.Show("Sva polja moraju biti popunjena!");
                    return null;
                }

                var uneseniPodaci = new Dictionary<string, string>
                {
                    { "kategorijaId" , kategorijaId },
                    { "Cijena", proizvodCijena },
                    { "Naziv", proizvodNaziv },
                    { "Garancija", proizvodGarancija }
                };

                var unos = new FormUrlEncodedContent(uneseniPodaci);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PostAsync("http://localhost:54623/api/proizvodi",unos))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                            MessageBox.Show(statusCode);

                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                }
                return string.Empty;
            }

            try
            {
                await DodajNoviProizvod();
            }

            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
            catch (FormatException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void btnPromijeniPodatkeProizvoda_Click(object sender, EventArgs e)
        {
            async Task<string> PromijeniPodatkeProizvoda()
            {

                int id = int.Parse(txtIdPretragaProizvod.Text.Trim());

                string kategorijaId = txtKategorijaID.Text.Trim();
                string proizvodCijena = txtProizvodCijena.Text.Trim();
                string proizvodNaziv = txtProizvodNaziv.Text.Trim();
                string proizvodGarancija = txtProizvodGarancija.Text.Trim();

                if (kategorijaId.Length == 0 || proizvodCijena.Length == 0 || proizvodNaziv.Length == 0 || proizvodGarancija.Length == 0)
                {
                    MessageBox.Show("Sva polja moraju biti popunjena!");
                    return null;
                }

                var uneseniPodaci = new Dictionary<string, string>
                {
                    { "kategorijaId" , kategorijaId },
                    { "Cijena", proizvodCijena },
                    { "Naziv", proizvodNaziv },
                    { "Garancija", proizvodGarancija }
                };

                var unos = new FormUrlEncodedContent(uneseniPodaci);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PutAsync("http://localhost:54623/api/proizvodi/" + id, unos))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                            MessageBox.Show(statusCode);

                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                }
                return string.Empty;
            }
            try
            {
                await PromijeniPodatkeProizvoda();
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
            catch (FormatException x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private void dgvProizvodi_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvProizvodi.CurrentRow.Index != -1)
            {
                txtIdPretragaProizvod.Text = (Convert.ToInt32(dgvProizvodi.CurrentRow.Cells["proizvodId"].Value)).ToString();
                txtProizvodCijena.Text = (Convert.ToDecimal(dgvProizvodi.CurrentRow.Cells["proizvodCijena"].Value)).ToString();
                txtKategorijaID.Text = (Convert.ToInt32(dgvProizvodi.CurrentRow.Cells["kategorijaId"].Value)).ToString();
                txtProizvodGarancija.Text = (string)(dgvProizvodi.CurrentRow.Cells["proizvodGarancija"].Value).ToString();
                txtProizvodNaziv.Text = (string)(dgvProizvodi.CurrentRow.Cells["proizvodNaziv"].Value).ToString();
            }
        }

        private async void napuniCB()
        {
            async Task<string> PrikaziSveKategorije()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:54623/api/kategorije/GetFullName"))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                }
                return string.Empty;
            }
            try
            {
                var response = await PrikaziSveKategorije();
                var podaci = JsonConvert.DeserializeObject<Dictionary<int,string>>(response);
                
                foreach(var pod in podaci)
                {
                    cbKategorije.Items.Add(pod.Value);
                }
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void cbKategorije_SelectedIndexChanged(object sender, EventArgs e)
        {
            async Task<string> PrikaziSveKategorije()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:54623/api/kategorije/GetFullName"))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                            string data = await content.ReadAsStringAsync();

                            if (data != null)
                            {
                                return data;
                            }
                        }
                    }
                }
                return string.Empty;
            }

            try
            {
                var response = await PrikaziSveKategorije();
                var podaci = JsonConvert.DeserializeObject<Dictionary<int, string>>(response);

                var kategorijaId = podaci.FirstOrDefault(x => x.Value == cbKategorije.SelectedText).Key;
                txtKategorijaID.Text = kategorijaId.ToString();
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }

           
        }


    }

}
