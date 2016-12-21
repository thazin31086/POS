using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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