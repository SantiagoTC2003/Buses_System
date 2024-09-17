using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Autobuses_FrontEnd_SPDC.Models
{
    public class ModeloUnidades
    {
        public ModeloUnidades()
        {
            Id = 0;
            Modelo = string.Empty;
            Capacidad = 0;
            Estado = string.Empty;
            Ruta_id = 0;
            Chofer_id = 0;
            Montos = new HashSet<ModeloMontos>();
        }

        public int Id { get; set; }
        public string Modelo { get; set; }
        public int Capacidad { get; set; }
        public string Estado { get; set; }
        public int? Ruta_id { get; set; }
        public int? Chofer_id { get; set; }

        public virtual ModeloChoferes Chofer { get; set; }
        public virtual ModeloRutas Ruta { get; set; }
        public virtual ICollection<ModeloMontos> Montos { get; set; }
    }
}
}
