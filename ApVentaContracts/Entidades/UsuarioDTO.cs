using ApVentaContracts.Enumerados;
using ApVentaContracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApVentaContracts.Entidades
{
    public class UsuarioDTO : IEntidad
    {
        public UsuarioDTO() { }

        public int IdUsuario {get; set;}
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int IdTipoUusario { get; set; }

        public string GetNombreSp(Enumerados.MovimientoBase movimiento)
        {
            String nombreParametro;

            switch (movimiento)
            {
                case MovimientoBase.Insert:
                    nombreParametro = "usuarioInsert";
                    break;
                case MovimientoBase.Update:
                    nombreParametro = "usuarioUpdate";
                    break;
                case MovimientoBase.Select:
                    nombreParametro = "usuarioSelectId";
                    break;
                case MovimientoBase.SelectAll:
                    nombreParametro = "usuarioSelect";
                    break;
                case MovimientoBase.Delete:
                    nombreParametro = "usuarioDelete";
                    break;
                default:
                    throw new NotImplementedException();
            }

            return nombreParametro;
        }

        public SqlParameter[] GetParametros(MovimientoBase movimiento)
        {
            List<SqlParameter> parametros;
            switch (movimiento)
            {
                case MovimientoBase.Insert:
                    parametros = GetParametros();
                    break;
                case MovimientoBase.Update:
                    parametros = GetParametroId();
                    parametros.AddRange(GetParametros());
                    break;
                case MovimientoBase.Select:
                    parametros = GetParametroId();
                    break;
                case MovimientoBase.SelectAll:
                    parametros = new List<SqlParameter>();
                    break;
                case MovimientoBase.Delete:
                    parametros = GetParametroId();
                    break;
                default:
                    parametros = new List<SqlParameter>();
                    break;
            }
            return parametros.ToArray();
        }

        public IEntidad MapEntidad(DataRow row)
        {
            UsuarioDTO usuario = new UsuarioDTO();
            usuario.IdUsuario = Convert.ToInt32(row["idUsuario"]);
            usuario.Nombre = Convert.ToString(row["nombre"]);
            usuario.Apellido = Convert.ToString(row["apellido"]);
            usuario.Username = Convert.ToString(row["username"]);
            usuario.Password = Convert.ToString(row["password"]);
            //usuario.IdTipoUusario = Convert.ToInt32(row["idTipoUsuario"]);

            return usuario;
        }

        private List<SqlParameter> GetParametroId()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("idUsuario", IdUsuario));

            return parametros;
        }

        private List<SqlParameter> GetParametros()
        {
            List<SqlParameter> parametros = new List<SqlParameter>();

            parametros.Add(new SqlParameter("nombre", Nombre));
            parametros.Add(new SqlParameter("apellido", Apellido));
            parametros.Add(new SqlParameter("username", Username));
            parametros.Add(new SqlParameter("password", Password));

            return parametros;
        }

    }
}
