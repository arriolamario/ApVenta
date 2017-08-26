using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApVentaContracts.Interfaces;
using System.Data;
using ApVentaContracts.Enumerados;
using System.Reflection;

namespace ApVentaDatos.Entidades
{
    public static class ABM
    {
        public static bool EntidadABM(this IEntidad entidad, MovimientoBase movimiento)
        {
            SqlConexion cnn = new SqlConexion();

            return cnn.ExecuteNonQuery(entidad.GetNombreSp(movimiento), entidad.GetParametros(movimiento));
        }


        public static List<IEntidad> GetEntidad(this IEntidad entidad, MovimientoBase movimiento)
        {
            SqlConexion cnn = new SqlConexion();
            DataTable table = cnn.ExecuteDataAdapter(entidad.GetNombreSp(movimiento), entidad.GetParametros(movimiento));

            List<IEntidad> entidades = new List<IEntidad>();

            foreach (DataRow item in table.Rows)
            {
                entidades.Add(entidad.MapEntidad(item));
            }

            return entidades;
        }

    }

}
