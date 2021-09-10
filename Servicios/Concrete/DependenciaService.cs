using Repository.Context;
using Repository.Entities;
using Servicios.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Concrete
{
    public class DependenciaService : IDependenciaService
    {

        private readonly ContextPrueba context;

        public DependenciaService(ContextPrueba context)
        {
            this.context = context;
        }
        public Dependencia Create(Dependencia data)
        {
            throw new NotImplementedException();
        }

        public void Delete(Dependencia data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Dependencia> Get()
        {
            throw new NotImplementedException();
        }

        public Dependencia Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Dependencia data)
        {
            throw new NotImplementedException();
        }
    }
}
