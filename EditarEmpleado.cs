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
    public partial class EditarEmpleado : Form
    {
        public EditarEmpleado()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void EditarEmpleado_Load(object sender, EventArgs e)
        {
          
            txtnombre.Enabled = false;
            txtapellido.Enabled = false;
            txtusuario.Enabled = false;
            txtcontraseña.Enabled = false;
            btnbuscar.Enabled = false;
            btnactualizar.Enabled = false;

            
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.t_Empleados' Puede moverla o quitarla según sea necesario.
            this.t_EmpleadosTableAdapter.Fill(this.dataSet1.t_Empleados);

        }
        SqlConnection conexion = new SqlConnection("workstation id=DBCinecatracho.mssql.somee.com;packet size=4096;user id=cesarsauceda_SQLLogin_1;pwd=nl65ssuu4h;data source=DBCinecatracho.mssql.somee.com;persist security info=False;initial catalog=DBCinecatracho");

        private void EditarEmpleado_MouseDown(object sender, MouseEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select * from t_Empleados where NombreEmpleado='" + txtnombre.Text + "'", conexion);
            conexion.Open();
            SqlDataReader nuevo = comando.ExecuteReader();


            if (nuevo.Read() == true)
            {
                txtnombre.Text = nuevo["NombreEmpleado"].ToString();
                txtapellido.Text = nuevo["ApellidoEmpleado"].ToString();
                txtusuario.Text = nuevo["Usuario"].ToString();
                txtcontraseña.Text = nuevo["Contraseña"].ToString();
                
            }
            try
            {

                label7.Text = "Empleado Encontrado";
                

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);


            }
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if( txtnombre.Enabled == true && txtapellido.Enabled == true && txtusuario.Enabled == true && txtcontraseña.Enabled == true && btnbuscar.Enabled == true && btnactualizar.Enabled == true )
            {
              
                txtnombre.Enabled = false;
                txtapellido.Enabled = false;
                txtusuario.Enabled = false;
                txtcontraseña.Enabled = false;
                btnbuscar.Enabled = false;
                btnactualizar.Enabled = false;
            }
            else
            {
               
                txtnombre.Enabled = true;
                txtapellido.Enabled = true;
                txtusuario.Enabled = true;
                txtcontraseña.Enabled = true;
                btnbuscar.Enabled = true;
                btnactualizar.Enabled = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (txtnombre.Text == ""|| txtcontraseña.Text ==""||txtapellido.Text == "" ||txtusuario.Text == "")
            {
                label7.Text = "Primero Busque El empleado a Actualizar";
            }
            else
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand("update t_Empleados set NombreEmpleado=@NombreEmpleado, ApellidoEmpleado=@ApellidoEmpleado,Usuario=@Usuario,Contraseña=@Contraseña where NombreEmpleado=@NombreEmpleado", conexion);

                comando.Parameters.AddWithValue("@NombreEmpleado", txtnombre.Text);
                comando.Parameters.AddWithValue("@ApellidoEmpleado", txtapellido.Text);
                comando.Parameters.AddWithValue("@Usuario", txtusuario.Text);
                comando.Parameters.AddWithValue("@Contraseña", txtcontraseña.Text);

                try
                {
                    comando.ExecuteNonQuery();
                    label7.Text = "Empleado Actualizado Correctamente";
                    txtnombre.Text = "";
                    txtcontraseña.Text = "";
                    txtapellido.Text = "";
                    txtusuario.Text = "";

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            conexion.Close();
        }
    }
}
