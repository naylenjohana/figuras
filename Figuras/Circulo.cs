using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras
{
    public class Circulo : Figura
    {
        public Circulo(IPunto punto1,IPunto punto2)
        {
            base.Punto1 = punto1;
            base.Punto2 = punto2;
        }
        /// <summary>
        /// Calcula el Area de un Circulo
        /// </summary>
        /// <returns></returns>
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(base.Punto1.CalcularDistancia(Punto2),2);
        }
        public override double CalcularPerimetro()
        {
            return 2*Math.PI* base.Punto1.CalcularDistancia(Punto2);
        }        
    }
}
