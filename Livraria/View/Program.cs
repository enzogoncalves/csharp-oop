using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livraria.Controller;

namespace Livraria
{
    internal class Program
    {
        static public string entrada(int opc)
        {
            string entr = "";

            switch(opc)
            {
                case 1:
                    entr = "LIVRO";
                    break;
                case 2:
                    entr = "CD";
                    break;
                case 3:
                    entr = "DVD";
                    break;

            }
            return "---- " + entr + " ----\n";
        }

        static void Main(string[] args)
        {
            Livro novoLivro = new Livro();
            Cd novoCd = new Cd();
            Dvd novoDvd = new Dvd();

            bool continuar = true;

            do
            {
                Console.WriteLine("----- BEM VINDO -----\n\nOpções:\n1 - Livro" + "\n2 - CD" + "\n3 - DVD" + "\n0 - Sair");
                int opcao = int.Parse(Console.ReadLine());
                
                switch(opcao)
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
                            Console.WriteLine("1 - Cadastrar\n2 - Comprar\n3 - Calcular Preço de Venda\n4 - Vender\n5 - Listar\n0 - Sair");
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
                                    Console.WriteLine("Digite a descrição: ");
                                    string descricao = Console.ReadLine();
                                    Console.WriteLine("Digite o gênero: ");
                                    string genero = Console.ReadLine();
                                    Console.WriteLine("Digite o estoque disponível: ");
                                    int estoqueDisp = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o preço de custo: ");
                                    double precoCusto = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o autor: ");
                                    string autor = Console.ReadLine();
                                    Console.WriteLine("Digite a editora: ");
                                    string editora = Console.ReadLine();
                                    Console.WriteLine("Digite a edição: ");
                                    string edicao = Console.ReadLine();
                                    novoLivro.setDescricao(descricao);
                                    novoLivro.setGenero(genero);
                                    novoLivro.setEstoqueDisponivel(estoqueDisp);
                                    novoLivro.setPrecoCusto(precoCusto);
                                    novoLivro.setAutor(autor);
                                    novoLivro.setEditora(editora);
                                    novoLivro.setEdicao(edicao);
                                    break;

                                case 2:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    Console.WriteLine("Quantas unidades deseja comprar?");
                                    int comprar = int.Parse(Console.ReadLine());
                                    novoLivro.comprar(comprar);
                                    Console.WriteLine("Compra realizada com sucesso!");
                                    Console.ReadKey();
                                    break;

                                case 3:
                                    Console.Clear();
                                    novoLivro.calcularPrecoVenda();
                                    Console.WriteLine(entrada(opcao));
                                    Console.WriteLine("Preço da venda: R$" + novoLivro.getPrecoVenda());
                                    Console.ReadKey();
                                    break;

                                case 4:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    int estoqueDisponivel = novoLivro.getEstoqueDisponivel();
                                    Console.WriteLine("Quantas unidades deseja vender?");
                                    int unidadesVender = int.Parse(Console.ReadLine());
                                    if (estoqueDisponivel - unidadesVender >= 0)
                                    {
                                        novoLivro.vender(unidadesVender);
                                        Console.WriteLine("Unidades vendidas com sucesso.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Não possuímos essa quantidade de livros em nosso estoque.");
                                    }
                                    Console.ReadKey();
                                    break;

                                case 5:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    Console.WriteLine(novoLivro.listarProduto());
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
                            Console.WriteLine("1 - Cadastrar\n2 - Comprar\n3 - Calcular Preço de Venda\n4 - Vender\n5 - Listar\n0 - Sair");
                            int opcao2 = int.Parse(Console.ReadLine());

                            switch (opcao2)
                            {
                                case 0:
                                    Console.Clear();
                                    continuarOpcao = false;
                                    break;

                                case 1:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    Console.WriteLine("Digite a descrição: ");
                                    string descricao = Console.ReadLine();
                                    Console.WriteLine("Digite o gênero: ");
                                    string genero = Console.ReadLine();
                                    Console.WriteLine("Digite o estoque disponível: ");
                                    int estoqueDisp = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o preço de custo: ");
                                    double precoCusto = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o artista: ");
                                    string artista = Console.ReadLine();
                                    Console.WriteLine("Digite a gravadora: ");
                                    string gravadora = Console.ReadLine();
                                    Console.WriteLine("Digite o país de origem: ");
                                    string paisOrigem = Console.ReadLine();
                                    novoCd.setDescricao(descricao);
                                    novoCd.setGenero(genero);
                                    novoCd.setEstoqueDisponivel(estoqueDisp);
                                    novoCd.setPrecoCusto(precoCusto);
                                    novoCd.setArtista(artista);
                                    novoCd.setGravadora(gravadora);
                                    novoCd.setPaisOrigem(paisOrigem);
                                    break;

                                case 2:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    Console.WriteLine("Quantas unidades deseja comprar?");
                                    int comprar = int.Parse(Console.ReadLine());
                                    novoCd.comprar(comprar);
                                    Console.WriteLine("Compra realizada com sucesso!");
                                    Console.ReadKey();
                                    break;

                                case 3:
                                    Console.Clear();
                                    novoCd.calcularPrecoVenda();
                                    Console.WriteLine(entrada(opcao));
                                    Console.WriteLine("Preço da venda: R$" + novoCd.getPrecoVenda());
                                    Console.ReadKey();
                                    break;

                                case 4:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    int estoqueDisponivel = novoCd.getEstoqueDisponivel();
                                    Console.WriteLine("Quantas unidades deseja vender?");
                                    int unidadesVender = int.Parse(Console.ReadLine());
                                    if (estoqueDisponivel - unidadesVender >= 0)
                                    {
                                        novoCd.vender(unidadesVender);
                                        Console.WriteLine("Unidades vendidas com sucesso.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Não possuímos essa quantidade de CDs em nosso estoque.");
                                    }
                                    Console.ReadKey();
                                    break;

                                case 5:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    Console.WriteLine(novoCd.listarProduto());
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
                            Console.WriteLine("1 - Cadastrar\n2 - Comprar\n3 - Calcular Preço de Venda\n4 - Vender\n5 - Listar\n0 - Sair");
                            int opcao3 = int.Parse(Console.ReadLine());

                            switch (opcao3)
                            {
                                case 0:
                                    Console.Clear();
                                    continuarOpcao = false;
                                    break;

                                case 1:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    Console.WriteLine("Digite a descrição: ");
                                    string descricao = Console.ReadLine();
                                    Console.WriteLine("Digite o gênero: ");
                                    string genero = Console.ReadLine();
                                    Console.WriteLine("Digite o estoque disponível: ");
                                    int estoqueDisp = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o preço de custo: ");
                                    double precoCusto = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Digite o diretor: ");
                                    string diretor = Console.ReadLine();
                                    Console.WriteLine("Digite a duração: ");
                                    string duracao = Console.ReadLine();
                                    Console.WriteLine("Digite a censura: ");
                                    string censura = Console.ReadLine();
                                    novoDvd.setDescricao(descricao);
                                    novoDvd.setGenero(genero);
                                    novoDvd.setEstoqueDisponivel(estoqueDisp);
                                    novoDvd.setPrecoCusto(precoCusto);
                                    novoDvd.setDiretor(diretor);
                                    novoDvd.setDuracao(duracao);
                                    novoDvd.setCensura(censura);
                                    break;

                                case 2:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    Console.WriteLine("Quantas unidades deseja comprar?");
                                    int comprar = int.Parse(Console.ReadLine());
                                    novoDvd.comprar(comprar);
                                    Console.WriteLine("Compra realizada com sucesso!");
                                    Console.ReadKey();
                                    break;

                                case 3:
                                    Console.Clear();
                                    novoDvd.calcularPrecoVenda();
                                    Console.WriteLine(entrada(opcao));
                                    Console.WriteLine("Preço da venda: R$" + novoDvd.getPrecoVenda());
                                    Console.ReadKey();
                                    break;

                                case 4:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    int estoqueDisponivel = novoDvd.getEstoqueDisponivel();
                                    Console.WriteLine("Quantas unidades deseja vender?");
                                    int unidadesVender = int.Parse(Console.ReadLine());
                                    if (estoqueDisponivel - unidadesVender >= 0)
                                    {
                                        novoDvd.vender(unidadesVender);
                                        Console.WriteLine("Unidades vendidas com sucesso.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Não possuímos essa quantidade de DVDs em nosso estoque.");
                                    }
                                    Console.ReadKey();
                                    break;

                                case 5:
                                    Console.Clear();
                                    Console.WriteLine(entrada(opcao));
                                    Console.WriteLine(novoDvd.listarProduto());
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
