using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSoderia.BL
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal Precio { get; set; }
        public EstadoProducto Estado { get; set; }


        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
