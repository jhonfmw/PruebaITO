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
    public class EmpleadosBO : IEmpleado
    {
        private readonly ContextPrueba context;

        public EmpleadosBO(ContextPrueba context)
        {
            this.context = context;
        }
        public Empleado Create(Empleado entity)
        {
            try
            {
                BaseRepository<Empleado> repository = new EmpleadoRepo(context);
                repository.Create(entity);
                context.SaveChanges();
                return entity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(Empleado entity)
        {
            try
            {
                BaseRepository<Empleado> repository = new EmpleadoRepo(context);
                repository.Delete(entity);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Empleado GetFirst(int id)
        {
            try
            {
                BaseRepository<Empleado> repository = new EmpleadoRepo(context);
                return repository.Get(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IEnumerable<Empleado> GetEmpleados()
        {
            try
            {
                BaseRepository<Empleado> repository = new EmpleadoRepo(context);
                return repository.Get();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Empleado Update(Empleado entity)
        {
            try
            {
                BaseRepository<Empleado> repository = new EmpleadoRepo(context);
                repository.Update(entity);
                context.SaveChanges();
                return entity;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
