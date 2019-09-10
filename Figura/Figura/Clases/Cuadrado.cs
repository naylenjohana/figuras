using System;
using System.Collections.Generic;
using System.Text;

namespace Figura
{
    public class Cuadrado: Figura 
    {
        public Cuadrado()
        {
            base.Punto1 = new Punto()
            {
                x1 = 4,
                y1 = 2,

            };
            base.Punto2 = new Punto()
            {
                x1 = 8,
                y1 = 3,

            };
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
