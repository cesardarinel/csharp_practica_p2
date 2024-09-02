using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDiversos
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Nomina nota = new Nomina();
            nota.ShowDialog();
            this.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
            this.Hide();
            Notas nota = new Notas();
            nota.ShowDialog();
            this.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            Calculadora calcular = new Calculadora();
            calcular.ShowDialog();
            this.Show();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
