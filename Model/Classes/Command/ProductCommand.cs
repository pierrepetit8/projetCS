using Model;
using Model.Classes;
using System.Linq;

namespace Model
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

      
        public void Update(Product p)
        {
            Product upPrd = _context.Products.Where(prd => prd.Code == p.Code).FirstOrDefault();
            if (upPrd != null)
            {
                upPrd.Label = p.Label;
                upPrd.CategoryId = p.CategoryId;
            }
            _context.SaveChanges();
        }

        public void Delete(string productID)
        {
            Product delPrd = _context.Products.Where(prd => prd.Code == productID).FirstOrDefault();
            if (delPrd != null)
            {
                _context.Products.Remove(delPrd);
            }
            _context.SaveChanges();
        }
    }
}
