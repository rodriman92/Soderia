using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSoderia.BL
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string ApeNombre { get; set; }
        public string CUIT { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Localidad { get; set; }
        public string ConsumoHabitual { get; set; }
        public int NroReparto { get; set; }


        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
