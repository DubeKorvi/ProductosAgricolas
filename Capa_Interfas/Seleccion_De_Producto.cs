

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
    public partial class Seleccion_De_Producto : Form
    {
        private int? indiceEditar = null;
        private string idProducto=null;
        //private bool Editar = false;
        public Seleccion_De_Producto()
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
            producto.Precio = decimal.Parse(txbPrecio.Text);



            int precio;

            if (!int.TryParse(txbPrecio.Text, out precio))
            {

                MessageBox.Show("El Precioso Digitado no es uno valido, digite un precio Real.");
                return;
            }
            producto.Precio = precio;


            // Si estamos en modo edición, actualizamos el producto existente
            if (indiceEditar != null)
            {
                // Modo edición: actualiza la fila en el DataGridView
                DataGridViewRow fila = dgvResumen.Rows[indiceEditar.Value];
                fila.Cells["Tipo"].Value = producto.Tipo;
                fila.Cells["Temporada"].Value = producto.Temporada;
                fila.Cells["Nombre"].Value = producto.Nombre;
                fila.Cells["Cantidad"].Value = producto.Cantidad;
                fila.Cells["Precio"].Value = producto.Precio;

                indiceEditar = null; // Resetea
                MessageBox.Show("Producto editado correctamente.");
            }
            else
            {

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
            

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (indiceEditar != null)
            {
                DataGridViewRow fila = dgvResumen.Rows[indiceEditar.Value];

                idProducto = fila.Cells["Id"].Value.ToString(); // Asegúrate de tener el Id  

                Producto producto = new Producto
                {
                    Tipo = fila.Cells["Tipo"].Value.ToString(),
                    Temporada = fila.Cells["Temporada"].Value.ToString(),
                    Nombre = fila.Cells["Nombre"].Value.ToString(),
                    Cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value),
                    Precio = Convert.ToDecimal(fila.Cells["Precio"].Value)
                };

                bool editado = EditarProducto.Editar(producto);

                if (editado)
                {
                    MessageBox.Show("Producto editado correctamente.");
                    MostrarPedidos(); // refresca el DataGridView  
                }
                else
                {
                    MessageBox.Show("No se pudo editar el producto en la base de datos.");
                }

                indiceEditar = null; // Resetea  
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvResumen.SelectedRows.Count > 0)
            {
                idProducto = dgvResumen.CurrentRow.Cells["Id"].Value.ToString();
                int id = Convert.ToInt32(idProducto);
                if (EliminarProducto.Eliminar(id))
                {
                    MessageBox.Show("Producto eliminado correctamente.");
                    MostrarPedidos();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el producto.");
                }
            }
            
        }


       
    }


}