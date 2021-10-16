using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session1Api.Models
{
    using Base;

    public class EmployeeModel
    {
        public EmployeeModel(Employees employee)
        {
            ID = employee.ID;
            Name = employee.FirstName + " " + employee.LastName;
        }

        public long ID { get; set; }
        public string Name { get; set; }

    }
}