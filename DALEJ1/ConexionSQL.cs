using Microsoft.Data.SqlClient;
using System.Data;

namespace DALEJ1
{
    public class ConexionSQL
    {
        public static ConnectionState GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            System.Data.ConnectionState connState = System.Data.ConnectionState.Closed;
            try
            {
                conn.ConnectionString = "server=alonso.database.windows.net;database=alonso-db;uid=usuario;pwd=LaCampana123;trustServerCertificate=true;";
                conn.Open();
                connState = conn.State;
            }
            catch (Exception)
            {
                connState = System.Data.ConnectionState.Closed;
            }
            finally { 
                conn.Close();
            }
            return connState;
        }
    }
}
