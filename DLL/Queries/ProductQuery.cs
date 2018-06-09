using Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Queries
{
    class ProductQuery
    {
        private readonly Context _context;

       
        public ProductQuery(Context context)
        {
            _context = context;
        }

        public IQueryable<Product> GetAll()
        {
            return _context.Products;
        }

      
        public IQueryable<Product> GetByID(string code)
        {
            return _context.Products.Where(p => p.code == code);
        }
    }
}
