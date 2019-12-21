using KMS.BL.Implementation;
using KMS.BL.Interface;
using KMS.BL.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KMS.UI
{
    public partial class City : System.Web.UI.Page
    {
        ICityService cityService;
        public City()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
            cityService = new CityService(connectionString);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetStateList();
            }

        }
        public void GetStateList()
        {
            List<CityVM> cities = cityService.GetCity();
            gridView.DataSource = cities;
            gridView.DataBind();

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            CityVM city = new CityVM();
            city.StateId = Convert.ToInt32(ddlState.SelectedValue);
            city.Name = txtCity.Text;
            cityService.Save(city);
        }
    }
}