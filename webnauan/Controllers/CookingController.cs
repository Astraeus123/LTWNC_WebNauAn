using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webnauan.Controllers
{
    public class CookingController : Controller
    {
        // GET: Cooking
        public ActionResult Index()
        {
            return View();
        }

        // GET: Cooking/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cooking/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cooking/Create
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

        // GET: Cooking/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cooking/Edit/5
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

        // GET: Cooking/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cooking/Delete/5
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
