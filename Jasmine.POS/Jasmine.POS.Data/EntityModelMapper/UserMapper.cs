using Jasmine.POS.Common.Models;
using System.Collections.Generic;

namespace Jasmine.POS.Data.EntityModelMapper
{
    public static class UserMapper
    {

        #region Entity To Model Mapper 

        /// <summary>
        /// Map List of User 
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static List<UserModel> UsersToUsersModelMapper(this List<User> users)
        {
            List<UserModel> usersmodel = new List<UserModel>();
            if (usersmodel != null)
            {
                foreach (var user in users)
                {
                    usersmodel.Add(user.UserToUserModelMapper());
                }
            }

            return usersmodel;
        }


        /// <summary>
        /// Map Single User
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static UserModel UserToUserModelMapper(this User user)
        {
            if (user == null)
            {
                return new UserModel();
            }

            UserModel usermodel = new UserModel()
            {
                Id = user.Id,
                UserName = user.UserName,
                Password = user.Password,
                FirstName = user.FirstName,
                LastName = user.LastName,
                RoleID = user.RoleID,
                Role = user.Role.RoleToRoleModelMapper(), 
                TFN = user.TFN, 
                mobile = user.mobile, 
                address = user.address
            };

            return usermodel; 

        }

        public static RoleModel RoleToRoleModelMapper(this Role role)
        {
            RoleModel rolemodel = new RoleModel()
            {
                RoleID = role.RoleID, 
                Description = role.Description
            };
            return rolemodel;
        }

        #endregion  Entity To Model Mapper 

        #region Model to Entity Mapper 
        /// <summary>
        /// Map List of UserModel
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        public static List<User> UsersModelToUsersMapper(this List<UserModel> usermodels)
        {
            List<User> users = new List<User>();
            if (users != null)
            {
                foreach (var usermodel in usermodels)
                {
                    users.Add(usermodel.UserModelToUserMapper());
                }
            }

            return users;
        }

        /// <summary>
        /// Map Single UserModel
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static User UserModelToUserMapper(this UserModel usermodel)
        {
            if (usermodel == null)
            {
                return new User();
            }

            User user = new User()
            {
                Id = usermodel.Id,
                UserName = usermodel.UserName,
                Password = usermodel.Password,
                FirstName = usermodel.FirstName,
                LastName = usermodel.LastName,
                RoleID = usermodel.RoleID,
                Role = usermodel.Role.RoleModelToRoleMapper(),
                TFN = usermodel.TFN,
                mobile = usermodel.mobile,
                address = usermodel.address
            };

            return user;

        }

        /// <summary>
        /// Map RoleModel
        /// </summary>
        /// <param name="rolemodel"></param>
        /// <returns></returns>
        public static Role RoleModelToRoleMapper(this RoleModel rolemodel)
        {
            Role role = new Role()
            {
                RoleID = rolemodel.RoleID,
                Description = rolemodel.Description
            };
            return role;
        }
        #endregion Model to Entity Mapper 
    }
}
