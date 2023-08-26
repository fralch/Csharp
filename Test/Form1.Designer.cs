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
            button1 = new Button();
            inputEdad = new TextBox();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.AutoSize = true;
            txtResultado.ForeColor = Color.CornflowerBlue;
            txtResultado.Location = new Point(347, 158);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(74, 15);
            txtResultado.TabIndex = 0;
            txtResultado.Text = "Hola Mundo";
            // 
            // button1
            // 
            button1.Location = new Point(347, 193);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Cambiar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // inputEdad
            // 
            inputEdad.Location = new Point(347, 115);
            inputEdad.Name = "inputEdad";
            inputEdad.Size = new Size(100, 23);
            inputEdad.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inputEdad);
            Controls.Add(button1);
            Controls.Add(txtResultado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtResultado;
        private Button button1;
        private TextBox inputEdad;
    }
}