using KMS.BL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using KMS.BL.Implementation;
using KMS.BL.Model;

namespace KMS.UI
{
    public partial class MonthlyTransaction : System.Web.UI.Page
    {
        IMonthlyTransactionService monthlyTransactionService;
        public MonthlyTransaction()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
            monthlyTransactionService = new MonthlyTransactionService(connectionString);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            List<MonthlyTransactionVM> monthlyTransactions = new List<MonthlyTransactionVM>();

            MonthlyTransactionVM vM = new MonthlyTransactionVM();

            for (int i = 0; i < 3; i++)
            {
                vM.UserId = 1 + i;
                vM.MonthlyInstallment = 2 + i;
                vM.TakenAmount = 3 + i;
                vM.GivenAmount = 6 + i;
                vM.DepositeAmount = 4 + i;
                vM.BalanceAmount = 5 + i;

                monthlyTransactions.Add(vM);
            }

            MonthlyTransactionVM vM1 = new MonthlyTransactionVM() { UserId = 4 };
           
            monthlyTransactions.Add(vM1);

           

            monthlyTransactionService.Save(monthlyTransactions);
        }
    }
}