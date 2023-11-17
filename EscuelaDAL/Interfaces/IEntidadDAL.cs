using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaDAL.Interfaces
{
    public interface IEntidadDAL<T>
    {
        List<T> Listar();
        T ObtenerInfo(int id);
        bool Crear(T dto, ref string error);
        bool Actualizar(T dto, ref string error);
        bool Borrar(int id);
    }
}
