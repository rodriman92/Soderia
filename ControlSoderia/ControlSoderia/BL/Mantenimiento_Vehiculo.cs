using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSoderia.BL
{
    public class Mantenimiento_Vehiculo
    {
        public int IdMatenimiento { get; set; }
        public string DescripcionVehiculo { get; set; }
        public string Dominio { get; set; }
        public DateTime FechaMantenimiento { get; set; }
        public string DetalleMantenimiento { get; set; }
        public string Observaciones { get; set; }
        public DateTime FechaProxMantenimiento { get; set; }


        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
