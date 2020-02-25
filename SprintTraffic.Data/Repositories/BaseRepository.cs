using SprintTraffic.Domain.Interfaces;
using SprintTraffic.Infrastructure.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace SprintTraffic.Data.Repositories
{
    public class BaseRepository<T> : IDisposable, IBaseRepository<T> where T : class
    {
        private readonly SprintTrafficContext _context;
        public BaseRepository(SprintTrafficContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(T obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<T> Listar()
        {
            throw new NotImplementedException();
        }

        public void Remove(T obj)
        {
            throw new NotImplementedException();
        }

        public void Update(T obj)
        {
            throw new NotImplementedException();
        }
    }
}
