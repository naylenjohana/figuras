using System;
using System.Collections.Generic;
using System.Text;

namespace Figura
{
    public class Circulo : Figura
    {
       
        public Circulo()
        {
            base.Punto1 = new Punto() {
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
            return Math.PI * Math.Pow(base.Punto1.CalcularDistancia(Punto2),2);
        }
       

        public override double CalcularPerimetro()
        {
            return 2*Math.PI* base.Punto1.CalcularDistancia(Punto2);
        }        
    }
}
