using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SuperClase
    {
        private readonly ILiquidadorEmpleado liquidadorEmpleado;

        public SuperClase(ILiquidadorEmpleado liquidadorEmpleado)
        {
            this.liquidadorEmpleado = liquidadorEmpleado;
        }

        public decimal SuperOperacion(decimal salario)
        {
            // 1 
            // 2
            // 3

            salario = this.liquidadorEmpleado.Liquidar(salario);

            salario = salario - 1; //

            // 4
            // 5
            // 6

            return salario * 0.78m;
        }
    }
}
