using System.Collections.Generic;
using System.Linq;
using DI.AspNetCore.Data;
using DI.AspNetCore.Models;

namespace DI.AspNetCore.Logic
{
    public class ClientLogic : IClientLogic
    {
        private readonly IClientRepository clientRepository;

        public ClientLogic(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        public List<ClientViewModel> GetAll()
        {
            return clientRepository.GetAll()
                .Select(c => new ClientViewModel
                    {
                        Id = c.Id,
                        Name = c.Name,
                        EmployeesCount = c.Employees.Count
                    }
                ).ToList();
        }
    }
}