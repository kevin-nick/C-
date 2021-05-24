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

namespace asa_empleado
{
    public partial class login : Form 
    {
        public login()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LOGUIN_Click(object sender, EventArgs e)
        {
            if (USER.Text != "")
            {
                if (PASS.Text != "")
                {
                    MySqlConnection conexion = new MySqlConnection("Server=localhost;Database=asa;port=3308;Uid=root;Pwd=qwerty1234;");

                    conexion.Open();
                  
                    MySqlCommand cmd = new MySqlCommand("select * from asa.login  where usuario = '" + USER.Text + "' and contra ='" + PASS.Text + "';", conexion);
                    MySqlDataReader leer = cmd.ExecuteReader();
                   
                        if (leer.HasRows)
                        {
                            asa f = new asa();
                            this.Hide();
                            f.ShowDialog();
                        this.Close();
                          
                        }
                       else
                        error.Text = "usuario no existe";
                }
                else
                error.Text = "ingrese contraseña";
            }
              else
                error.Text = "ingrese usuario";
        }
    }
}
