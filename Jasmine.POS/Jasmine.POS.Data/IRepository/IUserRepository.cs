using Jasmine.POS.Common.Models;
using System.Collections.Generic;

namespace Jasmine.POS.Data.IRepository
{
    public interface IUserRepository
    {
        IList<UserModel> GetAllUser();
        UserModel GetUserByID(int userId);

        /// <summary>
        /// save/modify
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        OperationStatus Save(UserModel user);

        OperationStatus Delete(int userId);
    }
}
