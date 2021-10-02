using iTextSharp.text;
using iTextSharp.text.pdf;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrgovinaRacunalaWFA.Modeli;

namespace TrgovinaRacunalaWFA
{
    public partial class Stavka : Form
    {
        public Stavka()
        {
            InitializeComponent();
            string racunID = Racun.racunID;
            txtUkupnaCijena.Enabled = false;
            napuniCbKategorije();
            txtRacunId.Text = racunID;
            txtRacunId.Enabled = false;
           
        }


        string brojRacuna = Racun.brojRacuna;
        decimal partnerPopust = Racun.partnerPopust;
        
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
        public async void napuniCbKategorije()
        {
            try
            {
                var response = await PrikaziSveKategorije();
                var podaci = JsonConvert.DeserializeObject<Dictionary<int, string>>(response);

                foreach (var pod in podaci)
                {
                    cbKategorija.Items.Add(pod.Value);
                }
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private async void napuniCBProizvodi()
        {
            async Task<string> PrikaziSveProizvode(int id)
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:54623/api/proizvodi/GetProKat/" + id))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                            //MessageBox.Show(statusCode);
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
                var kategorijaId = podaci.FirstOrDefault(x => x.Value == cbKategorija.SelectedText).Key;

                var response2 = await PrikaziSveProizvode(kategorijaId);
                var podaci2 = JsonConvert.DeserializeObject<Dictionary<int, string>>(response2);

                foreach (var pod2 in podaci2)
                {
                    cbProizvodi.Items.Add(pod2.Value);
                }
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }


        }

        private void cbKategorija_SelectedIndexChanged(object sender, EventArgs e)
        {
            napuniCBProizvodi();
            cbProizvodi.Items.Clear();
        }

        async Task<string> PrikaziSveProizvode()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync("http://localhost:54623/api/proizvodi/GetCijena"))
                {
                    using (HttpContent content = res.Content)
                    {
                        //string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                        //MessageBox.Show(statusCode);
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

        async Task<string> PrikaziSveProizvodeName()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync("http://localhost:54623/api/proizvodi/GetId"))
                {
                    using (HttpContent content = res.Content)
                    {
                        string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                        //MessageBox.Show(statusCode);
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

        private async void cbKolicina_SelectedIndexChanged(object sender, EventArgs e)
            {
            try
            {
                var response = await PrikaziSveProizvode();
                var podaci = JsonConvert.DeserializeObject<Dictionary<string, decimal>>(response);

                var proizvodCijena = podaci.FirstOrDefault(x => x.Key == cbProizvodi.Text).Value;

                txtUkupnaCijena.Text = (proizvodCijena * (int.Parse(cbKolicina.SelectedText))).ToString();
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnDodajStavku_Click(object sender, EventArgs e)
        {
            async Task<string> dodajStavku()
            {
                string racunId = txtRacunId.Text.Trim();

                var response = await PrikaziSveProizvodeName();
                var podaci = JsonConvert.DeserializeObject <Dictionary<string,int>>(response);

                string proizvodId = podaci.FirstOrDefault(x => x.Key == cbProizvodi.Text).Value.ToString();

                
                string kolicina = cbKolicina.Text;
                string cijena = txtUkupnaCijena.Text.ToString();

                if(racunId.Length == 0 || proizvodId.Length == 0 || kolicina.Length == 0 || cijena.Length == 0)
                {
                    MessageBox.Show("Sva polja moraju biti popunjena!");
                    return null;
                }

                var uneseniPodaci = new Dictionary<string, string>
                {
                    { "racunId", racunId },
                    { "proizvodId", proizvodId },
                    { "kolicina", kolicina },
                    { "cijena", cijena }
                };

                var unos = new FormUrlEncodedContent(uneseniPodaci);

                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.PostAsync("http://localhost:54623/api/stavka", unos))
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
                await dodajStavku();
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

        private async void btnPrikaziStavkeRacuna_Click(object sender, EventArgs e)
        {
            async Task<string> PrikaziStavkeRacuna(int id)
            {
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage res = await client.GetAsync("http://localhost:54623/api/stavka/"+id))
                    {
                        using (HttpContent content = res.Content)
                        {
                            string statusCode = res.StatusCode.ToString() + " - " + ((int)res.StatusCode).ToString();
                            //MessageBox.Show(statusCode);
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
                var response = await PrikaziStavkeRacuna(int.Parse(txtRacunId.Text.Trim()));

                var podaci = JsonConvert.DeserializeObject<List<StavkaModelFull>>(response);
                dgvStavkeRacuna.DataSource = podaci;
            }
            catch (HttpRequestException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            void ExportToPdf()
            {
                var pdfDoc = new Document(PageSize.LETTER, 40f, 40f, 60f, 60f);
                //string path = $"C:\\Users\\tbozi\\OneDrive\\Desktop\\PDF Izvjestaji\\RacunId{txtRacunId.Text.TrimEnd(' ')}.pdf";
                string path = $"C:\\Users\\tbozi\\OneDrive\\Desktop\\PDF Izvjestaji\\{brojRacuna}.BR.pdf";

                PdfWriter.GetInstance(pdfDoc, new FileStream(path, FileMode.OpenOrCreate));
                pdfDoc.Open();

                var imagepath = @"C:\Users\tbozi\source\repos\Projekt\logo.png";

                using (FileStream fs = new FileStream(imagepath, FileMode.Open))
                {
                    var png = iTextSharp.text.Image.GetInstance(System.Drawing.Image.FromStream(fs),
                            ImageFormat.Png);
                    png.ScalePercent(2f);
                    png.SetAbsolutePosition(pdfDoc.Left, pdfDoc.Top);
                    pdfDoc.Add(png);
                }

                var Naslov = new Paragraph("Programiranje u .NET okolini - Projekt: Trgovina Racunala");
                pdfDoc.Add(Naslov);


                var spacer = new Paragraph("")
                {
                    SpacingBefore = 10f,
                    SpacingAfter = 10f,
                };

                pdfDoc.Add(spacer);

                var headerTable = new PdfPTable(new[] { .75f, 2f })
                {
                    HorizontalAlignment = Left,
                    WidthPercentage = 75,
                    DefaultCell = { MinimumHeight = 22f }
                };

                headerTable.AddCell("Datum");
                headerTable.AddCell(DateTime.Now.ToString());
                headerTable.AddCell("RacunID");
                headerTable.AddCell(txtRacunId.Text.Trim());
                headerTable.AddCell("Broj Racuna");
                headerTable.AddCell(brojRacuna);
                headerTable.AddCell("Racun Izdao");
                headerTable.AddCell("Tomislav Bozinovic");

                pdfDoc.Add(headerTable);
                pdfDoc.Add(spacer);

                var columnCount = dgvStavkeRacuna.ColumnCount;
                var columnWidths = new[] { 1f, 1f, 1.5f, 1f, 1f, 1f };

                var table = new PdfPTable(columnWidths)
                {
                    HorizontalAlignment = Left,
                    WidthPercentage = 100,
                    DefaultCell = { MinimumHeight = 22f }
                };

                var cell = new PdfPCell(new Phrase("Stavke Računa"))
                {
                    Colspan = columnCount,
                    HorizontalAlignment = 1,
                    MinimumHeight = 30f
                };

                table.AddCell(cell);

                //headers

                dgvStavkeRacuna.Columns
                    .OfType<DataGridViewColumn>()
                    .ToList()
                    .ForEach(c => table.AddCell(c.Name));

                // rows

                dgvStavkeRacuna.Rows
                    .OfType<DataGridViewRow>()
                    .ToList()
                    .ForEach(r =>
                    {
                        var cells = r.Cells.OfType<DataGridViewCell>().ToList();
                        cells.ForEach(c => table.AddCell(c.Value.ToString()));
                    });


                decimal ukupnaCijena = 0;

                for(int i = 0; i < dgvStavkeRacuna.Rows.Count; ++i)
                {
                    ukupnaCijena += Convert.ToDecimal(dgvStavkeRacuna.Rows[i].Cells[5].Value);
                }
                

                var ukupno = new PdfPCell(new Phrase("Ukupna Cijena: " + 
                    ukupnaCijena))
                {
                    Colspan = columnCount,
                    HorizontalAlignment = 2,
                    MinimumHeight = 30f
                };

                table.AddCell(ukupno);


                var popust = new PdfPCell(new Phrase("Partner popust: " + partnerPopust.ToString() + "%"))
                {
                    Colspan = columnCount,
                    HorizontalAlignment = 2,
                    MinimumHeight = 30f
                };

                table.AddCell(popust);

                var konacnaCijena = ukupnaCijena - (ukupnaCijena * (partnerPopust / 100));
                konacnaCijena = Math.Round(konacnaCijena, 2, MidpointRounding.AwayFromZero);

                var cijenaKonacno = new PdfPCell(new Phrase("Konačna cijena: "
                    + konacnaCijena))
                {
                    Colspan = columnCount,
                    HorizontalAlignment = 2,
                    MinimumHeight = 30f
                };

                table.AddCell(cijenaKonacno);

                pdfDoc.Add(table);

                pdfDoc.Close();
                System.Diagnostics.Process.Start(path);
            }


            ExportToPdf();


        }
    }
}
