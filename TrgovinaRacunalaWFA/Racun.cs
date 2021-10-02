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
    public partial class Racun : Form
    {
        public static string racunID;
        public static string brojRacuna;
        public static decimal popust;
        public static decimal partnerPopust;

        public Racun()
        {
            InitializeComponent();
            napuniCb();
            txtPartnerId.Enabled = false;
            txtRacunId.Enabled = false;
            txtPartnerPopust.Enabled = false;
        }
        private async void napuniCb()
        {
            async Task<string> PrikaziSvePartnere()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:54623/api/partneri/GetPartnerName"))
                    {
                        using (HttpContent content = res.Content)
                        {
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
                var podaci = JsonConvert.DeserializeObject<Dictionary<int, string>>(response);

                foreach (var pod in podaci)
                {
                    cbPartneri.Items.Add(pod.Value);
                }
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void cbPartneri_SelectedIndexChanged(object sender, EventArgs e)
        {
            async Task<string> PrikaziSvePartnere()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:54623/api/partneri/GetPartnerName"))
                    {
                        using (HttpContent content = res.Content)
                        {
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
                var podaci = JsonConvert.DeserializeObject<Dictionary<int, string>>(response);

                var partnerId = podaci.FirstOrDefault(x => x.Value == cbPartneri.SelectedText).Key;
                txtPartnerId.Text = partnerId.ToString();
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }

        }

        private async void btnSpremiRacun_Click(object sender, EventArgs e)
        {
            async Task<string> dodajRacun()
            {
                string partnerId = txtPartnerId.Text.Trim();
                string brojRacuna = txtBrojRacuna.Text.Trim();
                string datum = txtDatum.Text.Trim();

                if(partnerId.Length == 0 || brojRacuna.Length == 0)
                {
                    MessageBox.Show("Sva polja moraju biti ispunjena!");
                    return null;
                }

                var uneseniPodaci = new Dictionary<string, string>
                {
                    { "partnerId", partnerId },
                    { "datum", datum },
                    { "brojRacuna", brojRacuna }
                };

                var unos = new FormUrlEncodedContent(uneseniPodaci);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PostAsync("http://localhost:54623/api/racuni", unos))
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
                await dodajRacun();
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

        private async void btnPrikaziSveRacune_Click(object sender, EventArgs e)
        {
            async Task<string> PrikaziSveRacune()
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:54623/api/racuni"))
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
                var response = await PrikaziSveRacune();

                var podaci = JsonConvert.DeserializeObject<List<RacunModel>>(response);
                dgvRacun.DataSource = podaci;
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }


        }

        private async void dgvRacun_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvRacun.CurrentRow.Index != -1)
            {
                txtRacunId.Text = (Convert.ToInt32(dgvRacun.CurrentRow.Cells["racunId"].Value)).ToString();
                txtRacunPretragaId.Text = (Convert.ToInt32(dgvRacun.CurrentRow.Cells["racunId"].Value)).ToString();
                txtBrojRacuna.Text = (string)(dgvRacun.CurrentRow.Cells["brojRacuna"].Value).ToString();
                txtDatum.Text = (string)(dgvRacun.CurrentRow.Cells["datum"].Value).ToString();
                txtPartnerId.Text = (Convert.ToInt32(dgvRacun.CurrentRow.Cells["partnerId"].Value)).ToString();
            }

            var response2 = await DohvatiPopust();
            var podaci2 = JsonConvert.DeserializeObject<Dictionary<string, decimal>>(response2);

            partnerPopust = podaci2.FirstOrDefault(x => x.Key == txtPartnerId.Text).Value;

            txtPartnerPopust.Text = partnerPopust.ToString();
        }

        private void btnStavkeRacuna_Click(object sender, EventArgs e)
        {
            try
            {
                racunID = txtRacunId.Text;
                brojRacuna = txtBrojRacuna.Text;
                Stavka stavka = new Stavka();
                partnerPopust = decimal.Parse(txtPartnerPopust.Text.Trim());
                stavka.ShowDialog();
            }
            catch(System.FormatException k)
            {
                MessageBox.Show("Odaberite Račun!");
            }
        }

        private async void btnPretraziRacun_Click(object sender, EventArgs e)
        {
            async Task<string> PretraziRacun(int id)
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:54623/api/racuni/" + id))
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
                var response = await PretraziRacun(int.Parse(txtRacunPretragaId.Text.Trim()));

                var podaci = JsonConvert.DeserializeObject<RacunModel>(response);
                List<RacunModel> lista = new List<RacunModel>();
                lista.Add(podaci);

                dgvRacun.DataSource = lista;
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

        private async void btnIzbrisiRacun_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni?", "Važno", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                async Task<string> izbrisiRacun(int id)
                {
                    using (HttpClient client = new HttpClient())
                    {
                        using (HttpResponseMessage res = await client.DeleteAsync("http://localhost:54623/api/racuni/" + id))
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
                    await izbrisiRacun(int.Parse(txtRacunPretragaId.Text.Trim()));
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
        }

        private async void btnPromijeniPodatke_Click(object sender, EventArgs e)
        {
            async Task<string> PromijeniPodatkeRacuna()
            {
                int id = int.Parse(txtRacunPretragaId.Text.Trim());

                string racunPartner = txtPartnerId.Text.Trim();
                string brojRacuna = txtBrojRacuna.Text.Trim();
                string datum = txtDatum.Text.Trim();

                if(racunPartner.Length == 0 || brojRacuna.Length == 0 || datum.Length == 0)
                {
                    MessageBox.Show("Sva polja moraju biti ispunjena!");
                    return null;
                }

                var uneseniPodaci = new Dictionary<string, string>
                {
                    { "partnerId", racunPartner },
                    { "datum", datum },
                    { "brojRacuna", brojRacuna }
                };

                var unos = new FormUrlEncodedContent(uneseniPodaci);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PutAsync("http://localhost:54623/api/racuni/" + id, unos))
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
                await PromijeniPodatkeRacuna();
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

        async Task<string> DohvatiPopust()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync("http://localhost:54623/api/partneri/GetPopust"))
                {
                    using (HttpContent content = res.Content)
                    {
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

        private async void btnPretraziBroj_Click(object sender, EventArgs e)
        {
            async Task<string> PretraziRacun(string brojRacuna)
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:54623/api/racuni/PretragaBroj/" + brojRacuna))
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
                var response = await PretraziRacun(txtBrojRacunaPretraga.Text.Trim());

                var podaci = JsonConvert.DeserializeObject<List<RacunModel>>(response);

                dgvRacun.DataSource = podaci;
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
    }
}
