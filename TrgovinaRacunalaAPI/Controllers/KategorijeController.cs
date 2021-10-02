using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TrgovinaRacunalaAPI.BO;

namespace TrgovinaRacunalaAPI.Controllers
{
    public class KategorijeController : ApiController
    {
        public List<KategorijaBO> Get()
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                var sveKategorije = new List<Kategorija>();
                sveKategorije = db.Kategorijas.ToList<Kategorija>();
                var katList = new List<KategorijaBO>();

                foreach(var kategorija in sveKategorije)
                {
                    var kat = new KategorijaBO();
                    kat.kategorijaId = kategorija.kategorijaId;
                    kat.kategorijaNaziv = kategorija.Naziv;
                    kat.kategorijaProizvodac = kategorija.Proizvodac;

                    katList.Add(kat);
                }
                return katList;
            }
        }
        public object Get(int id)
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                var sveKategorije = new List<Kategorija>();
                sveKategorije = db.Kategorijas.ToList<Kategorija>();
                Kategorija kategorija = sveKategorije.Where(x => x.kategorijaId == id).FirstOrDefault();

                if (kategorija == null)
                    return NotFound();

                var kat = new KategorijaBO();

                kat.kategorijaId = kategorija.kategorijaId;
                kat.kategorijaNaziv = kategorija.Naziv;
                kat.kategorijaProizvodac = kategorija.Proizvodac;

                return kat;
            }
        }
        public object Post(Kategorija kategorija)
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                try
                {
                    var result = (from row in db.Kategorijas
                                  where row.Naziv == kategorija.Naziv
                                  && row.Proizvodac == kategorija.Proizvodac
                                  select row).ToList();

                    if (result.Count != 0)
                    {
                        return StatusCode((HttpStatusCode)409);
                    }

                    db.Kategorijas.Add(kategorija);
                    db.SaveChanges();
                    return StatusCode((HttpStatusCode)201);
                }
                catch (DbEntityValidationException x)
                {
                    return x.Message;
                }
            }
        }
        public object Put(int id, Kategorija kategorija)
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                try
                {
                    var result = (from row in db.Kategorijas where row.kategorijaId == id select row).ToList();
                    if (result.Count == 0)
                    {
                        return NotFound();
                    }

                    var result2 = (from row in db.Kategorijas
                                   where row.Naziv == kategorija.Naziv
                                    && row.Proizvodac == kategorija.Proizvodac
                                   select row).ToList();

                    if (result2.Count != 0)
                        return StatusCode((HttpStatusCode)409);

                    var query = from Kategorija in db.Kategorijas where Kategorija.kategorijaId == id select Kategorija;
                    foreach (Kategorija kat in query)
                    {
                        kat.Naziv = kategorija.Naziv;
                        kat.Proizvodac = kategorija.Proizvodac;
                    }

                    db.SaveChanges();
                    return StatusCode((HttpStatusCode)204);
                }
                catch (DbEntityValidationException x)
                {
                    return x.Message;
                }
            }
        }
        public object Delete(int id)
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                var sveKategorije = new List<Kategorija>();
                sveKategorije = db.Kategorijas.ToList<Kategorija>();

                try
                {
                    Kategorija kategorija = sveKategorije.Where(x => x.kategorijaId == id).FirstOrDefault();
                    if (kategorija == null)
                        return NotFound();
                    else
                    {
                        db.Kategorijas.Attach(kategorija);
                        db.Kategorijas.Remove(kategorija);
                        db.SaveChanges();
                        return StatusCode((HttpStatusCode)204);
                    }
                }
                catch (ArgumentNullException e)
                {
                    return e.Message;
                }
            }
        }

        [Route("api/kategorije/GetFullName/")]
        public Dictionary<int,string> GetFullName()
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                var sveKategorije = new List<Kategorija>();
                sveKategorije = db.Kategorijas.ToList<Kategorija>();

                var kategorije = new Dictionary<int, string>();

                foreach (var kategorija in sveKategorije)
                {
                    kategorije.Add(kategorija.kategorijaId,kategorija.Naziv + " " + kategorija.Proizvodac);
                }
                return kategorije;
            }
        }
    }
}
