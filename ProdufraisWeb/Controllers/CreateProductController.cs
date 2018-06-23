using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProdufraisWeb.Controllers
{
    public class CreateProductController : Controller
    {
        // GET: CreateProduct
        public ActionResult Index()
        {
            Product p = new Product();
            return View("View", p);
        }

        // POST: CreateProduct
        [HttpPost]
        public void Index(Product p)
        {
            BusinessManager bm = BusinessManager.Instance;
            p.categoryId = 1;
            bm.AddProduct(p);
        }
    }
}