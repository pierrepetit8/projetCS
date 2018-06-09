using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdufraisApp.Mock
{
    class BuisinessManagerMock
    {
        private static BuisinessManagerMock _businessManager = null;

    
        private BuisinessManagerMock()
        {
        }

        public static BuisinessManagerMock Instance
        {
            get
            {
                if (_businessManager == null)
                    _businessManager = new BuisinessManagerMock();
                return _businessManager;
            }
        }

        public List<Produit> GetAllProduit()
        {
            List<Produit> produits = new List<Produit>();
            produits.Add(new Produit { Code = "2ER45", Nom = "Huile d'olive végétale" });
            produits.Add(new Produit { Code = "3ZZ21", Nom = "Magrets de canard" });
            produits.Add(new Produit { Code = "45WXB", Nom = "Terrine de truite" });
            return produits;
        }
    }
}
