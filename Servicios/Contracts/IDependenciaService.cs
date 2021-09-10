using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Contracts
{
    public interface IDependenciaService
    {
        public void Update(Dependencia data);
        public IEnumerable<Dependencia> Get();
        public Dependencia Get(int id);
        public Dependencia Create(Dependencia data);
        void Delete(Dependencia data);
    }
}
