using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Venta.Prueba
{
    public partial class frmPrincipalTest : Form
    {
        ucIniciarSesion viewIniciarSesion;
        int numeroButton;
        public frmPrincipalTest()
        {
            InitializeComponent();
            viewIniciarSesion = new ucIniciarSesion();
            viewIniciarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            scPrincipal.Panel2.Controls.Add(viewIniciarSesion);
            numeroButton = 0;
        }

        private void btnIniciarSecion_Click(object sender, EventArgs e)
        {
            scPrincipal.Panel2.Controls.Clear();
            scPrincipal.Panel2.Controls.Add(new ucIniciarSesion());
        }

        private void button1_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                GroupBox grupo = new GroupBox();
                for (int j = 0; j < 3; j++)
                {
                    Button button = new Button();
                    button.Dock = DockStyle.Top;
                    button.Name = string.Format("Boton {0}", numeroButton);
                    button.Text = string.Format("Boton {0}", numeroButton);
                    numeroButton++;
                    grupo.Controls.Add(button);
                }
                grupo.Dock = DockStyle.Top;
                grupo.Text = string.Format("grupo {0}", i);
                scPrincipal.Panel1.Controls.Add(grupo);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipalTest_Load(object sender, EventArgs e)
        {

        }

        private void frmPrincipalTest_Resize(object sender, EventArgs e)
        {
            foreach (Control item in scPrincipal.Panel2.Controls)
            {
                int medioPanelHeight = scPrincipal.Panel2.Height / 2;
                int medioItemHeight = item.Height / 2;
                int medioPanelWidth = scPrincipal.Panel2.Width / 2;
                int medioItemWidth = item.Width / 2;

                int x = (medioPanelWidth - medioItemWidth) > 0 ? (medioPanelWidth - medioItemWidth) : 0;
                int y = (medioPanelHeight - medioItemHeight) > 0 ? (medioPanelHeight - medioItemHeight) : 0;
                item.Location = new Point(x, y);
            }


        }


    }
}
