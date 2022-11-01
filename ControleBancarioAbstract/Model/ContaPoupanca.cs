using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleBancarioAbstract.Model;

namespace ControleBancarioAbstract.Model
{
    class ContaPoupanca : Conta
    {
        private double reajusteMensal;

        // Get e Set
        public double getReajusteMensal()
        {
            return reajusteMensal;
        }

        public void setReajusteMensal(double reajusteMensal)
        {
            this.reajusteMensal = reajusteMensal;
        }

        // Construtores

        public ContaPoupanca()
        {
            reajusteMensal = 0;
        }

        public ContaPoupanca(double saldo, double reajusteMensal) : base(saldo)
        {
            this.reajusteMensal = reajusteMensal;
        }

        // Métodos

        public override void atualizarSaldos()
        {
            setSaldo(getSaldo() + (getSaldo() * getReajusteMensal()));
        }

        public void atualizarSaldos(double reajuste)
        {
            if(getSaldo() > 0)
            {
                setReajusteMensal(reajuste);
                setSaldo(getSaldo() + (getSaldo() * getReajusteMensal()));
            }
        }
    }
}
