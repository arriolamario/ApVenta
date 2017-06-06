using ApVentaContracts.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApVentaLogica.Usuarios
{
    public class GestionUsuario
    {
        public ConsultaUsuario IniciarSesion(UsuarioDTO user)
        {
            var retorno = new ConsultaUsuario();
            if (!String.IsNullOrEmpty(user.usuario) || !String.IsNullOrEmpty(user.contraseña))
            {
                retorno.valido = false;
                retorno.mensaje = "Usuario y/o Contraseña no pueden ser vacios.";
            }
            else
            {
                //retorno.usuario = 
            }

            return retorno;
        }
    }
}
