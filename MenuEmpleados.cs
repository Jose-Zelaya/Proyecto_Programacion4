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

namespace Administrador
{
    public partial class MenuEmpleados : Form
    {
        public MenuEmpleados()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void button1_Click(object sender, EventArgs e)
        {
            NuevoEmpleado nuevo = new NuevoEmpleado();
            nuevo.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditarEmpleado nuevo = new EditarEmpleado();
            nuevo.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EliminarEmpleado nuevo = new EliminarEmpleado();
            nuevo.Show();
            this.Hide();
        }

        private void MenuEmpleados_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormMenu nuevo = new FormMenu();
            nuevo.Show();
            this.Hide();

        }
    }
}
