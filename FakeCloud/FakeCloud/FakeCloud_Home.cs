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
    public partial class FakeCloud_Home : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
       


        static FakeCloud_Home _obj;
        public static FakeCloud_Home Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FakeCloud_Home();
                }
                return _obj;
            }
        }
        public Panel nav_module
        {
            get { return panel2; }
            set { panel2 = value; }
        }

        public FakeCloud_Home()
        {
            InitializeComponent();
            _obj = this;
        }

        private void FakeCloud_Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FakeCloud_Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void FakeCloud_Home_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
 
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (!FakeCloud.FakeCloud_Home.Instance.nav_module.Controls.ContainsKey("Home"))
            {
                FakeCloud.Modules.Home nuuyy = new FakeCloud.Modules.Home();
                nuuyy.Dock = DockStyle.Fill;
                FakeCloud.FakeCloud_Home.Instance.nav_module.Controls.Add(nuuyy);
            }
            FakeCloud.FakeCloud_Home.Instance.nav_module.Controls["Home"].BringToFront();
        }

        private void btnLoader_Click(object sender, EventArgs e)
        {

        }
    }
}
