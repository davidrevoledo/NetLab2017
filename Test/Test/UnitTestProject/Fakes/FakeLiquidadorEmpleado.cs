using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject.Fakes
{
    public class FakeLiquidadorEmpleado : ILiquidadorEmpleado
    {
        public decimal Liquidar(decimal salario)
        {
            return salario;
        }
    }
}
