using Microsoft.EntityFrameworkCore;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Context
{
    public class ContextPrueba : DbContext
    {
        public ContextPrueba(DbContextOptions<ContextPrueba> options)
            : base(options)
        {
        }

        public DbSet<Dependencia> Dependencia { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
    }
}
