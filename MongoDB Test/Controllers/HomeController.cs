using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB_Test.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using MongoDB_Test.App_Start;

namespace MongoDB_Test.Controllers
{
    public class HomeController : Controller
    {
        MongoDBContext mongoContext = new MongoDBContext();
        public async Task<ActionResult> Index()
        {
//            var document = new BsonDocument
//{
//    { "address" , new BsonDocument
//        {
//            { "street", "2 Avenue" },
//            { "zipcode", "10075" },
//            { "building", "1480" },
//            { "coord", new BsonArray { 73.9557413, 40.7720266 } }
//        }
//    },
//    { "borough", "Manhattan" },
//    { "cuisine", "Italian" },
//    { "grades", new BsonArray
//        {
//            new BsonDocument
//            {
//                { "date", new DateTime(2014, 10, 1, 0, 0, 0, DateTimeKind.Utc) },
//                { "grade", "A" },
//                { "score", 11 }
//            },
//            new BsonDocument
//            {
//                { "date", new DateTime(2014, 1, 6, 0, 0, 0, DateTimeKind.Utc) },
//                { "grade", "B" },
//                { "score", 17 }
//            }
//        }
//    },
//    { "name", "Vella" },
//    { "restaurant_id", "41704620" }
//};

//            var collection = database.GetCollection<BsonDocument>("restaurants");
//            await collection.InsertOneAsync(document);
            var collection = mongoContext.Database.GetCollection<BsonDocument>("restaurants");
            var filter = new BsonDocument();
            var count = 0;
            
            var result = await collection.Find(filter).ToListAsync();
            //using (var cursor = await collection.FindAsync(filter))
            //{
                
            //    while (await cursor.MoveNextAsync())
            //    {

            //        var batch = cursor.Current;
            //        foreach (var document in batch)
            //        {
            //            // process document
            //            result.Add(document);
            //        }
            //    }
            //}
            return Json(result.ToJson(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}