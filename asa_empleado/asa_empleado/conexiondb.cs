using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace asa_empleado
{
    public class conexiondb
    {

        MySqlConnection conexion = new MySqlConnection("Server=localhost;Database=asa;port=3308;Uid=root;Pwd=qwerty1234;");

        private MySqlCommand cmd;
        private MySqlCommandBuilder cmdb;
        private MySqlDataAdapter adater;
        private DataSet ds;
        private DataTable dt;

        public bool conect()
        {
            bool conn = false;

            try
            {
                conexion.Open();
                conn = true;
            }
            catch (Exception ex)
            {
                conn = false;
            }
            finally
            {
                conexion.Close();
            }
            return conn;
        }
        public bool insertar(string consulta)
        {
            bool agregado = false;
            int rows = 0;
            conexion.Open();

            cmd = new MySqlCommand(consulta,conexion);
            rows = cmd.ExecuteNonQuery();

            if(rows > 0)
            {
                agregado = true;
            }

            return agregado;
        }
        public bool eliminar(string consulta)
        {
            bool eliminado = false;
            int rows = 0;
            conexion.Open();

            cmd = new MySqlCommand(consulta, conexion);
            rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                eliminado = true;
            }

            return eliminado;

        }
        public DataTable buscar(string consulta)
        {
            conexion.Open();

            cmd = new MySqlCommand(consulta, conexion);
            adater = new MySqlDataAdapter(cmd);
            dt = new DataTable();

            adater.Fill(dt);
            conexion.Close();
            return dt;
        }

        public bool actualizar(string consulta)
        {
            bool actualizado = false;
            int rows = 0;
            conexion.Open();

            cmd = new MySqlCommand(consulta, conexion);
            rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                actualizado = true;
            }

            return actualizado;
        }

        public DataTable Llenargrid(string consulta)
        {
            conexion.Open();

            cmd = new MySqlCommand(consulta,conexion);
            adater = new MySqlDataAdapter(cmd);
            dt = new DataTable();

            adater.Fill(dt);
            conexion.Close();
            return dt; 
        }

    }
}
