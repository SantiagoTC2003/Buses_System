using Entidades;
using Microsoft.AspNetCore.Mvc;
using Negocio;
using System;
using System.Collections.Generic;

namespace Bus_WebApi.Controllers
{
    [ApiController]
    [Route("api/Itinerarios")]

    public class ItinerarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route(nameof(AgregarItinerario))]
        public bool AgregarItinerario(Itinerario P_Itinerario)
        {
            return Logica.AgregarItinerario(P_Itinerario);
        }

        [HttpPut]
        [Route(nameof(ModificarItinerario))]
        public bool ModificarItinerario([FromHeader] int P_ID_Itinerario, [FromBody] Itinerario P_Itinerario)
        {
            return Logica.ModificarItinerario(new Itinerario { ID_Itinerario = P_ID_Itinerario, Nombre_Chofer = P_Itinerario.Nombre_Chofer, ID_Bus = P_Itinerario.ID_Bus, Nombre_Ruta = P_Itinerario.Nombre_Ruta, Fecha = P_Itinerario.Fecha, Recaudacion_Proyectada = P_Itinerario.Recaudacion_Proyectada, Recaudacion_Final = P_Itinerario.Recaudacion_Final, Estado_Salida = P_Itinerario.Estado_Salida, Estado_Regreso = P_Itinerario.Estado_Regreso });
        }

        [HttpDelete]
        [Route(nameof(EliminarItinerario))]
        public bool EliminarItinerario([FromHeader] int P_ID_Itinerario)
        {
            return Logica.EliminarItinerario(new Itinerario { ID_Itinerario = P_ID_Itinerario });
        }

        [HttpGet]
        [Route(nameof(ConsultarItinerarios))]
        public List<Itinerario> ConsultarItinerarios()
        {
            return Logica.ConsultarItinerarios();
        }

        [HttpGet]
        [Route(nameof(ConsultarItinerariosXRuta))]
        public List<Itinerario> ConsultarItinerariosXRuta([FromHeader] string P_Nombre_Ruta)
        {
            return Logica.ConsultarItinerariosXRuta(new Itinerario { Nombre_Ruta = P_Nombre_Ruta });
        }

        [HttpGet]
        [Route(nameof(ConsultarItinerariosXFecha))]
        public List<Itinerario> ConsultarItinerariosXFecha([FromHeader] DateTime P_Fecha)
        {
            return Logica.ConsultarItinerariosXFecha(new Itinerario { Fecha = P_Fecha });
        }

    }
}
