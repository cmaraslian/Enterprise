using Fiap.Exemplo04.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo04.MVC.Repositories
{
    //Tem que colocar publico na mao
    public interface IJogadorRepository
    {

        List<Jogador> Listar();
        void Cadastrar(Jogador jogador);

        void Alterar(Jogador jogador);

        Jogador Buscar(int id);
                
        List<Jogador> BuscarPor(Expression<Func<Jogador, bool>> filtro);

        

    }
}
