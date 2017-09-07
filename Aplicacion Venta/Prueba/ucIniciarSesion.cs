using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApInfra.Validaciones;
using ApVentaContracts.Entidades;

namespace Aplicacion_Venta.Prueba
{
    public partial class ucIniciarSesion : UserControl
    {
        Dictionary<string, object> validar;
        public ucIniciarSesion()
        {
            InitializeComponent();
            validar = new Dictionary<string, object>();
            validar.Add(lblContraseña.Text, tbPassword);
            validar.Add(lblNombreUsuario.Text, tbUsuario);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            var res = Validador.ValidarCampos(validar);
            if (res.Count > 0)
            {
                MessageBox.Show(Validador.ErroresMensaje(res));
            }
            else
            {
                UsuarioDTO usuario = new UsuarioDTO()
                {
                    Username = tbUsuario.Text,
                    Password = tbPassword.Text
                };

            }
        }
    }
}
