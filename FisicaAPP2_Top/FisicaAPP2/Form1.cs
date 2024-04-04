namespace FisicaAPP2

{
    public partial class Form1 : Form
    {
        string escolha;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            entrada_1_label.Visible = false;
            entrada_1_numericUpDown.Visible = false;
            entrada_2_label.Visible = false;
            entrada_2_numericUpDown.Visible = false;
            entrada_3_label.Visible = false;
            entrada_3_numericUpDown.Visible = false;
            calcular_button.Visible = false;
            resultado_label.Visible = false;
            useMenu_label.Visible = true;

        }

        private void velocidadeMédiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entrada_1_label.Visible = true;
            entrada_1_numericUpDown.Visible = true;
            entrada_2_label.Visible = true;
            entrada_2_numericUpDown.Visible = true;
            entrada_3_label.Visible = false;
            entrada_3_numericUpDown.Visible = false;
            calcular_button.Visible = true;
            resultado_label.Visible = true;
            useMenu_label.Visible = false;

            entrada_1_label.Text = "Espaço (km):";
            entrada_2_label.Text = "Tempo (h):";
            escolha = "velocidadeMedia";
        }

        private void aceleraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entrada_1_label.Visible = true;
            entrada_1_numericUpDown.Visible = true;
            entrada_2_label.Visible = true;
            entrada_2_numericUpDown.Visible = true;
            entrada_3_label.Visible = true;
            entrada_3_numericUpDown.Visible = true;
            calcular_button.Visible = true;
            resultado_label.Visible = true;
            useMenu_label.Visible = false;

            entrada_1_label.Text = "Velocidade inicial (m/s)";
            entrada_2_label.Text = "Velocidade final (m/s)";
            entrada_3_label.Text = "Tempo (s)";
            escolha = "aceleração";
        }

        private void movimentoUniformeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entrada_1_label.Visible = true;
            entrada_1_numericUpDown.Visible = true;
            entrada_2_label.Visible = true;
            entrada_2_numericUpDown.Visible = true;
            entrada_3_label.Visible = true;
            entrada_3_numericUpDown.Visible = true;
            calcular_button.Visible = true;
            resultado_label.Visible = true;
            useMenu_label.Visible = false;

            entrada_1_label.Text = "Posição inicial (m)";
            entrada_2_label.Text = "Velocidade (m/s)";
            entrada_3_label.Text = "Tempo (s)";
            escolha = "movimentoUniforme";
        }

        private void torricielliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            entrada_1_label.Visible = true;
            entrada_1_numericUpDown.Visible = true;
            entrada_2_label.Visible = true;
            entrada_2_numericUpDown.Visible = true;
            entrada_3_label.Visible = true;
            entrada_3_numericUpDown.Visible = true;
            calcular_button.Visible = true;
            resultado_label.Visible = true;
            useMenu_label.Visible = false;

            entrada_1_label.Text = "Velocidade inical (m/s)";
            entrada_2_label.Text = "Aceleração";
            entrada_3_label.Text = "Espaço percorrido (m)";
            escolha = "tori";
        }
        private void calcular_button_Click(object sender, EventArgs e)
        {

            if (escolha == "velocidadeMedia")
            {
                double resultado = Convert.ToDouble(entrada_1_numericUpDown.Value / entrada_2_numericUpDown.Value);
                mostrar_resultado_label.Text = (resultado.ToString() + " km/h");
                mostrar_resultado_label.Visible = true;

            }
            else if (escolha == "aceleração")
            {
                double resultado = Convert.ToDouble((entrada_2_numericUpDown.Value - entrada_1_numericUpDown.Value) / entrada_3_numericUpDown.Value);
                mostrar_resultado_label.Text = (resultado.ToString() + " m/s^2");
                mostrar_resultado_label.Visible = true;
            }
            else if (escolha == "movimentoUniforme")
            {
                double resultado = Convert.ToDouble(entrada_1_numericUpDown.Value + (2* entrada_2_numericUpDown.Value * entrada_3_numericUpDown.Value));
                mostrar_resultado_label.Text = (resultado.ToString() + " m");
                mostrar_resultado_label.Visible = true;
            }
            else if (escolha == "tori")
            {
                double resultado = Convert.ToDouble((entrada_1_numericUpDown.Value* entrada_1_numericUpDown.Value) + (entrada_2_numericUpDown.Value * entrada_3_numericUpDown.Value));
                Math.Sqrt(resultado);
                mostrar_resultado_label.Text = (resultado.ToString() + " m/s");
                mostrar_resultado_label.Visible = true;
            }
        }

        private void entrada_1_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (entrada_1_numericUpDown.Value == 0)
                calcular_button.Enabled = false;
            else
                calcular_button.Enabled = true;
        }

        private void entrada_2_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (entrada_2_numericUpDown.Value == 0)
                calcular_button.Enabled = false;
            else
                calcular_button.Enabled = true;

        }

        private void entrada_3_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (entrada_3_numericUpDown.Value == 0)
                calcular_button.Enabled = false;
            else
                calcular_button.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
