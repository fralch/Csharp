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


            MessageBox.Show("el IMC es: " + imc);

        }

        // funciones que devuelven algo 

        private List<int> devolverLista()
        {
            // Arreglos 
            // int[] otra_lista = new int[] {2, 3, 4};

            List<int> lista = new List<int>();
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            return lista;
        }

        private void mostrarListado(List<int> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                int num = lista[i];
                MessageBox.Show("el numero es: " + num);
                


            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            List<int> lista = devolverLista();
            mostrarListado(lista);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            select.Items.Add("Pantalon");
            select.Items.Add("Camisa");
            select.Items.Add("Zapatos");
        }

        private void agregarTextArea_Click(object sender, EventArgs e)
        {
            string objeto = select.SelectedItem.ToString();

            textArea.Items.Add(objeto); 
        }
    }
}