using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Business.Interface
{
    public interface IDependencia
    {
        Dependencia Create(Dependencia entity);

        Dependencia Update(Dependencia entity);

        bool Delete(Dependencia entity);

        IEnumerable<Dependencia> GetDependencias();
        Dependencia GetFirst(int id);
    }
}
