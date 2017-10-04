using System;
using TreinoNAC.Context;
using TreinoNAC.Repositories;

namespace TreinoNAC.Units
{
    public class UnitOfWork : IDisposable
    {

        private EscritorioContext _context = new EscritorioContext();
        private IFuncionarioRepository _funcionarioRepository;
        private IDepartamentoRepository _departamentoRepository;

      
        public IFuncionarioRepository FuncionarioRepository
        {
            get
            {
                if (_funcionarioRepository == null)
                {
                    _funcionarioRepository = new FuncionarioRepository(_context);

                }
                return _funcionarioRepository;
            }

        }

        public IDepartamentoRepository DepartamentoRepository
        {
            get
            {
                if (_departamentoRepository == null)
                {
                    _departamentoRepository = new DepartamentoRepository(_context);
                }
                return _departamentoRepository;
            }
        }

        
        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }

    }
}