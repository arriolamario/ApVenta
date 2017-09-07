using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApVentaContracts.Entidades;
using ApVentaDatos.Entidades;

namespace ApVentaLogica.Usuario
{
    public class UsuarioController
    {
        public UsuarioController()
        {

        }

        public void Login(UsuarioDTO usuario)
        {
            var usuarioAll = usuario.GetEntidad(ApVentaContracts.Enumerados.MovimientoBase.SelectAll);

            var 
        }
    }
}
