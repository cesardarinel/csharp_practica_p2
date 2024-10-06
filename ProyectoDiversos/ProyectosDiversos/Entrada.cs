using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectosDiversos
{
    public partial class Entrada : Form
    {
        public Entrada()
        {
            InitializeComponent();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            Conexion conexion = new Conexion();
            if (conexion.ValidarCredenciales(usuario.Text, contrasena.Text))
            {
                MessageBox.Show("Bienvenido al Sistema");
                this.Hide();
                Menu menu = new Menu();
                menu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
