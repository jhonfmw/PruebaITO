using Microsoft.EntityFrameworkCore;
using Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Prueba.Repository.Repository.Base
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected ContextPrueba context = null;

        private readonly DbSet<T> entity = null;

        protected BaseRepository(ContextPrueba context)
        {
            this.context = context;
            entity = context.Set<T>();
        }

        public ContextPrueba Context
        {
            get
            {
                return context;
            }
        }

        public abstract T Get(int id);
        public abstract ICollection<T> Get();
        public abstract long Create(T Entity);
        public abstract void Update(T Entity);
        public abstract void Delete(T Entity);
    }
}
