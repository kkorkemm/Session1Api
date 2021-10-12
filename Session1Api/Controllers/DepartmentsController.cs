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
    using Models;

    public class DepartmentsController : ApiController
    {
        private KazanNeftSession1DBEntities db = new KazanNeftSession1DBEntities();

        // GET: api/Departments
        [ResponseType(typeof(List<Departments>))]
        public IHttpActionResult GetDepartments()
        {
            return Ok(db.Departments.ToList().ConvertAll(p => new DepartmentsModel(p)));
        }

        // GET: api/Departments/5
        [ResponseType(typeof(Departments))]
        public IHttpActionResult GetDepartments(long id)
        {
            Departments departments = db.Departments.Find(id);
            if (departments == null)
            {
                return NotFound();
            }

            return Ok(departments);
        }
    }
}