using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Autobuses_FrontEnd_SPDC.Models
{
    public class ModeloRoles
    {
        public ModeloRoles()
        {
            Id = 0;
            Nombre = string.Empty;
            UsuarioRoles = new HashSet<ModeloUsuarioRoles>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<ModeloUsuarioRoles> UsuarioRoles { get; set; }
    }
}
}
