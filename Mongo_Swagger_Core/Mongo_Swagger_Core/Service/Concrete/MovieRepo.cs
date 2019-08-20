using Mongo_Swagger_Core.Models.Concrete;
using Mongo_Swagger_Core.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mongo_Swagger_Core.Service.Concrete
{
    public class MovieRepo:BaseRepo<Movie>
    {
        public MovieRepo(string connectionString, string dbName, string collectionName):base(connectionString,dbName,collectionName)
        {

        }
    }
}
