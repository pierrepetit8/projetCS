using Model;
using Model.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produfrais.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessManager bm = BusinessManager.Instance;
            bm.GetAllProducts().ForEach(
                product => System.Console.WriteLine(product.Label)
            );
        }
    }
}
