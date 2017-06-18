using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ApVentaContracts.Interfaces
{
    public interface IEntidad<TT>
    {
        TT entidad { get; set; }

        string GetNombreSp(MovimientoBase movimiento);

        SqlParameter[] GetParametros(MovimientoBase movimiento);
    }

    public enum MovimientoBase{
        Insert,
        Update,
        Select,
        SelectAll
    }
   
}
