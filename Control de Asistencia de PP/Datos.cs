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
using MySql.Data;
using MySql.Data.Types;

namespace Control_de_Asistencia_de_PP
{
    public partial class Datos : Form
    {
        MySqlConnection conexionDataBase = new MySqlConnection("server = 127.0.0.1; database = prueba_asistencia; Uid = root; pwd = .;");


        public Datos()
        {
            InitializeComponent();
            condicionCombobox();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Datos_Load(object sender, EventArgs e)
        {
            string Quary = "SELECT alumnos.id_Alumno, Nombre, Apellido, Hora_De_Entrada, Condicion, fecha, total_Asistencia, total_Inasistencias FROM alumnos INNER JOIN asistencias ON alumnos.id_Alumno = asistencias.id_Alumno;";

            conexionDataBase.Open();
            MySqlCommand dataGrid = new MySqlCommand(Quary, conexionDataBase);
            dataGrid.CommandTimeout = 60;
            MySqlDataReader reader;
            reader = dataGrid.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = reader.GetString(0);
                    dataGridView1.Rows[n].Cells[1].Value = reader.GetString(1);
                    dataGridView1.Rows[n].Cells[2].Value = reader.GetString(2);
                    dataGridView1.Rows[n].Cells[3].Value = reader.GetString(3);
                    //dataGridView1.Rows[n].Cells[4].Value = reader.GetString(4);
                    dataGridView1.Rows[n].Cells[5].Value = reader.GetString(5);
                    dataGridView1.Rows[n].Cells[6].Value = reader.GetString(6);
                    dataGridView1.Rows[n].Cells[7].Value = reader.GetString(7);
                }
            }
            conexionDataBase.Close();
            
        }

        private void but_Guardar_Click(object sender, EventArgs e)
        {

        }

        private void condicionCombobox()
        {
            /*conexionDataBase.Open();
            string Quary = "SELECT Condicion FROM asistencias;";
            MySqlDataAdapter mySqlAdapter = new MySqlDataAdapter(Quary, conexionDataBase);
            DataTable dtbl = new DataTable();
            mySqlAdapter.Fill(dtbl);
            ausPres.ValueMember = "Condicion";

            DataRow topItem = dtbl.NewRow();
            DataRow topItem1 = dtbl.NewRow();
            topItem[0] = "-Select-";
            topItem1[0] = "Ausente";
            dtbl.Rows.InsertAt(topItem, 0);
            dtbl.Rows.InsertAt(topItem1, 2);
            ausPres.DataSource = dtbl;*/

            ausPres.Items.Add("Presente");
            ausPres.Items.Add("Ausente");

        }
    }
}
