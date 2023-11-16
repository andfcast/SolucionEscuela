using EscuelaBL.Implementacion;
using EscuelaBL.Interfaces;
using EscuelaEntities.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EscuelaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        private readonly IProfesorBL _profesorBL;

        public ProfesorController(IProfesorBL profesorBL)
        {
            _profesorBL = profesorBL;
        }
        // GET: api/<ProfesorController>
        [HttpGet("[action]")]
        public RespuestaDto Listar()
        {
            return _profesorBL.Listar();
        }

        // GET api/<ProfesorController>/5
        [HttpGet("[action]/{id}")]
        public RespuestaDto Obtener(int id)
        {
            return _profesorBL.ObtenerInfo(id);
        }

        // POST api/<ProfesorController>
        [HttpPost("[action]")]
        public RespuestaDto Crear([FromBody] ProfesorDto dto)
        {
            return _profesorBL.Crear(dto);
        }

        // PUT api/<ProfesorController>/5
        [HttpPut("[action]/{id}")]
        public RespuestaDto Actualizar(int id, [FromBody] ProfesorDto dto)
        {
            return _profesorBL.Actualizar(dto);
        }

        // DELETE api/<ProfesorController>/5
        [HttpDelete("[action]/{id}")]
        public RespuestaDto Borrar(int id)
        {
            return _profesorBL.Borrar(id);
        }
    }
}
