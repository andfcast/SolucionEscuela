using EscuelaEntities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaBL.Interfaces
{
    public interface IEntidadBL<T>
    {
        RespuestaDto Listar();
        RespuestaDto ObtenerInfo(int id);
        RespuestaDto Crear(T dto);
        RespuestaDto Actualizar(T dto);
        RespuestaDto Borrar(int id);
    }
}
