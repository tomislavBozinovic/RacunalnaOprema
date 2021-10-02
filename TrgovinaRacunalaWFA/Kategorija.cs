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
    public partial class Kategorija : Form
    {
        public Kategorija()
        {
            InitializeComponent();
        }

        private async void btnPrikaziSveKategorije_Click(object sender, EventArgs e)
        {
            async Task<string> PrikaziSveKategorije()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:54623/api/kategorije"))
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
                var response = await PrikaziSveKategorije();
                var podaci = JsonConvert.DeserializeObject<List<KategorijaModel>>(response);
                dgvKategorije.DataSource = podaci;
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void btnPretraziKategoriju_Click(object sender, EventArgs e)
        {
            async Task<string> PretraziKategoriju(int id)
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:54623/api/kategorije/" + id))
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
                var response = await PretraziKategoriju(int.Parse(txtIdPretragaKategorije.Text.Trim()));

                KategorijaModel podaci = JsonConvert.DeserializeObject<KategorijaModel>(response);
                List<KategorijaModel> lista = new List<KategorijaModel>();
                lista.Add(podaci);

                dgvKategorije.DataSource = lista;
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

        private async void btnIzbrisiKategoriju_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni?", "Važno", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                async Task<string> IzbrisiKategoriju(int id)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        using (HttpResponseMessage res = await client.DeleteAsync("http://localhost:54623/api/kategorije/" + id))
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
                    await IzbrisiKategoriju(int.Parse(txtIdPretragaKategorije.Text.Trim()));
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
                MessageBox.Show("Kategorija neće biti izbrisana.");
            }
        }

        private async void btnDodajKategoriju_Click(object sender, EventArgs e)
        {
            async Task<string> DodajKategoriju()
            {
                string kategorijaNaziv = txtNazivKategorije.Text.Trim();
                string kategorijaProizvodac = txtProizvodacKategorija.Text.Trim();

                if(kategorijaNaziv.Length == 0 || kategorijaProizvodac.Length == 0)
                {
                    MessageBox.Show("Sva polja moraju biti ispunjena!");
                    return null;
                }

                var uneseniPodaci = new Dictionary<string, string>
                {
                    { "Naziv" , kategorijaNaziv  },
                    { "Proizvodac", kategorijaProizvodac }
                };

                var unos = new FormUrlEncodedContent(uneseniPodaci);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PostAsync("http://localhost:54623/api/kategorije", unos))
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
                await DodajKategoriju();
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

        private async void btnIzmijeniPodatke_Click(object sender, EventArgs e)
        {
            async Task<string> IzmjeniPodatke()
            {
                int id = int.Parse(txtIdPretragaKategorije.Text.Trim());

                string kategorijaNaziv = txtNazivKategorije.Text.Trim();
                string kategorijaProizvodac = txtProizvodacKategorija.Text.Trim();

                if (kategorijaNaziv.Length == 0 || kategorijaProizvodac.Length == 0)
                {
                    MessageBox.Show("Sva polja moraju biti ispunjena!");
                    return null;
                }

                var uneseniPodaci = new Dictionary<string, string>
                {
                    { "Naziv" , kategorijaNaziv  },
                    { "Proizvodac", kategorijaProizvodac }
                };

                var unos = new FormUrlEncodedContent(uneseniPodaci);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PutAsync("http://localhost:54623/api/kategorije/" + id, unos))
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
                await IzmjeniPodatke();
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

        private void dgvKategorije_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvKategorije.CurrentRow.Index != -1)
            {
                txtIdPretragaKategorije.Text = (Convert.ToInt32(dgvKategorije.CurrentRow.Cells["kategorijaId"].Value)).ToString();
                txtNazivKategorije.Text = (string)dgvKategorije.CurrentRow.Cells["kategorijaNaziv"].Value.ToString();
                txtProizvodacKategorija.Text = (string)dgvKategorije.CurrentRow.Cells["kategorijaProizvodac"].Value.ToString();
            }
        }
    }
}
