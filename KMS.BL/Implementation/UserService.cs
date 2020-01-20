using KMS.BL.Interface;
using KMS.DB.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using KMS.BL.Model;
using KMS.DB;

namespace KMS.BL.Implementation
{
    public class UserService : UserRepository, IUserService
    {
        public UserService(string connectionString) : base(connectionString)
        {
        }

        public List<string> GetUsers(string userName)
        {
            List<string> names = new List<string>();

            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter();
            parameters[0].SqlDbType = SqlDbType.NVarChar;
            parameters[0].ParameterName = "@UserName";
            parameters[0].Value = userName;

            DataTable dataTable = Execute(CommandType.StoredProcedure, "Usp_getname", parameters);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string name = dataTable.Rows[i]["UserName"].ToString();
                    names.Add(name);
                }
            }
            return names;
        }

        public new List<UserVM> GetUsers()
        {
            List<UserVM> users = new List<UserVM>();
            DataTable result = Execute(CommandType.StoredProcedure, "Usp_PopulateMonthlyTransaction");

            if (result != null&& result.Rows.Count>0)
            {
                for (int i = 0; i < result.Rows.Count; i++)
                {
                    UserVM user = new UserVM();
                    user.UserId = Convert.ToInt32(result.Rows[i]["UserId"]);
                    user.UserName = Convert.ToString(result.Rows[i]["UserName"]);
                    user.Email = Convert.ToString(result.Rows[i]["Email"]);
                    user.PrimaryPhone = Convert.ToString(result.Rows[i]["PrimaryPhone"]);
                    user.AadhaarUrl = Convert.ToString(result.Rows[i]["UploadAadhaar"]);
                    user.IsActive = Convert.ToBoolean(result.Rows[i]["IsActive"]==DBNull.Value ? "false":"true");
                    user.TakenCredit = Convert.ToInt32(result.Rows[i]["Balance Amount"] == DBNull.Value ? 0 : Convert.ToInt32(result.Rows[i]["Balance Amount"]));
                    users.Add(user);
                }
            }
            return users;
        }

        public UserVM Login(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
