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
    public class ProductionsController : Controller
    {
        private WarrantyManagementEntities db = new WarrantyManagementEntities();
        //
        // GET: /Productions/

        public ActionResult Index()
        {
            var productions = db.Productions.Include(a => a.Manufacturer).Include(a => a.Specie);
            return View(productions.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.ManufacturerId = new SelectList(db.Manufactures, "Id", "ManufacturerName");
            ViewBag.SpecieId = new SelectList(db.Species, "Id", "SpecieName");
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(Production model)
        {
            if (ModelState.IsValid)
            {
                db.Productions.Add(model);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }


        // GET :/Productions/Edit/$id
        public ActionResult Edit(int id)
        {
            Production production = db.Productions.Find(id);
            ViewBag.ManufacturerId = new SelectList(db.Manufactures, "Id", "ManufacturerName");
            ViewBag.SpecieId = new SelectList(db.Species, "Id", "SpecieName");
            return View(production);
        }

        // POST :/Productions/Edit/$id
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(Production production)
        {
            if (ModelState.IsValid)
            {
                db.Entry(production).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ManufacturerId = new SelectList(db.Manufactures, "Id", "ManufacturerName");
            ViewBag.SpecieId = new SelectList(db.Species, "Id", "SpecieName");
            return View(production);
        }

    }
}
