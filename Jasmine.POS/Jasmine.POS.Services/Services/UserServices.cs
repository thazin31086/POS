using Jasmine.POS.Common.Models;
using Jasmine.POS.Data;
using Jasmine.POS.Data.Repository;
using System.Collections.Generic;

namespace Jasmine.POS.Services
{
    public class UserServices
    {
        private UserRepository userrepo;
        public UserServices(JasminePOSDBContext POSDBContext)
        {
            userrepo = new UserRepository(POSDBContext);
        }
        
        public IList<UserModel> GetAllUser()
        {
            return userrepo.GetAll();
        }
        public UserModel GetUserByID(int userId)
        {
            return userrepo.GetById(userId);
        }
        public OperationStatus SaveUser(UserModel user)
        {
            return userrepo.Save(user);
        }
        public OperationStatus DeleteUser(int userId)
        {
            return userrepo.Delete(userId);
        }
    }
}
