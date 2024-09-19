using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace UpdateTool.Class
{
    public class clsDataProvider
    {
        static public bool IsOpen { get { return conn.State == ConnectionState.Open; } }
        static public bool IsClosed { get { return conn.State == ConnectionState.Closed; } }
        static public string ConnectString;
        static public SqlConnection conn = null;

        static public Boolean CreateSqlConnection(string ConnectionString)
        {
            try
            {
                ConnectString = ConnectionString;
                conn = new SqlConnection(ConnectString);
                if (Check())
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        static public void RunExecute(string query, Dictionary<string, object> parameters = null)
        {
            if (conn == null) return;
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(query, conn);
                comm.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                throw ex;
            }
        }
        public static void ExcuteQuery(string strCommand, Dictionary<string, object> parameters)
        {
            using (SqlCommand command = new SqlCommand(strCommand, conn))
            {
                try
                {
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command))
                    {
                        command.CommandText = strCommand;
                        command.CommandType = CommandType.Text;
                        if (parameters != null)
                        {
                            foreach (KeyValuePair<string, object> parameter in (IEnumerable<KeyValuePair<string, object>>)parameters)
                            {
                                if (!(parameter.Key == string.Empty))
                                    command.Parameters.AddWithValue("@" + parameter.Key, parameter.Value ?? (object)DBNull.Value);
                            }
                        }
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    if (conn.State == ConnectionState.Open)
                        conn.Close();
                    throw ex;
                }
            }
        }
        static public bool Open()
        {
            try
            {
                conn.Open();
            }
            catch { return false; }
            return true;
        }
        static public bool Close()
        {
            try
            {
                conn.Close();
            }
            catch { return false; }
            return true;
        }
        private static Boolean Check()
        {
            try
            {
                conn.Open();
            }
            catch
            {
                return false;
            }
            conn.Close();
            return true;
        }
    }
}
