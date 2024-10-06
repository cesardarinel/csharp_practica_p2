using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectosDiversos
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
            Conexion conectado = new Conexion();
            codigo.Text=conectado.ObtenerNextId("nomina", "cod_emp").ToString();
            codigo.Enabled = false;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eliminara el registro?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Conexion conectado = new Conexion();
                conectado.Eliminar("delete from nomina where cod_emp=" + codigo.Text + " ");
            }
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
            gridnomina.DataSource = actualizarnomina();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!this.validar(false))
            {
                return;
            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private DataTable actualizarnomina()
        {
            Conexion conectado = new Conexion();
            return conectado.ExecuteQuery("Select * from nomina");

        }
        private void Nomina_Load(object sender, EventArgs e)
        {
            gridnomina.DataSource = actualizarnomina();
        }
        private bool validar(bool completo) {
            // Suponiendo que este código está dentro de un método
            if (string.IsNullOrWhiteSpace(codigo.Text))
            {
                MessageBox.Show("El campo 'Código' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                codigo.Focus(); // Establece el foco en el campo 'codigo'
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

            if (string.IsNullOrWhiteSpace(sueldo.Text))
            {
                MessageBox.Show("El campo 'Sueldo' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sueldo.Focus(); // Establece el foco en el campo 'sueldo'
                return false;
            }
            if (completo)
            {
                if (string.IsNullOrWhiteSpace(afp.Text))
            {
                MessageBox.Show("El campo 'AFP' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                afp.Focus(); // Establece el foco en el campo 'afp'
                    return false;
                }

            if (string.IsNullOrWhiteSpace(ars.Text))
            {
                MessageBox.Show("El campo 'ARS' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ars.Focus(); // Establece el foco en el campo 'ars'
                    return false;
                }

            if (string.IsNullOrWhiteSpace(isr.Text))
            {
                MessageBox.Show("El campo 'ISR' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isr.Focus(); // Establece el foco en el campo 'isr'
                    return false;
                }

            if (string.IsNullOrWhiteSpace(totalDescuento.Text))
            {
                MessageBox.Show("El campo 'Total Descuento' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                totalDescuento.Focus(); // Establece el foco en el campo 'totalDescuento'
                    return false;
                }

            if (string.IsNullOrWhiteSpace(suendoNeto.Text))
            {
                MessageBox.Show("El campo 'Sueldo Neto' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                suendoNeto.Focus(); // Establece el foco en el campo 'suendoNeto'
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
            string insert = "insert into nomina(cod_emp,nom_emp,ape_emp,sue_bas,afp_emp,ars_emp,isr_emp,tde_emp,sue_net) " +
                " values(@cod_emp,@nom_emp,@ape_emp,@sue_bas,@afp_emp,@ars_emp,@isr_emp,@tde_emp,@sue_net) ";
            SqlParameter[] parametros = new SqlParameter[] {
                new SqlParameter("@cod_emp",codigo.Text),
                new SqlParameter("@nom_emp",nombre.Text),
                new SqlParameter("@ape_emp",apellido.Text),
                new SqlParameter("@sue_bas",sueldo.Text),
                new SqlParameter("@afp_emp",afp.Text),
                new SqlParameter("@ars_emp",ars.Text),
                new SqlParameter("@isr_emp",isr.Text),
                new SqlParameter("@tde_emp",totalDescuento.Text),
                new SqlParameter("@sue_net", suendoNeto.Text)
            };
            conectado.ExecuteNonQuery(insert, parametros);

            gridnomina.DataSource = actualizarnomina();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Conexion conectado = new Conexion();
            if (busqueda.Text.Trim().Equals(""))
            { gridnomina.DataSource = actualizarnomina(); }
            else { gridnomina.DataSource = conectado.ExecuteQuery("Select * from nomina where nom_emp like ('%" + busqueda.Text.Trim() + "%') "); }

        }

        private void codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                Conexion conectado = new Conexion();
                DataTable dt = conectado.ExecuteQuery("Select * from nomina where cod_emp =" + codigo.Text + " ");
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        codigo.Text = row["cod_emp"].ToString();
                        nombre.Text = row["nom_emp"].ToString();
                        apellido.Text = row["ape_emp"].ToString();
                        sueldo.Text = row["sue_bas"].ToString();
                        afp.Text = row["afp_emp"].ToString();
                        ars.Text = row["ars_emp"].ToString();
                        isr.Text = row["isr_emp"].ToString();
                        totalDescuento.Text = row["tde_emp"].ToString();
                        suendoNeto.Text = row["sue_net"].ToString();
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
            string update = "update  nomina set nom_emp=@nom_emp,ape_emp=@ape_emp" +
                ",sue_bas=@sue_bas,afp_emp=@afp_emp,ars_emp=@ars_emp,isr_emp=@isr_emp,tde_emp=@tde_emp," +
                "sue_net=@sue_net where cod_emp=@cod_emp ";
            SqlParameter[] parametros = new SqlParameter[] {
                new SqlParameter("@nom_emp",nombre.Text),
                new SqlParameter("@ape_emp",apellido.Text),
                new SqlParameter("@sue_bas",sueldo.Text),
                new SqlParameter("@afp_emp",afp.Text),
                new SqlParameter("@ars_emp",ars.Text),
                new SqlParameter("@isr_emp",isr.Text),
                new SqlParameter("@tde_emp",totalDescuento.Text),
                new SqlParameter("@sue_net", suendoNeto.Text),
                 new SqlParameter("@cod_emp",codigo.Text)
            };
            conectado.ExecuteNonQuery(update, parametros);
            MessageBox.Show("Los Datos fueron Actualizados");
            gridnomina.DataSource = actualizarnomina();
        }

        private void Nomina_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'p2DataSet.nomina' table. You can move, or remove it, as needed.
            //    this.nominaTableAdapter.Fill(this.p2DataSet.nomina);
            gridnomina.DataSource = actualizarnomina();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ReporteNomina reporte = new ReporteNomina();
            reporte.Show();
        }
    }
}
