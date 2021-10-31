using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ResistenciaApi.Domain.Entities;

namespace ResistenciaApi.Controllers
{
    /* 
    Nombre de la escuela: Universidad Tecnologica Metropolitana

    Asignatura: Aplicaciones Web Orientadas a Servicios

    Nombre del Maestro: Joel Ivan Chuc Uc

    Nombre de la actividad: Actividad 2 (Unidad ll)

    Nombre del alumno: Eduardo Antonio Caballero Pech

    Cuatrimestre: 4    Grupo: B    Parcial: 2
*/
    [ApiController]

    [Route("api/[controller]")]
    public class BandasController:ControllerBase
    {
        [HttpGet]
        [Route("Calcular")]

        public IActionResult Lineas(string _Banda1, string _Banda2, string _Banda3, string _Banda4)

        {
            var rest = new Colors();

            rest.Bandauno(_Banda1);

            if (_Banda1.ToLower() != "naranja" && _Banda1.ToLower() != "negro" && _Banda1.ToLower() != "violeta"
            && _Banda1.ToLower() != "blanco" && _Banda1.ToLower() != "azul" && _Banda1.ToLower() != "verde"
            && _Banda1.ToLower() != "gris" && _Banda1.ToLower() != "amarillo" && _Banda1.ToLower() != "cafe"
            && _Banda1.ToLower() != "rojo")

            {
                return Ok("El color de la Linea 1 es INCORRECTO");
            }

            rest.Bandados(_Banda2);

            if (_Banda2.ToLower() != "naranja" && _Banda2.ToLower() != "negro" && _Banda2.ToLower() != "violeta"
            && _Banda2.ToLower() != "blanco" && _Banda2.ToLower() != "azul" && _Banda2.ToLower() != "verde"
            && _Banda2.ToLower() != "gris" && _Banda2.ToLower() != "amarillo" && _Banda2.ToLower() != "cafe"
            && _Banda2.ToLower() != "rojo")

            {
                return Ok("El color de la Linea 2 es INCORRECTO");
            }

            rest.Bandatres(_Banda3);

            if (_Banda3.ToLower() != "naranja" && _Banda3.ToLower() != "azul" && _Banda3.ToLower() != "verde"
            && _Banda3.ToLower() != "negro" && _Banda3.ToLower() != "rojo" && _Banda3.ToLower() != "cafe"
            && _Banda3.ToLower() != "amarillo" || _Banda3.ToLower() == "violeta" || _Banda3.ToLower() == "gris" || _Banda3.ToLower() == "blanco")

            {
                return Ok("El color de la Linea 3 es INCORRECTO");
            }

            rest.Bandacuatro(_Banda4);

            if (_Banda4.ToLower() != "dorado" && _Banda4.ToLower() != "plata")
            {
                return Ok("El color de la Linea 4 es INCORRECTO, Solo se acepta el color DORADO y PLATA");
            }
            rest.Retornardatos();

            return Ok(rest.Retornardatos());
        }
    }
}
