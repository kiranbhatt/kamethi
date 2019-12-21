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

namespace KMS.BL.Implementation
{
    public class CityService : BaseDbRepository, ICityService
    {
        public CityService(string connectionString) : base(connectionString)
        {
        }

        public List<CityVM> GetCity()
        {
            List<CityVM> cities = new List<CityVM>();
            
             DataTable dataTable =Execute(CommandType.StoredProcedure,"Usp_Get_City");
            if(dataTable!=null)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    CityVM city = new CityVM();
                    city.Id = Convert.ToInt32(dataTable.Rows[i]["ID"]);
                    city.Name = dataTable.Rows[i]["City"].ToString();
                    city.StateName = Convert.ToString(dataTable.Rows[i]["State"]);
                    cities.Add(city);
                }
            }
            return cities;
        }

        public int Save(CityVM model)
        {
            SqlParameter[] parameters = new SqlParameter[2];

            parameters[0] = new SqlParameter();
            parameters[0].SqlDbType = SqlDbType.Int;
            parameters[0].ParameterName = "@StateId";
            parameters[0].Value = model.StateId;

            parameters[1] = new SqlParameter();
            parameters[1].SqlDbType = SqlDbType.NVarChar;
            parameters[1].ParameterName = "@Name";
            parameters[1].Value = model.Name;

            int result = Execute("Usp_City", CommandType.StoredProcedure, parameters);
            return result;

        }
    }
}
