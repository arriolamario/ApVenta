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
            CargarDatos();
        }

        private void CargarDatos()
        {
            lblPie.Text = "Sistema Venta " + DateTime.Now.Year;

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //pnlLeft.Controls.AddRange(ViewPrincipal.GetBotonesPanelLeft(Roles.Administrador));
        }

        private void btnLoginLogOut_Click(object sender, EventArgs e)
        {
            if (login)
            {
                //abrimos dialogo de preguntar si quiere cerrar sesion
                DialogResult result = MessageBox.Show("Esta por cerrar sesion, desea continuar", Constantes.K_CerrarSesion, MessageBoxButtons.YesNo);

                login = result != DialogResult.Yes;
                btnLoginLogOut.Text = login ? Constantes.K_CerrarSesion : Constantes.K_IniciarSesion;
                //pnlDatosUsuario.Visible = login;
            }
            else
            {
                //abrimos form para login
                var result = new frmUsuario(this).ShowDialog();
                btnLoginLogOut.Text = login ? Constantes.K_CerrarSesion : Constantes.K_IniciarSesion;
                //pnlDatosUsuario.Visible = login;
                if (login)
                {
                    lblApellido.Text = usuario.Apellido;
                    lblNombre.Text = usuario.Nombre;
                }
            }
        }

        private void pnlDatosUsuario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (sender as Button);
            CrearUsuario panel = new CrearUsuario();
            panel.Dock = DockStyle.Fill;

            pnlCenter.Controls.Clear();

            pnlCenter.Controls.Add(panel);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CrearUsuario crearUsuario = new CrearUsuario();
            crearUsuario.Dock = DockStyle.Fill;

            pnlCenter.Controls.Clear();
            pnlCenter.Controls.Add(crearUsuario);
        }
    }
}
