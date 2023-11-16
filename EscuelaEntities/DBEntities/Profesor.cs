using System;
using System.Collections.Generic;

namespace EscuelaEntities.DBEntities
{
    public partial class Profesor
    {
        public Profesor()
        {
            Notas = new HashSet<Nota>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public virtual ICollection<Nota> Notas { get; set; }
    }
}
