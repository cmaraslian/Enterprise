using Fiap.Exemplo04.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo04.MVC.Repositories
{
    public interface IJogadorRepository
    {
        List<Jogador> Listar();
        List<Jogador> BuscarPor(Expression<Func<Jogador, bool>> filtro);
        Jogador Buscar(int id);
        void Cadastrar(Jogador jogador);
        void Alterar(Jogador jogador);
        void Deletar(int id);
    }
}
