

using System;
using System.Windows.Forms;
using Capa_Negocios;
using System.Linq;
using ConexionADatos;
using Microsoft.Data.SqlClient;
using System.Data;

//Entrega Final 3.0
namespace Capa_Interfas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MostrarPedidos();
            this.Load += Form1_Load;
        }

        //TODO Aqui empezamos a definir cada cmb, agregando los items, queria que esto se hiciera 
        //desde la base de datos, que se llamara todo desde la misma pero estuvo cabron.
        private void Form1_Load(object sender, EventArgs e)
        {
            
            cmbTipo.Items.Add("Verdura");
            cmbTipo.Items.Add("Grano");
            cmbTipo.Items.Add("Fruta");
            cmbTipo.SelectedIndex = 0;

            cmbTemporada.Items.Add("Verano");
            cmbTemporada.Items.Add("Otono");
            cmbTemporada.Items.Add("Invierno");
            cmbTemporada.Items.Add("Primavera");
            cmbTemporada.SelectedIndex = 0;

            cmbProduc.Items.Add("Zanahoria");
            cmbProduc.Items.Add("Espinaca");
            cmbProduc.Items.Add("Trigo");
            cmbProduc.Items.Add("Maiz");
            cmbProduc.Items.Add("Manzna");
            cmbProduc.Items.Add("Mango");
            cmbProduc.SelectedIndex = 0;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //TODO aqui se mostrara los pedidos en el datagiview y se crea una nueva tabla
        private void MostrarPedidos()
        {
            Productos_Agri conexion = new Productos_Agri();

            using (SqlConnection conn = new SqlConnection(conexion.Conexion))
            {


                conn.Open();

                SqlDataAdapter adpt = new SqlDataAdapter("SELECT * FROM Producto", conn);
                DataTable dataTable = new DataTable();
                adpt.Fill(dataTable);

                dgvResumen.DataSource = dataTable;



                conn.Close();

            }


        }

        //TODO Este es el boton de agregar lo seleciono a la base de datos 
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();


            producto.Tipo = cmbTipo.SelectedItem.ToString();
            producto.Temporada = cmbTemporada.Text;
            producto.Nombre = cmbProduc.Text;
            producto.Cantidad = int.Parse(numericUpDown1.Text);
            //producto.Precio = decimal.Parse(txbPrecio.Text);


            int precio;

            if (!int.TryParse(txbPrecio.Text, out precio))
            {

                MessageBox.Show("El Precioso Digitado no es uno valido, digite un precio Real.");
                return;
            }
            producto.Precio = precio;


            int A = Logicaproducto.GuardarPedido(producto);
            if (A > 0)
            {
                MessageBox.Show("To' eto' Sirve");
            }
            else
            {
                MessageBox.Show("To' eto' no Sirve");
            }
            MostrarPedidos();

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    
}