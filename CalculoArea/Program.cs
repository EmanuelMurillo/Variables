using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoArea
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;
            int Area = (a * b / 2);

            Console.WriteLine("El área del triángulo es: " + Area);
            Console.WriteLine("\nPresiona una tecla para finalizar");
            Console.ReadKey();
        }
    }
}
