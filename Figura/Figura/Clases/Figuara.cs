using System;
using System.Collections.Generic;
using System.Text;

namespace Figura
{
    public abstract class Figura
    {
        public Punto Punto1 { get; set; }
        public Punto Punto2 { get; set; }        
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();        


    }
}
