using KMS.BL.Interface;
using KMS.BL.Model;
using KMS.DB.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.BL.Implementation
{
    public class StateService : BaseDbRepository, IStateService
    {
        public StateService(string connectionString) : base(connectionString)
        {
        }

        public List<StateVM> GetState()
        {
            List<StateVM> states = new List<StateVM>();
            DataTable dataTable = Execute(CommandType.Text, "select * from StateMaster");

            if (dataTable != null)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    StateVM state = new StateVM();
                    state.Id = Convert.ToInt32(dataTable.Rows[i]["Id"]);
                    state.Name = Convert.ToString(dataTable.Rows[i]["Name"]);

                    states.Add(state);
                }
            }
            return states;
        }

        public int Save(StateVM model)
        {
            SqlParameter[] parameters = new SqlParameter[1];

            parameters[0] = new SqlParameter();
            parameters[0].SqlDbType = SqlDbType.NVarChar;
            parameters[0].ParameterName = "@Name";
            parameters[0].Value = model.Name;


            int result = Execute("usp_state", System.Data.CommandType.StoredProcedure, parameters);
            return result;
        }

        public int Add(int a)
        {
            return a;
        }
    }
}
