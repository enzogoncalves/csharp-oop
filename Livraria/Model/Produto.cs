using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Model
{
    internal class Produto
    {
        // ----------- PROPRIEDADES -----------
        private string descricao;
        private string genero;
        private int estoqueDisponivel;
        private double precoCusto;
        private double precoVenda;

        // ----------- SET -----------
        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }
        public void setGenero(string genero)
        {
            this.genero = genero;
        }
        public void setEstoqueDisponivel(int estoqueDisponivel)
        {
            this.estoqueDisponivel = estoqueDisponivel;
        }
        public void setPrecoCusto(double precoCusto)
        {
            this.precoCusto = precoCusto;
        }
        public void setPrecoVenda(double precoVenda)
        {
            this.precoVenda = precoVenda;
        }

        // ----------- GET -----------
        public string getDescricao()
        {
            return descricao;
        }
        public string getGenero()
        {
            return genero;
        }
        public int getEstoqueDisponivel()
        {
            return estoqueDisponivel;
        }
        public double getPrecoCusto()
        {
            return precoCusto;
        }
        public double getPrecoVenda()
        {
            return precoVenda;
        }

        // ----------- CONSTRUTORES -----------

        public Produto()
        {
            this.descricao = "sem descrição adicionada";
            this.genero = "sem gênero adicionado";
            this.estoqueDisponivel = 0;
            this.precoCusto = 0;
            this.precoVenda = 0;
        }

        public Produto(string descricao, string genero, int estoqueDisponivel, double precoCusto)
        {
            this.descricao = descricao;
            this.genero = genero;
            this.estoqueDisponivel = estoqueDisponivel;
            this.precoCusto = precoCusto;
        }

        // ----------- MÉTODOS -----------

        public void comprar(int unidadesComprada)
        {
            estoqueDisponivel += unidadesComprada;
        }
        public void vender(int unidadesVendidas) 
        {
            if(estoqueDisponivel - unidadesVendidas >= 0)
            {
                estoqueDisponivel -= unidadesVendidas;
            }
        }

        public virtual void calcularPrecoVenda()
        {
            setPrecoVenda(getPrecoCusto() * 1.1);
        }
    }
}
