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
            btnSave.Enabled = false;

            List<MonthlyTransactionVM> monthlyTransactions = new List<MonthlyTransactionVM>();



            foreach (GridViewRow row in GridView1.Rows)
            {
                if (row.RowType == DataControlRowType.DataRow)
                {
                    MonthlyTransactionVM transactionVM = new MonthlyTransactionVM();

                    Label lblUsetId = (row.FindControl("lblUsetId") as Label);
                    transactionVM.UserId = Convert.ToInt32(lblUsetId.Text);

                    TextBox txtMonthlyInstallment = (row.FindControl("txtMonthlyInstallment") as TextBox);
                    transactionVM.MonthlyInstallment = txtMonthlyInstallment.Text != "" ? Convert.ToInt32(txtMonthlyInstallment.Text) : 0;

                    TextBox txtTakenAmount = (row.FindControl("txtTakenAmount") as TextBox);
                    transactionVM.TakenAmount = txtTakenAmount.Text != "" ? Convert.ToInt32(txtTakenAmount.Text) : 0;

                    TextBox txtGivenAmount = (row.FindControl("txtGivenAmount") as TextBox);
                    transactionVM.GivenAmount = txtGivenAmount.Text != "" ? Convert.ToInt32(txtGivenAmount.Text) : 0;

                    TextBox txtDepositAmount = (row.FindControl("txtDepositAmount") as TextBox);
                    transactionVM.DepositeAmount = txtDepositAmount.Text != "" ? Convert.ToInt32(txtDepositAmount.Text) : 0;

                    TextBox txtBalanceAmount = (row.FindControl("txtBalanceAmount") as TextBox);
                    transactionVM.BalanceAmount = txtBalanceAmount.Text != "" ? Convert.ToInt32(txtBalanceAmount.Text) : 0;

                    monthlyTransactions.Add(transactionVM);

                }
            }



            monthlyTransactionService.Save(monthlyTransactions);
        }
    }
}