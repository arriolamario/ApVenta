using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApVentaContracts.Usuarios;
using ApVentaDatos.Entidades;

namespace ApVentaLogica
{
    public class Usuario : EntidadBase<UsuarioDTO>
    {
        public override System.Data.SqlClient.SqlParameter[] GetParametros(ApVentaContracts.Interfaces.MovimientoBase movimiento)
        {
            throw new NotImplementedException();
        }

        public override UsuarioDTO entidad
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override string GetNombreSp(ApVentaContracts.Interfaces.MovimientoBase movimiento)
        {
            throw new NotImplementedException();
        }

        public override UsuarioDTO GetEntidad(System.Data.DataTable dataTable)
        {
            throw new NotImplementedException();
        }

        public override List<UsuarioDTO> GetListaEntidad(System.Data.DataTable dataTable)
        {
            throw new NotImplementedException();
        }
    }
}
