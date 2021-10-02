using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TrgovinaRacunalaAPI.BO;
using TrgovinaRacunalaAPI.Models;

namespace TrgovinaRacunalaAPI.Controllers
{
    public class ProizvodiController : ApiController
    {


        List<Proizvod> proizvodi = new List<Proizvod>();

        public ProizvodiController()
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                proizvodi = db.Proizvods.ToList<Proizvod>();
            }
        }
        public Object Get()
        {
            List<ProizvodFull> sviProizvodi = new List<ProizvodFull>();

            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                var result = (from cat in db.Kategorijas
                              join pro in db.Proizvods on cat.kategorijaId equals pro.kategorijaId
                              select new
                              {
                                  pro.proizvodId,
                                  cat.kategorijaId,
                                  kategorijaNaziv = cat.Naziv,
                                  kategorijaProizvodac = cat.Proizvodac,
                                  proizvodNaziv = pro.Naziv,
                                  proizvodCijena = pro.Cijena,
                                  proizvodGarancija = pro.Garancija
                              }).ToList();

                foreach (var elem in result)
                {
                    sviProizvodi.Add(new ProizvodFull
                    {
                        proizvodId = elem.proizvodId,
                        kategorijaId = elem.kategorijaId,
                        kategorijaNaziv = elem.kategorijaNaziv,
                        kategorijaProizvodac = elem.kategorijaProizvodac,
                        proizvodNaziv = elem.proizvodNaziv,
                        proizvodCijena = elem.proizvodCijena,
                        proizvodGarancija = elem.proizvodGarancija
                    });
                };
            }

            if (sviProizvodi.Count == 0)
                return NotFound();
            else
                return sviProizvodi;
        }
        public object Get(int id)
        {
            List<ProizvodFull> trazeniProizvod = new List<ProizvodFull>();

            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                var result = (from cat in db.Kategorijas
                              join pro in db.Proizvods on cat.kategorijaId equals pro.kategorijaId
                              where pro.proizvodId == id
                              select new
                              {
                                  pro.proizvodId,
                                  cat.kategorijaId,
                                  kategorijaNaziv=cat.Naziv,
                                  kategorijaProizvodac=cat.Proizvodac,
                                  proizvodNaziv= pro.Naziv,
                                  proizvodCijena=pro.Cijena,
                                  proizvodGarancija =pro.Garancija
                              }).ToList();

                foreach (var elem in result)
                {
                    trazeniProizvod.Add(new ProizvodFull
                    {
                        proizvodId = elem.proizvodId,
                        kategorijaId = elem.kategorijaId,
                        kategorijaNaziv = elem.kategorijaNaziv,
                        kategorijaProizvodac = elem.kategorijaProizvodac,
                        proizvodNaziv = elem.proizvodNaziv,
                        proizvodCijena = elem.proizvodCijena,
                        proizvodGarancija = elem.proizvodGarancija
                    });
                };
            }

            if (trazeniProizvod.Count == 0)
                return NotFound();
            else
                return trazeniProizvod;
        }
        public Object Post(Proizvod proizvod)
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                try
                {
                    var result = (from row in db.Proizvods where row.Naziv == proizvod.Naziv
                                  && row.kategorijaId == proizvod.kategorijaId select row).ToList();

                    if(result.Count!=0)
                        return StatusCode((HttpStatusCode)409);

                    db.Proizvods.Add(proizvod);
                    db.SaveChanges();
                    return StatusCode((HttpStatusCode)201);
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException x)
                {
                    return x.Message;
                }
            }
        }
        public Object Put(int id, Proizvod proizvod)
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                try
                {
                    var result = (from row in db.Proizvods where row.proizvodId == id select row).ToList();

                    if (result.Count == 0)
                        return NotFound();

                    var result2 = (from row in db.Proizvods
                                   where row.Naziv == proizvod.Naziv
                                    && row.kategorijaId == proizvod.kategorijaId
                                    && row.proizvodId == proizvod.proizvodId
                                   select row).ToList();
                    if (result2.Count != 0)
                        return StatusCode((HttpStatusCode)409);

                    var query = from Proizvod in db.Proizvods where Proizvod.proizvodId == id select Proizvod;

                    foreach (Proizvod pro in query)
                    {
                        pro.kategorijaId = proizvod.kategorijaId;
                        pro.Cijena = proizvod.Cijena;
                        pro.Naziv = proizvod.Naziv;
                        pro.Garancija = proizvod.Garancija;
                    }

                    db.SaveChanges();
                    return StatusCode((HttpStatusCode)204);
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException x)
                {
                    return x.Message;
                }
            }
        }
        public Object Delete(int id)
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                try
                {
                    Proizvod proizvod = proizvodi.Where(x => x.proizvodId == id).FirstOrDefault();

                    if (proizvod == null)
                        return NotFound();
                    else
                    {
                        db.Proizvods.Attach(proizvod);
                        db.Proizvods.Remove(proizvod);
                        db.SaveChanges();
                        return StatusCode((HttpStatusCode)204);
                    }
                }
                catch (System.ArgumentNullException e)
                {
                    return e.Message;
                }
            }
        }

        [Route("api/proizvodi/GetProizvodi")]
        public Dictionary<int, string> GetProizvodi()
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                var sviProizvodi = new List<Proizvod>();
                sviProizvodi = db.Proizvods.ToList();

                var proizvodi = new Dictionary<int, string>();

                foreach (var proizvod in sviProizvodi)
                {
                    proizvodi.Add(proizvod.proizvodId, proizvod.Naziv);
                }
                return proizvodi;
            }
        }


        [Route("api/proizvodi/GetProKat/{id:int}/")]
        public Dictionary<int, string> GetProKat(int id)
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                var sviProizvodi = new List<Proizvod>();
                sviProizvodi = db.Proizvods.ToList();

                var proizvodi = new Dictionary<int, string>();

                var query = (from row in db.Proizvods where row.kategorijaId == id select row).ToList();

                foreach (Proizvod pro in query)
                {
                    proizvodi.Add(pro.proizvodId, pro.Naziv);
                }

                return proizvodi;
            }
        }

        [Route("api/proizvodi/GetCijena")]

        public Dictionary<string, decimal> GetCijena()
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                var sviProizvodi = new List<Proizvod>();
                sviProizvodi = db.Proizvods.ToList();

                var proizvodi = new Dictionary<string, decimal>();

                foreach(var proizvod in sviProizvodi)
                {
                    proizvodi.Add(proizvod.Naziv, proizvod.Cijena);
                }

                return proizvodi;
            }
        }

        [Route("api/proizvodi/GetId")]
        public Dictionary<string, int> GetId()
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                var sviProizvodi = new List<Proizvod>();
                sviProizvodi = db.Proizvods.ToList();

                var proizvodi = new Dictionary<string, int>();

                foreach (var proizvod in sviProizvodi)
                {
                    proizvodi.Add(proizvod.Naziv, proizvod.proizvodId);
                }

                return proizvodi;
            }
        }
    }
}
