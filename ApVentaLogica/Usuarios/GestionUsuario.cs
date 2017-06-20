using ApVentaContracts.Usuarios;
using ApVentaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApVentaLogica.Usuarios
{
    public class GestionUsuario
    {
        UsuarioDatos usuarioDatos;

        public GestionUsuario()
        {
            usuarioDatos = new UsuarioDatos();
        }

        public ConsultaUsuario IniciarSesion(UsuarioDTO user)
        {
            var retorno = new ConsultaUsuario();
            if (String.IsNullOrEmpty(user.Username) || String.IsNullOrEmpty(user.Password))
            {
                retorno.valido = false;
                retorno.mensaje = "Usuario y/o Contraseña no pueden ser vacios.";
            }
            else
            {
                if (usuarioDatos.GetUsuario(user))
                {
                    retorno.valido = true;
                    retorno.usuario = user;
                }
                else
                {
                    retorno.valido = false;
                    retorno.mensaje = "Inicio Sesion incorrecto, usuario y/o contraseña incorrecto";
                }

            }

            return retorno;
        }
    }
}
