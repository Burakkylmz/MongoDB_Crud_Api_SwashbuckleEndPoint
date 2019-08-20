using Mongo_Swagger_Core.Models.Abstract;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mongo_Swagger_Core.Models.Concrete
{
    public class Movie:BaseModel
    {
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("ReleaseDate")]
        public DateTime ReleaseDate { get; set; }
        [BsonElement("Score")]
        public double Score { get; set; }
    }
}
