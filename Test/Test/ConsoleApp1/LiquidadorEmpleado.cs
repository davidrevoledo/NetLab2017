using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LiquidadorEmpleado : ILiquidadorEmpleado
    {
        public decimal Liquidar(decimal salario)
        {
            return salario + 1000;
        }
    }


    public class LiquidadorEmpleadoUruguay : ILiquidadorEmpleado
    {
        public decimal Liquidar(decimal salario)
        {
            return salario * 2;
        }
    }

    public interface ILiquidadorEmpleado
    {
        decimal Liquidar(decimal salario);
    }
}
