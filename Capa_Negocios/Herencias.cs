using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
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
}
