using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApInfra;
using ApVentaContracts.Entidades;
namespace Aplicacion_Venta.Usuario
{
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            Button boton = sender as Button;

            foreach (Control control in boton.Parent.Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Clear();
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            UsuarioDTO usuario = new UsuarioDTO();

            //usuario.Save();
        }

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
