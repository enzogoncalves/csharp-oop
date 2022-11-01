using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta novaConta = new Conta(1);
            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("1 - Depositar\n2 - Sacar\n3 - Consultar saldo\n0 - Sair");
                int consulta = int.Parse(Console.ReadLine());
                switch (consulta)
                {
                    case 0:
                        continuar = false;
                        break;

                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite o valor a ser depositado: ");
                        double valor = double.Parse(Console.ReadLine());
                        novaConta.depositar(valor);
                        Console.WriteLine("Valor depositado com sucesso!");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Digite o valor do saque: ");
                        valor = double.Parse(Console.ReadLine());
                        if (novaConta.sacar(valor))
                        {
                            Console.WriteLine("Saque efetuado com sucesso.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Saque insuficiente.");
                            Console.ReadKey();
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Saldo atual: R$" + novaConta.consultaDeSaldo());
                        Console.WriteLine("Digite uma tecla para continuar");
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
