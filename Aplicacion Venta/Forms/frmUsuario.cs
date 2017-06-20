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
        private ConsultaUsuario result;
        private frmPrincipal frmPrincipal;

        public frmUsuario(frmPrincipal frmPrincipal)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.frmPrincipal = frmPrincipal;
        }

        void frmUsuario_FormClosing(object sender, FormClosingEventArgs e)
        {
            throw new NotImplementedException();
        }

        void frmUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var usuario = tbUsuario.Text;
            var contraseña = tbContraseña.Text;
            UsuarioDTO user = new UsuarioDTO()
            {
                Username = tbUsuario.Text,
                Password = tbContraseña.Text
            };

            var gestion = new GestionUsuario();

             result = gestion.IniciarSesion(user);

            if (result.valido)
            {
                this.frmPrincipal.login = result.valido;
                this.frmPrincipal.usuario = result.usuario;
                this.Close();
            }
            else
            {
                MessageBox.Show(result.mensaje);
            }

        }

    }
}
