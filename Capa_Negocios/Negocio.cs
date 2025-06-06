﻿using ConexionADatos;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

//Entrega Final 3.0
namespace Capa_Negocios
{
    //Todo Classe Principal 
    public class Producto
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Temporada { get; set; }
        public virtual string Tipo { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad {  get; set; }
        public decimal Total => Precio * Cantidad;

        //TODO Costo de envio y su metodo
        public decimal CostoDeEnvio => CostoEn();
        
        public decimal CostoEn()
        {
             decimal CostoE = Total * 0.15m;

            return CostoE;
        }

       
 
    }

      
      //TODO herencia en cada de cada hija
    public class Fruta : Producto
    {
        public override string Tipo => "Fruta";
        
      
    }

    public class Grano : Producto
    {
        public override string Tipo => "Grano";

    }

    public class Verdura : Producto
    {

        public override string Tipo => "Verdura";
    }

    //TODO Aqui esta el metodo para Guardar los pedidos, Estableciendo conexion con la Base de datos 
    public class Logicaproducto 
    {
        public static int GuardarPedido(Producto producto)
        {
            int retorno = 0;
            Productos_Agri conexion = new Productos_Agri();
            using (SqlConnection conn = new SqlConnection(conexion.Conexion))
            {
                conn.Open();
                string query = "INSERT INTO Producto (Nombre, Temporada, Tipo, Precio, Cantidad, Total, CostoDeEnvio) " +
                               "VALUES (@nombre, @Temporada, @Tipo, @Precio, @Cantidad, @Total, @CostoDeEnvio)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                cmd.Parameters.AddWithValue("@Temporada", producto.Temporada);
                cmd.Parameters.AddWithValue("@Tipo", producto.Tipo);
                cmd.Parameters.AddWithValue("@Precio",  producto.Precio);
                cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                cmd.Parameters.AddWithValue("@Total", producto.Total);
                cmd.Parameters.AddWithValue("@CostoDeEnvio", producto.CostoDeEnvio);
                
                retorno = cmd.ExecuteNonQuery();

                
            }

            return retorno;
        }

        

    }

}
