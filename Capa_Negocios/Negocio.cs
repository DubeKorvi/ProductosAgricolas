using ConexionADatos;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace Capa_Negocios
{
    public abstract class Productos
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Temporada { get; set; }
        public string Tipo { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }

        public abstract decimal CalcularCostoEnvio();
        
 
    }

    public class Fruta : Productos
    {

        public override decimal CalcularCostoEnvio()
        {
            return Precio * 0.15m;
        } 
    }

    public class Grano : Productos
    {

        public override decimal CalcularCostoEnvio()
        {
            return Precio * 0.20m;
        }
    }

    public class Verdura : Productos
    {

        public override decimal CalcularCostoEnvio()
        {
            return Precio * 0.10m;
        }
    }


    public class LogicaProductos
    {
        // Este método conecta a la base de datos, lee los datos y los convierte en objetos
        public List<Productos> ObtenerProductos()
        {
            List<Productos> lista = new List<Productos>();
            Productos_Agri conexion = new Productos_Agri();

            using (SqlConnection conn = new SqlConnection(conexion.Conexion))
            {
                conn.Open();

                string query = "SELECT * FROM Producto";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string tipo = reader["Tipo"].ToString();
                    Productos producto;

                    // Dependiendo del tipo se crea la clase hija correcta
                    switch (tipo)
                    {
                        case "Fruta": producto = new Fruta(); break;
                        case "Grano": producto = new Grano(); break;
                        case "Verdura": producto = new Verdura(); break;
                        default: continue;
                    }

                    producto.Id = (int)reader["Id"];
                    producto.Nombre = reader["Nombre"].ToString();
                    producto.Temporada = reader["Temporada"].ToString();
                    producto.Tipo = tipo;
                    producto.Precio = (int)reader["Precio"];
                    producto.Stock = (int)reader["Stock"];

                    lista.Add(producto);
                }
            }

            return lista;
        }
    }

}
