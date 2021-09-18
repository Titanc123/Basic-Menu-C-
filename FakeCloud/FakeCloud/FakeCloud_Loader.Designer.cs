
namespace FakeCloud
{
    partial class FakeCloud_Loader
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FakeCloud_Loader));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.elipseControl2 = new View.Components.ElipseControl();
            this.elipseControl1 = new View.Components.ElipseControl();
            this.elipseComponent1 = new View.Components.ElipseComponent();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FakeCloud.Properties.Resources.Nube_Blanca;
            this.pictureBox1.Location = new System.Drawing.Point(19, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FakeCloud_Loader_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Museo Sans Cyrl 700", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(104, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "FakeCloud";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FakeCloud_Loader_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FakeCloud.Properties.Resources.Nube_Blanca;
            this.pictureBox2.Location = new System.Drawing.Point(30, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 220);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // elipseControl2
            // 
            this.elipseControl2.BackColor = System.Drawing.Color.Crimson;
            this.elipseControl2.CornerRadius = 5;
            this.elipseControl2.Location = new System.Drawing.Point(159, 263);
            this.elipseControl2.Name = "elipseControl2";
            this.elipseControl2.Size = new System.Drawing.Size(18, 5);
            this.elipseControl2.TabIndex = 6;
            this.elipseControl2.Text = "elipseControl2";
            // 
            // elipseControl1
            // 
            this.elipseControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.elipseControl1.CornerRadius = 5;
            this.elipseControl1.Location = new System.Drawing.Point(23, 263);
            this.elipseControl1.Name = "elipseControl1";
            this.elipseControl1.Size = new System.Drawing.Size(283, 5);
            this.elipseControl1.TabIndex = 4;
            this.elipseControl1.Text = "elipseControl1";
            // 
            // elipseComponent1
            // 
            this.elipseComponent1.CornerRadius = 20;
            this.elipseComponent1.TargetControl = this;
            // 
            // FakeCloud_Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(326, 294);
            this.Controls.Add(this.elipseControl2);
            this.Controls.Add(this.elipseControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FakeCloud_Loader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FakeCloud";
            this.Load += new System.EventHandler(this.FakeCloud_Home_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FakeCloud_Loader_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private View.Components.ElipseComponent elipseComponent1;
        private View.Components.ElipseControl elipseControl1;
        private View.Components.ElipseControl elipseControl2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

