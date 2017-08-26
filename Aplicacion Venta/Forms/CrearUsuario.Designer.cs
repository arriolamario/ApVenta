namespace Aplicacion_Venta.Forms
{
    partial class CrearUsuario
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.tbNumDocumento = new System.Windows.Forms.MaskedTextBox();
            this.lblPassUsuario = new System.Windows.Forms.Label();
            this.tbPassUsuario = new System.Windows.Forms.MaskedTextBox();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.tbNomUsuario = new System.Windows.Forms.MaskedTextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.MaskedTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new ControlesPersonalizados.TextBoxEx();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(224, 197);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(87, 28);
            this.btnCargar.TabIndex = 26;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(194, 134);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(139, 16);
            this.lblDocumento.TabIndex = 25;
            this.lblDocumento.Text = "Numero de documento";
            // 
            // tbNumDocumento
            // 
            this.tbNumDocumento.Location = new System.Drawing.Point(138, 154);
            this.tbNumDocumento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNumDocumento.Name = "tbNumDocumento";
            this.tbNumDocumento.Size = new System.Drawing.Size(251, 22);
            this.tbNumDocumento.TabIndex = 24;
            // 
            // lblPassUsuario
            // 
            this.lblPassUsuario.AutoSize = true;
            this.lblPassUsuario.Location = new System.Drawing.Point(361, 14);
            this.lblPassUsuario.Name = "lblPassUsuario";
            this.lblPassUsuario.Size = new System.Drawing.Size(74, 16);
            this.lblPassUsuario.TabIndex = 23;
            this.lblPassUsuario.Text = "Contraseña";
            // 
            // tbPassUsuario
            // 
            this.tbPassUsuario.Location = new System.Drawing.Point(273, 33);
            this.tbPassUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassUsuario.Name = "tbPassUsuario";
            this.tbPassUsuario.Size = new System.Drawing.Size(251, 22);
            this.tbPassUsuario.TabIndex = 22;
            this.tbPassUsuario.UseSystemPasswordChar = true;
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Location = new System.Drawing.Point(86, 14);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(101, 16);
            this.lblNomUsuario.TabIndex = 19;
            this.lblNomUsuario.Text = "Nombre Usuario";
            // 
            // tbNomUsuario
            // 
            this.tbNomUsuario.Location = new System.Drawing.Point(11, 33);
            this.tbNomUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNomUsuario.Name = "tbNomUsuario";
            this.tbNomUsuario.Size = new System.Drawing.Size(251, 22);
            this.tbNomUsuario.TabIndex = 18;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(371, 74);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 16);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellido";
            // 
            // tbApellido
            // 
            this.tbApellido.Location = new System.Drawing.Point(273, 94);
            this.tbApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(251, 22);
            this.tbApellido.TabIndex = 16;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(110, 74);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 16);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.borrar = false;
            this.tbNombre.Location = new System.Drawing.Point(11, 94);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(251, 22);
            this.tbNombre.TabIndex = 14;
            this.tbNombre.TipoValidador = ControlesPersonalizados.TipoValidador.SoloLetras;
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.tbNumDocumento);
            this.Controls.Add(this.lblPassUsuario);
            this.Controls.Add(this.tbPassUsuario);
            this.Controls.Add(this.lblNomUsuario);
            this.Controls.Add(this.tbNomUsuario);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.tbApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbNombre);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CrearUsuario";
            this.Size = new System.Drawing.Size(537, 236);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.MaskedTextBox tbNumDocumento;
        private System.Windows.Forms.Label lblPassUsuario;
        private System.Windows.Forms.MaskedTextBox tbPassUsuario;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.MaskedTextBox tbNomUsuario;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.MaskedTextBox tbApellido;
        private System.Windows.Forms.Label lblNombre;
        private ControlesPersonalizados.TextBoxEx tbNombre;

    }
}
