namespace FisicaApp2._0___Simples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void velocidadeMedia_button_Click(object sender, EventArgs e)
        {
            entrada1_label.Visible = true;
            entrada1_NumericUpDown.Visible = true;
            entrada2_label.Visible = true;
            entrada2_NumericUpDown.Visible = true;
            resultado_label.Visible = true;

            double resultado = Convert.ToDouble(entrada1_NumericUpDown.Value / entrada2_NumericUpDown.Value);
            mostrarResultado_label.Text = (resultado.ToString() + " km/h");
            mostrarResultado_label.Visible = true;
        }

        private void aceleracao_button_Click(object sender, EventArgs e)
        {
            double resultado = Convert.ToDouble((entrada2_NumericUpDown.Value - entrada1_NumericUpDown.Value) / entrada3_NumericUpDown.Value);
            mostrarResultado_label.Text = (resultado.ToString() + " m/s^2");
            mostrarResultado_label.Visible = true;
        }

        private void movimentoUniforme_button_Click(object sender, EventArgs e)
        {
            double resultado = Convert.ToDouble(entrada1_NumericUpDown.Value + (2 * entrada2_NumericUpDown.Value * entrada3_NumericUpDown.Value));
            mostrarResultado_label.Text = (resultado.ToString() + " m");
            mostrarResultado_label.Visible = true;
        }

        private void torricelli_button_Click(object sender, EventArgs e)
        {
            double resultado = Convert.ToDouble((entrada1_NumericUpDown.Value * entrada1_NumericUpDown.Value) + (entrada2_NumericUpDown.Value * entrada3_NumericUpDown.Value));
            Math.Sqrt(resultado);
            mostrarResultado_label.Text = (resultado.ToString() + " m/s");
            mostrarResultado_label.Visible = true;
        }

        private void entrada1_NumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
