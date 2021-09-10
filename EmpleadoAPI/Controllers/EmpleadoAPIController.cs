using Microsoft.AspNetCore.Mvc;
using Repository.Context;
using Servicios.Concrete;
using System.Collections.Generic;
using Servicios.Contracts;
using AutoMapper;
using API.Models;
using Repository.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoAPIController : ControllerBase
    {
        private readonly ContextPrueba context;
        private readonly IMapper mapper;

        public EmpleadoAPIController(ContextPrueba context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        // GET: api/<EmpleadoAPIController>
        [HttpGet]
        public ActionResult<IEnumerable<Empleados>> Get()
        {
            IEmpleadoService empleadoService = new EmpleadoService(context);
            var result = empleadoService.Get();
            var empleados = mapper.Map<List<Empleados>>(result);
            return empleados;
        }

        // GET api/<EmpleadoAPIController>/5
        [HttpGet("{id}")]
        public ActionResult<Empleados> Get(int id)
        {
            IEmpleadoService empleadoService = new EmpleadoService(context);
            var result = empleadoService.Get(id);
            var empleado = mapper.Map<Empleados>(result);
            return empleado;
        }

        // POST api/<EmpleadoAPIController>
        [HttpPost]
        public IActionResult Post([FromBody] Empleados data)
        {
            IEmpleadoService empleadoService = new EmpleadoService(context);
            var empleadoNew = mapper.Map<Empleado>(data);
            empleadoService.Create(empleadoNew);
            return CreatedAtAction("Get", new { id = data.Id }, data);
        }

        // PUT api/<EmpleadoAPIController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Empleados data)
        {
            IEmpleadoService empleadoService = new EmpleadoService(context);
            var empleado = empleadoService.Get(id);
            if (empleado == null)
            {
                return BadRequest();
            }
            var empleadoUpd = mapper.Map<Empleado>(data);
            empleadoService.Update(empleadoUpd);
            return NoContent();
        }

        // DELETE api/<EmpleadoAPIController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            IEmpleadoService empleadoService = new EmpleadoService(context);
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
