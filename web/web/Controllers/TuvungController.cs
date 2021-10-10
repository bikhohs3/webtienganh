using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web.Models;
using web.Models.Database;

namespace web.Controllers
{
    public class TuvungController : Controller
    {
        DbContext1 db = new DbContext1();
        
        // GET: Tuvung
        public ActionResult Chude()
        {
            var db = DbContext1.Danhsach();
            return View(db);
        }

        // GET: Tuvung/Details/5
        public ActionResult Tuvung(String id)
        {
            var db = DbContext1.Tu(id);
            return View(db);
        }

        // GET: Tuvung/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tuvung/Create
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

        // GET: Tuvung/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Tuvung/Edit/5
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

        // GET: Tuvung/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Tuvung/Delete/5
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
