using Model;
using Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produfrais.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.Clients.ToList();
            BusinessManager bm = BusinessManager.Instance;
            Product p = new Product();
            p.CategoryId = 1;
            p.Price = 10.0F;
            p.Stock = 2322;
            p.Active = true;
            p.Code = "REF";
            p.Label = "Jambon GO VEGAN";
            bm.AddProduct(p);
            List<Product> list = new List<Product>();
            list = bm.GetAllProducts();
            foreach (Product pro in list)
            {
                System.Console.WriteLine(pro.Label);
            }
        }
    }
}
