using ConexionADatos;

namespace Capa_Negocios
{
    public abstract class Productos
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Temporada { get; set; }
        public string Tipo { get; set; }
        public int precio { get; set; }
        public int Stock { get; set; }

        public abstract decimal CalcularCostoEnvio();
        
 
    }

    public class Fruta : Productos
    {

        public override decimal CalcularCostoEnvio()
        {
            return precio * 0.15m;
        } 
    }

    public class Grano : Productos
    {

        public override decimal CalcularCostoEnvio()
        {
            return precio * 0.20m;
        }
    }

    public class Verdura : Productos
    {

        public override decimal CalcularCostoEnvio()
        {
            return precio * 0.10m;
        }
    }
}
