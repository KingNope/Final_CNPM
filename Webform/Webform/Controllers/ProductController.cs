using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webform.Context;

namespace Webform.Controllers
{
    public class ProductController : Controller
    {
        db_projectEntities1 dbWeb = new db_projectEntities1();

        // GET: Product
        public ActionResult Detail(int ID)
        {
            var objProduct = dbWeb.products.Where(n => n.ID == ID).FirstOrDefault();
            return View(objProduct);
        }

    }
}