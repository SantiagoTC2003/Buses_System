using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Autobuses_FrontEnd_SPDC.Models
{
    public class ModeloUsuarioRoles
    {

        public ModeloUsuarioRoles()
        {
            Usuario_id = 0;
            Rol_id = 0;
        }

        public int Usuario_id { get; set; }
        public int Rol_id { get; set; }

        public virtual ModeloRoles Rol { get; set; }
        public virtual ModeloUsuarios Usuario { get; set; }

    }

}
