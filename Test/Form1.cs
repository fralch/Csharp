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

            double peso = Double.Parse(inputPeso.Text);
            double altura = Double.Parse(inputAltura.Text);

            double imc = peso / (altura * altura);

            txtResultado.Text = "Tu indice de masa coporal es: " + imc;

            MessageBox.Show("el IMC es: "+imc); 
        }
    }
}