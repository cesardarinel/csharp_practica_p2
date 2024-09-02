namespace ProyectoDiversos
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
