using System;
using Model;
using Model.Classes;
using NUnit.Framework;

namespace ProdufraisTests.Model
{
    [SetUpFixture]
    public class BusinessManagerSetup
    {
        public static Product Product { get; set; }

        public static BusinessManager BusinessManager { get; set; }

        [SetUp]
        public void SetUp() 
        {
            Product = new Product
            {
                Id = 999,
                CategoryId = 1,
                Stock = 10,
                Label = "On test",
                Description = "On test product",
                Code = "109090",
                Price = 100,
                Active = true
            };

            BusinessManager = BusinessManager.Instance;
        }

        private void HandleCategory() 
        {
            var _context = new Context();
            // create category
        }
    }
}
