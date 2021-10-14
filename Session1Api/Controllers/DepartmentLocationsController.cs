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
    public class DepartmentLocationsController : ApiController
    {
        private KazanNeftSession1DBEntities db = new KazanNeftSession1DBEntities();

        // GET: api/DepartmentLocations
        [ResponseType(typeof(List<DepartmentLocations>))]
        public IHttpActionResult GetDepartmentLocations()
        {
            return Ok(db.DepartmentLocations);
        }

        // GET: api/DepartmentLocations/5
        [ResponseType(typeof(DepartmentLocations))]
        public IHttpActionResult GetDepartmentLocations(long id)
        {
            DepartmentLocations departmentLocations = db.DepartmentLocations.Find(id);
            if (departmentLocations == null)
            {
                return NotFound();
            }

            return Ok(departmentLocations);
        }

        // POST: api/Assets
        [ResponseType(typeof(DepartmentLocations))]
        public IHttpActionResult PostAssets(DepartmentLocations departmentLocations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.DepartmentLocations.Add(departmentLocations);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = departmentLocations.ID }, departmentLocations);
        }
    }
}