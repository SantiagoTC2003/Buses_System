using Entidades;
using Microsoft.AspNetCore.Mvc;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bus_WebApi.Controllers
{
    [ApiController]
    [Route("api/Paradas")]

    public class ParadaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route(nameof(AgregarParada))]
        public bool AgregarParada(Parada P_Parada)
        {
            return Logica.AgregarParada(P_Parada);
        }

        [HttpPut]
        [Route(nameof(ModificarParada))]
        public bool ModificarParada([FromHeader] string P_Nombre_Parada, [FromBody] Parada P_Parada)
        {
            return Logica.ModificarParada(new Parada { Nombre_Parada = P_Nombre_Parada, Provincia = P_Parada.Provincia, Canton = P_Parada.Canton, Distrito = P_Parada.Distrito, Ubicacion = P_Parada.Ubicacion });
        }

        [HttpDelete]
        [Route(nameof(EliminarParada))]
        public bool EliminarParada([FromHeader] string P_Nombre_Parada)
        {
            return Logica.EliminarParada(new Parada { Nombre_Parada = P_Nombre_Parada });
        }

        [HttpGet]
        [Route(nameof(ConsultarParadas))]
        public List<Parada> ConsultarParadas()
        {
            return Logica.ConsultarParadas();
        }

        [HttpGet]
        [Route(nameof(ConsultarParadasXProvincia))]
        public List<Parada> ConsultarParadasXProvincia([FromHeader] string P_Provincia)
        {
            return Logica.ConsultarParadasXProvincia(new Parada { Provincia = P_Provincia });
        }

        [HttpGet]
        [Route(nameof(ConsultarParadasXCanton))]
        public List<Parada> ConsultarParadasXCanton([FromHeader] string P_Canton)
        {
            return Logica.ConsultarParadasXCanton(new Parada { Canton = P_Canton });
        }

        [HttpGet]
        [Route(nameof(ConsultarParadasXDistrito))]
        public List<Parada> ConsultarParadasXDistrito([FromHeader] string P_Distrito)
        {
            return Logica.ConsultarParadasXDistrito(new Parada { Distrito = P_Distrito });
        }

    }
}
