using System.Collections.Generic;
using DI.AspNetCore.Data.Entities;

namespace DI.AspNetCore.Data
{
    public interface IClientRepository
    {
        List<Client> GetAll();
    }
}