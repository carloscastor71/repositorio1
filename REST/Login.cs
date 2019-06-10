using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace REST
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost;database=restaurante; Uid=root;pwd=; ");
            conectar.Open();

            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection con = new MySqlConnection();
            cmd.Connection = conectar;
            cmd.CommandText = ("select nombre, contrasena from usuarios where nombre='" + user.Text + "' and contrasena='" + pass.Text + "'");
            MySqlDataReader leer = cmd.ExecuteReader();
            if (leer.Read())

            {
                MessageBox.Show("bienvenido");
                Menu m = new Menu();
                this.Hide();
                m.Show();
            }
            else
            {
                MessageBox.Show("datos erroneos");
            }
            conectar.Close();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
