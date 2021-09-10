using Repository.Entities;
using System.Collections.Generic;

namespace Servicios.Contracts
{
    public interface IEmpleadoService
    {
        public void Update(Empleado data);
        public IEnumerable<Empleado> Get();
        public Empleado Get(int id);
        public Empleado Create(Empleado data);
        void Delete(Empleado data);
    }
}
