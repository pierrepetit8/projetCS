using Model.Classes;
using System.Linq;

namespace Model
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

      
        public IQueryable<Product> GetByCode(string code)
        {
            return _context.Products.Where(p => p.Code == code);
        }
    }
}
