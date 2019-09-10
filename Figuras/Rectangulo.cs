using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras
{
    public class Rectangulo : Figura
    {
        private IPunto _punto3;
        private double ladoA;
        private double ladoB;
        public Rectangulo(IPunto punto1, IPunto punto2, IPunto punto3)
        {
            base.Punto1 = punto1;
            base.Punto2 = punto2;
            _punto3 = punto3;
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
            _punto3 = new Punto() { x1 = base.Punto1.x1, y1 = base.Punto2.y1 };
            ladoA = base.Punto1.CalcularDistancia(_punto3);
            ladoB = base.Punto2.CalcularDistancia(_punto3);
        }
    }
}
