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
    public partial class AgregarPeli : Form
    {
       
        public AgregarPeli()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminPeli_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet4.t_Pelicula' Puede moverla o quitarla según sea necesario.
            this.t_PeliculaTableAdapter3.Fill(this.dataSet4.t_Pelicula);
            // TODO: esta línea de código carga datos en la tabla 'dataSet3.t_Pelicula' Puede moverla o quitarla según sea necesario.
            this.t_PeliculaTableAdapter2.Fill(this.dataSet3.t_Pelicula);
            // TODO: esta línea de código carga datos en la tabla 'dBCinecatrachoDataSet4.t_Sala' Puede moverla o quitarla según sea necesario.
            this.t_SalaTableAdapter1.Fill(this.dBCinecatrachoDataSet4.t_Sala);


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void AgregarPeli_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuPeliculas nuevo = new MenuPeliculas();
            nuevo.Show();
            this.Visible = false;
        }
        SqlConnection conexion = new SqlConnection("workstation id=DBCinecatracho.mssql.somee.com;packet size=4096;user id=cesarsauceda_SQLLogin_1;pwd=nl65ssuu4h;data source=DBCinecatracho.mssql.somee.com;persist security info=False;initial catalog=DBCinecatracho");

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand("insert into t_Pelicula values(@Nombre,@NombreActor, @NombreCompañia, @NombreGenero, @AñoLanzamiento,@LongitudMinuto, @FechaHora)",conexion);
            comando.Parameters.AddWithValue("@Nombre", txtnombre.Text);
            comando.Parameters.AddWithValue("@NombreActor", txtnombreactor.Text);
            comando.Parameters.AddWithValue("@NombreCompañia", cmbidcompañia.Text);
            comando.Parameters.AddWithValue("@NombreGenero", txtnombregenero.Text);
            comando.Parameters.AddWithValue("@Añolanzamiento", int.Parse(txtaño.Text));
            comando.Parameters.AddWithValue("@LongitudMinuto", txtminutos.Text);
            comando.Parameters.AddWithValue("@FechaHora", txtfecha.Text);

         try
            {
                comando.ExecuteNonQuery();
                aviso.Text = "Pelicula Agregada correctamente";
                Limpiar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show( ex.Message);

            }
            conexion.Close();
        }
            
       
        private void Limpiar()
        {

            txtnombre.Text = "";
            txtminutos.Text = "";
            txtaño.Text = "";
            txtfecha.Text = "";
            txtnombreactor.Text = "";
            txtnombregenero.Text = "";

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.t_PeliculaTableAdapter1.FillBy(this.dBCinecatrachoDataSet3.t_Pelicula);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
