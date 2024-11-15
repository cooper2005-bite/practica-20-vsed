namespace practica__20_vsed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeterminarCategoria_Click(object sender, EventArgs e)
        {
            // Convertir el texto del TextBox en un n�mero
            int edad;
            bool esNumero = int.TryParse(txtEdad.Text, out edad);

            if (!esNumero || edad < 0)
            {
                MessageBox.Show("Por favor, ingrese una edad v�lida.");
                return;
            }

            // Determinar la categor�a en funci�n de la edad
            string categoria;

            if (edad <= 12)
            {
                categoria = "Ni�o";
            }
            else if (edad <= 17)
            {
                categoria = "Adolescente";
            }
            else if (edad <= 60)
            {
                categoria = "Adulto";
            }
            else
            {
                categoria = "Adulto Mayor (Tercera Edad)";
            }

            // Mostrar la categor�a en el Label de resultado
            lblResultado.Text = "Categor�a: " + categoria;
        }
    }
}
