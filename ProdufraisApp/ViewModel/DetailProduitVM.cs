using ProdufraisApp.Mock;
using ProdufraisApp.View.Common;
using ProdufraisApp.ViewModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProdufraisApp.ViewModel
{
    class DetailProduitVM : BaseViewModel
    {

        private string _code;
        private string _nom;
        private RelayCommand _addOperation;

        public DetailProduitVM(Produit p)
        {
            _code = p.Code;
            _nom = p.Nom;
        }

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

      
    }
}
