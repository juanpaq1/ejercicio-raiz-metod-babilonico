using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name;
            int age;
            
            Console.WriteLine("escriba su nombre: ");
            name = Console.ReadLine();
            Console.WriteLine($"hola : {name}");

            Console.WriteLine("::::::::::::::::::::::::::");

            Console.WriteLine("escriba su edad: ");
            age = int.Parse( Console.ReadLine() );
            Console.WriteLine($"su edad es : {age}");
           

            if ( age >= 18)
            {
                Console.WriteLine($"{name} es mayor de edad");

            }
            else
            {
                Console.WriteLine($"{name} es menor de edad");
            }
            Console.ReadKey();
        }
    }
}
