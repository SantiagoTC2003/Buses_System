namespace Entidades
{
    public class Bus
    {

        #region Atributos

        public string ID_Bus { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Año { get; set; }
        public int Capacidad { get; set; }
        public string ID_Estado { get; set; }
        
        #endregion

        #region Constructor

        public Bus()
        {
            ID_Bus = string.Empty;
            Modelo = string.Empty;
            Marca = string.Empty;
            Año = 0;
            Capacidad = 0;
            ID_Estado = string.Empty;
        }

        #endregion

    }
}
