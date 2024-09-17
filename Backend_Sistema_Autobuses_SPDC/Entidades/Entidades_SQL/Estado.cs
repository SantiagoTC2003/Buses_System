namespace Entidades
{
    public class Estado
    {

        #region Atributos

        public string ID_Estado { get; set; }
        public string Tipo_Estado { get; set; }
        public string Condicion { get; set; }
        
        #endregion

        #region Constructor

        public Estado()
        {
            ID_Estado = string.Empty;
            Tipo_Estado = string.Empty;
            Condicion = string.Empty;
        }

        #endregion
    }
}
