using ControlSoderia.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSoderia.GUI
{


    public partial class frmMantenimiento_VechiulosAE : Form
    {
        Mantenimiento_Vehiculo mantenimiento;
        public frmMantenimiento_VechiulosAE()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (mantenimiento==null)
                {
                    mantenimiento = new Mantenimiento_Vehiculo();
                }
                mantenimiento.DescripcionVehiculo = txtDescripcion.Text;
                mantenimiento.Dominio = txtDominio.Text;
                mantenimiento.FechaMantenimiento = dtpFechaMantenimiento.Value;
                mantenimiento.DetalleMantenimiento = txtDetalle.Text;
                mantenimiento.Observaciones = txtObservaciones.Text;
                mantenimiento.FechaProxMantenimiento = dateTimePicker1.Value;


                this.DialogResult = DialogResult.OK;
            }
        }

        internal Mantenimiento_Vehiculo GetObjeto()
        {
            return mantenimiento; 
        }

        private bool validarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtDescripcion.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtDescripcion, "El campo no puede estar vacio");
            }

            return valido;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        internal void SetObjeto(Mantenimiento_Vehiculo obj)
        {
            this.mantenimiento = obj;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (mantenimiento!=null)
            {
                txtDescripcion.Text = mantenimiento.DescripcionVehiculo;
                txtDominio.Text = mantenimiento.Dominio;
                dtpFechaMantenimiento.Value = mantenimiento.FechaMantenimiento;
                txtDetalle.Text = mantenimiento.DetalleMantenimiento;
                txtObservaciones.Text = mantenimiento.Observaciones; 
                dateTimePicker1.Value = mantenimiento.FechaProxMantenimiento;
            }
        }

        private void frmMantenimiento_VechiulosAE_Load(object sender, EventArgs e)
        {

        }
    }
}
