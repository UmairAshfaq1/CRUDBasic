using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUDBasic.Context;

namespace CRUDBasic.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tbl_Category tbl_Category)
        {
            return View();
        }

    }
}