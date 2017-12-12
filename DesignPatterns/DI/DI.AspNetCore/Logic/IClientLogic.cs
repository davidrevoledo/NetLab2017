using System.Collections.Generic;
using DI.AspNetCore.Models;

namespace DI.AspNetCore.Logic
{
    public interface IClientLogic
    {
        List<ClientViewModel> GetAll();
    }
}