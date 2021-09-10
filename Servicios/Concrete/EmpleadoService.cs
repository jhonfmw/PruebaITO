using Repository.Business.BO;
using Repository.Business.Interface;
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
    public class EmpleadoService : IEmpleadoService
    {
        private readonly ContextPrueba context;

        public EmpleadoService(ContextPrueba context)
        {
            this.context = context;
        }
        public Empleado Create(Empleado data)
        {
            try
            {
                IEmpleado empleadoService = new EmpleadosBO(context);
                return empleadoService.Create(data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Empleado> Get()
        {
            try
            {
                IEmpleado empleadoService = new EmpleadosBO(context);
                return empleadoService.GetEmpleados();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Empleado Get(int id)
        {
            try
            {
                IEmpleado empleadoService = new EmpleadosBO(context);
                return empleadoService.GetFirst(id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Empleado data)
        {
            try
            {
                IEmpleado empleadoService = new EmpleadosBO(context);
                empleadoService.Update(data);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(Empleado data)
        {
            try
            {
                IEmpleado empleadoService = new EmpleadosBO(context);
                empleadoService.Delete(data);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}