using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleBancarioAbstract.Model;

namespace ControleBancarioAbstract.Model
{
    class ContaCorrente : Conta
    {
        private double limiteEspecial;

        // Get e Set
        public double getLimiteEspecial()
        {
            return limiteEspecial;
        }

        public void setLimiteEspecial(double limiteEspecial)
        {
            this.limiteEspecial = limiteEspecial;
        }

        // Construtores

        public ContaCorrente()
        {
            limiteEspecial = 0;
        }

        public ContaCorrente (double saldo, double limiteEspecial) : base(saldo)
        {
            this.limiteEspecial = limiteEspecial;
        }

        // Métodos

        public override void atualizarSaldos()
        {
            if(getSaldo() < 0)
            {
                limiteEspecial = getSaldo() * -0.08;
                setSaldo(getSaldo() - (getSaldo() * 0.08));
            }
        }

        public override void debitar(double valor)
        {
            if(getSaldo() + getLimiteEspecial() >= valor)
            {
                setSaldo(getSaldo() - valor);
            }
        }
    }
}
