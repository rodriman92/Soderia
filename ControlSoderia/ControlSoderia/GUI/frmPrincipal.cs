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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmProductos hijo2 = new frmProductos();
            
            hijo2.Show();
        }

        private void rECIBOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            frmFactura hijo2 = frmFactura.GetInstancia();
            
            hijo2.Show();
        }

        private void cLIENTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            frmClientes hijo2 = new frmClientes();
            
            hijo2.Show();
        }

        private void rEPARTOSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            frmReparto hijo2 = frmReparto.GetInstancia();
            
            hijo2.Show();
        }

        private void rEGISTROSToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            frmRegistros_Ventas hijo2 = frmRegistros_Ventas.GetInstancia();
            
            hijo2.Show();
        }

        private void pROVEEDORESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            frmProveedores hijo2 = frmProveedores.GetInstancia();
            
            hijo2.Show();
        }

        private void mANTENIMIENTOToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMantenimiento_Vehiculos hijo2 = frmMantenimiento_Vehiculos.GetInstancia();
            hijo2.Show();
        }
    }
}
