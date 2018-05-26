using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdufraisApp.AccessLayout
{
    class BusinessManagerMock
    {
        private static BusinessManagerMock businessManager = null;
        public static List<Product> GetAllProduit()
        {
            List<Product> produits = new List<Product>();
            produits.Add(new Product { Id = 1, Label = "Huile d'olive végétale" });

            return produits;
        }
    }
}
