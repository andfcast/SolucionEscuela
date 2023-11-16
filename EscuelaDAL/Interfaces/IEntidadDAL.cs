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
        bool Crear(T dto);
        bool Actualizar(T dto);
        bool Borrar(int id);
    }
}
