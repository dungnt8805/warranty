using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using warranty_management.Models;
using System.Data.Entity;

namespace warranty_management.Controllers
{
    public class OrdersController : Controller
    {
        //
        // GET: /Orders/
        WarrantyManagementEntities db = new WarrantyManagementEntities();

        public ActionResult Index()
        {
            return View();
        }

        // GET: /Orders/Create

        public ActionResult Create()
        {
            return View();
        }


        //POST: /Orders/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Order order, FormCollection value)
        {
            if (ModelState.IsValid)
            {
                order.OrderDate = DateTime.Now;
                db.Orders.Add(order);
                db.SaveChanges();
            }
            return RedirectToAction("OrderDetails", new { @id = order.Id });
        }

        public ActionResult OrderDetails(int id)
        {
            ViewBag.ProductionId = new SelectList(db.Productions, "Id", "Name");
            var order = db.Orders.Include(a => a.Customer).Where(i => i.Id == id).Single();
            ViewBag.Order = order;
            var ods = db.OrderDetails.Include(a => a.Production).Where(i => i.OrderId == id).ToList();
            
            ViewBag.orderDetails = ods;
            return View();
        }

        [HttpPost]
        public ActionResult OrderDetails(int id, OrderDetail order)
        {
            if (ModelState.IsValid)
            {
                order.OrderId = id;
                db.OrderDetails.Add(order);
                db.SaveChanges();
            }
            return RedirectToAction("OrderDetails");
        }

        public ActionResult Complete(int id)
        {
            var order = db.Orders.Find(id);
            order.Status = "finish";
            db.Entry(order).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction("Details", new { id = id });
        }
        public ActionResult Details(int id)
        {
            var order = db.Orders.Include(a => a.Customer).Where(i => i.Id == id).Single();
            ViewBag.Order = order;
            var ods = db.OrderDetails.Include(a => a.Production).Where(i => i.OrderId == id).ToList();
            ViewBag.orderDetails = ods;
            return View();
        }

    }
}
