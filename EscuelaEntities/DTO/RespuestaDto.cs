﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaEntities.DTO
{
    public class RespuestaDto
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
        public Object Data { get; set; }
    }
}
