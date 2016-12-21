using Jasmine.POS.Data;

namespace Jasmine.POS.Services
{
    public class ServiceFactory
    {
        private JasminePOSDBContext _POSDBContext = new JasminePOSDBContext();

        private OrderService _orderservice;
        private ProductServices _productservice;
        private UserServices _userservice;


        public ProductServices productservice
        {
            get
            {
                if (this._productservice == null)
                {
                    this._productservice = new ProductServices(_POSDBContext);
                }
                return this._productservice;
            }
        }
        public OrderService orderservice
        {
            get
            {
                if (this._orderservice == null)
                {
                    this._orderservice = new OrderService(_POSDBContext);
                }
                return this._orderservice;
            }
        }
        public UserServices userservice
        {
            get
            {
                if (this._userservice == null)
                {
                    this._userservice = new UserServices(_POSDBContext);
                }
                return this._userservice;
            }
        }
    }
}
