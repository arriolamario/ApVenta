using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApVentaContracts.Interfaces;

namespace ApVentaDatos.Entidades
{
    public abstract class EntidadBase<TT> : IEntidad<TT>
    {
        private SqlConexion slq;

        public EntidadBase()
        {
            this.slq = new SqlConexion();
        }

        public bool GuardarEntidad()
        {
            string NombreSP = GetNombreSp(MovimientoBase.Insert);
            if (String.IsNullOrEmpty(NombreSP))
                throw new Exception("Falta implementar el nombre del Store Procedure");

            return this.slq.ExecuteNonQuery(NombreSP, GetParametros(MovimientoBase.Insert));
        }

        public bool ActualizarEntidad()
        {
            string NombreSP = GetNombreSp(MovimientoBase.Update);
            if (String.IsNullOrEmpty(NombreSP))
                throw new Exception("Falta implementar el nombre del Store Procedure");
            return this.slq.ExecuteNonQuery(NombreSP, GetParametros(MovimientoBase.Update));

        }

        public abstract SqlParameter[] GetParametros(MovimientoBase movimiento);

        public abstract TT entidad { get; set; }

        public abstract string GetNombreSp(MovimientoBase movimiento);
        
    }
}
