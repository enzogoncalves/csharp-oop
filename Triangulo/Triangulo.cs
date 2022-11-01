using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Triangulo
    {
        public double lado1 { get; set; }
        public double lado2 { get; set; }
        public double lado3 { get; set; }
        public string tipo { get; set; }
        public double perimetro { get; set; }
        public double area { get; set; }

        public bool isTriangle()
        {
            return !((lado1 < lado2 + lado3) && (lado2 < lado1 + lado3) && (lado3 < lado1 + lado2));
        }

        public double calcularPerimetro()
        {
            perimetro = lado1 + lado2 + lado3;
            return perimetro;
        }

        public double calcularArea()
        {
            double sp = calcularPerimetro() / 2;
            area = Math.Sqrt(sp * (sp - lado1) * (sp - lado2) * (sp - lado3));
            return area;
        }

        public string classificar()
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                tipo = "Triângulo equilátero";
            }
            else if (lado1 == lado2 + lado3 || lado2 == lado1 + lado3 || lado3 == lado1 + lado2)
            {
                tipo = "Triângulo isóceles";
            }
            else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
            {
                tipo = "Triângulo escaleno";
            }
            return tipo;
        }
    }
}
