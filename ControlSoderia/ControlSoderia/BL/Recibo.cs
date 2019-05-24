using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSoderia.BL
{
    class Recibo
    {
        public int IdRecibo { get; set; }
        public decimal dia { get; set; }
        public decimal mes { get; set; }
        public int año { get; set; }
        public Cliente cliente { get; set; }
        public Producto producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioU { get; set; }
        public decimal Importe { get; set; }
        public decimal SaldoA { get; set; }
        public decimal Entrada { get; set; }
        public decimal Salida { get; set; }
    }
}
