using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaEntities.DTO
{
    public class NotaDto
    {
        public int Id { get; set; }
        public string Asignatura { get; set; }
        public int IdEstudiante { get;set; }
        public int IdProfesor { get; set; }
        public decimal Valor { get; set; }
    }
}
