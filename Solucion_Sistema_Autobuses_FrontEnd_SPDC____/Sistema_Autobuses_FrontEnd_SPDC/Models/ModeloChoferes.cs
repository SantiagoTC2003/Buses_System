using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Autobuses_FrontEnd_SPDC.Models
{
    public class ModeloChoferes
    {
        public ModeloChoferes()
        {
            Id = 0;
            Nombre = string.Empty;
            Unidades_asignadas = 0;
            Unidades = new HashSet<ModeloUnidades>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Unidades_asignadas { get; set; }

        public virtual ICollection<ModeloUnidades> Unidades { get; set; }
    }
}
}
