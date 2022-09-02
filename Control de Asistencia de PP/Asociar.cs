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
    public partial class Asociar : Form
    {
        MySqlConnection conexionDataBase = new MySqlConnection("server = 127.0.0.1; database = prueba_asistencia; Uid = root; pwd = ;");
        public Asociar()
        {
            InitializeComponent();
            cargarCmBox();
        }

        private void Asociar_Load(object sender, EventArgs e)
        {
            
        }

        private void cargarCmBox() 
        {
            string Quary = "SELECT id_Alumno, Apellido FROM alumnos";
            conexionDataBase.Open();
            MySqlCommand addComboBox = new MySqlCommand(Quary, conexionDataBase);
            MySqlDataAdapter data = new MySqlDataAdapter(addComboBox);
            DataTable DT = new DataTable();
            data.Fill(DT);
            cmBox_Alumno.ValueMember = "id_Alumno";
            cmBox_Alumno.DisplayMember = "Apellido";

            /*DataRow topItem = DT.NewRow();
            topItem[0] = "Selecciona el Alumno";
            DT.Rows.InsertAt(topItem, 0);*/
            cmBox_Alumno.DataSource = DT;
            conexionDataBase.Close();
        }

        private void asociar_Button_Click(object sender, EventArgs e)
        {
            conexionDataBase.Open();
            int IdAlumno = int.Parse(cmBox_Alumno.SelectedValue.ToString());
            string Quary = "INSERT INTO asistencias (uid_Tarjeta) VALUES ('" + textBox_Tarjeta.Text + "');";
            MySqlCommand insertar = new MySqlCommand(Quary, conexionDataBase);
            insertar.ExecuteNonQuery();
            string asociarQuary = "UPDATE asistencias JOIN alumnos SET asistencias.id_Alumno =" + IdAlumno + " where uid_Tarjeta =" + textBox_Tarjeta.Text;
            MySqlCommand asociar = new MySqlCommand(asociarQuary, conexionDataBase);
            asociar.ExecuteNonQuery();
            conexionDataBase.Close();
        }

        private void cmBox_Alumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmBox_Alumno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            conexionDataBase.Open();
            int IdAlumno = int.Parse(cmBox_Alumno.SelectedValue.ToString());
            string Quary = "SELECT uid_Tarjeta FROM asistencias WHERE id_Alumno = " + IdAlumno + " LIMIT 1;";
            MySqlCommand comando = new MySqlCommand(Quary, conexionDataBase);
            MySqlDataReader reader = comando.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    textBox_Tarjeta.Text = reader.GetString(0);
                }
            }
            conexionDataBase.Close();
        }

        private void desasociar_Button_Click(object sender, EventArgs e)
        {
        }
    }
} 
