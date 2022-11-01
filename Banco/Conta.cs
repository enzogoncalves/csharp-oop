using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Conta
    {
        public double saldo;
        public int numero;

        public Conta()
        {
            this.saldo = 0.0;
            this.numero = 0;
        }

        public Conta(double saldo, int numero)
        {
            this.saldo = saldo;
            this.numero = numero;
        }

        public Conta(int numero)
        {
            this.saldo = 0.0;
            this.numero = numero;
        }

        public void depositar(double valor)
        {
            saldo += valor;
        }

        public bool sacar(double valor)
        {
            if (saldo - valor >= 0)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }

        public double consultaDeSaldo()
        {
            return saldo;
        }
    }
}
