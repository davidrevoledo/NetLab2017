using System.Collections.Generic;
using DI.Data.Entities;

namespace DI.Data
{
    public interface IClientRepository
    {
        List<Client> GetAll();
    }
}