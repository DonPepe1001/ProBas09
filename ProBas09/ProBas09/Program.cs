using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProBas09
{
    public class Fraccion
    {
        #region propiedades
        public string NombreOperando { get; set; }
        public int Numerador { get; set; }
        public int Denominador { get; set; }
        #endregion

        #region Métodos
        public Fraccion()
        {
            this.NombreOperando = "A";
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
            return $"{this.NombreOperando} = {this.Numerador}/{this.Denominador}";
        }
        #endregion

    }
}