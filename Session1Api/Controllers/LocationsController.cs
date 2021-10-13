using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Session1Api.Base;

namespace Session1Api.Controllers
{
    public class LocationsController : ApiController
    {
        private KazanNeftSession1DBEntities db = new KazanNeftSession1DBEntities();

        // GET: api/Locations
        [ResponseType(typeof(List<Locations>))]
        public IHttpActionResult GetLocations()
        {
            return Ok(db.Locations);
        }

        // GET: api/Locations/5
        [ResponseType(typeof(Locations))]
        public IHttpActionResult GetLocations(long id)
        {
            Locations locations = db.Locations.Find(id);
            if (locations == null)
            {
                return NotFound();
            }

            return Ok(locations);
        }
    }
}