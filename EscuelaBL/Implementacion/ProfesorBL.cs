﻿using EscuelaBL.Interfaces;
using EscuelaDAL.Interfaces;
using EscuelaEntities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscuelaBL.Implementacion
{
    public class ProfesorBL : IProfesorBL
    {
        private readonly IEntidadDAL<ProfesorDto> _entidadDal;

        public ProfesorBL(IEntidadDAL<ProfesorDto> entidadDAL)
        {
            _entidadDal = entidadDAL;
        }
        public RespuestaDto Listar()
        {
            return new RespuestaDto
            {
                Exitoso = true,
                Mensaje = "OK",
                Data = _entidadDal.Listar()
            };
        }
        public RespuestaDto ObtenerInfo(int id)
        {
            var info = _entidadDal.ObtenerInfo(id);
            return new RespuestaDto
            {
                Exitoso = info != null ? true : false,
                Mensaje = info != null ? "OK" : "Error",
                Data = info!
            };
        }
        public RespuestaDto Crear(ProfesorDto dto)
        {
            bool esExitoso = _entidadDal.Crear(dto);
            return new RespuestaDto
            {
                Exitoso = esExitoso,
                Mensaje = "OK"
            };
        }
        public RespuestaDto Actualizar(ProfesorDto dto)
        {
            bool esExitoso = _entidadDal.Actualizar(dto);
            return new RespuestaDto
            {
                Exitoso = esExitoso,
                Mensaje = esExitoso ? "OK" : "Error"
            };
        }
        public RespuestaDto Borrar(int id)
        {
            bool esExitoso = _entidadDal.Borrar(id);
            return new RespuestaDto
            {
                Exitoso = esExitoso,
                Mensaje = esExitoso ? "OK" : "Error"
            };
        }
    }
}