using System.Collections.Generic;
using DI.AspNetCore.Data.Entities;

namespace DI.AspNetCore.Data
{
    public class ClientRepository : IClientRepository
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