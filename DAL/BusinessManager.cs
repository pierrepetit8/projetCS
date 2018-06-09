using Model.Classes;
using Command;
using Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BusinessManager
    {
        private readonly Context context;
        private static BusinessManager _businessManager = null;

        private BusinessManager()
        {
            context = new Context();
        }

  
        public static BusinessManager Instance
        {
            get
            {
                if (_businessManager == null)
                {
                    _businessManager = new BusinessManager();
                }
                return _businessManager;
            }
        }

 
        public List<Product> GetAllProducts()
        {
            ProductQuery pq = new ProductQuery(context);
            return pq.GetAll().ToList();
        }

        public Product getProductByCode(string code) 
        {
            ProductQuery pq = new ProductQuery(context);
            return pq.GetByCode(code).First();
        }

     
        public int AddProduct(Product p)
        {
            ProductCommand pc = new ProductCommand(context);
            return pc.Add(p);
        }

       
        public void ModifyProduct(Product p)
        {
            ProductCommand pc = new ProductCommand(context);
            pc.Modify(p);
        }

      
        public void DeleteProduct(string productID)
        {
            ProductCommand pc = new ProductCommand(context);
            pc.Delete(productID);
        }


    }
}
