using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Autobuses_FrontEnd_SPDC.Models
{
    public class ModeloParadas
    {
            public ModeloParadas()
            {
                Id = 0;
                Nombre = string.Empty;
                Ruta_id = 0;
                Orden = 0;
            }
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int Ruta_id { get; set; }
            public int Orden { get; set; }
            public virtual ModeloRutas Ruta { get; set; }
        }
    }
}
