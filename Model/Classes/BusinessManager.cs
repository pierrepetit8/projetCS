using Model.Classes;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    public class BusinessManager
    {
        private readonly Context _context;

        private static BusinessManager instance = null;

        private BusinessManager()
        {
            _context = new Context();
        }

  
        public static BusinessManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BusinessManager();
                }
                return instance;
            }
        }

        public List<Product> GetAllProducts()
        {
            var pq = new ProductQuery(_context);
            return pq.GetAll().ToList();
        }

        public Product GetProductByCode(string code) 
        {
            var pq = new ProductQuery(_context);
            return pq.GetByCode(code).First();
        }

     
        public int AddProduct(Product p)
        {
            var pc = new ProductCommand(_context);
            return pc.Add(p);
        }

       
        public void UpdateProduct(Product p)
        {
            var pc = new ProductCommand(_context);
            pc.Update(p);
        }

      
        public void DeleteProduct(string code)
        {
            var pc = new ProductCommand(_context);
            pc.Delete(code);
        }

        public List<ProductOrder> GetAllProductOrders()
        {
            var poq = new ProductOrderQuery(_context);
            return poq.GetAll().ToList();
        }
    }
}
