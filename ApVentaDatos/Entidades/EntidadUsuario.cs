using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApVentaContracts.Usuarios;
using ApVentaContracts.Interfaces;

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
                    nombreSp = "";
                    break;
                case MovimientoBase.Update:
                    nombreSp = "";
                    break;
                case MovimientoBase.Select:
                    nombreSp = "";
                    break;
                case MovimientoBase.SelectAll:
                    nombreSp = "";
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
            //lista.Add(new SqlParameter("documento", entidad.Documento));
            //lista.Add(new SqlParameter("estado", entidad.estado));
        }

        private void CargarParametrosUpdateOrDelete(List<SqlParameter> lista)
        {
            lista.Add(new SqlParameter("idUsuario", entidad.IdUsuario));
            lista.Add(new SqlParameter("nombre", entidad.Nombre));
            lista.Add(new SqlParameter("apellido", entidad.Apellido));
            lista.Add(new SqlParameter("username", entidad.Username));
            lista.Add(new SqlParameter("password", entidad.Password));
            //lista.Add(new SqlParameter("documento", entidad.Documento));
            //lista.Add(new SqlParameter("estado", entidad.estado));
        }

        private void CargarParametrosSelect(List<SqlParameter> lista)
        {
            lista.Add(new SqlParameter("idUsuario", entidad.IdUsuario));
        }
    }
}
