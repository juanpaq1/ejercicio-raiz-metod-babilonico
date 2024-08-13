using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = 0, Raiz, aux;
            Console.WriteLine("ESCRIBA EL NUMERO A BUSCAR LA RAIZ");
            number = double.Parse(Console.ReadLine());

            do
            {
                    Console.WriteLine("ERROR, EL NUMERO DEBE SER MAYOR A CERO");
                    number = double.Parse(Console.ReadLine()) ;
                
            }
            while (number < 0);

            aux = Math.Round(Math.Sqrt(number));
            
            Raiz = (number + (aux* aux))/(2*aux);
            Console.WriteLine($"LA RAIZ CUADRADA DE {number} por el metodo babilonico es: {Raiz}");

            Console.ReadKey();

        }
    }
}
