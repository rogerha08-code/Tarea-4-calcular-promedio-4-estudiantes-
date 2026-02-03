namespace Tareas_4
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
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            txtNota4 = new TextBox();
            txtCompletivo = new TextBox();
            txtResultado = new TextBox();
            btnCalcular = new Button();
            lblPromedio = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(33, 73);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(200, 39);
            txtNota1.TabIndex = 0;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(33, 165);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(200, 39);
            txtNota2.TabIndex = 1;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(535, 73);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(200, 39);
            txtNota3.TabIndex = 2;
            // 
            // txtNota4
            // 
            txtNota4.Location = new Point(535, 165);
            txtNota4.Name = "txtNota4";
            txtNota4.Size = new Size(200, 39);
            txtNota4.TabIndex = 3;
            // 
            // txtCompletivo
            // 
            txtCompletivo.Location = new Point(12, 386);
            txtCompletivo.Name = "txtCompletivo";
            txtCompletivo.Size = new Size(200, 39);
            txtCompletivo.TabIndex = 4;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(506, 399);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(282, 39);
            txtResultado.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(297, 247);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(150, 46);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(314, 200);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(117, 32);
            lblPromedio.TabIndex = 10;
            lblPromedio.Text = "Promedio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(600, 130);
            label4.Name = "label4";
            label4.Size = new Size(86, 32);
            label4.TabIndex = 11;
            label4.Text = "Nota 3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(610, 38);
            label5.Name = "label5";
            label5.Size = new Size(86, 32);
            label5.TabIndex = 12;
            label5.Text = "Nota 3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 25);
            label6.Name = "label6";
            label6.Size = new Size(86, 32);
            label6.TabIndex = 13;
            label6.Text = "Nota 1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(86, 130);
            label7.Name = "label7";
            label7.Size = new Size(86, 32);
            label7.TabIndex = 14;
            label7.Text = "Nota 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblPromedio);
            Controls.Add(btnCalcular);
            Controls.Add(txtResultado);
            Controls.Add(txtCompletivo);
            Controls.Add(txtNota4);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtNota4;
        private TextBox txtCompletivo;
        private TextBox txtResultado;
        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblPromedio;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
