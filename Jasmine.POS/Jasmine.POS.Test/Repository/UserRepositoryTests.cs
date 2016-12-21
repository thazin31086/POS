using Jasmine.POS.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Jasmine.POS.Data.Repository.Tests
{
    [TestClass()]
    public class UserRepositoryTests
    {
        ProductServices productservice;
      
        [TestMethod()]
        public void GetAllUserTest()
        {
            //Assign 
            int expected = 1;
            int actual = 0;

            //Act
            var products = productservice.GetAllProducts();
            actual = products.Count;


            //Asset
            Assert.AreEqual(expected, actual);
        }
    }
}