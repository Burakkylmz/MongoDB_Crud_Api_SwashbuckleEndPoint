using Mongo_Swagger_Core.Models.Abstract;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mongo_Swagger_Core.Service.Abstract
{
    public abstract class BaseRepo<TModel> where TModel : BaseModel
    {
        private readonly IMongoCollection<TModel> mongoCollection;


        public BaseRepo(string connectionString, string dbName, string collectionName)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase(dbName);
            mongoCollection = database.GetCollection<TModel>(collectionName);
        }

        public virtual List<TModel> GetList()
        {
            return mongoCollection.Find(book => true).ToList();
        }

        public virtual TModel GetById(string id)
        {
            //var docId = new ObjectId(id);
            return mongoCollection.Find<TModel>(m => m.Id == id).FirstOrDefault();
        }

        public virtual TModel Create(TModel model)
        {
            mongoCollection.InsertOne(model);
            return model;
        }

        public virtual void Update(string id, TModel model)
        {
            //var docId = new ObjectId(id);
            mongoCollection.ReplaceOne(m => m.Id == id, model);
        }

        public virtual void Delete(TModel model)
        {
            mongoCollection.DeleteOne(m => m.Id == model.Id);
        }

        public virtual void Delete(string id)
        {
            //var docId = new ObjectId(id);
            mongoCollection.DeleteOne(m => m.Id == id);
        }

    }
}
