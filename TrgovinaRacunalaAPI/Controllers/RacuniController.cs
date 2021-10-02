using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrgovinaRacunalaAPI.BO;

namespace TrgovinaRacunalaAPI.Controllers
{
    public class RacuniController : ApiController
    {
        public object Get()
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                var sviRacuni = new List<Racun>();
                sviRacuni = db.Racuns.ToList();

                var racList = new List<RacunBO>();

                foreach (var racun in sviRacuni)
                {
                    var rac = new RacunBO();

                    rac.racunId = racun.racunId;
                    rac.partnerId = racun.partnerId;
                    rac.datum = racun.datum;
                    rac.brojRacuna = racun.brojRacuna;

                    racList.Add(rac);
                }
                return racList;
            }
        }
     
        public object Get(int id)
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                var sviRacuni = new List<Racun>();
                sviRacuni = db.Racuns.ToList<Racun>();
                Racun racun = sviRacuni.Where(x => x.racunId == id).FirstOrDefault();

                if (racun == null)
                    return NotFound();

                var rac = new RacunBO();

                rac.racunId = racun.racunId;
                rac.partnerId = racun.partnerId;
                rac.brojRacuna = racun.brojRacuna;
                rac.datum = racun.datum;

                return rac;
            }
        }

        public object Post(Racun racun)
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                try
                {
                    var result = (from row in db.Racuns where row.brojRacuna == racun.brojRacuna select row).ToList();

                    if(result.Count!=0)
                    {
                        return StatusCode((HttpStatusCode)409);
                    }

                    db.Racuns.Add(racun);
                    db.SaveChanges();
                    return StatusCode((HttpStatusCode)201);
                }
                catch (DbEntityValidationException x)
                {
                    return x.Message;
                }
            }

        }

        public object Put(int id, Racun racun)
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                var result = (from row in db.Racuns where row.racunId == id select row).ToList();
                if (result.Count == 0)
                {
                    return NotFound();
                }
                var result2 = (from row in db.Racuns where row.brojRacuna == racun.brojRacuna select row).ToList();

                if (result2.Count != 0)
                {
                    return StatusCode((HttpStatusCode)409);
                }

                var query = from Racun in db.Racuns where Racun.racunId == id select Racun;
                foreach(Racun rac in query)
                {
                    rac.partnerId = racun.partnerId;
                    rac.datum = racun.datum;
                    rac.brojRacuna = racun.brojRacuna;
                }

                db.SaveChanges();
                return StatusCode((HttpStatusCode)204);
            }
        }

        public object Delete(int id)
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                var sviRacuni = new List<Racun>();
                sviRacuni = db.Racuns.ToList();

                try
                {
                    Racun racun = sviRacuni.Where(x => x.racunId == id).FirstOrDefault();
                    if (racun == null)
                        return NotFound();
                    else
                    {
                        db.Racuns.Attach(racun);
                        db.Racuns.Remove(racun);
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


        [Route("api/racuni/PretragaBroj/{brojRacun}/")]
        [System.Web.Http.HttpGet]
        [System.Web.Http.AcceptVerbs("GET", "POST")]
        public object PretragaBroj(string brojRacun)
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                var sviRacuni = new List<Racun>();
                sviRacuni = db.Racuns.ToList<Racun>();
                var racun = sviRacuni.Where(x => x.brojRacuna.Contains(brojRacun)).ToList();

                var racList = new List<RacunBO>();

                foreach (var Racun in racun)
                {
                    var rac = new RacunBO();

                    rac.racunId = Racun.racunId;
                    rac.partnerId = Racun.partnerId;
                    rac.datum = Racun.datum;
                    rac.brojRacuna = Racun.brojRacuna;

                    racList.Add(rac);
                }
                return racList;
            }
        }
    }
}
