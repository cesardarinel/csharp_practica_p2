using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDiversos
{
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            int notaf, npoe, npf, nap, nva, npef;
            npoe = int.Parse(poe.Text);
            npf = int.Parse(pf.Text);
            nap = int.Parse(ap.Text);
            nva = int.Parse(va.Text);
            npef = int.Parse(pef.Text);
            notaf = npoe + npf + nap + nva + npef;
            if (notaf >= 90)
            {
                notaFinal.Text = notaf.ToString();
                notaLiteral.Text = "A";
                condicion.Text = " Aprobado";
            }
            else if (notaf >= 80)
            {
                notaFinal.Text = notaf.ToString();
                notaLiteral.Text = "B";
                condicion.Text = " Aprobado";
            }
            else if (notaf >= 70)
            {
                notaFinal.Text = notaf.ToString();
                notaLiteral.Text = "C";
                condicion.Text = " Aprobado";
            }
            else if (notaf <= 60)
            {
                notaFinal.Text = notaf.ToString();
                notaLiteral.Text = "F";
                condicion.Text = " Reprobado";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
        }
    }
}
