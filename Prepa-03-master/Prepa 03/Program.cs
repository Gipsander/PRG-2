using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo_cuadrado = new Cuadrado(5, "azul");
            Rectangulo rectangulo = new Rectangulo(2,3, "blanco");
            Triangulo triangulo_isosceles = new Isosceles(2, 3, 4, "Lila");
            Triangulo triangulo_escaleno = new Escaleno(3, 6, 6, "Turquesa");
            Triangulo triangulo_equilatero = new Equilatero(6, 6, 5, "Verde");

            Figura figura1 = rectangulo_cuadrado;
            Figura figura2 = rectangulo;
            Figura figura3 = new Circulo(2, "negro");
            Figura figura4 = new Triangulo(5, 12, 3, "rojo");
            Figura figura5 = triangulo_isosceles;
            Figura figura6 = triangulo_escaleno;
            Figura figura7 = triangulo_equilatero;


            figura1.MostrarDatos();
          
            figura2.MostrarDatos();
           
            figura3.MostrarDatos();

            figura4.MostrarDatos();

            figura5.MostrarDatos();

            figura6.MostrarDatos();

            figura7.MostrarDatos();


            //Console.WriteLine($" Area {figura3.GetArea()}, Perimetro {figura3.GetPerimetro()}");

            Console.ReadLine();
           
            
        }
    }
}
