using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figura;

namespace Cliente2
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Figura.Figura figura = new Cuadrado();
            Console.WriteLine(figura.CalcularArea());
            Console.ReadLine();


        }
    }
}
