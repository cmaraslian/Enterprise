using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.Exemplo04.MVC.Models;
using Fiap.Exemplo04.MVC.Persistencia;
using System.Data.Entity;

namespace Fiap.Exemplo04.MVC.Repositories
{
    public class TimeRepository : ITimeRepository
    {
        private FutebolContext _context;

        public TimeRepository(FutebolContext context)
        {
            _context = context;
        }

        public void Alterar(Time time)
        {
            _context.Entry(time).State = EntityState.Modified;
        }

        public Time Buscar(int id)
        {
            return _context.Times.Find(id);
        }

        public List<Time> BuscarPor(Expression<Func<Time, bool>> filtro)
        {
            return _context.Times.Include("Tecnico")
                                    .Where(filtro).ToList();
        }

        public void Cadastrar(Time time)
        {
            _context.Times.Add(time);
        }

        public void Deletar(int id)
        {
            var time = _context.Times.Find(id);
            _context.Times.Remove(time);
        }

        public List<Time> Listar()
        {
            return _context.Times.Include("Tecnico").ToList();
        }
    }
}