using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Autobuses_FrontEnd_SPDC.Models
{
    public class ModeloMontos
    {
        public class ModeloMontos
        {
            public ModeloMontos()
            {
                Id = 0;
                Fecha = default(DateTime);
                Ruta_id = 0;
                Unidad_id = 0;
                Monto_estimado = 0;
                Monto_recibido = 0;
            }
            public int Id { get; set; }
            public DateTime Fecha { get; set; }
            public int Ruta_id { get; set; }
            public int Unidad_id { get; set; }
            public double Monto_estimado { get; set; }
            public double Monto_recibido { get; set; }

            public virtual ModeloRutas Ruta { get; set; }
            public virtual ModeloUnidades Unidad { get; set; }
        }
    }
}
