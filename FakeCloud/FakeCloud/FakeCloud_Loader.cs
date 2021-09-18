using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeCloud
{
    public partial class FakeCloud_Loader : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FakeCloud_Loader()
        {
            InitializeComponent();
        }


        private void FakeCloud_Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int Velocidad = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {   
            bool dale = true;

            if(dale)
            {
                elipseControl2.Size = new Size(10 + Velocidad * 2, 5);
                elipseControl2.Location = new Point(159 - Velocidad, 263);
                Velocidad = (int)(Velocidad + 10);
                if (elipseControl2.Size.Width >= elipseControl1.Size.Width)
                {
                    this.Hide();
                    Form menu = new FakeCloud_Home();
                    menu.Show();
                    timer1.Stop();

                }
            }

        }

        private void FakeCloud_Loader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
