using Model.Classes;
using Model.Command;
using Model.Queries;
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
                    _businessManager = new BusinessManager();
                return _businessManager;
            }
        }

 
        public List<Product> GetAllProduit()
        {
            ProduitQuery pq = new ProduitQuery(context);
            return pq.GetAll().ToList();
        }

     
        public int AjouterProduit(Product p)
        {
            ProduitCommand pc = new ProduitCommand(context);
            return pc.Ajouter(p);
        }

       
        public void ModifierProduit(Product p)
        {
            ProduitCommand pc = new ProduitCommand(context);
            pc.Modifier(p);
        }

      
        public void SupprimerProduit(string produitID)
        {
            ProduitCommand pc = new ProduitCommand(context);
            pc.Supprimer(produitID);
        }


    }
}
