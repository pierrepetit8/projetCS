using Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ProdufraisTests.Model
{
    [TestFixture]
    public class BusinessManagerTest : BusinessManagerSetup
    {

        [Test]
        public void GetAllProducts() 
        {
            List<Product> products = BusinessManager.GetAllProducts();
            Assert.NotNull(products);
        }

        [Test]
        public void GetAllProductOrders()
        {
            List<ProductOrder> productOrders = BusinessManager.GetAllProductOrders();
            Assert.NotNull(productOrders);
        }

        [Test]
        public void GetProductByCode() 
        {
            Product product = BusinessManager.GetProductByCode(OnTestProduct.Code);
            Assert.NotNull(product);
        }

        [Test]
        public void UpdateProduct()
        {
            string label = "On test updated";
            OnTestProduct.Label = label;
            BusinessManager.UpdateProduct(OnTestProduct);
            OnTestProduct = BusinessManager.GetProductByCode(OnTestProduct.Code);
            Assert.Equals(OnTestProduct.Label, label);
        }

        [Test]
        public void DeleteProduct()
        {
            BusinessManager.DeleteProduct(OnTestProduct.Code);
            OnTestProduct = BusinessManager.GetProductByCode(OnTestProduct.Code);
            Assert.Null(OnTestProduct);
        }
    }
}
