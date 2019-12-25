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

        /// <summary>
        /// This will save all the Transaction record month wise.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSave_Click(object sender, EventArgs e)
        {
            List<MonthlyTransactionVM> monthlyTransactions = new List<MonthlyTransactionVM>();

            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    TextBox txtName = (row.FindControl("txtMonthlyInstallment") as TextBox);
                }
            }



            monthlyTransactionService.Save(monthlyTransactions);
        }
    }
}