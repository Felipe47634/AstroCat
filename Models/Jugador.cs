using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MiApiJuego.Models
{
    public class Jugador
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("nombre")]
        public string Nombre { get; set; }

        [BsonElement("nivel")]
        public int Nivel { get; set; }
    }
}
