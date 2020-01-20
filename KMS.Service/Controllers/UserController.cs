using KMS.BL.Implementation;
using KMS.BL.Interface;
using KMS.BL.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KMS.Service.Controllers
{
    public class UserController : ApiController
    {
        IUserService  userService;
        public UserController()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
            userService = new UserService(connectionString);
        }

        /// <summary>
        /// https://localhost:44307/kms/User/GetAll
        /// </summary>
        /// <returns></returns>
        public List<UserVM> GetAll()
        {
            List<UserVM> users= userService.GetUsers();
            return users;
        }
        public UserVM Login(string email,string password)
        {
            return new UserVM();
        }

    }
}
