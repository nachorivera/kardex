using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Kardex_1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool res = false;

            SqlConnection conexion = Conexion.ObtnerConexion();
            SqlCommand comando = new SqlCommand(string.Format("SELECT * FROM usuarios WHERE nombre_usuario = '{0}' AND contrasena_usuario = '{1}'", usuario.Text, contraseña.Text), conexion);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                res = true;
            }

            if (res)
            {
                Kardex_General principal1 = new Kardex_General();
                principal1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error al ingresar el usuario o la contraseña");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            usuario.Focus();
        }

        private void usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                contraseña.Focus();
            }
        }

        private void contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                button1.PerformClick();
            }

        }
    }
}
