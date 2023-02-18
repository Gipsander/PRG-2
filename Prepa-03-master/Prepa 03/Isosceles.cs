using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Isosceles : Triangulo
    {
        public Isosceles(float base_triangulo, float altura, float lados, string color) : base(base_triangulo, altura, lados, color)
        {

        }

        public override double GetArea()
        {
            return base.GetArea();
        }

        public override double GetPerimetro()
        {
            return base.GetPerimetro();
        }


        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triangulo Isosceles de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }

    }
}
