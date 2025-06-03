

using System;
using System.Windows.Forms;
using Capa_Negocios;
using System.Linq;
using ConexionADatos;
using Microsoft.Data.SqlClient;
using System.Data;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            /*LogicaProductos logica = new LogicaProductos();
            var productos = logica.ObtenerProductos();*/

            // Creamos un listado que incluya también el costo de envío calculado
            cmbTipo.Items.Add("Verdura");
            cmbTipo.Items.Add("Grano");
            cmbTipo.Items.Add("Fruta");
            cmbTipo.SelectedIndex = 0;

            cmbTemporada.Items.Add("Verano");
            cmbTemporada.Items.Add("Otono");
            cmbTemporada.Items.Add("Invierno");
            cmbTemporada.Items.Add("Primavera");

            cmbProduc.Items.Add("Zanahoria");
            cmbProduc.Items.Add("Espinaca");
            cmbProduc.Items.Add("Trigo");
            cmbProduc.Items.Add("Maiz");
            cmbProduc.Items.Add("Manzna");
            cmbProduc.Items.Add("Mango");



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            
            producto.Tipo = cmbTipo.SelectedItem.ToString();
            producto.Temporada = cmbTemporada.Text;
            producto.Nombre = cmbProduc.Text;
            producto.Cantidad = int.Parse(numericUpDown1.Text);
            producto.Precio = decimal.Parse(txbPrecio.Text);

            int A = Logicaproducto.GuardarPedido(producto);
            if(A > 0)
            {
                MessageBox.Show("To' eto' Sirve");
            }
            else
            {
                MessageBox.Show("To' eto' no Sirve");
            }
            MostrarPedidos();

           
        }
    }
}