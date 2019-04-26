using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;

namespace WebApp
{
    public class BdUtil
    {
        protected string ConnectionString { get; set; }

        public BdUtil()
        {
            //this.ConnectionString = "Server=(localdb)\\mssqllocaldb;Database=WebApp;Trusted_Connection=True;ConnectRetryCount=0";
            this.ConnectionString = "Server=200.170.88.138;Database=potencialpesquis2;Uid=potencia8255;Pwd=4VCQYryz";
        }

        public BdUtil(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(this.ConnectionString);
            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {

                //throw;
            }
            
            if (connection.State != ConnectionState.Open)
                connection.Open();
            return connection;
        }

        protected DbCommand GetCommand(DbConnection connection, string commandText, CommandType commandType)
        {
            SqlCommand command = new SqlCommand(commandText, connection as SqlConnection);
            command.CommandType = commandType;
            return command;
        }

        protected SqlParameter GetParameter(string parameter, object value)
        {
            SqlParameter parameterObject = new SqlParameter(parameter, value != null ? value : DBNull.Value);
            parameterObject.Direction = ParameterDirection.Input;
            return parameterObject;
        }

        protected SqlParameter GetParameterOut(string parameter, SqlDbType type, object value = null, ParameterDirection parameterDirection = ParameterDirection.InputOutput)
        {
            SqlParameter parameterObject = new SqlParameter(parameter, type); ;

            if (type == SqlDbType.NVarChar || type == SqlDbType.VarChar || type == SqlDbType.NText || type == SqlDbType.Text)
            {
                parameterObject.Size = -1;
            }

            parameterObject.Direction = parameterDirection;

            if (value != null)
            {
                parameterObject.Value = value;
            }
            else
            {
                parameterObject.Value = DBNull.Value;
            }

            return parameterObject;
        }

        public int ExecuteNonQuery(string sql, List<DbParameter> parameters, CommandType commandType = CommandType.Text)
        {
            int returnValue = -1;

            try
            {
                using (SqlConnection connection = this.GetConnection())
                {
                    DbCommand cmd = this.GetCommand(connection, sql, commandType);

                    if (parameters != null && parameters.Count > 0)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }

                    returnValue = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                //LogException("Failed to ExecuteNonQuery for " + procedureName, ex, parameters);
                throw;
            }

            return returnValue;
        }

        protected object ExecuteScalar(string procedureName, List<SqlParameter> parameters)
        {
            object returnValue = null;

            try
            {
                using (DbConnection connection = this.GetConnection())
                {
                    DbCommand cmd = this.GetCommand(connection, procedureName, CommandType.StoredProcedure);

                    if (parameters != null && parameters.Count > 0)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }

                    returnValue = cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                //LogException("Failed to ExecuteScalar for " + procedureName, ex, parameters);
                throw;
            }

            return returnValue;
        }

        public DbDataReader Qry(string SQL, List<DbParameter> parameters, CommandType commandType = CommandType.Text)
        {
            DbDataReader ds;

            try
            {
                SqlConnection connection = this.GetConnection();

                           
                    DbCommand cmd = this.GetCommand(connection, SQL, commandType);
                    if (parameters != null && parameters.Count > 0)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }

                    ds = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                
            }
            catch (Exception ex)
            {
                //LogException("Failed to GetDataReader for " + procedureName, ex, parameters);
                throw;
            }

            return ds;
        }
    }
}
