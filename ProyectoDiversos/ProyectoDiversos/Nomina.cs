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
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Decimal nafp, nars, nisr, nsueldo, tdescuento;
            nsueldo = Decimal.Parse(sueldo.Text);
            nafp = nsueldo * 0.0287m;
            nars = nsueldo * 0.0291m;

            if (nsueldo > 33384)
            {
                nisr = (nsueldo - 33384) * 0.15m;
            }
            else { nisr = 0; }
            tdescuento = nafp + nars + nisr;
            suendoNeto.Text = (nsueldo - tdescuento).ToString();
            afp.Text = nafp.ToString();
            ars.Text = nars.ToString();
            isr.Text = nisr.ToString();
            totalDescuento.Text = tdescuento.ToString();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
