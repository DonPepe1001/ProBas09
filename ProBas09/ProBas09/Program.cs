using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProBas08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraccion A = new Fraccion(1, 2);
            Fraccion B = new Fraccion(3, 4);
            Fraccion C = new Fraccion();
            Console.WriteLine($"A:{A.imprimir()}");
            Console.WriteLine($"B:{B.imprimir()}");
            C = A.multiplica(C);
            Console.WriteLine($"La multiplicación de A*B es:{C}");
            Console.WriteLine($"Multiplicación de A*B:{A.multiplica(B).imprimir()}");
            Console.ReadLine();
        }
    }
}