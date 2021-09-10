using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependenciasAPI.Models
{
    public class Empleados
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Documento { get; set; }
        public string Direccion { get; set; }
    }
}
