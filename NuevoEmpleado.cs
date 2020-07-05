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
    public partial class NuevoEmpleado : Form
    {
        public NuevoEmpleado()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void label4_Click(object sender, EventArgs e)
        {

        }
        SqlConnection conexion = new SqlConnection("workstation id=DBCinecatracho.mssql.somee.com;packet size=4096;user id=cesarsauceda_SQLLogin_1;pwd=nl65ssuu4h;data source=DBCinecatracho.mssql.somee.com;persist security info=False;initial catalog=DBCinecatracho");

        private void NuevoEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void NuevoEmpleado_MouseDown(object sender, MouseEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand("insert into t_Empleados values(@NombreEmpleado, @ApellidoEmpleado, @Usuario, @Contraseña)", conexion);
            comando.Parameters.AddWithValue("@NombreEmpleado", txtnombre.Text);
            comando.Parameters.AddWithValue("@ApellidoEmpleado", txtapellido.Text);
            comando.Parameters.AddWithValue("@Usuario", txtusuario.Text);
            comando.Parameters.AddWithValue("@Contraseña", txtcontraseña.Text);

            try
            {
                comando.ExecuteNonQuery();
                label2.Text = "Pelicula Agregada correctamente";
                txtnombre.Text = "";
                txtapellido.Text = "";
                txtusuario.Text = "";
                txtcontraseña.Text = "";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            conexion.Close();
        }
    }
}
