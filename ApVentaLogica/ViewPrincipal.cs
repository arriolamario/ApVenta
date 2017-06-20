using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApVentaContracts.Enumerados;
using System.Drawing;

namespace ApVentaLogica
{
    public static class ViewPrincipal
    {
        //// 
        //    // btnModificarUsuario
        //    // 
        //    this.btnModificarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
        //    this.btnModificarUsuario.Location = new System.Drawing.Point(0, 23);
        //    this.btnModificarUsuario.Name = "btnModificarUsuario";
        //    this.btnModificarUsuario.Size = new System.Drawing.Size(200, 23);
        //    this.btnModificarUsuario.TabIndex = 1;
        //    this.btnModificarUsuario.Text = "Modificar Usuario";
        //    this.btnModificarUsuario.UseVisualStyleBackColor = true;

        public static Control[] GetBotonesPanelLeft(Roles rol)
        {
            List<Control> listaControles = new List<Control>();

            switch (rol)
            {
                case Roles.Administrador:
                    GetBononesAdministrador(listaControles);
                    break;
                case Roles.Vendedor:
                    break;
                case Roles.Operario:
                    break;
                default:
                    break;
            }
            var retorno = listaControles.ToArray();
            return retorno;
        }

        private static void GetBononesAdministrador(List<Control> listaControles)
        {
            Button crearUsuario = ConfigBtnCrearUsuario();
            Button modificarUsuario = ConfigBtnModificarUsuario();
            Button eliminarUsuario = ConfigEliminarUsuario();
            Panel pnl1 = new Panel();
            pnl1.Dock = DockStyle.Top;
            Label lblUsuario = new Label();
            lblUsuario.Text = "Seccion Usuario";
            lblUsuario.Dock = DockStyle.Top;
            pnl1.Controls.Add(crearUsuario);
            pnl1.Controls.Add(lblUsuario);

            Panel pnl2 = new Panel();
            pnl2.Dock = DockStyle.Top;
            Label lblModificar = new Label();
            lblModificar.Text = "Seccion Modificar";
            lblModificar.Dock = DockStyle.Top;
            pnl2.Controls.Add(modificarUsuario);
            pnl2.Controls.Add(lblModificar);

            listaControles.Add(pnl1);
            listaControles.Add(pnl2);
        }

        private static Button ConfigEliminarUsuario()
        {
            //EliminarUsuario
            Button eliminarUsuario = new Button();
            eliminarUsuario.Dock = DockStyle.Top;
            //eliminarUsuario.Location = new Point(0, 23);
            eliminarUsuario.Name = "btnEliminarUsuario";
            //eliminarUsuario.Size = new Size(200, 23);
            eliminarUsuario.TabIndex = 1;
            eliminarUsuario.Text = "Eliminar Usuario";
            eliminarUsuario.UseVisualStyleBackColor = true;
            return eliminarUsuario;
        }

        private static Button ConfigBtnModificarUsuario()
        {
            //ModificarUsuario
            Button modificarUsuario = new Button();
            modificarUsuario.Dock = DockStyle.Top;
            //modificarUsuario.Location = new Point(0, 23);
            modificarUsuario.Name = "btnModificarUsuario";
            //modificarUsuario.Size = new Size(200, 23);
            modificarUsuario.TabIndex = 1;
            modificarUsuario.Text = "Modificar Usuario";
            modificarUsuario.UseVisualStyleBackColor = true;
            return modificarUsuario;
        }

        private static Button ConfigBtnCrearUsuario()
        {
            //CrearUsuario
            Button crearUsuario = new Button();
            crearUsuario.Dock = DockStyle.Top;
            //crearUsuario.Location = new Point(0, 23);
            crearUsuario.Name = "btnCrearUsuario";
            //crearUsuario.Size = new Size(200, 23);
            crearUsuario.TabIndex = 1;
            crearUsuario.Text = "Crear Usuario";
            crearUsuario.UseVisualStyleBackColor = true;
            crearUsuario.Click += crearUsuario_Click;
            return crearUsuario;
        }

        static void crearUsuario_Click(object sender, EventArgs e)
        {
            Panel pnl = GetPanelPrincipal((sender as Button));
            
            
        }

        private static Panel GetPanelPrincipal(Button b)
        {
            Form formulario = b.FindForm();

            Panel principal = new Panel();

            foreach (Control control in formulario.Controls)
            {
                if (control.Name == "pnlPrincipal")
                {
                    principal = (control as Panel);
                    break;
                }
            }

            principal.Controls.Clear();

            return principal;
        }

    }
}
