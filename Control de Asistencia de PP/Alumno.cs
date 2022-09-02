using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Control_de_Asistencia_de_PP
{
    public partial class Alumno : Form
    {
        MySqlConnection conexionDataBase = new MySqlConnection("server = 127.0.0.1; database = prueba_asistencia; Uid = root; pwd = ;");
        public Alumno()
        {
            InitializeComponent();
        }

        private void button_IngresarDatos_Click(object sender, EventArgs e)
        {
            conexionDataBase.Open();
            string Quary = "INSERT INTO alumnos (Nombre, Apellido) values ('" + texbox_Nombre.Text + "','" + texbox_Apellido.Text + "');";
            MySqlCommand insertarDatos = new MySqlCommand(Quary, conexionDataBase);
            insertarDatos.ExecuteNonQuery();
            conexionDataBase.Close();
            MessageBox.Show("Alumno agregado");
        }
    }
}
