using Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ProdufraisTests.Model
{
    [TestFixture]
    public class BusinessManagerTest
    {
        private BusinessManager _manager;

        private Product _onTestProduct;

        [TestFixtureSetUp]
        public void SetUp() 
        {
            _manager = BusinessManagerSetup.BusinessManager;
            _onTestProduct = BusinessManagerSetup.Product;
            _manager.AddProduct(_onTestProduct);
        }

        [Test]
        public void ManagerIsInstancied()
        {
            Assert.NotNull(_manager);
        }

        [Test]
        public void GetAllProducts() {
            List<Product> products = _manager.GetAllProducts();
            Assert.NotNull(products);
        }

        [Test]
        public void GetAllProductOrders()
        {
            List<ProductOrder> productOrders = _manager.GetAllProductOrders();
            Assert.NotNull(productOrders);
        }

        [Test]
        public void GetProductByCode() 
        {
            Product product = _manager.GetProductByCode(_onTestProduct.Code);
            Assert.NotNull(product);
        }

        [Test]
        public void UpdateProduct()
        {
            string label = "On test updated";
            _onTestProduct.Label = label;
            _manager.UpdateProduct(_onTestProduct);
            _onTestProduct = _manager.GetProductByCode(_onTestProduct.Code);
            Assert.Equals(_onTestProduct.Label, label);
        }

        [Test]
        public void DeleteProduct()
        {
            _manager.DeleteProduct(_onTestProduct.Code);
            _onTestProduct = _manager.GetProductByCode(_onTestProduct.Code);
            Assert.Null(_onTestProduct);
        }
    }
}
