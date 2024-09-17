namespace Entidades
{
    public class Chofer
    {

        #region Atributos

        public string Cedula { get; set; }
        public string Nombre_Chofer { get; set; }
        public string Licencia { get; set; }
        public string ID_Estado { get; set; }
        
        #endregion

        #region Constructor

        public Chofer()
        {
            Cedula = string.Empty;
            Nombre_Chofer = string.Empty;
            Licencia = string.Empty;
            ID_Estado = string.Empty;
        }

        #endregion

    }
}
