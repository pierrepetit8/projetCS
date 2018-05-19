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
            Context context = new Context();
            context.Clients.ToList();
        }
    }
}
