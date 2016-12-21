using Jasmine.POS.Common.Models;
using Jasmine.POS.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace Jasmine.POS.WEBAPI.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        private ServiceFactory services = new ServiceFactory();
        // GET api/values
        public IEnumerable<ProductModel> GetProducts()
        {
            var products = services.productservice.GetAllProducts();
            return products;
        }

        public IEnumerable<UserModel> GetUsers()
        {
            var users = services.userservice.GetAllUser();
            return users;
        }

        public IEnumerable<UserModel> GetUser()
        {
            UserModel user = new UserModel()
            {
                UserName = "Jasmine",
                FirstName = "Jasmine",
                LastName = "Aung",
            };

            OperationStatus result = services.userservice.SaveUser(user);
            if (result.Success)
            {
                var users = services.userservice.GetAllUser();
                return users;
            }

            return null; 
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
