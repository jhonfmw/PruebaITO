using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SwaggerAPI.Models;
using SwaggerAPI.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SwaggerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DependenciasController : ControllerBase
    {
        private readonly ConnectionAPI appiCommon;
        private readonly string recursoDependencia;
        public DependenciasController(IConfiguration configuration)
        {
            var apiUrl = configuration.GetConnectionString("ApiDependencia");
            recursoDependencia = "DependenciasAPI";
            appiCommon = new ConnectionAPI($"{apiUrl}/{recursoDependencia}");
        }
        // GET: api/<EmpleadoController>
        [HttpGet]
        public async Task<IEnumerable<DependenciasDTO>> GetAsync()
        {
            var result = await appiCommon.GetRequest<List<DependenciasDTO>>();
            return result;
        }

        // GET api/<EmpleadoController>/5
        [HttpGet("{id}")]
        public async Task<DependenciasDTO> GetAsync(int id)
        {
            var result = await appiCommon.GetRequest<DependenciasDTO>($"{id}");
            return result;
        }

        // POST api/<EmpleadoController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DependenciasDTO value)
        {
            await appiCommon.PostRequest(value);
            return Ok();
        }

        // PUT api/<EmpleadoController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] string value)
        {
            await appiCommon.PutRequest(value, id);
            return Ok();
        }

        // DELETE api/<EmpleadoController>/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult> Delete(int id)
        //{
        //}
    }
}
