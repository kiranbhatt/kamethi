using KMS.BL.Interface;
using KMS.BL.Model;
using KMS.DB.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using KMS.BL.Utility;

namespace KMS.BL.Implementation
{
    public class MonthlyTransactionService : BaseDbRepository, IMonthlyTransactionService
    {
        public MonthlyTransactionService(string connectionString) : base(connectionString)
        {

        }

        public int Save(List<MonthlyTransactionVM> monthlyTransactions)
        {
            DataTable inputTable = ListtoDataTableConverter.ToDataTable(monthlyTransactions);

            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter();
            parameters[0].SqlDbType = SqlDbType.Structured;
            parameters[0].ParameterName = "@MonthlyTransaction";
            parameters[0].Value = inputTable;

            int result = Execute("InsertMonthlyTransaction", CommandType.StoredProcedure, parameters);
            return result;
        }
    }
}
