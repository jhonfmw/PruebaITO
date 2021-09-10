using Prueba.Repository.Repository.Base;
using Repository.Context;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class EmpleadoRepo : BaseRepository<Empleado>
    {
        public EmpleadoRepo(ContextPrueba context) : base(context)
        {

        }

        public override long Create(Empleado Entity)
        {
            try
            {
                context.Empleado.Add(Entity);
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override void Delete(Empleado Entity)
        {
            try
            {
                context.Remove(Entity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override Empleado Get(int id)
        {
            try
            {
                return context.Empleado.FirstOrDefault(x => x.Id == id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override ICollection<Empleado> Get()
        {
            try
            {
                return context.Empleado.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void Update(Empleado Entity)
        {
            try
            {
                context.Update(Entity);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
