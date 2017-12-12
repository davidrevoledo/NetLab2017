using System.Collections.Generic;

namespace DI.AspNetCore.Data.Entities
{
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Employee> Employees { get; set; }
    }
}