using EscuelaBL.Implementacion;
using EscuelaBL.Interfaces;
using EscuelaEntities.DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EscuelaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotaController : ControllerBase
    {

        private readonly INotaBL _notaBL;

        public NotaController(INotaBL notaBL)
        {
            _notaBL = notaBL;
        }
        // GET: api/<NotaController>
        [HttpGet("[action]")]
        public RespuestaDto Listar()
        {
            return _notaBL.Listar();
        }

        // GET api/<EstudianteController>/5
        [HttpGet("[action]/{id}")]
        public RespuestaDto Obtener(int id)
        {
            return _notaBL.ObtenerInfo(id);
        }

        // POST api/<EstudianteController>
        [HttpPost("[action]")]
        public RespuestaDto Crear([FromBody] NotaDto dto)
        {
            return _notaBL.Crear(dto);
        }

        // PUT api/<EstudianteController>/5
        [HttpPut("[action]/{id}")]
        public RespuestaDto Actualizar(int id, [FromBody] NotaDto dto)
        {
            return _notaBL.Actualizar(dto);
        }

        // DELETE api/<EstudianteController>/5
        [HttpDelete("[action]/{id}")]
        public RespuestaDto Borrar(int id)
        {
            return _notaBL.Borrar(id);
        }
    }
}
