using ApVentaContracts.Usuarios;
using ApVentaLogica.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Venta.Forms
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuario = tbUsuario.Text;
            var contraseña = tbContraseña.Text;
            UsuarioDTO user = new UsuarioDTO()
            {
                usuario = tbUsuario.Text,
                contraseña = tbContraseña.Text
            };

            var gestion = new GestionUsuario();

            var result = gestion.IniciarSesion(user);

            if (result.valido)
            {
                MessageBox.Show("Login correcto");
            }
            else
            {
                MessageBox.Show(result.mensaje);
            }

        }

        

    }
}
