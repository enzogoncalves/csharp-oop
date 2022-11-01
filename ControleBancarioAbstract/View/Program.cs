using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleBancarioAbstract.Model;
using ControleBancarioAbstract.Control;

namespace ControleBancarioAbstract
{
    internal class Program
    {

        static public string entrada(int opc)
        {
            string entr = "";

            switch (opc)
            {
                case 1:
                    entr = "Conta Corrente";
                    break;
                case 2:
                    entr = "Poupança";
                    break;
                case 3:
                    entr = "Consultar total dos saldos";
                    break;

            }
            return "---- " + entr + " ----\n";
        }

        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente(500, 1000);
            ContaPoupanca cp = new ContaPoupanca(5000, 0.01);
            GerenciadorContas gc = new GerenciadorContas(0);

            bool continuar = true;

            do
            {
                Console.WriteLine("----- BEM VINDO -----\n\nOpções:\n1 - Conta corrente" + "\n2 - Poupanca" + "\n3 - Consultar total dos saldos" + "\n0 - Sair");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        continuar = false;
                        break;

                    case 1:
                        bool continuarOpcao = true;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(entrada(opcao));
                            Console.WriteLine("1 - Depositar\n2 - Sacar\n3 - Consultar saldo\n4 - Reajustar saldo\n0 - Sair");
                            int opcao1 = int.Parse(Console.ReadLine());

                            switch (opcao1)
                            {
                                case 0:
                                    Console.Clear();
                                    continuarOpcao = false;
                                    break;

                                case 1:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    Console.WriteLine("Digite o valor a ser depositado: ");
                                    double deposito = double.Parse(Console.ReadLine());
                                    cc.creditar(deposito);
                                    Console.WriteLine("Valor depositado com sucesso!");
                                    Console.ReadKey();
                                    break;

                                case 2:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    Console.WriteLine("Digite o valor a ser sacado: ");
                                    double valor = double.Parse(Console.ReadLine());
                                    if (cc.getSaldo() + cc.getLimiteEspecial() >= valor)
                                    {
                                        cc.debitar(valor);
                                        Console.WriteLine("Valor sacado com sucesso");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Saldo insuficiente.");
                                    }
                                        Console.ReadKey();
                                    break;

                                case 3:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    Console.WriteLine("Saldo: " + cc.getSaldo());
                                    Console.ReadKey();
                                    break;

                                case 4:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    double saldoAnterior = cc.getSaldo();
                                    cc.atualizarSaldos();
                                    Console.WriteLine("Saldo anterior: " + saldoAnterior);
                                    Console.WriteLine("\nSaldo atualizado: " + cc.getSaldo());
                                    Console.ReadKey();
                                    break;
                            }
                        } while (continuarOpcao);

                        break;

                    case 2:
                        continuarOpcao = true;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(entrada(opcao));
                            Console.WriteLine("1 - Depositar\n2 - Sacar\n3 - Consultar saldo\n4 - Reajustar saldo\n0 - Sair");
                            int opcao1 = int.Parse(Console.ReadLine());

                            switch (opcao1)
                            {
                                case 0:
                                    Console.Clear();
                                    continuarOpcao = false;
                                    break;

                                case 1:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    Console.WriteLine("Digite o valor a ser depositado: ");
                                    double deposito = double.Parse(Console.ReadLine());
                                    cp.creditar(deposito);
                                    Console.WriteLine("Valor depositado com sucesso!");
                                    Console.ReadKey();
                                    break;

                                case 2:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    Console.WriteLine("Digite o valor a ser sacado: ");
                                    double valor = double.Parse(Console.ReadLine());
                                    if (cp.getSaldo() >= valor)
                                    {
                                        cp.debitar(valor);
                                        Console.WriteLine("Valor sacado com sucesso!");
                                    } else
                                    {
                                        Console.WriteLine("Saldo insuficiente.");
                                    }
                                    Console.ReadKey();
                                    break;

                                case 3:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    Console.WriteLine("Saldo: " + cp.getSaldo());
                                    Console.ReadKey();
                                    break;

                                case 4:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    double saldoAnterior = cp.getSaldo();
                                    cp.atualizarSaldos();
                                    Console.WriteLine("Saldo anterior: " + saldoAnterior);
                                    Console.WriteLine("\nSaldo atualizado: " + cp.getSaldo());
                                    Console.ReadKey();
                                    break;
                            }
                        } while (continuarOpcao);

                        break;
                    case 3:
                        continuarOpcao = true;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(entrada(opcao));
                            Console.WriteLine("1 - Consultar total dos saldos\n0 - Sair");
                            int opcao1 = int.Parse(Console.ReadLine());

                            switch (opcao1)
                            {
                                case 0:
                                    Console.Clear();
                                    continuarOpcao = false;
                                    break;

                                case 1:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    gc.totalizarSaldos(cc);
                                    gc.totalizarSaldos(cp);
                                    Console.WriteLine("Saldo total: " + gc.getSaldoTotal());
                                    Console.ReadKey();
                                    break;
                            }
                        } while (continuarOpcao);

                        break;

                }
            } while (continuar);
        }
    }
}
