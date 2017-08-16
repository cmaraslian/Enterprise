using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.HelloWorld.UI.Model
{
    abstract class Veiculo
    {
        //FIELD (Campo, Atributo)
        private string _placa;

        //Gets e Sets
        public string Placa
        {
            get { return _placa; }
            set { _placa = value; }
        }

        //Propriedade
        public Cambio Cambio { get; set; }

        //Construtor
        public Veiculo(string placa)
        {
            _placa = placa;
        }

        //Métodos
        public abstract void Acelerar();

        //virtual -> permite a sobrescrita do método
        public virtual void Frear()
        {
            Console.WriteLine("Veiculo desacelerando");
        }
    }
}
