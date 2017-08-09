using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWord.UI.Model
{
    class Moto : Veiculo
    {
        public bool Bau { get; set; }


        public Moto(string placa) : base(placa)
        {

        }

        public override void Acelerar()
        {
            Console.WriteLine("Moto acelerando");
        }

        public override void Frear()
        {
            Console.WriteLine("Moto parando");

        }

    }


    

}
