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
    public partial class ActualizarPeli : Form
    {
        public ActualizarPeli()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void button2_Click(object sender, EventArgs e)
        {
            MenuPeliculas nuevo = new MenuPeliculas();
            nuevo.Show();
            this.Visible = false;
        }

        private void ActualizarPeli_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBCinecatrachoDataSet5.t_Pelicula' Puede moverla o quitarla según sea necesario.
            this.t_PeliculaTableAdapter.Fill(this.dBCinecatrachoDataSet5.t_Pelicula);

        }

        private void ActualizarPeli_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        SqlConnection conexion = new SqlConnection("workstation id=DBCinecatracho.mssql.somee.com;packet size=4096;user id=cesarsauceda_SQLLogin_1;pwd=nl65ssuu4h;data source=DBCinecatracho.mssql.somee.com;persist security info=False;initial catalog=DBCinecatracho");
     
        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand comando = new SqlCommand("update t_Pelicula set Nombre=@Nombre, NombreActor=@NombreActor,NombreCompañia=@NombreCompañia,NombreGenero=@NombreGenero,AñoLanzamiento=@AñoLanzamiento,LongitudMinuto=@LongitudMinuto,FechaHora=@FechaHora where Nombre=@Nombre", conexion);

            comando.Parameters.AddWithValue("@Nombre",txtnombre.Text);
            comando.Parameters.AddWithValue("@NombreActor", txtnombreactor.Text);
            comando.Parameters.AddWithValue("@NombreCompañia", txtcompañia.Text);
            comando.Parameters.AddWithValue("@NombreGenero", txtnombregenero.Text);
            comando.Parameters.AddWithValue("@AñoLanzamiento", txtaño.Text);
            comando.Parameters.AddWithValue("@LongitudMinuto", txtminutos.Text);
            comando.Parameters.AddWithValue("@FechaHora", txtfecha.Text);
           
            try
            {
                comando.ExecuteNonQuery();
                label1.Text = "Pelicula Actualizada Correctamente";
                txtnombre.Text="";
                txtnombreactor.Text = "";
                txtcompañia.Text = "";
                txtnombregenero.Text = "";
                txtaño.Text = "";
                txtminutos.Text = "";
                txtfecha.Text = "";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            conexion.Close();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("select * from t_Pelicula where Nombre='"+txtnombre.Text+"'", conexion);
            conexion.Open();
            SqlDataReader nuevo = comando.ExecuteReader();

            
            if (nuevo.Read()==true)
            {
                txtnombre.Text = nuevo["Nombre"].ToString();                
                txtcompañia.Text = nuevo["NombreCompañia"].ToString();
                txtnombreactor.Text = nuevo["NombreActor"].ToString();
                txtnombregenero.Text = nuevo["NombreGenero"].ToString();
                txtaño.Text = nuevo["AÑoLanzamiento"].ToString();
                txtminutos.Text = nuevo["LongitudMinuto"].ToString();
                txtfecha.Text = nuevo["FechaHora"].ToString();
            }
            try
            {
                
                label1.Text = "Pelicula Encontrada";
                

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);


            }
            conexion.Close();
        }
    }
}
