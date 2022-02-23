using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enteros
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero_1 = 20;
            int Numero_2 = 50;
            int Numero_3 = 70;

            int Suma = (Numero_1 + Numero_2 + Numero_3);

            Console.WriteLine("El valor de suma es: " + Suma);
            Console.WriteLine("\nPresiona una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
