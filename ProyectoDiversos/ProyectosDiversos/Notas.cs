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
            Conexion conectado = new Conexion();
            matricula.Text = conectado.ObtenerNextId("Calificacion", "mat_est").ToString();
            matricula.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Suponiendo que este código está dentro de un método
            if (!this.validar(false))
            {
                return;
            }
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
            if (MessageBox.Show("Eliminara el registro?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conexion conectado = new Conexion();
                conectado.Eliminar("delete from Calificacion where mat_est=" + matricula.Text + " ");
            }
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
            gridnotas.DataSource = actualizarnotas();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private DataTable actualizarnotas()
        {
            Conexion conectado = new Conexion();
            return conectado.ExecuteQuery("Select * from Calificacion");
        }

        private void Notas_Load(object sender, EventArgs e)
        {

            gridnotas.DataSource = actualizarnotas();

        }

        private bool validar(bool completo) {
            if (string.IsNullOrWhiteSpace(matricula.Text))
            {
                MessageBox.Show("El campo 'Matrícula' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                matricula.Focus(); // Establece el foco en el campo 'matricula'
                return false;
            }

            if (string.IsNullOrWhiteSpace(nombre.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nombre.Focus(); // Establece el foco en el campo 'nombre'
                return false;
            }

            if (string.IsNullOrWhiteSpace(apellido.Text))
            {
                MessageBox.Show("El campo 'Apellido' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                apellido.Focus(); // Establece el foco en el campo 'apellido'
                return false;
            }

            if (string.IsNullOrWhiteSpace(asignatura.Text))
            {
                MessageBox.Show("El campo 'Asignatura' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                asignatura.Focus(); // Establece el foco en el campo 'asignatura'
                return false;
            }

            if (string.IsNullOrWhiteSpace(poe.Text))
            {
                MessageBox.Show("El campo 'POE' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                poe.Focus(); // Establece el foco en el campo 'poe'
                return false;
            }

            if (string.IsNullOrWhiteSpace(pf.Text))
            {
                MessageBox.Show("El campo 'PF' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pf.Focus(); // Establece el foco en el campo 'pf'
                return false;
            }

            if (string.IsNullOrWhiteSpace(ap.Text))
            {
                MessageBox.Show("El campo 'AP' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ap.Focus(); // Establece el foco en el campo 'ap'
                return false;
            }

            if (string.IsNullOrWhiteSpace(va.Text))
            {
                MessageBox.Show("El campo 'VA' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                va.Focus(); // Establece el foco en el campo 'va'
                return false;
            }

            if (string.IsNullOrWhiteSpace(pef.Text))
            {
                MessageBox.Show("El campo 'PEF' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pef.Focus(); // Establece el foco en el campo 'pef'
                return false;
            }

            if (string.IsNullOrWhiteSpace(notaFinal.Text))
            {
                MessageBox.Show("El campo 'Nota Final' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                notaFinal.Focus(); // Establece el foco en el campo 'notaFinal'
                return false;
            }
            if (completo) { 
            if (string.IsNullOrWhiteSpace(notaLiteral.Text))
            {
                MessageBox.Show("El campo 'Nota Literal' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                notaLiteral.Focus(); // Establece el foco en el campo 'notaLiteral'
                return false;
            }

            if (string.IsNullOrWhiteSpace(condicion.Text))
            {
                MessageBox.Show("El campo 'Condición' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                condicion.Focus(); // Establece el foco en el campo 'condicion'
                return false;
            }
            }
            return true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!this.validar(true))
            {
                return;
            }
            Conexion conectado = new Conexion();
            string insert = "insert into Calificacion(mat_est,nom_est,ape_est,asi_est,poe,pf,ap,va,pef,nf,L,con) " +
                " values(@mat_est,@nom_est,@ape_est,@asi_est,@poe,@pf,@ap,@va,@pef,@nf,@L,@con) ";
            SqlParameter[] parametros = new SqlParameter[] {
                new SqlParameter("@mat_est",matricula.Text),
                new SqlParameter("@nom_est",nombre.Text),
                new SqlParameter("@ape_est",apellido.Text),
                new SqlParameter("@asi_est",asignatura.Text),
                new SqlParameter("@poe",poe.Text),
                new SqlParameter("@pf",pf.Text),
                new SqlParameter("@ap",ap.Text),
                new SqlParameter("@va",va.Text),
                new SqlParameter("@pef",pef.Text),
                new SqlParameter("@nf",notaFinal.Text),
                new SqlParameter("@L",notaLiteral.Text),
                new SqlParameter("@con", condicion.Text)
            };
            conectado.ExecuteNonQuery(insert, parametros);

            gridnotas.DataSource = actualizarnotas();
        }

        private void buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conexion conectado = new Conexion();
            if (buscar.Text.Trim().Equals(""))
            { gridnotas.DataSource = actualizarnotas(); }
            else { gridnotas.DataSource = conectado.ExecuteQuery("Select * from Calificacion where nom_est like ('%" + buscar.Text.Trim() + "%') "); }
        }

        private void matricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                Conexion conectado = new Conexion();
                DataTable dt = conectado.ExecuteQuery("Select * from Calificacion where mat_est= " + matricula.Text + " ");
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        matricula.Text = row["mat_est"].ToString();
                        nombre.Text = row["nom_est"].ToString();
                        apellido.Text = row["ape_est"].ToString();
                        asignatura.Text = row["asi_est"].ToString();
                        poe.Text = row["poe"].ToString();
                        pf.Text = row["pf"].ToString();
                        ap.Text = row["ap"].ToString();
                        va.Text = row["va"].ToString();
                        pef.Text = row["pef"].ToString();
                        notaFinal.Text = row["nf"].ToString();
                        notaLiteral.Text = row["L"].ToString();
                        condicion.Text = row["con"].ToString();
                    }
                }
                else
                {
                    nombre.Text = "No encontrado";
                }
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Conexion conectado = new Conexion();
            string update = "update Calificacion set nom_est=@nom_est,ape_est=@ape_est,asi_est=@asi_est," +
                "poe=@poe,pf=@pf,ap=@ap,va=@va,pef=@pef,nf=@nf,L=@L,con=@con where mat_est=@mat_est  ";
            SqlParameter[] parametros = new SqlParameter[] {
                new SqlParameter("@nom_est",nombre.Text),
                new SqlParameter("@ape_est",apellido.Text),
                new SqlParameter("@asi_est",asignatura.Text),
                new SqlParameter("@poe",poe.Text),
                new SqlParameter("@pf",pf.Text),
                new SqlParameter("@ap",ap.Text),
                new SqlParameter("@va",va.Text),
                new SqlParameter("@pef",pef.Text),
                new SqlParameter("@nf",notaFinal.Text),
                new SqlParameter("@L",notaLiteral.Text),
                new SqlParameter("@con", condicion.Text),
                 new SqlParameter("@mat_est",matricula.Text)
            };
            conectado.ExecuteNonQuery(update, parametros);
            MessageBox.Show("Los Datos fueron Actualizados");
            gridnotas.DataSource = actualizarnotas();

        }

        private void Notas_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'p2DataSet.Calificacion' table. You can move, or remove it, as needed.
            gridnotas.DataSource = actualizarnotas();

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ReporteNotas reporte = new ReporteNotas();
            reporte.Show();
        }
    }
}
