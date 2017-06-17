using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApVentaDatos1;
using ApVentaContracts.Usuarios;

namespace Entidad.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EntidadUsuario entidad = new EntidadUsuario();

            UsuarioDTO usuario = new UsuarioDTO();

            usuario.usuario = "NomUsuario";
            usuario.contraseña = "RAN001";

            entidad.entidad = usuario;

            entidad.GuardarEntidad();

        }
    }
}
