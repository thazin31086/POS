using Jasmine.POS.Common.Models;
using Jasmine.POS.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace Jasmine.POS.WEBAPI.Controllers
{
    //[Authorize]
    public class ValuesController : ApiController
    {
        private ProductServices productservice = new ProductServices();
        private UserServices userservice = new UserServices();
        // GET api/values
        public IEnumerable<ProductModel> GetProducts()
        {
            var products = productservice.GetAllProducts();
            return products;
        }

        public IEnumerable<UserModel> GetUsers()
        {
            var users = userservice.GetAllUser();
            return users;
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
