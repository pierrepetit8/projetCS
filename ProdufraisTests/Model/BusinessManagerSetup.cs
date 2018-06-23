using System.Linq;
using Model;
using Model.Classes;
using NUnit.Framework;

namespace ProdufraisTests.Model
{
    public class BusinessManagerSetup
    {
        
        public Product OnTestProduct { get; set; }

        public BusinessManager BusinessManager { get; set; }

        [SetUp]
        public void BaseSetUp() 
        {
            HandleCategory();

            OnTestProduct = new Product
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
            BusinessManager.AddProduct(OnTestProduct);
        }

        [TearDown]
        public void BaseTearDown()
        {
            if (!_categoryExists)
            {
                var categories = _context.Categories;
                var inserted = categories
                    .Where(c => c.Id == 1)
                    .First();

                categories.Remove(inserted);
            }
        }

        private Context _context;

        private bool _categoryExists;


        // Create category if it doesn't exists yet
        private void HandleCategory() 
        {
            _context = new Context();
            var categories = _context.Categories;

            _categoryExists = categories
                .Where(c => c.Id == 1)
                .Count() == 1;
            
            if (!_categoryExists)
            {
                Category c = new Category
                {
                    Id = 1,
                    Label = "On test category",
                    Active = true
                };

                categories.Add(c);
            }
        }
    }
}
