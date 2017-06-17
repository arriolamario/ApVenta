using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApVentaDatos1
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
            if (String.IsNullOrEmpty(NombreSP))
                throw new Exception("Falta implementar el nombre del Store Procedure");

            return this.slq.Grabar(NombreSP, GetParametros());
        }


        public abstract string NombreSP { get; }

        public abstract SqlParameter[] GetParametros();

        public abstract TT entidad { get; set; }

    }
}
