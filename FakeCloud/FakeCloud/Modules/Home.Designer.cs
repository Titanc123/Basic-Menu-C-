
namespace FakeCloud.Modules
{
    partial class Home
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.elipseControl1 = new View.Components.ElipseControl();
            this.elipseControl2 = new View.Components.ElipseControl();
            this.elipseControl3 = new View.Components.ElipseControl();
            this.elipseControl4 = new View.Components.ElipseControl();
            this.SuspendLayout();
            // 
            // elipseControl1
            // 
            this.elipseControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.elipseControl1.CornerRadius = 10;
            this.elipseControl1.Location = new System.Drawing.Point(20, 12);
            this.elipseControl1.Name = "elipseControl1";
            this.elipseControl1.Size = new System.Drawing.Size(360, 244);
            this.elipseControl1.TabIndex = 0;
            this.elipseControl1.Text = "elipseControl1";
            // 
            // elipseControl2
            // 
            this.elipseControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.elipseControl2.CornerRadius = 10;
            this.elipseControl2.Location = new System.Drawing.Point(20, 285);
            this.elipseControl2.Name = "elipseControl2";
            this.elipseControl2.Size = new System.Drawing.Size(554, 244);
            this.elipseControl2.TabIndex = 1;
            this.elipseControl2.Text = "elipseControl2";
            // 
            // elipseControl3
            // 
            this.elipseControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.elipseControl3.CornerRadius = 10;
            this.elipseControl3.Location = new System.Drawing.Point(594, 285);
            this.elipseControl3.Name = "elipseControl3";
            this.elipseControl3.Size = new System.Drawing.Size(240, 244);
            this.elipseControl3.TabIndex = 2;
            this.elipseControl3.Text = "elipseControl3";
            // 
            // elipseControl4
            // 
            this.elipseControl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.elipseControl4.CornerRadius = 10;
            this.elipseControl4.Location = new System.Drawing.Point(400, 12);
            this.elipseControl4.Name = "elipseControl4";
            this.elipseControl4.Size = new System.Drawing.Size(434, 244);
            this.elipseControl4.TabIndex = 3;
            this.elipseControl4.Text = "elipseControl4";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.elipseControl4);
            this.Controls.Add(this.elipseControl3);
            this.Controls.Add(this.elipseControl2);
            this.Controls.Add(this.elipseControl1);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(851, 570);
            this.ResumeLayout(false);

        }

        #endregion

        private View.Components.ElipseControl elipseControl1;
        private View.Components.ElipseControl elipseControl2;
        private View.Components.ElipseControl elipseControl3;
        private View.Components.ElipseControl elipseControl4;
    }
}
