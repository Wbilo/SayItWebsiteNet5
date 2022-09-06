using MongoDB.Driver;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace SayItWebsiteNet5.Data
{
    public interface IDBFactory
    {
        IMongoDatabase Db { get; set; }

        IList<T> GetAllDocuments<T>(string dbname, string collection);
        IMongoDatabase GetDb(string dbname);
        T GetOneDocument<T>(string dbname, string collection, string ObjectId, bool uuid);
        Task<ReplaceOneResult> UpdateOneDocument<T>(string dbname, string collection, T obj);
    }
}