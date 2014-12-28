using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace warranty_management.Controllers
{
    public class StaffsController : Controller
    {
        //
        // GET: /Staffs/

        public ActionResult Index()
        {
            return View();
        }

        // GET: /dang-ki
        public ActionResult Create()
        {
            return View();
        }
        

    }
}
