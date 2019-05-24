using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSoderia.BL
{
    class Registro
    {
        public int IdRegistro { get; set; }
        public int numDia { get; set; }
        public int numMes { get; set; }
        public int año { get; set; }
        public Cliente idCliente { get; set; }
        public Producto idProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
        public decimal SaldoAnterior { get; set; }
    }
}
