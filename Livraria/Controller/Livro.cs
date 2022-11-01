using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livraria.Model;

namespace Livraria.Controller
{
    internal class Livro : Produto
    {
        // ----------- PROPRIEDADES -----------
        private string autor;
        private string editora;
        private string edicao;

        // ----------- SET -----------
        public void setAutor(string autor)
        {
            this.autor = autor;
        }
        public void setEditora(string editora)
        {
            this.editora = editora;
        }
        public void setEdicao(string edicao)
        {
            this.edicao = edicao;
        }

        // ----------- GET -----------
        public string getAutor()
        {
            return autor;
        }
        public string getEditora()
        {
            return editora;
        }
        public string getEdicao()
        {
            return edicao;
        }

        // ----------- CONSTRUTORES -----------

        public Livro() : base()
        {
            autor = "não adicionado";
            editora = "não adicionado";
            edicao = "não adicionado";
        }

        public Livro(string descricao, string genero, int estoqueDisponivel, double precoCusto, string autor, string editora, string edicao) : base (descricao, genero, estoqueDisponivel, precoCusto) 
        {
            this.autor = autor;
            this.editora = editora;
            this.edicao = edicao;
        }

        // ----------- MÉTODOS -----------
        public string listarProduto()
        {
            string lista = "Autor: " + autor + "\nEditora: " + editora + "\nEdição: " + edicao + "\nDescrição: " + base.getDescricao() + "\nGênero: " + base.getGenero() + "\nEstoque Disponível: " + base.getEstoqueDisponivel() + "\nPreço de custo: " + base.getPrecoCusto() + "\nPreço de venda: R$" + base.getPrecoVenda();

            return lista;
        }
    }
}
