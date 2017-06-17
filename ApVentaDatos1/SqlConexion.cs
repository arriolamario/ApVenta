using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ApVentaDatos1
{
    public class SqlConexion
    {

        public bool Grabar(string sp, SqlParameter[] parametros)
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

    }
}
