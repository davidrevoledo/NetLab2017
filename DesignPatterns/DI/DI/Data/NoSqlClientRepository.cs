using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DI.Data.Entities;

namespace DI.Data
{
    public class NoSqlClientRepository : IClientRepository
    {
        public List<Client> GetAll()
        {
            return new List<Client>()
            {
                new Client(),
                new Client()
            };
        }
    }
}