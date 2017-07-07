namespace Aplicacion_Venta.Forms
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblPie = new System.Windows.Forms.Label();
            this.pnlBottomLeft = new System.Windows.Forms.Panel();
            this.pnlBottomRight = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlLeftTop = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.pnlTopRight = new System.Windows.Forms.Panel();
            this.pnlTopCenter = new System.Windows.Forms.Panel();
            this.pnlLeftCenter = new System.Windows.Forms.Panel();
            this.pnlBottomCenter = new System.Windows.Forms.Panel();
            this.btnLoginLogOut = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlBottom.SuspendLayout();
            this.pnlBottomLeft.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlLeftTop.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlTopRight.SuspendLayout();
            this.pnlLeftCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.pnlBottomCenter);
            this.pnlBottom.Controls.Add(this.pnlBottomRight);
            this.pnlBottom.Controls.Add(this.pnlBottomLeft);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 398);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1012, 75);
            this.pnlBottom.TabIndex = 1;
            // 
            // lblPie
            // 
            this.lblPie.AutoSize = true;
            this.lblPie.Location = new System.Drawing.Point(50, 31);
            this.lblPie.Name = "lblPie";
            this.lblPie.Size = new System.Drawing.Size(35, 13);
            this.lblPie.TabIndex = 0;
            this.lblPie.Text = "label3";
            // 
            // pnlBottomLeft
            // 
            this.pnlBottomLeft.Controls.Add(this.lblPie);
            this.pnlBottomLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBottomLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlBottomLeft.Name = "pnlBottomLeft";
            this.pnlBottomLeft.Size = new System.Drawing.Size(176, 75);
            this.pnlBottomLeft.TabIndex = 1;
            // 
            // pnlBottomRight
            // 
            this.pnlBottomRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBottomRight.Location = new System.Drawing.Point(853, 0);
            this.pnlBottomRight.Name = "pnlBottomRight";
            this.pnlBottomRight.Size = new System.Drawing.Size(159, 75);
            this.pnlBottomRight.TabIndex = 2;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlLeftCenter);
            this.pnlLeft.Controls.Add(this.pnlLeftTop);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(176, 398);
            this.pnlLeft.TabIndex = 2;
            // 
            // pnlLeftTop
            // 
            this.pnlLeftTop.Controls.Add(this.lblApellido);
            this.pnlLeftTop.Controls.Add(this.lblNombre);
            this.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLeftTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftTop.Name = "pnlLeftTop";
            this.pnlLeftTop.Size = new System.Drawing.Size(176, 100);
            this.pnlLeftTop.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlTopCenter);
            this.panel4.Controls.Add(this.pnlTopRight);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(176, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(836, 100);
            this.panel4.TabIndex = 3;
            // 
            // pnlCenter
            // 
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(176, 100);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(836, 298);
            this.pnlCenter.TabIndex = 4;
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.Controls.Add(this.btnLoginLogOut);
            this.pnlTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTopRight.Location = new System.Drawing.Point(720, 0);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.Size = new System.Drawing.Size(116, 100);
            this.pnlTopRight.TabIndex = 0;
            // 
            // pnlTopCenter
            // 
            this.pnlTopCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTopCenter.Location = new System.Drawing.Point(0, 0);
            this.pnlTopCenter.Name = "pnlTopCenter";
            this.pnlTopCenter.Size = new System.Drawing.Size(720, 100);
            this.pnlTopCenter.TabIndex = 0;
            // 
            // pnlLeftCenter
            // 
            this.pnlLeftCenter.Controls.Add(this.button1);
            this.pnlLeftCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftCenter.Location = new System.Drawing.Point(0, 100);
            this.pnlLeftCenter.Name = "pnlLeftCenter";
            this.pnlLeftCenter.Size = new System.Drawing.Size(176, 298);
            this.pnlLeftCenter.TabIndex = 0;
            // 
            // pnlBottomCenter
            // 
            this.pnlBottomCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottomCenter.Location = new System.Drawing.Point(176, 0);
            this.pnlBottomCenter.Name = "pnlBottomCenter";
            this.pnlBottomCenter.Size = new System.Drawing.Size(677, 75);
            this.pnlBottomCenter.TabIndex = 0;
            // 
            // btnLoginLogOut
            // 
            this.btnLoginLogOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoginLogOut.Location = new System.Drawing.Point(0, 0);
            this.btnLoginLogOut.Name = "btnLoginLogOut";
            this.btnLoginLogOut.Size = new System.Drawing.Size(116, 100);
            this.btnLoginLogOut.TabIndex = 0;
            this.btnLoginLogOut.Text = "button5";
            this.btnLoginLogOut.UseVisualStyleBackColor = true;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(65, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "label1";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(71, 44);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(35, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 473);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlBottom);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottomLeft.ResumeLayout(false);
            this.pnlBottomLeft.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeftTop.ResumeLayout(false);
            this.pnlLeftTop.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.pnlTopRight.ResumeLayout(false);
            this.pnlLeftCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblPie;
        private System.Windows.Forms.Panel pnlBottomLeft;
        private System.Windows.Forms.Panel pnlBottomRight;
        private System.Windows.Forms.Panel pnlBottomCenter;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlLeftCenter;
        private System.Windows.Forms.Panel pnlLeftTop;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlTopCenter;
        private System.Windows.Forms.Panel pnlTopRight;
        private System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.Button btnLoginLogOut;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button button1;

    }
}