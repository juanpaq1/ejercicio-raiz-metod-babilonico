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
            Console.WriteLine("ESCRIBA EL NUMERO A BUSCAR LA RAIZ ");
            double num = double.Parse(Console.ReadLine());

            double x = num / 2.0;
            double tolerancia = 0.0000001;
            double new_num = x;
            int max_iter = 1000;

            for (int i = 0; i < max_iter; i++)
            {
                new_num = 0.5 * (x + num / x);

                if (Math.Abs(new_num - x) < tolerancia)
                {
                    break;
                }

                x = new_num; 
            }

            Console.WriteLine($"LA RAIZ CUADRADA DE {num} USANDO EL METODO BABILONICO ES {x}");
            Console.ReadKey();
        }
    }
}