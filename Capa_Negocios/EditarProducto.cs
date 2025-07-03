using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionADatos;
using Microsoft.Data.SqlClient;

namespace Capa_Negocios
{
    public class EditarProducto
    {

        public static bool Editar(Producto producto)
        {
            try
            {
                Productos_Agri conexion = new Productos_Agri();
                using (SqlConnection conn = new SqlConnection(conexion.Conexion))
                {
                    conn.Open();
                    string query = "UPDATE Producto SET Tipo = @Tipo, Temporada = @Temporada, Nombre = @Nombre, Cantidad = @Cantidad, Precio = @Precio WHERE Id = @Id";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Tipo", producto.Tipo);
                    cmd.Parameters.AddWithValue("@Temporada", producto.Temporada);
                    cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                    cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@Id", producto.Id);

                    int filas = cmd.ExecuteNonQuery();
                    return filas > 0;
                }
            }
            catch (Exception ex)
            {
              
                return false;
            }
        }

    }
}
