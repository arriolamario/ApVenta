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
        /// <summary>
        /// Para insertar, update y delete.
        /// </summary>
        /// <param name="sp">Nombre del procedimiento</param>
        /// <param name="parametros">Parametros necesarios para ejecutar el procedimiento</param>
        /// <returns>Retorna true se afectaron una o mas filas, de lo contrario retorna false.</returns>
        public bool ExecuteNonQuery(string sp, SqlParameter[] parametros)
        {
            int numRows;
            using (SqlConnection cnn = new SqlConnection(GetConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sp;
                    cmd.Connection = cnn;
                    cmd.Parameters.AddRange(parametros);
                    cmd.Connection.Open();
                    numRows = cmd.ExecuteNonQuery();
                }
            }
            return numRows > 0;
        }

        /// <summary>
        /// Para hacer un select
        /// </summary>
        /// <param name="sp">Nombre del procedimiento</param>
        /// <param name="parametros">Parametros necesarios para ejecutar el procedimiento</param>
        /// <returns>Retorna un DataTable con los datos devuelto en la consulta</returns>
        public DataTable ExecuteDataAdapter(string sp, SqlParameter[] parametros)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cnn = new SqlConnection(GetConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = sp;
                    cmd.Connection = cnn;
                    cmd.Parameters.AddRange(parametros);
                    cmd.Connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    adapter.Fill(dt);
                }
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
