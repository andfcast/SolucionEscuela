using System;
using System.Collections.Generic;

namespace EscuelaEntities.DBEntities
{
    public partial class Nota
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public int IdProfesor { get; set; }
        public int IdEstudiante { get; set; }
        public decimal Valor { get; set; }

        public virtual Estudiante IdEstudianteNavigation { get; set; } = null!;
        public virtual Profesor IdProfesorNavigation { get; set; } = null!;
    }
}
