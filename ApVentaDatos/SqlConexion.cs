using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ApVentaDatos
{
    public class SqlConexion
    {

        public bool ExecuteNonQuery(string sp, SqlParameter[] parametros)
        {
            int numRows;
            using (SqlConnection cnn = new SqlConnection("Data Source=MARIO-ULP;Initial Catalog=prueba;Integrated Security=True"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;
                cmd.Connection = cnn;
                cmd.Parameters.AddRange(parametros);
                cmd.Connection.Open();
                numRows = cmd.ExecuteNonQuery();

            }
            return numRows > 0;
        }

        public DataTable asd(string sp, SqlParameter[] parametros)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cnn = new SqlConnection("data source=mario-ulp;initial catalog=prueba;integrated security=true"))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sp;
                cmd.Connection = cnn;
                cmd.Parameters.AddRange(parametros);
                cmd.Connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);



            }

            return dt;
        }

        private string GetConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["base"].ConnectionString;
            }
        }

    }
}
