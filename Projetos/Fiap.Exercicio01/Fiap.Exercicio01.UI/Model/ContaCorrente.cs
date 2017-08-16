using Fiap.Exercicio01.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    sealed class ContaCorrente : Conta
    {
        public TipoConta TipoConta { get; set; }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if (TipoConta == TipoConta.Comum && Saldo < valor)
            {
                throw new Exception("Saldo insuficiente");
            }
            Saldo -= valor;
        }
    }
}
