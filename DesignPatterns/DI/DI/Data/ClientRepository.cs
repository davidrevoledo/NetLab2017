using System.Collections.Generic;
using System.Web;
using DI.Data.Entities;

namespace DI.Data
{
    public class ClientRepository : IClientRepository
    {
        public List<Client> GetAll()
        {
            return DataBase.Instance.Clients;
        }
    }
}