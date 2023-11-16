using EscuelaEntities.DBEntities;
using EscuelaEntities.DTO;

namespace EscuelaUtils
{
    public static class Convertidor
    {
        #region Estudiante
        public static Estudiante AEstudiante(EstudianteDto dto) {
            return new Estudiante
            {
                Id = dto.Id,
                Nombre = dto.Nombre
            };
        }

        public static EstudianteDto AEstudianteDto(Estudiante entidad)
        {
            return new EstudianteDto
            {
                Id = entidad.Id,
                Nombre = entidad.Nombre
            };
        }
        #endregion

        #region Profesor
        public static Profesor AProfesor(ProfesorDto dto)
        {
            return new Profesor
            {
                Id = dto.Id,
                Nombre = dto.Nombre
            };
        }

        public static ProfesorDto AProfesorDto(Profesor entidad)
        {
            return new ProfesorDto
            {
                Id = entidad.Id,
                Nombre = entidad.Nombre
            };
        }
        #endregion

        #region Nota
        public static Nota ANota(NotaDto dto)
        {
            return new Nota
            {
                Id = dto.Id,
                Nombre = dto.Asignatura,
                IdEstudiante = dto.IdEstudiante,
                IdProfesor = dto.IdProfesor,
                Valor = dto.Valor
            };
        }

        public static NotaDto ANotaDto(Nota entidad)
        {
            return new NotaDto
            {
                Id = entidad.Id,
                Asignatura = entidad.Nombre,
                IdEstudiante = entidad.IdEstudiante,
                IdProfesor = entidad.IdProfesor,
                Valor = entidad.Valor
            };
        }
        #endregion
    }
}