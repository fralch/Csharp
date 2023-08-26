namespace Test
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
            txtResultado = new Label();
            btnCalcular = new Button();
            inputPeso = new TextBox();
            inputAltura = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.AutoSize = true;
            txtResultado.ForeColor = Color.CornflowerBlue;
            txtResultado.Location = new Point(242, 160);
            txtResultado.Name = "txtResultado";
            txtResultado.RightToLeft = RightToLeft.No;
            txtResultado.Size = new Size(0, 15);
            txtResultado.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(241, 117);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // inputPeso
            // 
            inputPeso.Location = new Point(232, 34);
            inputPeso.Name = "inputPeso";
            inputPeso.Size = new Size(100, 23);
            inputPeso.TabIndex = 2;
            // 
            // inputAltura
            // 
            inputAltura.Location = new Point(232, 74);
            inputAltura.Name = "inputAltura";
            inputAltura.Size = new Size(100, 23);
            inputAltura.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 39);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 4;
            label1.Text = "Peso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 82);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Altura";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 257);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inputAltura);
            Controls.Add(inputPeso);
            Controls.Add(btnCalcular);
            Controls.Add(txtResultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtResultado;
        private Button btnCalcular;
        private TextBox inputPeso;
        private TextBox inputAltura;
        private Label label1;
        private Label label2;
    }
}