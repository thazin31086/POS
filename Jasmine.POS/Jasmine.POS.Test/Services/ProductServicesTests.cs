using Microsoft.VisualStudio.TestTools.UnitTesting;
using Jasmine.POS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jasmine.POS.Services.Tests
{
    [TestClass()]
    public class ProductServicesTests
    {
        [TestMethod()]
        public void GetAllProductsTest()
        {
            //Asset 
            int expected = 14;

            //Assign
            ServiceFactory services = new ServiceFactory();
            var products= services.productservice.GetAllProducts();
            int actual = products.Count();

            //Act
            Assert.AreEqual(expected, actual);
        }
    }
}