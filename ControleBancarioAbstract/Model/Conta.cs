using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBancarioAbstract
{
    abstract class Conta
    {
        private double saldo;

        // Get e Set
        public double getSaldo()
        {
            return saldo;
        }

        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        // Construtores

        public Conta()
        {
            this.saldo = 0.0;
        }

        public Conta(double saldo)
        {
            this.saldo = saldo;
        }

        // Métodos

        public void creditar(double valor)
        {
            setSaldo(getSaldo() + valor);
        }

        public virtual void debitar(double valor)
        {
            if(getSaldo() >= valor)
            {
                setSaldo(getSaldo() - valor);
            }
        }

        public abstract void atualizarSaldos();
    }
}
