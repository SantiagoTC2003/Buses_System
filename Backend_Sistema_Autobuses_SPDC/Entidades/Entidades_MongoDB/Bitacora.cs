using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Entidades
{
    public class Bitacora
    {

        #region Propiedades

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ID { get; set; }

        [BsonElement("ID_Usuario")]
        public int ID_Usuario { get; set; }

        [BsonElement("Accion")]
        public string Accion { get; set; }

        #endregion

        #region Constructor

        public Bitacora()
        {
            ID = string.Empty;
            ID_Usuario = 0;
            Accion = string.Empty;
        }

        #endregion

    }
}
