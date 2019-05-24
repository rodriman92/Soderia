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
    public partial class frmClientesAE : Form
    {
        Cliente cliente;

        public frmClientesAE()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (cliente==null)
                {
                    cliente = new Cliente();
                }
                cliente.ApeNombre = txtApeNombre.Text;
                cliente.CUIT = txtCUIT.Text;
                cliente.Direccion = txtDireccion.Text;
                cliente.Telefono = txtTel.Text;
                cliente.Email = txtEmail.Text;
                cliente.Localidad = txtLocalidad.Text;
                cliente.ConsumoHabitual = txtConsumo.Text;
                cliente.NroReparto = int.Parse(txtNroReparto.Text);

                this.DialogResult = DialogResult.OK;
            }
        }

        internal Cliente GetObjeto()
        {
            return cliente;
        }

        private bool validarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtApeNombre.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtApeNombre, "El campo es requerido");
            }

            if (string.IsNullOrEmpty(txtNroReparto.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtNroReparto, "El campo es requerido");
            }

            return valido;
        }


        protected override void OnLoad(EventArgs e)
        {
            
            base.OnLoad(e);

            if (cliente!=null)
            {
                txtApeNombre.Text = cliente.ApeNombre;
                txtCUIT.Text = cliente.CUIT;
                txtDireccion.Text = cliente.Direccion;
                txtTel.Text = cliente.Telefono;
                txtEmail.Text = cliente.Email;
                txtLocalidad.Text = cliente.Localidad;
                txtConsumo.Text = cliente.ConsumoHabitual;
                txtNroReparto.Text = cliente.NroReparto.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        internal void SetObjeto(Cliente obj)
        {
            this.cliente = obj;
        }

        private void frmClientesAE_Load(object sender, EventArgs e)
        {

        }
    }
}
