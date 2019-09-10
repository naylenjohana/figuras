using System;
using System.Collections.Generic;
using System.Text;

namespace Figura
{
    public class Punto 
    {
        public double x1 { get; set; }
        public double y1 { get; set; }       

        private double difx;
        private double dify;
        private double distancia; 

        public double CalcularDistancia(Punto punto2)
        {
            difx = x1 - punto2.x1;
            dify = y1 - punto2.y1;
            distancia= Math.Sqrt(Math.Pow(difx, 2) + Math.Pow(dify, 2));
            return distancia;
        }
    }
}
