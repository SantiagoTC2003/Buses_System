namespace Entidades
{
    public class Ruta
    {

        #region Atributos

        public string Nombre_Ruta { get; set; }
        public string Provincia_inicio { get; set; }
        public string Provincia_fin { get; set; }
        public string Canton_inicio { get; set; }
        public string Canton_fin { get; set; }
        public string Distrito_inicio { get; set; }
        public string Distrito_fin { get; set; }
        public string Distancia { get; set; }
        public int Precio { get; set; }

        #endregion

        #region Constructor

        public Ruta()
        {
            Nombre_Ruta = string.Empty;
            Provincia_inicio = string.Empty;
            Provincia_fin = string.Empty;
            Canton_inicio = string.Empty;
            Canton_fin = string.Empty;
            Distrito_inicio = string.Empty;
            Distrito_fin = string.Empty;
            Distancia = string.Empty;
            Precio = 0;
        }

        #endregion

    }
}
