using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace UnitTestProject
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void ProbarSumaDebeDevolverNumerosSumados()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var suma = calculadora.Agregar(10, 60);

            //Assert
            Assert.IsInstanceOfType(suma, typeof(int));
            Assert.AreEqual(suma, 70);
        }

        [TestMethod]
        public void ProbarSumaEnterosDebeDevolverUnEntero()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var suma = calculadora.Agregar(10, 60);

            //Assert
            Assert.IsInstanceOfType(suma, typeof(int));
            Assert.IsTrue(suma > 0);
        }

        [TestMethod]
        public void ProbarSumaNegativosDebeDevolverNegativo()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var suma = calculadora.Agregar(-59, -1);

            //Assert
            Assert.IsInstanceOfType(suma, typeof(int));
            Assert.IsTrue(suma < 0);
        }
    }
}
