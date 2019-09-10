using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras
{
    public class Cuadrado: Figura 
    {
        public Cuadrado(IPunto punto1, IPunto punto2)
        {
            base.Punto1 = punto1;
            base.Punto2 = punto2;          
        }
        public override double CalcularArea()
        {
            return Math.Pow(base.Punto1.CalcularDistancia(Punto2),2);
        }

        public override double CalcularPerimetro()
        {
            return 4 * base.Punto1.CalcularDistancia(Punto2);
        }
    }
}
