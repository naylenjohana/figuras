using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figuras;

namespace Cliente2
{
    class Program
    {

        
        static void Main(string[] args)
        {
            ImprimirTexto(@"Circulo");
            ImprimirTexto(@"Punto 1");
            IPunto punto1 = SolicitarPunto();
            ImprimirTexto(@"Punto 2");
            IPunto punto2 = SolicitarPunto();           
            Figura figura = new Circulo(punto1, punto2);
            ImprimirTexto($"Area:{figura.CalcularArea().ToString()}");
            ImprimirTexto($"Perimetro:{ figura.CalcularPerimetro().ToString()}");
            ImprimirTexto(@"Enter para Continuar");
            Console.ReadLine();


            //****************************************************
            ImprimirTexto(@"Cuadrado");
            ImprimirTexto(@"Punto 1");
            punto1 = SolicitarPunto();
            ImprimirTexto(@"Punto 2");
            punto2 = SolicitarPunto();
            figura = new Cuadrado(punto1, punto2);
            ImprimirTexto($"Area:{figura.CalcularArea().ToString()}");
            ImprimirTexto($"Perimetro:{ figura.CalcularPerimetro().ToString()}");
            ImprimirTexto(@"Enter para Continuar");
            Console.ReadLine();

            //****************************************************
            ImprimirTexto(@"Cuadrado");
            ImprimirTexto(@"Punto 1");
            punto1 = SolicitarPunto();
            ImprimirTexto(@"Punto 2");
            punto2 = SolicitarPunto();
            ImprimirTexto(@"Punto 3");
            IPunto punto3 = SolicitarPunto();
            figura = new Rectangulo(punto1, punto2,punto3);
            ImprimirTexto($"Area:{figura.CalcularArea().ToString()}");
            ImprimirTexto($"Perimetro:{ figura.CalcularPerimetro().ToString()}");
            ImprimirTexto(@"Enter para Continuar");
            Console.ReadLine();
        }

        private static void ImprimirTexto(string titulo)
        {
            Console.WriteLine(titulo);
        }

        private static IPunto SolicitarPunto()
        {
            IPunto punto = new Punto();
            punto.x1 =Convert.ToDouble(solicitarValor("Ingrese el valor del punto en X"));
            punto.y1 = Convert.ToDouble(solicitarValor("Ingrese el valor del punto en Y"));
            return punto;
        }

        private static string solicitarValor(string valor)
        {
            Console.WriteLine(valor);            
            return Console.ReadLine();
        }
        
    }
}
