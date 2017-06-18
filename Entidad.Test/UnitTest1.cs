using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApVentaContracts.Usuarios;
using ApVentaDatos.Entidades;

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

            usuario.Username = "NomUsuario";
            usuario.Password = "RAN001";

            entidad.entidad = usuario;

            entidad.GuardarEntidad();

        }
    }
}
