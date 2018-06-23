using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProdufraisWeb.Controllers
{
    public class ProductController : Controller
    {
        // GET: Produit
        public ActionResult Index()
        {
            BusinessManager bm = BusinessManager.Instance;
            List<Product> p = bm.GetAllProducts();
            return View("ListProduct", p);
        }
    }
}