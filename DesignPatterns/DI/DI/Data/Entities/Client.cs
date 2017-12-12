using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DI.Data.Entities
{
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public List<Employee> Employees { get; set; }

        public List<Employee> ExternalEmployees { get; set; }
    }
}