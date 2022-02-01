using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abasto.Data
{

    public class Articulo
    {
        public int NumProducion { get; set; }
        public int IdArticulo { get; set; }
        public int cantProducion { get; set; }
        public string comentario { get; set; }
    }

    public class Pedido {
        public string NumPedido { get; set; }
        public string Estado { get; set; }
        public string FechaPedido { get; set; }
        public string Representante { get; set; }
        public string Cliente { get; set; }
        public string Area { get; set; }
        public string Trabajador { get; set; }
        public string CargoTrabajador { get; set; }
        public string Reporte { get; set; }
    }

    public class DetallePedido {
        public int NumPedido { get; set; }
        public string IdProducto { get; set; }
        public int IdAbastecedor { get; set; }
    }

    public class Insumo{
        public int NumPedido { get; set; }
        public string IdProducto { get; set; }
        public string IdInsumo { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public Double Precio { get; set; }

    }
}
