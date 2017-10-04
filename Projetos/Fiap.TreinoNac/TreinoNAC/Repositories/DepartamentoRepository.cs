using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using TreinoNAC.Context;
using TreinoNAC.Models;

namespace TreinoNAC.Repositories
{
    public class DepartamentoRepository : IDepartamentoRepository
    {
        private EscritorioContext _context;

        public DepartamentoRepository(EscritorioContext context)
        {
            _context = context;
        }
        
        public void alterar(Departamento departamento)
        {
            _context.Entry(departamento).State = EntityState.Modified;
        }

        public List<Departamento> buscapor(Expression<Func<Departamento, bool>> filtro)
        {
            return _context.Departamentos.Where(filtro).ToList();
        }

        public Departamento buscar(int id)
        {
            return _context.Departamentos.Find(id);
        }

        public void cadastrar(Departamento departamento)
        {
            _context.Departamentos.Add(departamento);
        }

        public void Excluir(int id)
        {
            _context.Departamentos.Remove(_context.Departamentos.Find(id));
        }

        public List<Departamento> Listar()
        {
            return _context.Departamentos.ToList();
        }
    }
}