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
        bool login;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnLoginLogOut_Click(object sender, EventArgs e)
        {
            if (login)
            {
                //abrimos dialogo de preguntar si quiere cerrar sesion
                login = !login;
                btnLoginLogOut.Text = "Cerrar Sesion";
            }
            else
            {
                //abrimos form para login
                login = !login;
                btnLoginLogOut.Text = "Iniciar Sesion";

                
            }
        }

    }
}
