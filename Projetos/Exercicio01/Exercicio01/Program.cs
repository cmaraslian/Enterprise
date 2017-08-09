using Fiap.Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaCorrente = new ContaCorrente();
            contaCorrente.agencia = 0735;
            contaCorrente.numero = 372336;
            contaCorrente.dataAbertura = new DateTime(2017,1,31);
            contaCorrente.saldo = 100;

            Console.WriteLine("---------- Conta Corrente ----------");
            Console.WriteLine(
                " Agencia:" + contaCorrente.agencia + "\n" +
                " Numero:" + contaCorrente.numero + "\n" +
                " Data de abertura:" + contaCorrente.dataAbertura + "\n" +
                " Saldo:" + contaCorrente.saldo);


            contaCorrente.Depositar(100);
            Console.WriteLine(" Novo saldo:" + contaCorrente.saldo);

            contaCorrente.Retirar(200);
            Console.WriteLine(" Novo saldo:" + contaCorrente.saldo);

            //Testa exception 
            //contaCorrente.Retirar(200);
            //Console.WriteLine(" Novo saldo:" + contaCorrente.saldo);

            ContaPoupanca contaPoupanca = new ContaPoupanca(2);
            contaPoupanca.agencia = 12345;
            contaPoupanca.numero = 678;
            contaPoupanca.dataAbertura = new DateTime(2005,10,10);
            contaPoupanca.saldo = 200;

            Console.WriteLine("---------- Conta Poupança ----------");
            Console.WriteLine(
                " Agencia:" + contaPoupanca.agencia + "\n" +
                " Numero:" + contaPoupanca.numero + "\n" +
                " Data de abertura:" + contaPoupanca.dataAbertura + "\n" +
                " Saldo:" + contaPoupanca.saldo);


            Console.WriteLine(" Retorno do investimento:" + contaPoupanca.CalculaRetornoInvestimento());            
            Console.ReadLine();



        }
    }
}
