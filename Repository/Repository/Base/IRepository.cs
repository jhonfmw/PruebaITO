using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Prueba.Repository.Repository.Base
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);
        ICollection<T> Get();
        long Create(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
    }
}
