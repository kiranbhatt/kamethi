using KMS.BL.Interface;
using KMS.DB.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace KMS.BL.Implementation
{
    public class UserService : BaseDbRepository, IUserService
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
    }
}
