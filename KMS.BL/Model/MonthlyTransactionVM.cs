using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.BL.Model
{
 public   class MonthlyTransactionVM
    {
        public int UserId { get; set; }
        public int MonthlyInstallment { get; set; }
        public int TakenAmount { get; set; }
        public int GivenAmount { get; set; }
        public int DepositeAmount { get; set; }
        public int BalanceAmount { get; set; }
    }
}
