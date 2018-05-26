using Model;
using ProdufraisApp.AccessLayout;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdufraisApp.ViewModels
{
    class ListeProduitViewModel 
    {
        private int code;
        private string label;
        private ObservableCollection<AccessLayout.Product> produits = new ObservableCollection<AccessLayout.Product>();
        
        public ListeProduitViewModel()
        {
            foreach (AccessLayout.Product p in BusinessManagerMock.GetAllProduit())
            {
                produits.Add(p);
            }
        }
    public ObservableCollection<AccessLayout.Product> Produits
        {
            get { return produits; }
            set
            {
                produits = value;
                
            }
        }
    }
}
