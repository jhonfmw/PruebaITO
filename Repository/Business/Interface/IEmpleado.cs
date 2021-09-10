using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Business.Interface
{
    public interface IEmpleado
    {
        Empleado Create(Empleado entity);

        Empleado Update(Empleado entity);

        bool Delete(Empleado entity);

        IEnumerable<Empleado> GetEmpleados();
        Empleado GetFirst(int id);
    }
}