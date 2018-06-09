using Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Command
{
    class ProductCommand
    {
        private readonly Context _context;
        
        public ProductCommand(Context context)
        {
            _context = context;
        }

       
        public int Add(Product p)
        {
            _context.Products.Add(p);
            return _context.SaveChanges();
        }

      
        public void Modify(Product p)
        {
            Product upPrd = _context.Products.Where(prd => prd.code == p.code).FirstOrDefault();
            if (upPrd != null)
            {
                upPrd.label = p.label;
                upPrd.categoryId = p.categoryId;
            }
            _context.SaveChanges();
        }

        public void Delete(string productID)
        {
            Product delPrd = _context.Products.Where(prd => prd.code == productID).FirstOrDefault();
            if (delPrd != null)
            {
                _context.Products.Remove(delPrd);
            }
            _context.SaveChanges();
        }
    }
}
