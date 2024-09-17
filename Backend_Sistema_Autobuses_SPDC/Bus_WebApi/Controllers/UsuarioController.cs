using Entidades;
using Microsoft.AspNetCore.Mvc;
using Negocio;
using System.Collections.Generic;

namespace Bus_WebApi.Controllers
{
    [ApiController]
    [Route("api/Usuarios")]

    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route(nameof(ConsultarUsuariosXEstado))]
        public List<Usuario> ConsultarUsuariosXEstado([FromHeader] string P_ID_Estado)
        {
            return Logica.ConsultarUsuariosXEstado(new Usuario { ID_Estado = P_ID_Estado });
        }

        [HttpGet]
        [Route(nameof(ConsultarUsuariosXNombre))]
        public List<Usuario> ConsultarUsuariosXNombre([FromHeader] string P_Nombre)
        {
            return Logica.ConsultarUsuariosXNombre(new Usuario { Nombre_Usuario = P_Nombre });
        }

    }
}
