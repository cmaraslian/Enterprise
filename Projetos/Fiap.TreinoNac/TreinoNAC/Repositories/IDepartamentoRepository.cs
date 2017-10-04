using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TreinoNAC.Models;

namespace TreinoNAC.Repositories
{
    public interface IDepartamentoRepository
    {
        void cadastrar(Departamento departamento);
        void alterar(Departamento departamento);
        List<Departamento> Listar();
        List<Departamento> buscapor(Expression<Func<Departamento,bool>>filtro);
        Departamento buscar(int id);
        void Excluir(int id);

    }
}
