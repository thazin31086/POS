using Jasmine.POS.Data.IRepository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Jasmine.POS.Data.Repository.Tests
{
    [TestClass()]
    public class UserRepositoryTests
    {
        [TestMethod()]
        public void GetAllUserTest()
        {
            //Assign 
            int expected = 1;
            int actual = 0;
            //Act 
            using (var JasDBContext = new JasminePOSDBContext())
            {
                //IUserRepository userrepo = new UserRepository(JasDBContext);
                //var users = userrepo.GetAllUser();

                //actual = users.Count();

                IProductRepository repo = new ProductRepository(JasDBContext);
                var products = repo.GetAllProducts();

                actual = products.Count();
            }

            //Asset
            Assert.AreEqual(expected, actual);
        }
    }
}