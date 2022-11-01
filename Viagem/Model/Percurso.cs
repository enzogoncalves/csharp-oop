using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viagem.Model
{
    internal class Percurso
    {
        private double kmPercorrida { get; set; }
        private double valorCombustivel { get; set; }
        private double valorPedagio { get; set; }

        public Percurso()
        {
            this.kmPercorrida = 0;
            this.valorCombustivel = 0;
            this.valorPedagio = 0;
        }

        public Percurso(double kmPercorrida, double valorCombustivel, double valorPedagio)
        {
            this.kmPercorrida = kmPercorrida;
            this.valorCombustivel = valorCombustivel;
            this.valorPedagio = valorPedagio;
        }

        public void setKmPercorrida(double kmPercorrida)
        {
            this.kmPercorrida = kmPercorrida;
        }

        public double getKmPercorrida()
        {
            return this.kmPercorrida;
        }
        public void setValorCombustivel(double valorCombustivel)
        {
            this.valorCombustivel = valorCombustivel;
        }

        public double getValorCombustivel()
        {
            return this.valorCombustivel;
        }

        public void setValorPedagio(double valorPedagio)
        {
            this.valorPedagio = valorPedagio;
        }

        public double getValorPedagio()
        {
            return this.valorPedagio;
        }

        public string listarPercurso()
        {
            string percurso = "Km percorrido: " + kmPercorrida + "\nValor do combustível: " + valorCombustivel + "\nValor do pedágio: " + valorPedagio;
            return percurso;
        }
    }
}
