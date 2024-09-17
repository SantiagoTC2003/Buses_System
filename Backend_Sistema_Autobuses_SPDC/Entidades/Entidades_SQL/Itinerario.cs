using System;

namespace Entidades
{
    public class Itinerario
    {

        #region Atributos

        public int ID_Itinerario { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre_Ruta { get; set; }
        public string Nombre_Chofer { get; set; }
        public string ID_Bus { get; set; }
        public string Estado_Salida { get; set; }
        public string Estado_Regreso { get; set; }
        public int Recaudacion_Proyectada { get; set; }
        public int Recaudacion_Final { get; set; }

        #endregion

        #region Constructor

        public Itinerario()
        {
            ID_Itinerario = 0;
            Fecha = DateTime.Now;
            Nombre_Ruta = string.Empty;
            Nombre_Chofer = string.Empty;
            ID_Bus = string.Empty;
            Estado_Salida = string.Empty;
            Estado_Regreso = string.Empty;
            Recaudacion_Proyectada = 0;
            Recaudacion_Final = 0;
        }

        #endregion

    }
}
