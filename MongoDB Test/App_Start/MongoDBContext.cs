using MongoDB.Driver;
using MongoDB_Test.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoDB_Test.App_Start
{
    public class MongoDBContext
    {
        public IMongoDatabase Database;
        public MongoDBContext()
        {
            MongoClient client = new MongoClient(Settings.Default.MongoDBConnection);
            Database = client.GetDatabase(Settings.Default.MongoFileDB);
        }
    }
}