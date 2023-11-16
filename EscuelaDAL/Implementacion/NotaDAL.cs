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
    public class NotaDAL : INotaDAL
    {
        private readonly EscuelaBDContext _context;

        public NotaDAL(EscuelaBDContext context)
        {
            _context = context;
        }
        public List<NotaDto> Listar()
        {
            List<NotaDto> lstNotas = new List<NotaDto>();
            foreach (var item in _context.Notas.ToList())
            {
                lstNotas.Add(Convertidor.ANotaDto(item));
            }
            return lstNotas;
        }
        public NotaDto ObtenerInfo(int id)
        {
            return Convertidor.ANotaDto(_context.Notas.FirstOrDefault(x => x.Id == id)!);
        }
        public bool Crear(NotaDto dto)
        {
            try
            {
                _context.Notas.Add(Convertidor.ANota(dto));
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Actualizar(NotaDto dto)
        {
            try
            {
                _context.Notas.Update(Convertidor.ANota(dto));
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
            var nota = _context.Notas.FirstOrDefault(x => x.Id == id);
            try
            {
                _context.Notas.Remove(nota);
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
