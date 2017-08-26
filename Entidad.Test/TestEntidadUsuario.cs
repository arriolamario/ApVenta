using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApVentaContracts.Entidades;
using ApVentaDatos.Entidades;
using ApVentaContracts.Enumerados;

namespace Entidad.Test
{
    [TestClass]
    public class TestEntidadUsuario
    {
        [TestMethod]
        public void Insert()
        {
            UsuarioDTO usuario = new UsuarioDTO();
            usuario.Nombre = "Mario";
            usuario.Apellido = "Arriola";
            usuario.Username = "marioarriola";
            usuario.Password = "RAN001";

            for (int i = 0; i < 100000; i++)
            {
                bool respuesta = usuario.EntidadABM(MovimientoBase.Insert);
            }
        }

        [TestMethod]
        public void SelectAll()
        {
            UsuarioDTO usuario = new UsuarioDTO();
            var lista = usuario.GetEntidad(MovimientoBase.SelectAll);

            foreach (var item in lista)
            {
                item.EntidadABM(MovimientoBase.Delete);
            }
        }

        [TestMethod]
        public void Select()
        {
            UsuarioDTO usuario = new UsuarioDTO();
            usuario.IdUsuario = 4;
            var lista = usuario.GetEntidad(MovimientoBase.Select);
        }

        [TestMethod]
        public void Update()
        {
            UsuarioDTO usuario = new UsuarioDTO();
            usuario.IdUsuario = 4;
            var usuarioId4 = (UsuarioDTO)usuario.GetEntidad(MovimientoBase.Select)[0];

            usuarioId4.Nombre = "Fabian";
            usuarioId4.EntidadABM(MovimientoBase.Update);
        }

    }
}
