using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;
            int c = 7;
            int Perimetro = (a + b + c);

            Console.WriteLine("El valor del perímetro del triángulo es: " + Perimetro);
            Console.WriteLine("\nPresiona una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
