using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livraria.Model;

namespace Livraria.Controller
{
    internal class Dvd : Produto
    {
        // ----------- PROPRIEDADES -----------
        private string diretor;
        private string duracao;
        private string censura;

        // ----------- SET -----------
        public void setDiretor(string diretor)
        {
            this.diretor = diretor;
        }
        public void setDuracao(string duracao)
        {
            this.duracao = duracao;
        }
        public void setCensura(string censura)
        {
            this.censura = censura;
        }

        // ----------- GET -----------
        public string getDiretor()
        {
            return diretor;
        }
        public string getDuracao()
        {
            return duracao;
        }
        public string getCensura()
        {
            return censura;
        }

        // ----------- CONSTRUTORES -----------

        public Dvd() : base()
        {
            diretor = "não adicionado";
            duracao = "não adicionado";
            censura = "não adicionado";
        }

        public Dvd(string descricao, string genero, int estoqueDisponivel, double precoCusto, string diretor, string duracao, string censura) : base(descricao, genero, estoqueDisponivel, precoCusto)
        {
            this.diretor = diretor;
            this.duracao = duracao;
            this.censura = censura;
        }

        // ----------- MÉTODOS -----------
        public override void calcularPrecoVenda()
        {
            base.setPrecoVenda(base.getPrecoCusto() * 5);
        }

        public string listarProduto()
        {
            string lista = "Diretor: " + diretor + "\nDuração: " + duracao + "\nCensura: " + censura + "\nDescrição: " + base.getDescricao() + "\nGênero: " + base.getGenero() + "\nEstoque Disponível: " + base.getEstoqueDisponivel() + "\nPreço de custo: " + base.getPrecoCusto() + "\nPreço de venda: R$" + base.getPrecoVenda();

            return lista;
        }
    }
}
