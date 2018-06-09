using ProdufraisApp.Mock;
using ProdufraisApp.View.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdufraisApp.ViewModel
{
    class ListeProduitVM : BaseViewModel 
    {
        private ObservableCollection<DetailProduitVM> _produits = null;
        private DetailProduitVM _selectedProduit;

        public ListeProduitVM()
        {
            _produits = new ObservableCollection<DetailProduitVM>();
            foreach (Produit p in BuisinessManagerMock.Instance.GetAllProduit())
            {
                _produits.Add(new DetailProduitVM(p));
            }

            if (_produits != null && _produits.Count > 0)
                _selectedProduit = _produits.ElementAt(0);
        }
        

        public ObservableCollection<DetailProduitVM> Produits
        {
            get { return _produits; }
            set
            {
                _produits = value;
                OnPropertyChanged("Produits");
            }
        }

        public DetailProduitVM SelectedProduit
        {
            get { return _selectedProduit; }
            set
            {
                _selectedProduit = value;
                OnPropertyChanged("SelectedProduit");
            }
        }

    }
}
