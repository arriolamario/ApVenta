using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApVentaContracts.Usuarios;

namespace ApVentaDatos1
{
    public class EntidadUsuario : EntidadBase<UsuarioDTO>
    {
        public EntidadUsuario()
        {
            this.entidad = new UsuarioDTO();
        }

        public override UsuarioDTO entidad { get; set; }

        public override string NombreSP
        {
            get { return "SpUsuarioDTO"; }
        }

        public override SqlParameter[] GetParametros()
        {
            List<SqlParameter> retorno = new List<SqlParameter>()
            {
                new SqlParameter("usuario", entidad.usuario),
                new SqlParameter("password", entidad.contraseña)
            };
            
            return retorno.ToArray();
        }

    }
}
