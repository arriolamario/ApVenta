using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ApVentaDatos1
{
    public interface IEntidad<TT>
    {
        TT entidad { get; set; }

        string NombreSP { get; }

        SqlParameter[] GetParametros();
    }
}
