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
            int opcion = 0;
            while (opcion != 5)
            {
                Console.WriteLine("Elige Operacion");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicacion");
                Console.WriteLine("4. Division");
                opcion = int.Parse(Console.ReadLine());
                Fraccion A = new Fraccion("A");
                Console.WriteLine("Escriba Numerador de A");
                A.Numerador = int.Parse(Console.ReadLine());
                A.Denominador = LeerDenominador("A");
                Fraccion B = new Fraccion("B");
                Console.WriteLine("Escriba Numerador de B");
                B.Numerador = int.Parse(Console.ReadLine());
                B.Denominador = LeerDenominador("B");
                Console.Clear();
                Console.WriteLine(A.ToString());
                Console.WriteLine(B.ToString());
                switch (opcion)
                {
                    case 1:
                        Fraccion C = A + B;
                        C.NombreOperando = "A + B";
                        Console.WriteLine(C.ToString());
                        break;
                    case 2:
                        Fraccion D = A - B;
                        D.NombreOperando = "A - B";
                        Console.WriteLine(D.ToString());
                        break;
                    case 3:
                        Fraccion E = A * B;
                        E.NombreOperando = "A * B";
                        Console.WriteLine(E.ToString());
                        break;
                    case 4:
                        Fraccion F = A / B;
                        F.NombreOperando = "A / B";
                        Console.WriteLine(F.ToString());
                        break;
                }
            }
        }
        public static int LeerDenominador(string operando)
        {
            int aux = 0;
            while (aux == 0)
            {
                Console.WriteLine($"Escriba denominador de {operando} diferente a 0");
                aux = int.Parse(Console.ReadLine());
            }
            return aux;
        }
    }
}
            