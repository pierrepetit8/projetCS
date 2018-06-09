using ProdufraisApp.View.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdufraisApp.ViewModel
{
    class MainWindowVM : BaseViewModel
    {
        private ListeProduitVM _listeProduitVM = null;
        
        public MainWindowVM()
        {
            _listeProduitVM = new ListeProduitVM();
        }
 
        public ListeProduitVM ListeProduitViewModel
        {
            get { return _listeProduitVM; }
            set { _listeProduitVM = value; }
        }
    }
}
