using Jasmine.POS.Common.Models;
using Jasmine.POS.Data.EntityModelMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Jasmine.POS.Data.Repository
{
    public class UserRepository :IRepository<UserModel>
    {
        private readonly JasminePOSDBContext _POSDBContext;
        public UserRepository(JasminePOSDBContext POSDBContext)
        {
           _POSDBContext = POSDBContext ?? new JasminePOSDBContext();
        }

        public IList<UserModel> GetAll()
        {
            List<UserModel> usersmodel = new List<UserModel>();
            try
            {
                var _results = _POSDBContext.Users;
                var _users = _results.ToList();
                if (_users != null)
                {
                    usersmodel = _users.UsersToUsersModelMapper();
                }
            }
            catch (Exception)
            {
                //ToDo: Log error   
            }

            return usersmodel;
        }

        public UserModel GetById(int Id)
        {
            UserModel usermodel = new UserModel();
            try
            {
                var _user = _POSDBContext.Users.FirstOrDefault(u => u.Id == Id);
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
        public OperationStatus Save(UserModel model)
        {
            OperationStatus result = new OperationStatus();
            try
            {
                if (model == null)                
                    throw new Exception("Invalid Record");                                    

                User user = model.UserModelToUserMapper();                
                _POSDBContext.Users.Add(user);                
                _POSDBContext.SaveChanges();
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
                _POSDBContext.SaveChanges();
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