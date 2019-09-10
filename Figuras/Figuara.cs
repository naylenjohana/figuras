using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras
{
    public abstract class Figura
    {
        protected IPunto Punto1 { get; set; }
        protected IPunto Punto2 { get; set; }
        /// <summary>
        /// calcula el Area de la figura 
        /// </summary>
        /// <returns></returns> 
        public abstract double CalcularArea();
        /// <summary>
        /// calcula el perimetro de la figura
        /// </summary>
        /// <returns></returns>
        public abstract double CalcularPerimetro();        


    }
}
