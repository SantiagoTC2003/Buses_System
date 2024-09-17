using Entidades;
using Microsoft.AspNetCore.Mvc;
using Negocio;
using System.Collections.Generic;

namespace Bus_WebApi.Controllers
{
    [ApiController]
    [Route("api/Estados")]

    public class EstadoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route(nameof(ConsultarEstados))]
        public List<Estado> ConsultarEstados()
        {
            return Logica.ConsultarEstados();
        }

    }
}
