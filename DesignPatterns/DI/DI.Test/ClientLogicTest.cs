using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using DI.Data;
using DI.Data.Entities;
using DI.Logic;
using DI.Models;

namespace DI.Test
{
    [TestClass]
    public class ClientLogicTest
    {
        [TestMethod]
        public void ClientLogicGetAllShouldReturnClientViewModel()
        {
            // arrange
            var repository = new Mock<IClientRepository>();
            var clientLogic = new ClientLogic(repository.Object);

            repository.Setup(c => c.GetAll())
                .Returns(new List<Client>()
                {
                    new Client
                    {
                        Id = 1,
                        Name = "David",
                        Employees = new List<Employee>()
                        {
                            new Employee(),
                            new Employee()
                        },
                        ExternalEmployees = new List<Employee>()
                        {
                            new Employee(),
                            new Employee()
                        }
                    }
                });

            // act
            var result = clientLogic.GetAll();

            // assert
            Assert.AreEqual(typeof(List<ClientViewModel>), result.GetType());
            Assert.AreEqual(result.Count, 1);
            Assert.AreEqual(result.First().Name, "David");
            Assert.AreEqual(result.First().Id, 1);
            Assert.AreEqual(result.First().EmployeesCount, 4);
        }
    }
}
