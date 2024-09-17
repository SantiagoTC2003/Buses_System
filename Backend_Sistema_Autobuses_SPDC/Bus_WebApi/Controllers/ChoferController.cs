using Entidades;
using Microsoft.AspNetCore.Mvc;
using Negocio;
using System.Collections.Generic;

namespace Bus_WebApi.Controllers
{
    [ApiController]
    [Route("api/Choferes")]

    public class ChoferController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route(nameof(AgregarChofer))]
        public bool AgregarChofer(Chofer P_Chofer)
        {
            return Logica.AgregarChofer(P_Chofer);
        }

        [HttpPut]
        [Route(nameof(ModificarChofer))]
        public bool ModificarChofer([FromHeader] string P_Cedula, [FromBody] Chofer P_Chofer)
        {
            return Logica.ModificarChofer(new Chofer { Cedula = P_Cedula, Nombre_Chofer = P_Chofer.Nombre_Chofer, Licencia = P_Chofer.Licencia, ID_Estado = P_Chofer.ID_Estado });
        }

        [HttpDelete]
        [Route(nameof(EliminarChofer))]
        public bool EliminarChofer([FromHeader] string P_Cedula)
        {
            return Logica.EliminarChofer(new Chofer { Cedula = P_Cedula });
        }

        [HttpGet]
        [Route(nameof(ConsultarChoferes))]
        public List<Chofer> ConsultarChoferes()
        {
            return Logica.ConsultarChoferes();
        }

        [HttpGet]
        [Route(nameof(ConsultarChoferesXEstado))]
        public List<Chofer> ConsultarChoferesXEstado([FromHeader] string P_ID_Estado)
        {
            return Logica.ConsultarChoferesXEstado(new Chofer { ID_Estado = P_ID_Estado });
        }

    }
}
