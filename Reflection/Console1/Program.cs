using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            //// properties
            ////var type = person.GetType(); //  typeof(Person)
            ////var value = type.GetProperty("Surname").GetValue(person);

            //var dynamicType = Assembly.GetExecutingAssembly().GetTypes()
            //                                 .First(c => c.Name == "Student");

            //// creating instances
            //var person = Activator.CreateInstance(dynamicType);


            //var property  =person.GetType().GetProperty("Name");
            
            //property.SetValue(person, "David");

            //var dynamicValue = property.GetValue(person);

            var persona = new Person
            {
                Name = "David",
                Surname = "Revoledo"
            };
            
            var std = new Student();

            //var studentType = std.GetType();
            //var pType = persona.GetType();
            //foreach (var prop in pType.GetProperties())
            //{
            //   var getProperty = pType.GetProperty(prop.Name);

            //    studentType.GetProperty(prop.Name)
            //               .SetValue(std, getProperty.GetValue(persona));
            //}


            var method = typeof(Person).GetMethod("Caminar");

            method.Invoke(persona, new []{ "Playa"});


            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
