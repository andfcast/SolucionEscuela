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
    public class EstudianteDAL : IEstudianteDAL
    {
        private readonly EscuelaBDContext _context;

        public EstudianteDAL(EscuelaBDContext context)
        {
            _context = context;
        }
        public List<EstudianteDto> Listar() {
            List<EstudianteDto> lstEstudiantes = new List<EstudianteDto>();
            foreach (var item in _context.Estudiantes.ToList())
            {
                lstEstudiantes.Add(Convertidor.AEstudianteDto(item));
            }
            return lstEstudiantes;
        }
        public EstudianteDto ObtenerInfo(int id) {
            return Convertidor.AEstudianteDto(_context.Estudiantes.FirstOrDefault(x => x.Id == id)!);
        }
        public bool Crear(EstudianteDto dto, ref string error) {
            try
            {
                if (_context.Estudiantes.Count(x =>  x.Nombre.ToLower() == dto.Nombre.ToLower()) > 0)
                {
                    error = "Ya existe un registro con los mismos valores. Favor revisar";
                    return false;
                }
                _context.Estudiantes.Add(Convertidor.AEstudiante(dto));
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Actualizar(EstudianteDto dto, ref string error) {
            try
            {
                if (_context.Estudiantes.Count(x => x.Nombre.ToLower() == dto.Nombre.ToLower() && x.Id != dto.Id) > 0)
                {
                    error = "Ya existe un registro con los mismos valores. Favor revisar";
                    return false;
                }
                _context.Estudiantes.Update(Convertidor.AEstudiante(dto));
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Borrar(int id) {
            var estudiante = _context.Estudiantes.FirstOrDefault(x => x.Id == id);
            try
            {
                _context.Estudiantes.Remove(estudiante);
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
