using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectosDiversos
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            primerValor.Text = "";
            segundoValor.Text = " ";
            resultado.Text = " ";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Decimal  prim, segun;
            prim = decimal.Parse(primerValor.Text);
            segun = decimal.Parse(segundoValor.Text);
            resultado.Text= (prim+segun).ToString();
        }
    }
}
