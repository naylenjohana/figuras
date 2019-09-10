using System;
using System.Collections.Generic;
using System.Text;

namespace Figura
{
    public class Rectangulo : Figura
    {
        private Punto punto3;
        private double ladoA;
        private double ladoB;
        public Rectangulo()
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

            CalcularVariables();
        }
        
        public override double CalcularArea()
        {
           return ladoA * ladoB;
        }

        public override double CalcularPerimetro()
        {
            return 2 * ladoA + 2 * ladoB;
        }

        private void CalcularVariables()
        {
            punto3 = new Punto() { x1 = base.Punto1.x1, y1 = base.Punto2.y1 };
            ladoA = base.Punto1.CalcularDistancia(punto3);
            ladoB = base.Punto2.CalcularDistancia(punto3);
        }
    }
}
