using Prueba.Repository.Repository.Base;
using Repository.Business.Interface;
using Repository.Context;
using Repository.Entities;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Business.BO
{
    public class DependenciasBO : IDependencia
    {
        private readonly ContextPrueba context;
        public DependenciasBO(ContextPrueba context)
        {
            this.context = context;
        }
        public Dependencia Create(Dependencia entity)
        {
            try
            {
                BaseRepository<Dependencia> repository = new DependenciasRepo(context);
                repository.Create(entity);
                context.SaveChanges();
                return entity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Dependencia entity)
        {
            try
            {
                BaseRepository<Dependencia> repository = new DependenciasRepo(context);
                repository.Delete(entity);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Dependencia> GetDependencias()
        {
            try
            {
                BaseRepository<Dependencia> repository = new DependenciasRepo(context);
                return repository.Get();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Dependencia GetFirst(int id)
        {
            try
            {
                BaseRepository<Dependencia> repository = new DependenciasRepo(context);
                return repository.Get(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Dependencia Update(Dependencia entity)
        {
            try
            {
                BaseRepository<Dependencia> repository = new DependenciasRepo(context);
                repository.Update(entity);
                return entity;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}