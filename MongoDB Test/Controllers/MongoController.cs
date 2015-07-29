using MongoDB_Test.Models;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB_Test.App_Start;
using AutoMapper;

namespace MongoDB_Test.Controllers
{
    public class MongoController : Controller
    {
        public readonly MongoDBContext Context = new MongoDBContext();

        // GET: Mongo
        public ActionResult Index()
        {
            var fileUsers = Context.FileUsers.FindAll();
            return View(fileUsers);
        }

        // GET: Mongo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mongo/Create
        public ActionResult CreateFileUser()
        {
            FileUser user = new FileUser();
            return View(user);
        }

        // POST: Mongo/Create
        [HttpPost]
        public ActionResult CreateFileUser(FileUser model)
        {
            try
            {
                var fileUser = new FileUserModel(model);
                Context.FileUsers.Insert(fileUser);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mongo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mongo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mongo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mongo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
