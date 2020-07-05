using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrador
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuPeliculas nuevo = new MenuPeliculas();
            nuevo.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuEmpleados nuevo = new MenuEmpleados();
            nuevo.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Application.Restart();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
