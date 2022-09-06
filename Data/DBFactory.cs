using MongoDB.Driver;
using MongoDB.Bson;
using System.Linq;
using System;
using SayItWebsiteNet5.Settings;
using System.Collections.Generic;
using SayItWebsiteNet5.Models;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization;
using System.Collections.ObjectModel;

namespace SayItWebsiteNet5.Data
{

    public class DBFactory : IDBFactory
    {
        private MongoClient _MongoClient { get; set; }
        public IMongoDatabase Db { get; set; }


        public DBFactory()
        {
            var MongoDbConfig = new MongoDbConfig();
            var settings = MongoClientSettings.FromConnectionString(MongoDbConfig.ConnectionString);
            _MongoClient = new MongoClient(settings);



        }


        public IMongoDatabase GetDb(string dbname)
        {
            Db = _MongoClient.GetDatabase(dbname);
            return Db;
        }

        public  IList<T> GetAllDocuments<T>(string dbname, string collection)
        
        
        {

            Db = _MongoClient.GetDatabase(dbname);
            var collectionResult =  Db?.GetCollection<T>($"{collection}").Find(_ => true).ToList();
            if(collectionResult == null)
            {
                return  new List<T>();
            }

            return collectionResult;
        }

        public T GetOneDocument<T>(string dbname, string collection, string Id, bool uuid)
        {

            Db = _MongoClient.GetDatabase(dbname);
            FilterDefinition<T> filt;
            
            var collectionResult = Db.GetCollection<T>($"{collection}");
           
            var testlist = collectionResult.Find(_ => true).ToList();
            if (uuid)
            {
                filt = Builders<T>.Filter.Eq("_Id", Id);
            }
            else
            {
                var objId = new BsonObjectId(ObjectId.Parse(Id));
                filt = Builders<T>.Filter.Eq("_id", objId);
            }
            var returvar = collectionResult.Find(filt).ToList().FirstOrDefault();
           
          
     

            return returvar;
        }

        public IList<T> GetAllByUserId<T>(string dbname, string collection, string userID)
        {
            var collectionResult = Db.GetCollection<T>($"{collection}");
            var filt = Builders<T>.Filter.Eq("_id", ObjectId.Parse(userID));
            var collecMatches = collectionResult.Find(filt).ToList();



            return collecMatches;
        }

        public Task<ReplaceOneResult> UpdateOneDocument<T>(string dbname, string collection, T obj)
        {

            Db = _MongoClient.GetDatabase(dbname);
            var testinfo = obj.GetType()?.GetProperty("_Id")?.GetValue(obj).ToString();
            ReplaceOneResult result;

            var temp = obj.GetType()?.GetProperty("Id")?.GetValue(obj) != null ? obj.GetType().GetProperty("Id").GetValue(obj).ToString() : obj.GetType()?.GetProperty("_Id")?.GetValue(obj).ToString();
            if (obj.GetType()?.GetProperty("Id")?.GetValue(obj) != null) 
            { 
                var filt = Builders<T>.Filter.Eq("_id", ObjectId.Parse(temp));
                var collectionResult = Db.GetCollection<T>($"{collection}");
    
                result = collectionResult.ReplaceOne(filt, obj);
               

              
                
            }
            else
            {
                var filt = Builders<T>.Filter.Eq("_Id", temp);
                var collectionResult = Db.GetCollection<T>($"{collection}");
                result = collectionResult.ReplaceOne(filt, obj);
            }
           

    
            

            return Task.FromResult(result);
        }

        

        public WriteError CreateDocument<T>(string dbname, string collection, T obj)
        {
            try{
                Db = _MongoClient.GetDatabase(dbname);
                var collectionResult = Db.GetCollection<T>($"{collection}");
                collectionResult.InsertOne(obj);

                return null;
            }
            catch(MongoWriteException ex)
            {
                return ex.WriteError;
            }

        }

        //delete document
        public bool DeleteDocument<T>(string dbname, string collection, T obj)
        {
            Db = _MongoClient.GetDatabase(dbname);

            var filt = Builders<T>.Filter.Eq("_id", ObjectId.Parse( obj.GetType().GetProperty("Id").GetValue(obj,null).ToString()));
            var collectionResult = Db.GetCollection<T>($"{collection}");
         
            var documentsToDelete = collectionResult.Find(filt).FirstOrDefault();
            if (documentsToDelete != null)
            {
                collectionResult.DeleteOne(filt);
                return true;
            }
 
            return false;

        }

    }
}




