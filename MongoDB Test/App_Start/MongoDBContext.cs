using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB_Test.Properties;
using MongoDB_Test.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB_Test.Models;

namespace MongoDB_Test.App_Start
{
    public class MongoDBContext
    {
        public MongoDatabase Database;
        public MongoDBContext()
        {
            MongoClient client = new MongoClient(Settings.Default.MongoDBConnection);
            MongoServer server = client.GetServer();
            Database = server.GetDatabase("restaurants");           
        }

        public MongoCollection<FileUserModel> FileUsers{
            get
            {
                return Database.GetCollection<FileUserModel>("FileUsers");
            }
        }

    
    }
}