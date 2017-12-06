using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var liquidador = new LiquidadorEmpleado();
            var liquidadorU = new LiquidadorEmpleadoUruguay();

            var superclase = new SuperClase(liquidador);
            var superclaseU = new SuperClase(liquidadorU);

            var resultado = superclase.SuperOperacion(1000);

            Console.WriteLine(resultado);
            Console.ReadLine();
        }
    }
}