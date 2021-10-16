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

    public class EmployeesController : ApiController
    {
        private KazanNeftSession1DBEntities db = new KazanNeftSession1DBEntities();

        // GET: api/Employees
        [ResponseType(typeof(List<Employees>))]
        public IHttpActionResult GetEmployees()
        {
            return Ok(db.Employees.ToList().ConvertAll(p => new EmployeeModel(p)));
        }

        // GET: api/Employees/5
        [ResponseType(typeof(Employees))]
        public IHttpActionResult GetEmployees(long id)
        {
            Employees employees = db.Employees.Find(id);
            if (employees == null)
            {
                return NotFound();
            }

            return Ok(new EmployeeModel(employees));
        }
    }
}