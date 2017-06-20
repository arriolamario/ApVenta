using ApVentaContracts.Enumerados;
using ApVentaContracts.Usuarios;
using ApVentaLogica;
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
    public partial class frmPrincipal : Form
    {
        public bool login;
        public UsuarioDTO usuario;
        public frmPrincipal()
        {
            InitializeComponent();
            usuario = new UsuarioDTO();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            pnlLeft.Controls.AddRange(ViewPrincipal.GetBotonesPanelLeft(Roles.Administrador));
        }

        private void btnLoginLogOut_Click(object sender, EventArgs e)
        {
            if (login)
            {
                //abrimos dialogo de preguntar si quiere cerrar sesion
                DialogResult result = MessageBox.Show("Esta por cerrar sesion, desea continuar", Constantes.K_CerrarSesion, MessageBoxButtons.YesNo);

                login = result != DialogResult.Yes;
                btnLoginLogOut.Text = login ? Constantes.K_CerrarSesion : Constantes.K_IniciarSesion;
                pnlDatosUsuario.Visible = login;
            }
            else
            {
                //abrimos form para login
                var result = new frmUsuario(this).ShowDialog();
                btnLoginLogOut.Text = login ? Constantes.K_CerrarSesion : Constantes.K_IniciarSesion;
                pnlDatosUsuario.Visible = login;
                if (login)
                {
                    lblApellido.Text = usuario.Apellido;
                    lblNombre.Text = usuario.Nombre;
                }
            }
        }
    }
}
