using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viagem.Model;
using Viagem.Controller;

namespace Viagem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Percurso novoPercurso = new Percurso();
            Custos meusCustos = new Custos();

            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("1 - Criar novo percurso\n2 - Listar o percurso\n3 - Calcular custos\n0 - Sair");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 0:
                        continuar = false;
                        break;

                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite o kilômetro percorrido: ");
                        double kmPercorrida = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor do combustível: ");
                        double valorCombustível = double.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o valor do pedágio: ");
                        double valorPedagio = double.Parse(Console.ReadLine());
                        novoPercurso = new Percurso(kmPercorrida, valorCombustível, valorPedagio);
                        Console.WriteLine("Percurso criado com sucesso!");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine(novoPercurso.listarPercurso());
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine(meusCustos.calcularViagem((novoPercurso)));
                        Console.ReadKey();
                        break;

                    default:
                        continuar = false;
                        break;
                }
            }
        }
    }
}
