using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {

        Decimal taxa { get; set; }

        private readonly decimal _rendimento;

        public ContaPoupanca(decimal rendimento)
        {
            _rendimento = rendimento;
        }
             

        public decimal CalculaRetornoInvestimento()
        {
            return this.saldo * _rendimento;

        }


        public override void Depositar(decimal valor)
        {
            this.saldo = this.saldo + valor;
        }

        public override void Retirar(decimal valor)
        {
            if (this.saldo - valor - this.taxa < 0)
            {
                throw new Exception("Saldo insuficiente");
            }
            else
            {
                this.saldo = this.saldo - valor - this.taxa;
            }

        }


    }
}
