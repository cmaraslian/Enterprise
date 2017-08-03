using Fiap.HelloWord.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWord.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Carro carro = new Model.Carro("UBA-1030");

            carro.Placa = "UBA-1040";
            carro.Portas = 4;

            Console.WriteLine("O Carro placa " + carro.Placa +
                " contem " + carro.Portas + " portas" );
            Console.ReadLine();

            Moto moto = new Moto("TTT-1010");
            

            Console.WriteLine("Moto - Bau: " + moto.Bau);
            Console.ReadLine();
        }
    }
}
