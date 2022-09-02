using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Control_de_Asistencia_de_PP.MySql
{
    class conexionMySql
    {
        public static MySqlConnection conexionDB() 
        {
            MySqlConnection conexionDataBase = new MySqlConnection("server = 127.0.0.1; database = asistencia_virtual_pp; Uid = root; pwd = Alexis020304.;");
            conexionDataBase.Open();
            return conexionDataBase;
        }
    }
}
