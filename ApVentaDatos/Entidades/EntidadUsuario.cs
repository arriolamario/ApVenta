using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApVentaContracts.Usuarios;
using ApVentaContracts.Interfaces;
using System.Data;
using ApVentaContracts.Enumerados;

namespace ApVentaDatos.Entidades
{
    public class EntidadUsuario : EntidadBase<UsuarioDTO>
    {
        public EntidadUsuario()
        {
            this.entidad = new UsuarioDTO();
        }

        public override UsuarioDTO entidad { get; set; }

        public override SqlParameter[] GetParametros(MovimientoBase movimiento)
        {
            List<SqlParameter> retorno = new List<SqlParameter>();

            switch (movimiento)
            {
                case MovimientoBase.Insert:
                    CargarParametrosInsert(retorno);
                    break;
                case MovimientoBase.Update:
                    CargarParametrosUpdateOrDelete(retorno);
                    break;
                case MovimientoBase.Select:
                    CargarParametrosSelect(retorno);
                    break;
                case MovimientoBase.SelectAll:
                    break;
                default:
                    break;
            }

            return retorno.ToArray();
        }

        public override string GetNombreSp(MovimientoBase movimiento)
        {
            string nombreSp = string.Empty;

            switch (movimiento)
            {
                case MovimientoBase.Insert:
                    nombreSp = "usuarioInsert";
                    break;
                case MovimientoBase.Update:
                    nombreSp = "usuarioUpdate";
                    break;
                case MovimientoBase.Select:
                    nombreSp = "usuarioSelectId";
                    break;
                case MovimientoBase.SelectAll:
                    nombreSp = "usuarioSelect";
                    break;
                case MovimientoBase.Delete:
                    nombreSp = "usuarioDelete";
                    break;
                default:
                    break;
            }

            return nombreSp;
        }

        private void CargarParametrosInsert(List<SqlParameter> lista)
        {
            lista.Add(new SqlParameter("nombre", entidad.Nombre));
            lista.Add(new SqlParameter("apellido", entidad.Apellido));
            lista.Add(new SqlParameter("username", entidad.Username));
            lista.Add(new SqlParameter("password", entidad.Password));
        }

        private void CargarParametrosUpdateOrDelete(List<SqlParameter> lista)
        {
            lista.Add(new SqlParameter("idUsuario", entidad.IdUsuario));
            lista.Add(new SqlParameter("nombre", entidad.Nombre));
            lista.Add(new SqlParameter("apellido", entidad.Apellido));
            lista.Add(new SqlParameter("username", entidad.Username));
            lista.Add(new SqlParameter("password", entidad.Password));
        }

        private void CargarParametrosSelect(List<SqlParameter> lista)
        {
            lista.Add(new SqlParameter("idUsuario", entidad.IdUsuario));
        }

        public override List<UsuarioDTO> GetListaEntidad(DataTable dataTable)
        {
            List<UsuarioDTO> lista = new List<UsuarioDTO>();

            foreach (DataRow item in dataTable.Rows)
            {
                lista.Add(GetEntidad(item));
            }

            return lista;
        }

        public override UsuarioDTO GetEntidad(DataRow row)
        {
            UsuarioDTO usuario = new UsuarioDTO();
            usuario.Apellido = Convert.ToString(row["apellido"]);
            usuario.IdUsuario = Convert.ToInt32(row["idUsuario"]);
            usuario.Nombre = Convert.ToString(row["nombre"]);
            usuario.Password = Convert.ToString(row["password"]);
            usuario.Username = Convert.ToString(row["username"]);
            return usuario;
        }
    }
}
