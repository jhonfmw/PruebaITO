using Prueba.Repository.Repository.Base;
using Repository.Context;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class DependenciasRepo : BaseRepository<Dependencia>
    {
        public DependenciasRepo(ContextPrueba context) : base(context)
        {

        }
        public override long Create(Dependencia Entity)
        {
            try
            {
                context.Dependencia.Add(Entity);
                return 1;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override void Delete(Dependencia Entity)
        {
            try
            {
                context.Dependencia.Remove(Entity);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public override Dependencia Get(int id)
        {
            try
            {
                return context.Dependencia.FirstOrDefault(x => x.Id == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override ICollection<Dependencia> Get()
        {
            try
            {
                return context.Dependencia.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void Update(Dependencia Entity)
        {
            try
            {
                context.Dependencia.Update(Entity);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}