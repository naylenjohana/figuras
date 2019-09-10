using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras
{
    public class Punto: IPunto
    {
        /// <summary>
        /// valor del punto en x
        /// </summary>
        public double x1 { get; set; }
        //valor del punto en y
        public double y1 { get; set; }     

        private double difx;
        private double dify;
        private double distancia; 

        /// <summary>
        /// calcula la distancia desde el punto a otro punto
        /// </summary>
        /// <param name="punto2"></param>
        /// <returns></returns>
        public double CalcularDistancia(IPunto punto2)
        {
            difx = x1 - punto2.x1;
            dify = y1 - punto2.y1;
            distancia= Math.Sqrt(Math.Pow(difx, 2) + Math.Pow(dify, 2));
            return distancia;
        }
        
    }
}
