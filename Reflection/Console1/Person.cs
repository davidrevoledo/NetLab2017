using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void Saldudar()
        {   
            Console.WriteLine("Hola soy una persona");
        }

        public void Caminar(string p)
        {
            Console.WriteLine("Estoy caminando en la" + p);
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void Saldudar()
        {
            Console.WriteLine("Hola soy una un estudiante");
        }

        public void Caminar()
        {
            Console.WriteLine("Estoy caminando");
        }
    }
}
