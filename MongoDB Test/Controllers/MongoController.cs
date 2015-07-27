using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MongoDB_Test.Controllers
{
    public class MongoController : Controller
    {
        // GET: Mongo
        public ActionResult Index()
        {
            return View();
        }

        // GET: Mongo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mongo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mongo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

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
