using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using warranty_management.Models;

namespace warranty_management.Controllers
{
    public class WarrantiesController : Controller
    {
        private WarrantyManagementEntities db = new WarrantyManagementEntities();
        //
        // GET: /Warranties/

        public ActionResult Index()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Check(FormCollection value)
        {
            string serial = value["Serial"];
            var orderDetail = db.OrderDetails.Include(a => a.Production).Include(a => a.Order).Where(i => i.Serial == serial).Single();
            if (orderDetail == null)
                return RedirectToAction("NotExists");
            var flag = DateTime.Compare(orderDetail.Order.OrderDate.AddYears(orderDetail.Production.WarrantyTime), DateTime.Now);
            Session["orderDetail"] = orderDetail;
            return RedirectToAction("Create");
        }

        // GET: /Warranties/Create
        public ActionResult Create()
        {
            ViewBag.OrderDetail = Session["orderDetail"];
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Warranty model)
        {
            OrderDetail orderDetail = (OrderDetail)Session["orderDetail"];
            model.OrderDetailsId = orderDetail.Id;
            model.ReceivedDate = DateTime.Now;
            model.Status = "on";
            if (ModelState.IsValid)
            {
                db.Warranties.Add(model);
                db.SaveChanges();
            }
            return RedirectToAction("Details", new { @id = model.Id });
        }

        public ActionResult NotExists()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            return View();
        }

    }
}
