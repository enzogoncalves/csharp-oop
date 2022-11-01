using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Livraria.Model;

namespace Livraria.Controller
{
    internal class Cd : Produto
    {
        // ----------- PROPRIEDADES -----------
        private string artista;
        private string gravadora;
        private string paisOrigem;

        // ----------- SET -----------
        public void setArtista(string artista)
        {
            this.artista = artista;
        }
        public void setGravadora(string gravadora)
        {
            this.gravadora = gravadora;
        }
        public void setPaisOrigem(string paisOrigem)
        {
            this.paisOrigem = paisOrigem;
        }

        // ----------- GET -----------
        public string getArtista()
        {
            return artista;
        }
        public string getGravadora()
        {
            return gravadora;
        }
        public string getPaisOrigem()
        {
            return paisOrigem;
        }

        // ----------- CONSTRUTORES -----------

        public Cd() : base()
        {
            artista = "não adicionado";
            gravadora = "não adicionado";
            paisOrigem = "não adicionado";
        }

        public Cd(string descricao, string genero, int estoqueDisponivel, double precoCusto, string artista, string gravadora, string paisOrigem) : base(descricao, genero, estoqueDisponivel, precoCusto)
        {
            this.artista = artista;
            this.gravadora = gravadora;
            this.paisOrigem = paisOrigem;
        }

        // ----------- MÉTODOS -----------
        public override void calcularPrecoVenda()
        {
            base.setPrecoVenda(base.getPrecoCusto() * 1.15);
        }

        public string listarProduto()
        {
            string lista = "Artista: " + artista + "\nGravadora: " + gravadora + "\nPáis de Origem: " + paisOrigem + "\nDescrição: " + base.getDescricao() + "\nGênero: " + base.getGenero() + "\nEstoque Disponível: " + base.getEstoqueDisponivel() + "\nPreço de custo: " + base.getPrecoCusto() + "\nPreço de venda: R$" + base.getPrecoVenda();

            return lista;
        }
    }
}
