using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProBas08
{
    public class Fraccion
    {
        #region propiedades
        public int Numerador { get; set; }
        public int Denominador { get; set; }
        #endregion
        #region métodos
        public Fraccion()
        {
            this.Numerador = 0;
            this.Denominador = 1;

        }
        public Fraccion(int numerador, int denominador)
        {
            this.Numerador = numerador;
            this.Denominador = denominador;
        }
        public Fraccion multiplica(Fraccion value)
        {
            return new Fraccion(this.Numerador * value.Numerador, this.Denominador * value.Denominador);
        }
        public string imprimir()
        {
            return $"{this.Numerador}/{this.Denominador}";
        }
        #endregion

    }
}