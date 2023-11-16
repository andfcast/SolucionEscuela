using EscuelaBL.Interfaces;
using EscuelaEntities.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EscuelaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudianteController : ControllerBase
    {

        private readonly IEstudianteBL _estudianteBL;

        public EstudianteController(IEstudianteBL estudianteBL) {
            _estudianteBL = estudianteBL;
        }
        // GET: api/<EstudianteController>
        [HttpGet("[action]")]
        public RespuestaDto Listar()
        {
            return _estudianteBL.Listar();
        }

        // GET api/<EstudianteController>/5
        [HttpGet("[action]/{id}")]
        public RespuestaDto Obtener(int id)
        {
            return _estudianteBL.ObtenerInfo(id);
        }

        // POST api/<EstudianteController>
        [HttpPost("[action]")]
        public RespuestaDto Crear([FromBody] EstudianteDto dto)
        {
            return _estudianteBL.Crear(dto);
        }

        // PUT api/<EstudianteController>/5
        [HttpPut("[action]/{id}")]
        public RespuestaDto Actualizar(int id, [FromBody] EstudianteDto dto)
        {
            return _estudianteBL.Actualizar(dto);
        }

        // DELETE api/<EstudianteController>/5
        [HttpDelete("[action]/{id}")]
        public RespuestaDto Borrar(int id)
        {
            return _estudianteBL.Borrar(id);
        }
    }
}
