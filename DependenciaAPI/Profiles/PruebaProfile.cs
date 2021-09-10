
using AutoMapper;
using DependenciasAPI.Models;
using Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependenciasAPI.Profiles
{
    public class PruebaProfile : Profile    
    {
        public PruebaProfile()
        {
            CreateMap<Empleado, Empleados>().ReverseMap();
            CreateMap<Dependencia, Dependencias>().ReverseMap();
        }
    }
}
