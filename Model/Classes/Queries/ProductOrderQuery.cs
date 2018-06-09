using Model.Classes;
using System.Linq;

namespace Model
{
    public class ProductOrderQuery
    {
        private readonly Context _context;

        public ProductOrderQuery(Context context)
        {
            _context = context;
        }

        public IQueryable<ProductOrder> GetAll()
        {
            return _context.ProductOrders;
        }
    }
}
