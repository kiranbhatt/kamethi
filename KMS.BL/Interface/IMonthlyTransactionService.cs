using KMS.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.BL.Interface
{
   public interface IMonthlyTransactionService
    {
        int Save(MonthlyTransactionInsert monthlyTransaction);
    }
}
