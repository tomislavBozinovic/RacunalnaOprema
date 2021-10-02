using Newtonsoft.Json;
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
using TrgovinaRacunalaWFA.Modeli;

namespace TrgovinaRacunalaWFA
{
    public partial class Partneri : Form
    {
        public Partneri()
        {
            InitializeComponent();
        }

        private async void btnPrikaziSvePartnere_Click(object sender, EventArgs e)
        {
            async Task<string> PrikaziSvePartnere()
            {
                using (HttpClient client = new HttpClient())
                {
                    using(HttpResponseMessage res = await client.GetAsync("http://localhost:54623/api/partneri"))
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
                var response = await PrikaziSvePartnere();

                var podaci = JsonConvert.DeserializeObject<List<PartneriModel>>(response);
                dgvPartneri.DataSource = podaci;
            }

            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private async void btnPretraziPartnera_Click(object sender, EventArgs e)
        {
            async Task<string> PretraziPartnera(int id)
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:54623/api/partneri/" + id))
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
                var response = await PretraziPartnera(int.Parse(txtIdPretragaPartnera.Text.Trim()));

                PartneriModel podaci = JsonConvert.DeserializeObject<PartneriModel>(response);

                List<PartneriModel> lista = new List<PartneriModel>();
                lista.Add(podaci);

                dgvPartneri.DataSource = lista;
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

        private async void btnIzbrisiPartnera_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Jeste li sigurni?", "Važno", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                async Task<string> IzbrisiPartnera(int id)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        using (HttpResponseMessage res = await client.DeleteAsync("http://localhost:54623/api/partneri/" + id))
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
                    await IzbrisiPartnera(int.Parse(txtIdPretragaPartnera.Text.Trim()));
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
                MessageBox.Show("Partner neće biti izbrisan.");
            }
        }

        private async void btnDodajPartnera_Click(object sender, EventArgs e)
        {
            async Task<string> DodajPartnera()
            {
                string partnerIme = txtImePartnera.Text.Trim();
                string partnerPopust = txtPopustPartnera.Text.Trim();

                if(partnerIme.Length == 0 || partnerPopust.Length == 0)
                {
                    MessageBox.Show("Sva polja moraju biti popunjena!");
                    return null;
                }

                var uneseniPodaci = new Dictionary<string, string>
                {
                    { "Naziv" , partnerIme },
                    { "Popust" , partnerPopust }
                };

                var unos = new FormUrlEncodedContent(uneseniPodaci);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PostAsync("http://localhost:54623/api/partneri",unos))
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
                await DodajPartnera();
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

        private async void btnPromijeniPodatke_Click(object sender, EventArgs e)
        {
            async Task<string> PromijeniPodatke()
            {
                int id = int.Parse(txtIdPretragaPartnera.Text.Trim());

                string partnerIme = txtImePartnera.Text.Trim();
                string partnerPopust = txtPopustPartnera.Text.Trim();

                if(partnerIme.Length == 0 || partnerPopust.Length == 0)
                {
                    MessageBox.Show("Sva polja moraju biti popunjena!");
                    return null;
                }

                var uneseniPodaci = new Dictionary<string, string>
                {
                    { "Naziv" , partnerIme },
                    { "Popust" , partnerPopust }
                };

                var unos = new FormUrlEncodedContent(uneseniPodaci);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PutAsync("http://localhost:54623/api/partneri/" + id, unos))
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
                await PromijeniPodatke();
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

        private void dgvPartneri_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvPartneri.CurrentRow.Index != -1)
            {
                txtIdPretragaPartnera.Text = (Convert.ToInt32(dgvPartneri.CurrentRow.Cells["partnerIdd"].Value)).ToString();
                txtImePartnera.Text = (string)dgvPartneri.CurrentRow.Cells["partnerNaziv"].Value.ToString();
                txtPopustPartnera.Text = (Convert.ToDecimal(dgvPartneri.CurrentRow.Cells["partnerPopust"].Value)).ToString();
            }
        }
    }
}
