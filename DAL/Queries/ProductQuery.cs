using Model;
using Model.Classes;
using System.Linq;

namespace Queries
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
