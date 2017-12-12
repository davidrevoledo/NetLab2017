using System.Collections.Generic;
using DI.Models;

namespace DI.Logic
{
    public interface IClientLogic
    {
        List<ClientViewModel> GetAll();
    }
}