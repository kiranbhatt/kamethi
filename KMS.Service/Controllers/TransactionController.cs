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
    public class TransactionController : ApiController
    {
        IMonthlyTransactionService transactionService;
        public TransactionController()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
            transactionService = new MonthlyTransactionService(connectionString);
        }

        [HttpPost]
        public int Insert(MonthlyTransactionInsert monthlyTransaction)
        {
            int result = transactionService.Save(monthlyTransaction);
            return result;
        }
    }
}
