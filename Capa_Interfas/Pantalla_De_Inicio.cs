namespace Capa_Interfas
{
    public partial class Pantalla_De_Inicio : Form
    {
        public Pantalla_De_Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Catalogo_De_Los_Productos catPro = new Catalogo_De_Los_Productos();

            catPro.Show();

            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Seleccion_De_Producto SelPro = new Seleccion_De_Producto();

            SelPro.Show();

            // this.Hide();
        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
