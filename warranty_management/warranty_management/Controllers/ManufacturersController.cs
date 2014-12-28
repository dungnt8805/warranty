using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using warranty_management.Models;

namespace warranty_management.Controllers
{
    public class ManufacturersController : Controller
    {
        private WarrantyManagementEntities db = new WarrantyManagementEntities();
        //
        // GET: /Manufacturers/

        public ActionResult Index()
        {
            return View();
        }

        // GET /Manufacturers/Create

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Manufacturer model)
        {
            if (ModelState.IsValid)
            {
                db.Manufactures.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);

        }

        // GET: /Manufacturers/Edit/$i
        public ActionResult Edit(int id)
        {
            Manufacturer manufacturer = db.Manufactures.Find(id);
            return View(manufacturer);
        }

        // POST: /Manufacturers/Edit/$
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Manufacturer manufacturer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(manufacturer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manufacturer);

        }
    }
}
