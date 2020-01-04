using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using KMS.BL.Interface;
using KMS.BL.Implementation;

namespace KMS.Service
{
    /// <summary>
    /// Summary description for user
    /// https://localhost:44307/user.asmx
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class user : System.Web.Services.WebService
    {
        IUserService userService;
        public user()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
            userService = new UserService(connectionString);
        }
        [WebMethod]
        public List<string> GetStudentsName(string userName)
        {
            return userService.GetUsers(userName);
        }
    }
}
