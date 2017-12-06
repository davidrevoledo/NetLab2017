using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnitTestProject.Fakes;

namespace UnitTestProject
{
    [TestClass]
    public class SuperClaseTest
    {
        [TestMethod]
        public void SuperClaseSuperOperacionDebeRetornarElSalario()
        {
            //Arrange
            var liquidador = new Mock<ILiquidadorEmpleado>();

            liquidador.Setup(c => c.Liquidar(It.IsAny<decimal>()))
                .Returns(1000);

            var superClase = new SuperClase(liquidador.Object);

            //Act
            var salario = superClase.SuperOperacion(1000);

            //Assert
            Assert.IsInstanceOfType(salario, typeof(decimal));
            Assert.AreEqual(salario, 999 * 0.78m);
            liquidador.Verify(c=> c.Liquidar(1000));
        }
    }
}
