using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrgovinaRacunalaAPI.BO;

namespace TrgovinaRacunalaAPI.Controllers
{
    public class PartneriController : ApiController
    {
        public List<PartneriBO> Get()
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                var sviPartneri = new List<Partneri>();
                sviPartneri = db.Partneris.ToList<Partneri>();

                var partList = new List<PartneriBO>();

                foreach (var partner in sviPartneri)
                {
                    var part = new PartneriBO();
                    part.partnerId = partner.partnerId;
                    part.partnerNaziv = partner.Naziv;
                    part.partnerPopust = partner.Popust;

                    partList.Add(part);

                }

                return partList;
            }
        }
        public object Get(int id)
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                List<Partneri> sviPartneri = new List<Partneri>();
                sviPartneri = db.Partneris.ToList<Partneri>();

                var partner = sviPartneri.Where(x => x.partnerId == id).FirstOrDefault();

                if (partner == null)
                {
                    return NotFound();
                }

                var part = new PartneriBO();

                part.partnerId = partner.partnerId;
                part.partnerNaziv = partner.Naziv;
                part.partnerPopust = partner.Popust;

                return part;
            }
        }
        public object Post(Partneri partner)
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                List<Partneri> sviPartneri = new List<Partneri>();
                sviPartneri = db.Partneris.ToList<Partneri>();

                try
                {
                    var result = (from row in db.Partneris where row.Naziv == partner.Naziv select row).ToList();

                    if (result.Count != 0)
                    {
                        return StatusCode((HttpStatusCode)409);
                    }

                    db.Partneris.Add(partner);
                    db.SaveChanges();

                    return StatusCode((HttpStatusCode)201);
                }
                catch (System.Data.Entity.Validation.DbEntityValidationException x)
                {
                    return x.Message;
                }
            }
        }
        public object Put(int id, Partneri partner)
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                try
                {
                    var result = (from row in db.Partneris where row.partnerId == id select row).ToList();
                    if (result.Count == 0)
                    {
                        return NotFound();
                    }

                    var result2 = (from row in db.Partneris
                                   where row.Naziv == partner.Naziv
          && row.Popust == partner.Popust
                                   select row).ToList();

                    if (result2.Count != 0)
                    {
                        return StatusCode((HttpStatusCode)409);
                    }

                    var query = from partneri in db.Partneris where partneri.partnerId == id select partneri;

                    foreach (Partneri par in query)
                    {
                        par.Naziv = partner.Naziv;
                        par.Popust = partner.Popust;
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
        public object Delete(int id)
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                List<Partneri> sviPartneri = new List<Partneri>();
                sviPartneri = db.Partneris.ToList<Partneri>();

                try
                {
                    Partneri partner = sviPartneri.Where(x => x.partnerId == id).FirstOrDefault();

                    if (partner == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        db.Partneris.Attach(partner);
                        db.Partneris.Remove(partner);
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

        [Route("api/partneri/GetPartnerName")]
        public Dictionary<int, string> GetPartnerName()
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                var sviPartneri = new List<Partneri>();
                sviPartneri = db.Partneris.ToList<Partneri>();

                var partneri = new Dictionary<int, string>();

                foreach (var partner in sviPartneri)
                {
                    partneri.Add(partner.partnerId, partner.Naziv);
                }
                return partneri;
            }
        }

        [Route("api/partneri/GetPopust")]
        public Dictionary<int,decimal> GetPopust()
        {
            using (TrgovinaProjektEntities db = new TrgovinaProjektEntities())
            {
                var sviPartneri = new List<Partneri>();
                sviPartneri = db.Partneris.ToList<Partneri>();

                var partneri = new Dictionary<int, decimal>();

                foreach (var partner in sviPartneri)
                {
                    partneri.Add(partner.partnerId, partner.Popust);
                }
                return partneri;
            }
        }
    }
}