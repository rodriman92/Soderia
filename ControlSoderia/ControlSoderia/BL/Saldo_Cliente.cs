using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSoderia.BL
{
    class Saldo_Cliente
    {
        public int IdSaldo { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public Cliente idCliente { get; set; }
        public decimal SaldoMes { get; set; }
    }
}
