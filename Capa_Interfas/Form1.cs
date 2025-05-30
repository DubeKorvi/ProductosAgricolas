using System;
using System.Windows.Forms;
using Capa_Negocios;
using System.Linq;

namespace Capa_Interfas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LogicaProductos logica = new LogicaProductos();
            var productos = logica.ObtenerProductos();

            // Creamos un listado que incluya también el costo de envío calculado
            var datos = productos.Select(p => new
            {
                p.Id,
                p.Nombre,
                p.Temporada,
                p.Tipo,
                p.Precio,
                p.Stock,
                CostoEnvio = p.CalcularCostoEnvio()
            }).ToList();

            dgvProductos.DataSource = datos;
        }
    }
}

