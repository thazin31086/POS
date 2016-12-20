using Jasmine.POS.Common.Models;
using Jasmine.POS.Data.EntityModelMapper;
using Jasmine.POS.Data.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Jasmine.POS.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly POSDBContext _POSDBContext;
        public UserRepository(POSDBContext POSDBContext)
        {
            _POSDBContext = POSDBContext;
        }

        public IList<UserModel> GetAllUser()
        {
            List<UserModel> usersmodel = new List<UserModel>();
            try
            {
                var _users = _POSDBContext.Users.ToList();
                if (_users != null)
                {
                    usersmodel = _users.UsersToUsersModelMapper();
                }
            }
            catch (Exception ex)
            {
                //ToDo: Log error   
            }

            return usersmodel;
        }

        public UserModel GetUserByID(int userId)
        {
            UserModel usermodel = new UserModel();
            try
            {
                var _user = _POSDBContext.Users.FirstOrDefault(u => u.Id == userId);
                if (_user != null)
                {
                    usermodel = _user.UserToUserModelMapper();
                }

            }
            catch (Exception)
            {

                //ToDo: Log error
            }

            return usermodel;
        }

        /// <summary>
        /// save/modify
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public OperationStatus Save(UserModel usermodel)
        {
            OperationStatus result = new OperationStatus();
            try
            {
                if (usermodel == null)                
                    throw new Exception("Invalid Record");                                    

                User user = usermodel.UserModelToUserMapper();
                _POSDBContext.Users.Add(user);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                //ToDo: Log error             
            }

            return result;
        }

        public OperationStatus Delete(int userId)
        {
            OperationStatus result = new OperationStatus();
            try
            {
                var user = _POSDBContext.Users.FirstOrDefault(x => x.Id == userId);
                if (user == null)                
                    throw new Exception("User Record does not exist.");                                    

                _POSDBContext.Users.Remove(user);
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = ex.Message;
                //ToDo: Log error
            }

            return result;

        }
    }
}