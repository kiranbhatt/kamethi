using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace KMS.DB.Abstract
{
    /// <summary>
    /// Abstarct base class with protected and virtual members.
    /// </summary>
    public abstract class BaseDbRepository
    {
        readonly SqlConnection _connection;

        /// <summary>
        /// This constructor will create the SqlConnection object.
        /// </summary>
        /// <param name="connectionString"></param>
        public BaseDbRepository(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            Trace.TraceInformation("connection initlized sucessfully.");
        }
        /// <summary>
        /// This function will be using in INSERT, UPDATE, DELETE  (DML operations)
        /// </summary>
        /// <param name="command"></param>
        /// <param name="commandType"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        protected virtual int Execute(string command, CommandType commandType, SqlParameter[] sqlParameters)
        {
            try
            {
                _connection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, _connection);
                sqlCommand.CommandType = commandType;
                sqlCommand.Parameters.AddRange(sqlParameters);
                int result = sqlCommand.ExecuteNonQuery();
                _connection.Close();
                return result;
            }
            catch (Exception ex)
            {
                Trace.TraceError("Error occured while saving record in Execute() " + ex.Message, sqlParameters);
                throw ex;
            }
            finally
            {
                _connection.Close();
            }
        }

        /// <summary>
        /// This function will be using in SELECT
        /// </summary>
        /// <param name="commandType"></param>
        /// <param name="command"></param>
        /// <param name="sqlParameters"></param>
        /// <returns></returns>
        protected virtual DataTable Execute(CommandType commandType, string command, SqlParameter[] sqlParameters = null)
        {
            try
            {
                _connection.Open();
                SqlCommand sqlCommand = new SqlCommand(command, _connection);
                sqlCommand.CommandType = commandType;
                if (sqlParameters != null)
                {
                    sqlCommand.Parameters.AddRange(sqlParameters);
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                _connection.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                Trace.TraceError("Error occured while getting record in Execute() " + ex.Message, sqlParameters);
                throw ex;
            }
            finally
            {
                _connection.Close();
            }
        }

    }
}
