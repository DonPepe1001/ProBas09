using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProBas09
{
    public class Fraccion
    {
        public string NombreOperando { get; set; }
        public int Numerador { get; set; }
        public int Denominador { get; set; }
        public Fraccion()
        {
            this.NombreOperando = "a";
            this.Numerador = 3;
            this.Denominador = 6;
        }
        public Fraccion(int numerador, int denominador)
        {
            this.NombreOperando = "A";
            this.Numerador = numerador;
            this.Denominador = denominador;
        }
        public Fraccion(string nombreOperador, int numerador, int denominador)
        {
            this.NombreOperando = nombreOperador;
            this.Numerador = numerador;
            this.Denominador = denominador;
        }
        public Fraccion(string NombreOperando)
        {
            this.NombreOperando = NombreOperando;
        }
        public static Fraccion operator *(Fraccion A, Fraccion B)
        {
            return new Fraccion(A.Numerador * B.Numerador, A.Denominador * B.Denominador);
        }
        public static Fraccion operator /(Fraccion A, Fraccion B)
        {
            return new Fraccion(A.Numerador * B.Denominador, A.Denominador * B.Numerador);
        }
        public static Fraccion operator +(Fraccion A, Fraccion B)
        {
            return new Fraccion(A.Numerador * B.Denominador + A.Denominador * B.Numerador, A.Denominador * B.Denominador);
        }
        public static Fraccion operator -(Fraccion A, Fraccion B)
        {
            return new Fraccion(A.Numerador * B.Denominador - A.Denominador * B.Numerador, A.Denominador * B.Denominador);
        }
        public override string ToString()
        {
            this.simplificar();
            return $"{this.NombreOperando} = {this.Numerador} / {this.Denominador}";
        }
        public void simplificar()
        {
            int num = this.Numerador;
            int den = this.Denominador;
            int mcd = 0;
            MCD(ref num, ref den, ref mcd);
        }
        static void MCD(ref int num, ref int den, ref int mcd)
        {
            for (int x = 1; x <= den; x++)
            {
                if ((num % x == 0) && (den % x == 0))
                    mcd = x;
            }
            if (mcd == 0)
            {
                return;
            }
            else
            {
                num = num / mcd;
                den = den / mcd;
            }
        }
    }
}