using Fiap.Exemplo04.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo04.MVC.Repositories
{
    public interface ITimeRepository
    {
        void Cadastrar(Time time);
        List<Time> Listar();
        void Deletar(int id);
        void Alterar(Time time);
        Time Buscar(int id);
        List<Time> BuscarPor(Expression<Func<Time, bool>> filtro);
    }
}
