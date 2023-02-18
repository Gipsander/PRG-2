using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prepa_03
{
    class Escaleno : Triangulo
    {
        public Escaleno(float base_triangulo, float altura, float lados, string color) : base(base_triangulo, altura, lados, color)
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

        //Listo

        public override void MostrarDatos()
        {
            Console.WriteLine($" Soy un Triangulo Escaleno de Color {GetColor()}, Area {GetArea()}, Perimetro {GetPerimetro()}");
        }

    }
}
