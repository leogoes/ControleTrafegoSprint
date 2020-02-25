using System;
using System.Collections.Generic;
using System.Text;

namespace SprintTraffic.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {

        void Add(T obj);
        T GetById(int Id);
        IEnumerable<T> GetAll();
        List<T> Listar();
        void Update(T obj);
        void Remove(T obj);
        void Dispose();
    }
}
