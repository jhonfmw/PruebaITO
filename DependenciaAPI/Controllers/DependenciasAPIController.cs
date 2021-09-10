using AutoMapper;
using DependenciasAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Context;
using Repository.Entities;
using Servicios.Concrete;
using Servicios.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DependenciasAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DependenciasAPIController : ControllerBase
    {
        private readonly ContextPrueba context;
        private readonly IMapper mapper;

        public DependenciasAPIController(ContextPrueba context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        // GET: api/<EmpleadoAPIController>
        [HttpGet]
        public ActionResult<IEnumerable<Dependencias>> Get()
        {
            IDependenciaService empleadoService = new DependenciaService(context);
            var result = empleadoService.Get();
            var dependencias = mapper.Map<List<Dependencias>>(result);
            return dependencias;
        }

        // GET api/<EmpleadoAPIController>/5
        [HttpGet("{id}")]
        public ActionResult<Dependencias> Get(int id)
        {
            IDependenciaService empleadoService = new DependenciaService(context);
            var result = empleadoService.Get(id);
            var empleado = mapper.Map<Dependencias>(result);
            return empleado;
        }

        // POST api/<EmpleadoAPIController>
        [HttpPost]
        public IActionResult Post([FromBody] Dependencia data)
        {
            IDependenciaService empleadoService = new DependenciaService(context);
            var empleadoNew = mapper.Map<Dependencia>(data);
            empleadoService.Create(empleadoNew);
            return CreatedAtAction("Get", new { id = data.Id }, data);
        }

        // PUT api/<EmpleadoAPIController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Dependencias data)
        {
            IDependenciaService empleadoService = new DependenciaService(context);
            var empleado = empleadoService.Get(id);
            if (empleado == null)
            {
                return BadRequest();
            }
            var empleadoUpd = mapper.Map<Dependencia>(data);
            empleadoService.Update(empleadoUpd);
            return NoContent();
        }

        // DELETE api/<EmpleadoAPIController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            IDependenciaService empleadoService = new DependenciaService(context);
            var empleado = empleadoService.Get(id);
            if (empleado == null)
            {
                return NotFound();
            }
            empleadoService.Delete(empleado);
            return NoContent();
        }
    }
}
