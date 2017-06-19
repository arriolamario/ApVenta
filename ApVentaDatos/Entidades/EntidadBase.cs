using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApVentaContracts.Interfaces;
using System.Data;

namespace ApVentaDatos.Entidades
{
    public abstract class EntidadBase<TT> : IEntidad<TT>
    {
        private SqlConexion sql;

        public EntidadBase()
        {
            this.sql = new SqlConexion();
        }

        public bool GuardarEntidad()
        {
            string NombreSP = GetNombreSp(MovimientoBase.Insert);
            if (String.IsNullOrEmpty(NombreSP))
                throw new Exception("Falta implementar el nombre del Store Procedure");

            return this.sql.ExecuteNonQuery(NombreSP, GetParametros(MovimientoBase.Insert));
        }

        public bool ActualizarEntidad()
        {
            string NombreSP = GetNombreSp(MovimientoBase.Update);
            if (String.IsNullOrEmpty(NombreSP))
                throw new Exception("Falta implementar el nombre del Store Procedure");
            return this.sql.ExecuteNonQuery(NombreSP, GetParametros(MovimientoBase.Update));
        }

        public bool DeleteEntidad()
        {
            string nombreSP = GetNombreSp(MovimientoBase.Delete);
            SqlParameter[] parametros = GetParametros(MovimientoBase.Delete);
            return sql.ExecuteNonQuery(nombreSP, parametros);
        }

        public TT Select()
        {
            string nombreSP = GetNombreSp(MovimientoBase.Select);
            SqlParameter[] parametros = GetParametros(MovimientoBase.Select);
            DataTable dt = sql.ExecuteDataAdapter(nombreSP, parametros);
            return GetEntidad(dt);
        }

        public List<TT> SelectAll()
        {
            string nombreSP = GetNombreSp(MovimientoBase.SelectAll);
            SqlParameter[] parametros = GetParametros(MovimientoBase.SelectAll);
            DataTable dt = sql.ExecuteDataAdapter(nombreSP, parametros);
            return GetListaEntidad(dt);
        }
        public abstract SqlParameter[] GetParametros(MovimientoBase movimiento);

        public abstract TT entidad { get; set; }

        public abstract string GetNombreSp(MovimientoBase movimiento);


        public abstract TT GetEntidad(DataTable dataTable);

        public abstract List<TT> GetListaEntidad(DataTable dataTable);
    }
}
