namespace Estructuras_condicionales_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int edad=int.Parse( txtedad.Text);

            if (edad>=18 ) {

                lblda.Text = "Usted es mayor de edad";
            
            } else {
                lblda.Text = "Usted es menor de edad";
            
            }

        }
    }
}