﻿using ApVentaContracts.Enumerados;
using System;
using System.Collections.Generic;
using System.Data;
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

        TT GetEntidad(DataRow row);

        List<TT> GetListaEntidad(DataTable dataTable);
    }


    public interface IEntidad
    {
        string GetNombreSp(MovimientoBase movimiento);

        SqlParameter[] GetParametros(MovimientoBase movimiento);

        IEntidad MapEntidad(DataRow row);
    }

    
   
}
