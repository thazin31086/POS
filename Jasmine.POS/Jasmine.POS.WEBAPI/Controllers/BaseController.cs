using Jasmine.POS.Services;
using System.Web.Http;

namespace Jasmine.POS.WEBAPI.Controllers
{
    public class BaseController : ApiController
    {
        protected ServiceFactory services = new ServiceFactory();
    }
}
