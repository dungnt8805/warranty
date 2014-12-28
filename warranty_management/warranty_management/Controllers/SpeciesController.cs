using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHibernate;
using warranty_management.Models;

namespace warranty_management.Controllers
{
    public class SpeciesController : Controller
    {
        //
        // GET: /Spieces/
        WarrantyManagementEntities db = new WarrantyManagementEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Specie model)
        {
            if (ModelState.IsValid)
            {
                db.Species.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);

        }

        // GET :/Species/Edit/$id
        public ActionResult Edit(int id)
        {
            Specie specie = db.Species.Find(id);
            return View(specie);
        }

        // POST: /Species/Edit/$id
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(Specie specie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(specie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(specie);
        }
    }
}
