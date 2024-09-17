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
    [Route("api/Rutas")]

    public class RutaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route(nameof(AgregarRuta))]
        public bool AgregarRuta(Ruta P_Ruta)
        {
            return Logica.AgregarRuta(P_Ruta);
        }

        [HttpPut]
        [Route(nameof(ModificarRuta))]
        public bool ModificarRuta([FromHeader] string P_Nombre_Ruta, [FromBody] Ruta P_Ruta)
        {
            return Logica.ModificarRuta(new Ruta { Nombre_Ruta = P_Nombre_Ruta, Provincia_inicio = P_Ruta.Provincia_inicio, Provincia_fin = P_Ruta.Provincia_fin, Canton_inicio = P_Ruta.Canton_inicio, Canton_fin = P_Ruta.Canton_fin, Distrito_inicio = P_Ruta.Distrito_inicio, Distrito_fin = P_Ruta.Distrito_fin, Distancia = P_Ruta.Distancia, Precio = P_Ruta.Precio });
        }

        [HttpDelete]
        [Route(nameof(EliminarRuta))]
        public bool EliminarRuta([FromHeader] string P_Nombre_Ruta)
        {
            return Logica.EliminarRuta(new Ruta { Nombre_Ruta = P_Nombre_Ruta });
        }

        [HttpGet]
        [Route(nameof(ConsultarRutas))]
        public List<Ruta> ConsultarRutas()
        {
            return Logica.ConsultarRutas();
        }

        [HttpGet]
        [Route(nameof(ConsultarRutasXDistrito_Inicio))]
        public List<Ruta> ConsultarRutasXDistrito_Inicio([FromHeader] string P_Distrito)
        {
            return Logica.ConsultarRutasXDistrito_Inicio(new Ruta { Distrito_inicio = P_Distrito });
        }

        [HttpGet]
        [Route(nameof(ConsultarRutasXDistrito_Fin))]
        public List<Ruta> ConsultarRutasXDistrito_Fin([FromHeader] string P_Distrito)
        {
            return Logica.ConsultarRutasXDistrito_Fin(new Ruta { Distrito_inicio = P_Distrito });
        }

    }
}
