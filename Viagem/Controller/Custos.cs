using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viagem.Model;

namespace Viagem.Controller
{
    internal class Custos
    {
        public string calcularViagem(Percurso p)
        {
            double totalPercurso = (p.getKmPercorrida() * p.getValorCombustivel()) + p.getValorPedagio();
            return "Km percorrido: " + p.getKmPercorrida() + "\nValor do combustível: " + p.getValorCombustivel() + "\nValor do pedágio: " + p.getValorPedagio() + "\nTotal Percurso = R$" + totalPercurso;
        }
    }
}
