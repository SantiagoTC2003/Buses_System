using Entidades;
using Microsoft.AspNetCore.Mvc;
using Negocio;
using System.Collections.Generic;

namespace Bus_WebApi.Controllers
{
    [ApiController]
    [Route("api/Bus")]

    public class BusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route(nameof(AgregarBus))]
        public bool AgregarBus(Bus P_Bus)
        {
            return Logica.AgregarBus(P_Bus);
        }

        [HttpPut]
        [Route(nameof(ModificarBus))]
        public bool ModificarBus([FromHeader] string P_ID_Bus, [FromBody] Bus P_Bus)
        {
            return Logica.ModificarBus(new Bus { ID_Bus = P_ID_Bus, Marca = P_Bus.Marca, Modelo = P_Bus.Modelo, Año = P_Bus.Año, Capacidad = P_Bus.Capacidad, ID_Estado = P_Bus.ID_Estado });
        }

        [HttpDelete]
        [Route(nameof(EliminarBus))]
        public bool EliminarBus([FromHeader] string P_ID_Bus)
        {
            return Logica.EliminarBus(new Bus { ID_Bus = P_ID_Bus });
        }

        [HttpGet]
        [Route(nameof(ConsultarBuses))]
        public List<Bus> ConsultarBuses()
        {
            return Logica.ConsultarBuses();
        }

        [HttpGet]
        [Route(nameof(ConsultarBusesXEstado))]
        public List<Bus> ConsultarBusesXEstado([FromHeader] string P_ID_Estado)
        {
            return Logica.ConsultarBusesXEstado(new Bus { ID_Estado = P_ID_Estado });
        }

    }
}
