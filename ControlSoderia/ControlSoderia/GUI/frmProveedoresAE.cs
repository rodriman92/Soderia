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
    public partial class frmProveedoresAE : Form
    {
        Proveedor prov;


        public frmProveedoresAE()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (prov==null)
                {
                    prov = new Proveedor();
                }
                prov.RazonSocial = txtRazonSocial.Text;
                prov.CUIT = txtCUIT.Text;
                prov.Domicilio = txtDomicilio.Text;
                prov.Telefono = txtTel.Text;
                prov.Email = txtEmail.Text;
                prov.Localidad = txtLocalidad.Text;

                this.DialogResult = DialogResult.OK;
            }
        }

        internal Proveedor GetObjeto()
        {
            return prov;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (prov!=null)
            {
                txtRazonSocial.Text = prov.RazonSocial;
                txtCUIT.Text = prov.CUIT;
                txtDomicilio.Text = prov.Domicilio;
                txtTel.Text = prov.Telefono;
                txtEmail.Text = prov.Email;
                txtLocalidad.Text = prov.Localidad;
            }
        }

        private bool validarDatos()
        {
            bool valido = true;

            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtRazonSocial.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtRazonSocial, "El campo no puede estar vacio");
            }

            return valido;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        internal void SetObjeto(Proveedor obj)
        {
            this.prov = obj;
        }

        private void frmProveedoresAE_Load(object sender, EventArgs e)
        {
            txtRazonSocial.CharacterCasing = CharacterCasing.Upper;
            
            txtDomicilio.CharacterCasing = CharacterCasing.Upper;
            txtTel.CharacterCasing = CharacterCasing.Upper;
            txtEmail.CharacterCasing = CharacterCasing.Upper;
            txtLocalidad.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
