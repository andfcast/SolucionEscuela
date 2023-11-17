using EscuelaDAL.Interfaces;
using EscuelaEntities.DBEntities;
using EscuelaEntities.DTO;
using EscuelaUtils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaDAL.Implementacion
{
    public class ProfesorDAL : IProfesorDAL
    {
        private readonly EscuelaBDContext _context;

        public ProfesorDAL(EscuelaBDContext context) {
            _context = context;
        }
        public List<ProfesorDto> Listar()
        {
            List<ProfesorDto> lstProfesores = new List<ProfesorDto>();
            foreach (var item in _context.Profesores.ToList())
            {
                lstProfesores.Add(Convertidor.AProfesorDto(item));
            }
            return lstProfesores;
        }
        public ProfesorDto ObtenerInfo(int id)
        {
            return Convertidor.AProfesorDto(_context.Profesores.FirstOrDefault(x => x.Id == id)!);
        }
        public bool Crear(ProfesorDto dto, ref string error)
        {
            try
            {
                if (_context.Profesores.Count(x => x.Nombre.ToLower() == dto.Nombre.ToLower()) > 0)
                {
                    error = "Ya existe un registro con los mismos valores. Favor revisar";
                    return false;
                }
                _context.Profesores.Add(Convertidor.AProfesor(dto));
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Actualizar(ProfesorDto dto, ref string error)
        {
            try
            {
                if (_context.Estudiantes.Count(x => x.Nombre.ToLower() == dto.Nombre.ToLower() && x.Id != dto.Id) > 0)
                {
                    error = "Ya existe un registro con los mismos valores. Favor revisar";
                    return false;
                }
                _context.Profesores.Update(Convertidor.AProfesor(dto));
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Borrar(int id)
        {
            var profesor = _context.Profesores.FirstOrDefault(x => x.Id == id);
            try
            {
                _context.Profesores.Remove(profesor);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
