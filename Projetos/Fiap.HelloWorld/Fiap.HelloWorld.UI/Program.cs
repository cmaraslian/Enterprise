using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap.HelloWorld.UI.Model;

namespace Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um Carro
            var carro = new Carro("FFF-45587");
            var moto = new Moto("FSG-8899")
            {
                Bau = true
            };

            //Criar uma lista de balão
            var lista = new List<Balao>();
            lista.Add(new Balao("Mágico"));
            lista.Add(new Balao("São João"));

            carro.Cambio = Cambio.Automatico;

            //E exibir os dados do balão
            foreach (var item in lista)
            {
                Console.WriteLine(item.Placa);
            }

            //Atribuir valores a placa e portas
            carro.Placa = "FFF-44546";
            carro.Porta = 5;
            //Exibir a placa
            Console.WriteLine(carro.Placa);
            Console.ReadLine();
        }
    }
}
