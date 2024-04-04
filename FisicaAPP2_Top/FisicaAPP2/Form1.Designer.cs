namespace FisicaAPP2
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
            menu = new MenuStrip();
            velocidadeMédiaToolStripMenuItem = new ToolStripMenuItem();
            aceleraçãoToolStripMenuItem = new ToolStripMenuItem();
            movimentoUniformeToolStripMenuItem = new ToolStripMenuItem();
            torricielliToolStripMenuItem = new ToolStripMenuItem();
            entrada_1_label = new Label();
            entrada_1_numericUpDown = new NumericUpDown();
            entrada_2_label = new Label();
            entrada_2_numericUpDown = new NumericUpDown();
            entrada_3_numericUpDown = new NumericUpDown();
            entrada_3_label = new Label();
            calcular_button = new Button();
            resultado_label = new Label();
            mostrar_resultado_label = new Label();
            useMenu_label = new Label();
            menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)entrada_1_numericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entrada_2_numericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)entrada_3_numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // menu
            // 
            menu.BackgroundImageLayout = ImageLayout.None;
            menu.ImeMode = ImeMode.Off;
            menu.Items.AddRange(new ToolStripItem[] { velocidadeMédiaToolStripMenuItem, aceleraçãoToolStripMenuItem, movimentoUniformeToolStripMenuItem, torricielliToolStripMenuItem });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(406, 24);
            menu.TabIndex = 0;
            menu.Text = "menu_formulas";
            // 
            // velocidadeMédiaToolStripMenuItem
            // 
            velocidadeMédiaToolStripMenuItem.Checked = true;
            velocidadeMédiaToolStripMenuItem.CheckState = CheckState.Checked;
            velocidadeMédiaToolStripMenuItem.Name = "velocidadeMédiaToolStripMenuItem";
            velocidadeMédiaToolStripMenuItem.Size = new Size(112, 20);
            velocidadeMédiaToolStripMenuItem.Tag = "";
            velocidadeMédiaToolStripMenuItem.Text = "Velocidade Média";
            velocidadeMédiaToolStripMenuItem.Click += velocidadeMédiaToolStripMenuItem_Click;
            // 
            // aceleraçãoToolStripMenuItem
            // 
            aceleraçãoToolStripMenuItem.Name = "aceleraçãoToolStripMenuItem";
            aceleraçãoToolStripMenuItem.Size = new Size(77, 20);
            aceleraçãoToolStripMenuItem.Text = "Aceleração";
            aceleraçãoToolStripMenuItem.Click += aceleraçãoToolStripMenuItem_Click;
            // 
            // movimentoUniformeToolStripMenuItem
            // 
            movimentoUniformeToolStripMenuItem.Name = "movimentoUniformeToolStripMenuItem";
            movimentoUniformeToolStripMenuItem.Size = new Size(134, 20);
            movimentoUniformeToolStripMenuItem.Text = "Movimento Uniforme";
            movimentoUniformeToolStripMenuItem.Click += movimentoUniformeToolStripMenuItem_Click;
            // 
            // torricielliToolStripMenuItem
            // 
            torricielliToolStripMenuItem.Name = "torricielliToolStripMenuItem";
            torricielliToolStripMenuItem.Size = new Size(66, 20);
            torricielliToolStripMenuItem.Text = "Torricielli";
            torricielliToolStripMenuItem.Click += torricielliToolStripMenuItem_Click;
            // 
            // entrada_1_label
            // 
            entrada_1_label.AutoSize = true;
            entrada_1_label.Location = new Point(12, 59);
            entrada_1_label.Name = "entrada_1_label";
            entrada_1_label.Size = new Size(59, 15);
            entrada_1_label.TabIndex = 1;
            entrada_1_label.Text = "Entrada 1:";
            // 
            // entrada_1_numericUpDown
            // 
            entrada_1_numericUpDown.DecimalPlaces = 2;
            entrada_1_numericUpDown.Location = new Point(150, 57);
            entrada_1_numericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            entrada_1_numericUpDown.Name = "entrada_1_numericUpDown";
            entrada_1_numericUpDown.Size = new Size(244, 23);
            entrada_1_numericUpDown.TabIndex = 2;
            entrada_1_numericUpDown.ValueChanged += entrada_1_numericUpDown_ValueChanged;
            // 
            // entrada_2_label
            // 
            entrada_2_label.AutoSize = true;
            entrada_2_label.Location = new Point(12, 116);
            entrada_2_label.Name = "entrada_2_label";
            entrada_2_label.Size = new Size(59, 15);
            entrada_2_label.TabIndex = 1;
            entrada_2_label.Text = "Entrada 2:";
            // 
            // entrada_2_numericUpDown
            // 
            entrada_2_numericUpDown.DecimalPlaces = 2;
            entrada_2_numericUpDown.Location = new Point(150, 114);
            entrada_2_numericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            entrada_2_numericUpDown.Name = "entrada_2_numericUpDown";
            entrada_2_numericUpDown.Size = new Size(244, 23);
            entrada_2_numericUpDown.TabIndex = 2;
            entrada_2_numericUpDown.ValueChanged += entrada_2_numericUpDown_ValueChanged;
            // 
            // entrada_3_numericUpDown
            // 
            entrada_3_numericUpDown.DecimalPlaces = 2;
            entrada_3_numericUpDown.Location = new Point(150, 169);
            entrada_3_numericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            entrada_3_numericUpDown.Name = "entrada_3_numericUpDown";
            entrada_3_numericUpDown.Size = new Size(244, 23);
            entrada_3_numericUpDown.TabIndex = 4;
            entrada_3_numericUpDown.ValueChanged += entrada_3_numericUpDown_ValueChanged;
            // 
            // entrada_3_label
            // 
            entrada_3_label.AutoSize = true;
            entrada_3_label.Location = new Point(12, 171);
            entrada_3_label.Name = "entrada_3_label";
            entrada_3_label.Size = new Size(59, 15);
            entrada_3_label.TabIndex = 3;
            entrada_3_label.Text = "Entrada 3:";
            // 
            // calcular_button
            // 
            calcular_button.Enabled = false;
            calcular_button.Location = new Point(39, 223);
            calcular_button.Name = "calcular_button";
            calcular_button.Size = new Size(329, 23);
            calcular_button.TabIndex = 5;
            calcular_button.Text = "Calcular";
            calcular_button.UseVisualStyleBackColor = true;
            calcular_button.Click += calcular_button_Click;
            // 
            // resultado_label
            // 
            resultado_label.AutoSize = true;
            resultado_label.Location = new Point(39, 274);
            resultado_label.Name = "resultado_label";
            resultado_label.Size = new Size(62, 15);
            resultado_label.TabIndex = 6;
            resultado_label.Text = "Resultado:";
            // 
            // mostrar_resultado_label
            // 
            mostrar_resultado_label.AutoSize = true;
            mostrar_resultado_label.Location = new Point(107, 274);
            mostrar_resultado_label.Name = "mostrar_resultado_label";
            mostrar_resultado_label.Size = new Size(134, 15);
            mostrar_resultado_label.TabIndex = 7;
            mostrar_resultado_label.Text = "(Mostrar resultado aqui)";
            mostrar_resultado_label.Visible = false;
            // 
            // useMenu_label
            // 
            useMenu_label.AutoSize = true;
            useMenu_label.Location = new Point(116, 39);
            useMenu_label.Name = "useMenu_label";
            useMenu_label.Size = new Size(173, 15);
            useMenu_label.TabIndex = 8;
            useMenu_label.Text = "Escolha uma equação no menu";
            useMenu_label.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 450);
            Controls.Add(useMenu_label);
            Controls.Add(mostrar_resultado_label);
            Controls.Add(resultado_label);
            Controls.Add(calcular_button);
            Controls.Add(entrada_3_numericUpDown);
            Controls.Add(entrada_3_label);
            Controls.Add(entrada_2_numericUpDown);
            Controls.Add(entrada_2_label);
            Controls.Add(entrada_1_numericUpDown);
            Controls.Add(entrada_1_label);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "Form1";
            Text = "FísicaAPP 2.0 - Top";
            Load += Form1_Load;
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)entrada_1_numericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)entrada_2_numericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)entrada_3_numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem velocidadeMédiaToolStripMenuItem;
        private ToolStripMenuItem aceleraçãoToolStripMenuItem;
        private ToolStripMenuItem movimentoUniformeToolStripMenuItem;
        private ToolStripMenuItem torricielliToolStripMenuItem;
        private Label entrada_1_label;
        private NumericUpDown entrada_1_numericUpDown;
        private Label entrada_2_label;
        private NumericUpDown entrada_2_numericUpDown;
        private NumericUpDown entrada_3_numericUpDown;
        private Label entrada_3_label;
        private Button calcular_button;
        private Label resultado_label;
        private Label mostrar_resultado_label;
        private Label useMenu_label;
    }
}
