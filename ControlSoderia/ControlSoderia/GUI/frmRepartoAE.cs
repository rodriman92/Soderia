using ControlSoderia.BL;
using ControlSoderia.Datos;
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
    public partial class frmRepartoAE : Form
    {
        Reparto reparto;
        public frmRepartoAE()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (validarDatos())
                {
                    if (reparto==null)
                {
                    reparto = new Reparto();
                }
                reparto.NroReparto = int.Parse(numReparto.Text);
                reparto.idCliente = (Cliente)cboCliente.SelectedItem;
                reparto.Mes = txtMes.Text;
                
                reparto.Sem1 = txtDetalleSem1.Text;
                reparto.Sem2 = txtDetalleSem2.Text;
                reparto.Sem3 = txtDetalleSem3.Text;
                reparto.Sem4 = txtDetalleSem4.Text;

                this.DialogResult = DialogResult.OK;

            }
            
        }

        internal Reparto GetObjeto()
        {
            return reparto;
        }

        private bool validarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (cboCliente.SelectedIndex.Equals(0))
            {
                valido = false;
                errorProvider1.SetError(cboCliente, "El dato ingresado no es valido");
            }

            return valido;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ClientesBD.CargarCombo(ref cboCliente);
            
            if (reparto!=null)
            {
                numReparto.Text = reparto.NroReparto.ToString();
                cboCliente.SelectedValue = reparto.idCliente.IdCliente;
                txtMes.Text = reparto.Mes;
                
                txtDetalleSem1.Text = reparto.Sem1;
                txtDetalleSem2.Text = reparto.Sem2;
                txtDetalleSem3.Text = reparto.Sem3;
                txtDetalleSem4.Text = reparto.Sem4;
                numReparto.Enabled = false;
                cboCliente.Enabled = false;
            }
        }

        internal void SetObjeto(Reparto obj)
        {
            this.reparto = obj;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void cboCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();

            cl = (Cliente)cboCliente.SelectedItem;
            numReparto.Text = cl.NroReparto.ToString(); 
        }

        private void frmRepartoAE_Load(object sender, EventArgs e)
        {

        }
    }
}
