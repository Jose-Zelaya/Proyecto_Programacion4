using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administrador
{
    public partial class EliminarEmpleado : Form
    {
        public EliminarEmpleado()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void EliminarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void EliminarEmpleado_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MenuEmpleados nuevo = new MenuEmpleados();
            nuevo.Show();
            this.Visible = false;
        }
        SqlConnection conexion = new SqlConnection("workstation id=DBCinecatracho.mssql.somee.com;packet size=4096;user id=cesarsauceda_SQLLogin_1;pwd=nl65ssuu4h;data source=DBCinecatracho.mssql.somee.com;persist security info=False;initial catalog=DBCinecatracho");

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand("delete From t_Empleados where IdEmpleado='" + txtid.Text + "'", conexion);

            try
            {
                int a = comando.ExecuteNonQuery();
               
                if (a==1)
                {
                    label5.Text = "Pelicula Eliminada correctamente";
                    txtid.Text = "";
                }
                else
                {
                    label6.Text = "Empleado No existe";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);


            }
            conexion.Close();
        }
    }
}
