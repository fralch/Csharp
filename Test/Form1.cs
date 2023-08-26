namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = 123;
            double decimales = 122.3;
            bool booleano = false;

            int edad = int.Parse(inputEdad.Text);
            if (edad >= 18)
            {
                txtResultado.Text = "Eres Mayor"+" de Edad";
            }
            else
            {
                txtResultado.Text = "Eres menor de edad"; 
            }
            



        }
    }
}