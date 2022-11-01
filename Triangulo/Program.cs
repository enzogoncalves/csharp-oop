using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo novoTriangulo = new Triangulo();

            Console.WriteLine("Digite o comprimento do primeiro lado do triângulo");
            novoTriangulo.lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o comprimento do segundo lado do triângulo");
            novoTriangulo.lado2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o comprimento do terceiro lado do triângulo");
            novoTriangulo.lado3 = double.Parse(Console.ReadLine());

            if (novoTriangulo.isTriangle())
            {
                Console.WriteLine("Valores inseridos não formam um triângulo :/");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Lado1: " + novoTriangulo.lado1 + "cm.\nLado2: " + novoTriangulo.lado2 + "cm.\nLado3: " + novoTriangulo.lado3 + "cm.");
                Console.WriteLine("Área do triângulo: " + Math.Round(novoTriangulo.calcularArea(), 2) + "cm.");
                Console.WriteLine(novoTriangulo.classificar());
            }

            Console.ReadKey();
        }
    }
}
