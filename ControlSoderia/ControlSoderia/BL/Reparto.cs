using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSoderia.BL
{
    class Reparto
    {
        public int IdReparto { get; set; }
        public int NroReparto { get; set; }
        public Cliente idCliente { get; set; }
        public string Mes { get; set; }
        public string Sem1 { get; set; }
        public string Sem2 { get; set; }
        public string Sem3 { get; set; }
        public string Sem4 { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
