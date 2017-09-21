using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fiap.Exemplo04.MVC.Models;
using Fiap.Exemplo04.MVC.Persistencia;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Fiap.Exemplo04.MVC.Repositories
{
    public class JogadorRepository : IJogadorRepository
    {
        
        private FutebolContext _context;

        public JogadorRepository(FutebolContext _context)
        {
            this._context = _context;
        }

        public void Alterar(Jogador jogador)
        {
            _context.Entry(jogador).State = EntityState.Modified;
        }

        public Jogador Buscar(int id)
        {
            return _context.Jogadores.Find(id);
        }

        
        public List<Jogador> BuscarPor(Expression<Func<Jogador, bool>> filtro)
        {
            //return _context.Times.Include("Time").Where(filtro).ToList();
        }

        public void Cadastrar(Jogador jogador)
        {
            _context.Jogadores.Add(jogador);
            _context.SaveChanges();
        }

        public List<Jogador> Listar()
        {
            throw new NotImplementedException();
        }
    }
}