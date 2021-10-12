using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Session1Api.Models
{
    using Base;

    public class DepartmentsModel
    {
        public DepartmentsModel(Departments departments)
        {
            ID = departments.ID;
            Name = departments.Name;
        }

        public long ID { get; set; }
        public string Name { get; set; }
    }
}