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
    public partial class frmProductosAE : Form
    {
        Producto producto;
        public frmProductosAE()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                if (producto == null)
                {
                    producto = new Producto();

                }
                producto.DescripcionProducto = txtProducto.Text;
                producto.Precio = decimal.Parse(txtPrecio.Text);

                if (rbtActivo.Checked == true)
                {
                    producto.Estado = EstadoProducto.Activo;
                }
                else
                {
                    producto.Estado = EstadoProducto.Inactivo;
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        internal Producto GetObjeto()
        {
            return producto;
        }

        private bool validarDatos()
        {
            bool valido = true;

            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtProducto.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtProducto, "El campo no puede estar vacio");
            }
            if (string.IsNullOrEmpty(txtPrecio.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtPrecio, "El campo no puede estar vacio");


            }

            return valido;
        }

        protected override void OnLoad(EventArgs e)
        {
            txtProducto.CharacterCasing = CharacterCasing.Upper;
            base.OnLoad(e);
            if (producto!=null)
            {
                txtProducto.Text = producto.DescripcionProducto.ToString();
                txtPrecio.Text = producto.Precio.ToString();

                if (producto.Estado==EstadoProducto.Activo)
                {
                    rbtActivo.Checked = true;
                }
                else
                {
                    rbtnactivo.Checked = true;
                }
            }
        }

        internal void SetObjeto(Producto obj)
        {
            this.producto = obj;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
