
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using KMS.BL.Interface;
using KMS.BL.Implementation;
using System.Data;
using KMS.BL.Model;

namespace KMS.UI
{
    public partial class State : System.Web.UI.Page
    {
        IStateService stateService;
        public State()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
            stateService = new StateService(connectionString);
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Show();
            }
        }
        public void Show()
        {
            List<StateVM> states = stateService.GetState();
          
            grdState.DataSource = states;
            grdState.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            StateVM state = new StateVM();
            state.Name = txtStateName.Text;

            stateService.Save(state);




        }
    }
}