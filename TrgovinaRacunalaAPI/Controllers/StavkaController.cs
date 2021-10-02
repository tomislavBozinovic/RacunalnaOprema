using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrgovinaRacunalaAPI.BO;
using TrgovinaRacunalaAPI.Models;

namespace TrgovinaRacunalaAPI.Controllers
{
    public class StavkaController : ApiController
    {
        public object Get()
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                List<StavkaFull> sveStavke = new List<StavkaFull>();

                var result = (from rac in db.Racuns
                              join sta in db.StavkaRacunas on rac.racunId equals sta.racunId
                              join pro in db.Proizvods on sta.proizvodId equals pro.proizvodId
                              select new
                              {
                                  rac.racunId,
                                  pro.Naziv,
                                  sta.kolicina,
                                  sta.cijena
                              }).ToList();

                foreach (var elem in result)
                {
                    sveStavke.Add(new StavkaFull
                    {
                        racunId = elem.racunId,
                        naziv = elem.Naziv,
                        kolicina = elem.kolicina,
                        cijena = elem.cijena

                    });
                };

                return sveStavke;
            }
        }

        public object Get(int id)
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                List<StavkaFull> sveStavke = new List<StavkaFull>();

                var result = (from rac in db.Racuns
                              join sta in db.StavkaRacunas on rac.racunId equals sta.racunId
                              join pro in db.Proizvods on sta.proizvodId equals pro.proizvodId
                              join kat in db.Kategorijas on pro.kategorijaId equals kat.kategorijaId
                              where sta.racunId == id
                              select new
                              {
                                  rac.racunId,
                                  pro.Naziv,
                                  kat.Proizvodac,
                                  kategorijaNaziv = kat.Naziv,
                                  sta.kolicina,
                                  sta.cijena
                              }).ToList();

                foreach (var elem in result)
                {
                    sveStavke.Add(new StavkaFull
                    {
                        racunId = elem.racunId,
                        kategorijaProizvodac = elem.Proizvodac,
                        kategorijaIme = elem.kategorijaNaziv,
                        naziv = elem.Naziv,
                        kolicina = elem.kolicina,
                        cijena = elem.cijena

                    });
                };

                return sveStavke;
            }
        }

        // POST: api/Stavka
        public object Post(StavkaRacuna stavka)
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                List<StavkaRacuna> sveStavke = new List<StavkaRacuna>();
                sveStavke = db.StavkaRacunas.ToList();

                try
                {
                    var result = (from row in db.StavkaRacunas where row.proizvodId == stavka.proizvodId
                                  && row.racunId == stavka.racunId select row).ToList();

                    if(result.Count!=0)
                    {
                        return StatusCode((HttpStatusCode)409);
                    }

                    db.StavkaRacunas.Add(stavka);
                    db.SaveChanges();
                    return StatusCode((HttpStatusCode)201);
                }
                catch (DbEntityValidationException x)
                {
                    return x.Message;
                }
            }
        }

        // PUT: api/Stavka/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Stavka/5
        public void Delete(int id)
        {
        }
    }
}
