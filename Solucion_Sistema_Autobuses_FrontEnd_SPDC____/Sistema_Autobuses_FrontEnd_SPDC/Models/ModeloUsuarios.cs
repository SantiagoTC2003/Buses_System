using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Autobuses_FrontEnd_SPDC.Models
{
    public class ModeloUsuarios
    {
        public ModeloUsuarios()
        {
            UsuarioRoles = new HashSet<ModeloRoles>();
            Id = 0;
            Nombre = string.Empty;
            Contrasena = string.Empty;
            Rol = string.Empty;
        }

        // metodo para identificar si el usuario y contrasena estan registrados
        public ModeloUsuarios ValidarAutenticacion()
        {
            List<ModeloUsuarios> lstusuarios = new List<ModeloUsuarios>();

            ModeloUsuarios encontrado = lstusuarios.Find(x => x.Nombre.ToUpper().ToUpper().Equals(this.Nombre)
                                                    && x.Contrasena.Trim().Equals(this.Contrasena.Trim()));

            return encontrado;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public string Rol { get; set; }

        public virtual ICollection<ModeloRoles> UsuarioRoles { get; set; }

    }




}
}
