using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.BL.Model
{
    public class MonthlyTransactionVM
    {
        public int UserId { get; set; }
        public int MonthlyInstallment { get; set; }
        public int TakenAmount { get; set; }
        public int GivenAmount { get; set; }
        public int DepositeAmount { get; set; }
        public int BalanceAmount { get; set; }
    }



    public class MonthlyTransactionInsert
    {
        public List<MonthlyTransactionVM> MonthlyTransactions { get; set; }
        public int HostId { get; set; }
        public string KamethiNumber { get; set; }
        public int TotalTakenAmount { get; set; }
        public int TotalDepositeAmount { get; set; }
        public int TotalBalanceAmount { get; set; }

    }
}
