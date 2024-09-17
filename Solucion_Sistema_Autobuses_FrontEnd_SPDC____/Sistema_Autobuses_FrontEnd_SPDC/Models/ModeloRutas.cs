using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Autobuses_FrontEnd_SPDC.Models
{
    public class ModeloRutas
    {
        public ModeloRutas()
        {
            Id = 0;
            Nombre = string.Empty;
            Costo_pasaje = 0;
            Montos = new HashSet<ModeloMontos>();
            Paradas = new HashSet<ModeloParadas>();
            Unidades = new HashSet<ModeloUnidades>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Costo_pasaje { get; set; }

        public virtual ICollection<ModeloMontos> Montos { get; set; }
        public virtual ICollection<ModeloParadas> Paradas { get; set; }
        public virtual ICollection<ModeloUnidades> Unidades { get; set; }
    }
}
}
