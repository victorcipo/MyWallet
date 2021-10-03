using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MyWallet.Infrastructure.Data.MongoDb.Entities
{
    public class Lancamentos
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("valor")]
        public decimal Valor { get; set; }

        [BsonElement("categoria")]
        public string Categoria { get; set; }

        [BsonElement("descricao")]
        public string Descricao { get; set; }
    }
}
