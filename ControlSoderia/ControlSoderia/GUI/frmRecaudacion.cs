using ControlSoderia.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSoderia.GUI
{
    public partial class frmRecaudacion : Form
    {
        public frmRecaudacion()
        {
            InitializeComponent();
        }

        private void frmRecaudacion_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();
                    string selectComando = "select recibo.numdia as Dia,recibo.nummes as Mes, Cliente.apenombre as Cliente, sum(recibo.importe)as ImporteVta from Recibo, cliente where recibo.idCliente=Cliente.IdCliente group by numdia, nummes, ApeNombre order by numDia desc";
                    SqlDataAdapter da = new SqlDataAdapter(selectComando, cnn);

                    DataTable dt = new DataTable();


                    da.Fill(dt);

                    dgRecaudacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dgRecaudacion.DataSource = dt;

                    double sumatoria = 0.00;

                    foreach (DataGridViewRow row in dgRecaudacion.Rows)
                    {
                        sumatoria += Convert.ToInt32(row.Cells["ImporteVta"].Value);
                    }

                    txtRecaudacion.Text = Math.Round(sumatoria, 2).ToString();

                    cnn.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
