using ControlSoderia.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSoderia.GUI
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos frm = frmProductos.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frm = frmClientes.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void repartosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoReparto frm = new ListadoReparto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistros_Ventas frm = new frmRegistros_Ventas();
            frm.MdiParent = this;
            frm.Show();

        }

        private void recibosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactura frm = new frmFactura();
            frm.MdiParent = this;
            frm.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores frm = frmProveedores.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimiento_Vehiculos frm = frmMantenimiento_Vehiculos.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
        }

        private void saldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaldoCliente frm = new frmSaldoCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void backupToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string ConnectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString();
                SqlConnection cnn = new SqlConnection(ConnectionString);


                SqlCommand cmd = new SqlCommand("backupdb", cnn);
                cmd.CommandType = CommandType.StoredProcedure;




                cnn.Open();


                cmd.ExecuteNonQuery();


                MessageBox.Show("El backup fue realizado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe frm = new AcercaDe();
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Recuerde realizar un respaldo de datos con frecuencia");
            Application.Exit();
        }
    }
}
