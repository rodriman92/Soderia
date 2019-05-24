using ControlSoderia.BL;
using ControlSoderia.Datos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSoderia.GUI
{
    public partial class frmSaldoCliente : Form
    {
        public frmSaldoCliente()
        {
            InitializeComponent();
        }

        private void frmSaldoCliente_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = ConexionBD.GetConexion())
            {
                try
                {
                    cnn.Open();
                    string selectComando = "SELECT Cliente.IdCliente, Cliente.ApeNombre, SUM(Recibo.Importe)AS Suma FROM Cliente INNER JOIN Recibo ON Cliente.IdCliente = Recibo.idCliente GROUP BY Cliente.ApeNombre, Cliente.IdCliente ORDER BY Cliente.ApeNombre";

                    SqlDataAdapter da = new SqlDataAdapter(selectComando, cnn);

                    DataTable dt = new DataTable();


                    da.Fill(dt);

                    dgSaldo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dgSaldo.DataSource = dt;



                    cnn.Close();
                }
                catch (Exception)
                {

                    throw;
                }


                //List<Saldo_Cliente> listSaldo = new List<Saldo_Cliente>();
                //listSaldo = SaldosBD.GetLista();
                //MostrarDatosGrilla(listSaldo);
            }
        }

        private void iMPRIMIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTable = new PdfPTable(dgSaldo.ColumnCount);

            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            foreach (DataGridViewColumn column in dgSaldo.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }


            foreach (DataGridViewRow row in dgSaldo.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }


            string folderPath = "C:\\Listados\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "Saldos.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();

                System.Diagnostics.Process.Start(@"C:\\Listados\\");

            }
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
