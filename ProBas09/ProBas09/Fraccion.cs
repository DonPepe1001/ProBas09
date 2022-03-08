using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProBas09
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fraccion A = new Fraccion();
            Fraccion B = new Fraccion("B", 4,2);
            Fraccion C = A * B;
            Fraccion D = A / B;
            Fraccion E = A + B;
            Fraccion F = A - B;

            C.NombreOperando = "A*B";
            D.NombreOperando = "A/B";
            E.NombreOperando = "A+B";
            F.NombreOperando = "A-B";

            Console.WriteLine(A.ToString());
            Console.WriteLine(B.ToString());
            Console.WriteLine(C.ToString());
            Console.WriteLine(D.ToString());
            Console.WriteLine(E.ToString());
            Console.WriteLine(F.ToString());
            Console.ReadLine();
        }
    }
}
            