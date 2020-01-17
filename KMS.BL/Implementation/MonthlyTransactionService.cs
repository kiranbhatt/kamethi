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

        public int Save(MonthlyTransactionInsert monthlyTransaction)
        {
            DataTable inputTable = ListtoDataTableConverter.ToDataTable(monthlyTransaction.MonthlyTransactions);

            //double TotalTakenAmount = monthlyTransactions.Sum(x => x.TakenAmount);
            //double TotalDepositAmount = monthlyTransactions.Sum(x => x.DepositeAmount);
            //double RemainingBalance = monthlyTransactions.Sum(x => x.BalanceAmount);

            SqlParameter[] parameters = new SqlParameter[6];

            parameters[0] = new SqlParameter();
            parameters[0].SqlDbType = SqlDbType.Structured;
            parameters[0].ParameterName = "@MonthlyTransaction";
            parameters[0].Value = inputTable;

            parameters[1] = new SqlParameter();
            parameters[1].SqlDbType = SqlDbType.NVarChar;
            parameters[1].ParameterName = "@KamethiNumber";
            parameters[1].Value = monthlyTransaction.KamethiNumber;

            parameters[2] = new SqlParameter();
            parameters[2].SqlDbType = SqlDbType.Int;
            parameters[2].ParameterName = "@HostId";
            parameters[2].Value = monthlyTransaction.HostId;

            parameters[3] = new SqlParameter();
            parameters[3].SqlDbType = SqlDbType.Int;
            parameters[3].ParameterName = "@TotalTakenAmount";
            parameters[3].Value = monthlyTransaction.TotalTakenAmount;

            parameters[4] = new SqlParameter();
            parameters[4].SqlDbType = SqlDbType.Int;
            parameters[4].ParameterName = "@TotalDepositAmount";
            parameters[4].Value = monthlyTransaction.TotalDepositeAmount;

            parameters[5] = new SqlParameter();
            parameters[5].SqlDbType = SqlDbType.Int;
            parameters[5].ParameterName = "@RemainingBalance";
            parameters[5].Value = monthlyTransaction.TotalBalanceAmount;

            int result = Execute("InsertMonthlyTransaction", CommandType.StoredProcedure, parameters);
            return result;
        }
    }
}
