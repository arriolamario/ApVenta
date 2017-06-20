using ApVentaContracts;
using ApVentaContracts.Usuarios;
using ApVentaDatos;
using ApVentaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApVentaLogica.Usuarios
{
    public class GestionUsuario
    {
        EntidadUsuario enUsuario;

        public GestionUsuario()
        {
            enUsuario = new EntidadUsuario();
        }

        public Consulta IniciarSesion(UsuarioDTO user)
        {
            Consulta retorno = new Consulta();
            if (String.IsNullOrEmpty(user.Username) || String.IsNullOrEmpty(user.Password))
            {
                retorno.valido = false;
                retorno.mensaje = "Usuario y/o Contraseña no pueden ser vacios.";
            }
            else
            {
                enUsuario.entidad = user;
                List<UsuarioDTO> usuarios = enUsuario.SelectAll();
                retorno.usuario = usuarios.FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);
                if (retorno.usuario != null)
                {
                    retorno.valido = true;
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
