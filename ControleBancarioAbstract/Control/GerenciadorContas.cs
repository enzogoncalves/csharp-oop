using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleBancarioAbstract.Model;

namespace ControleBancarioAbstract.Control
{
    internal class GerenciadorContas
    {
        private double saldoTotal;

        // GET E SET
        public void setSaldoTotal(double saldoTotal)
        {
            this.saldoTotal = saldoTotal;
        }

        public double getSaldoTotal()
        {
            return saldoTotal;
        }

        // Construtores
        public GerenciadorContas()
        {
            this.saldoTotal = 0.0;
        }

        public GerenciadorContas(double saldoTotal)
        {
            this.saldoTotal = saldoTotal;
        }


        // Métodos
        public void totalizarSaldos(Conta conta)
        {
            saldoTotal = getSaldoTotal() + conta.getSaldo();
        }
    }
}
