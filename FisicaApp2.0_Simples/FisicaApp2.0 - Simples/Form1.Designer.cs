namespace FisicaApp2._0___Simples
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            entrada1_label = new Label();
            entrada2_label = new Label();
            entrada3_label = new Label();
            entrada1_NumericUpDown = new NumericUpDown();
            entrada2_NumericUpDown = new NumericUpDown();
            entrada3_NumericUpDown = new NumericUpDown();
            resultado_label = new Label();
            mostrarResultado_label = new Label();
            velocidadeMedia_button = new Button();
            aceleracao_button = new Button();
            movimentoUniforme_button = new Button();
            torricelli_button = new Button();
            ((System.ComponentModel.ISupportInitialize)entrada1_NumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entrada2_NumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entrada3_NumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // entrada1_label
            // 
            entrada1_label.AutoSize = true;
            entrada1_label.Location = new Point(44, 32);
            entrada1_label.Name = "entrada1_label";
            entrada1_label.Size = new Size(59, 15);
            entrada1_label.TabIndex = 0;
            entrada1_label.Text = "Entrada 1:";
            // 
            // entrada2_label
            // 
            entrada2_label.AutoSize = true;
            entrada2_label.Location = new Point(44, 73);
            entrada2_label.Name = "entrada2_label";
            entrada2_label.Size = new Size(59, 15);
            entrada2_label.TabIndex = 1;
            entrada2_label.Text = "Entrada 2:";
            // 
            // entrada3_label
            // 
            entrada3_label.AutoSize = true;
            entrada3_label.Location = new Point(44, 113);
            entrada3_label.Name = "entrada3_label";
            entrada3_label.Size = new Size(59, 15);
            entrada3_label.TabIndex = 2;
            entrada3_label.Text = "Entrada 3:";
            entrada3_label.Click += label3_Click;
            // 
            // entrada1_NumericUpDown
            // 
            entrada1_NumericUpDown.Location = new Point(121, 30);
            entrada1_NumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            entrada1_NumericUpDown.Name = "entrada1_NumericUpDown";
            entrada1_NumericUpDown.Size = new Size(187, 23);
            entrada1_NumericUpDown.TabIndex = 3;
            entrada1_NumericUpDown.ValueChanged += entrada1_NumericUpDown_ValueChanged;
            // 
            // entrada2_NumericUpDown
            // 
            entrada2_NumericUpDown.Location = new Point(121, 71);
            entrada2_NumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            entrada2_NumericUpDown.Name = "entrada2_NumericUpDown";
            entrada2_NumericUpDown.Size = new Size(187, 23);
            entrada2_NumericUpDown.TabIndex = 4;
            // 
            // entrada3_NumericUpDown
            // 
            entrada3_NumericUpDown.Location = new Point(121, 113);
            entrada3_NumericUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            entrada3_NumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            entrada3_NumericUpDown.Name = "entrada3_NumericUpDown";
            entrada3_NumericUpDown.Size = new Size(187, 23);
            entrada3_NumericUpDown.TabIndex = 5;
            entrada3_NumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // resultado_label
            // 
            resultado_label.AutoSize = true;
            resultado_label.Location = new Point(44, 225);
            resultado_label.Name = "resultado_label";
            resultado_label.Size = new Size(62, 15);
            resultado_label.TabIndex = 6;
            resultado_label.Text = "Resultado:";
            // 
            // mostrarResultado_label
            // 
            mostrarResultado_label.AutoSize = true;
            mostrarResultado_label.Location = new Point(121, 225);
            mostrarResultado_label.Name = "mostrarResultado_label";
            mostrarResultado_label.Size = new Size(0, 15);
            mostrarResultado_label.TabIndex = 7;
            // 
            // velocidadeMedia_button
            // 
            velocidadeMedia_button.Location = new Point(44, 157);
            velocidadeMedia_button.Name = "velocidadeMedia_button";
            velocidadeMedia_button.Size = new Size(88, 51);
            velocidadeMedia_button.TabIndex = 8;
            velocidadeMedia_button.Text = "Velocidade Média";
            velocidadeMedia_button.UseVisualStyleBackColor = true;
            velocidadeMedia_button.Click += velocidadeMedia_button_Click;
            // 
            // aceleracao_button
            // 
            aceleracao_button.Location = new Point(138, 157);
            aceleracao_button.Name = "aceleracao_button";
            aceleracao_button.Size = new Size(106, 51);
            aceleracao_button.TabIndex = 9;
            aceleracao_button.Text = "Aceleração";
            aceleracao_button.UseVisualStyleBackColor = true;
            aceleracao_button.Click += aceleracao_button_Click;
            // 
            // movimentoUniforme_button
            // 
            movimentoUniforme_button.Location = new Point(250, 157);
            movimentoUniforme_button.Name = "movimentoUniforme_button";
            movimentoUniforme_button.Size = new Size(94, 51);
            movimentoUniforme_button.TabIndex = 10;
            movimentoUniforme_button.Text = "Movimento Uniforme";
            movimentoUniforme_button.UseVisualStyleBackColor = true;
            movimentoUniforme_button.Click += movimentoUniforme_button_Click;
            // 
            // torricelli_button
            // 
            torricelli_button.Location = new Point(350, 157);
            torricelli_button.Name = "torricelli_button";
            torricelli_button.Size = new Size(111, 51);
            torricelli_button.TabIndex = 11;
            torricelli_button.Text = "Torricelli";
            torricelli_button.UseVisualStyleBackColor = true;
            torricelli_button.Click += torricelli_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 450);
            Controls.Add(torricelli_button);
            Controls.Add(movimentoUniforme_button);
            Controls.Add(aceleracao_button);
            Controls.Add(velocidadeMedia_button);
            Controls.Add(mostrarResultado_label);
            Controls.Add(resultado_label);
            Controls.Add(entrada3_NumericUpDown);
            Controls.Add(entrada2_NumericUpDown);
            Controls.Add(entrada1_NumericUpDown);
            Controls.Add(entrada3_label);
            Controls.Add(entrada2_label);
            Controls.Add(entrada1_label);
            Name = "Form1";
            Text = "Fisica App 2.0 - Básico";
            ((System.ComponentModel.ISupportInitialize)entrada1_NumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)entrada2_NumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)entrada3_NumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label entrada1_label;
        private Label entrada2_label;
        private Label entrada3_label;
        private NumericUpDown entrada1_NumericUpDown;
        private NumericUpDown entrada2_NumericUpDown;
        private NumericUpDown entrada3_NumericUpDown;
        private Label resultado_label;
        private Label mostrarResultado_label;
        private Button velocidadeMedia_button;
        private Button aceleracao_button;
        private Button movimentoUniforme_button;
        private Button torricelli_button;
    }
}
