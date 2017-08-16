using Fiap.Banco.Model;
using Fiap.Exercicio01.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercicio01.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var cc = new ContaCorrente()
            {
                Agencia = 123,
                Numero = 321,
                DateAbertura = DateTime.Now,
                TipoConta = TipoConta.Comum,
                Saldo = 10000
            };
            var cp = new ContaPoupanca(0.006m)
            {
                Agencia = 123,
                Numero = 655,
                DateAbertura = DateTime.Now,
                Saldo = 500,
                Taxa = 10
            };

            cc.Depositar(500);
            cc.Retirar(100000);
            Console.WriteLine(cp.CalculaRetornoInvestimento());
            Console.WriteLine(cc.Saldo);
            Console.ReadLine();//Parar a aplicação...
        }
    }
}
