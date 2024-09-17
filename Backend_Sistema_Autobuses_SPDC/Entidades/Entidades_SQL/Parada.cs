namespace Entidades
{
    public class Parada
    {

        #region Atributos

        public string Nombre_Parada { get; set; }
        public string Provincia { get; set; }
        public string Canton { get; set; }
        public string Distrito { get; set; }
        public string Ubicacion { get; set; }

        #endregion

        #region Constructor

        public Parada()
        {
            Nombre_Parada = string.Empty;
            Provincia = string.Empty;
            Canton = string.Empty;
            Distrito = string.Empty;
            Ubicacion = string.Empty;
        }

        #endregion

    }
}
