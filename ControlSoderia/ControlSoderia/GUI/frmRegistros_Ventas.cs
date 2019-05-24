using ControlSoderia.BL;
using ControlSoderia.Datos;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSoderia.GUI
{
    public partial class frmRegistros_Ventas : Form
    {
        private static frmRegistros_Ventas _instancia;
        public frmRegistros_Ventas()
        {
            InitializeComponent();
        }
        internal static frmRegistros_Ventas GetInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new frmRegistros_Ventas();
            }
            _instancia.BringToFront();
            return _instancia;
        }
        private void frmRegistros_Ventas_Load(object sender, EventArgs e)
        {
            List<Registro> listaReg = new List<Registro>();
            listaReg = RegistrosBD.GetLista();
            MostrarDatosGrilla(listaReg);
        }

        private void MostrarDatosGrilla(List<Registro> listaReg)
        {
            dgRegistros.Rows.Clear();

            foreach (Registro reg in listaReg)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgRegistros);
                SetearFila(r, reg);
                AgregarFila(r);
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgRegistros.Rows.Add(r);

        }

        private void SetearFila(DataGridViewRow r, Registro reg)
        {
            r.Cells[cmnDia.Index].Value = reg.numDia;
            r.Cells[cmnMes.Index].Value = reg.numMes;
            r.Cells[cmnAño.Index].Value = reg.año;
            r.Cells[cmnCliente.Index].Value = reg.idCliente.ApeNombre;
            r.Cells[cmnProductos.Index].Value = reg.idProducto.DescripcionProducto;
            r.Cells[cmnCantidad.Index].Value = reg.Cantidad;
            r.Cells[cmnPrecio.Index].Value = reg.Precio;
            r.Cells[cmnImporte.Index].Value = reg.Importe;
            r.Cells[cmnSaldoAnterior.Index].Value = reg.SaldoAnterior;

            r.Tag = reg;
        }

        private void bORRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgRegistros.SelectedRows[0];
                Registro reg = (Registro)r.Tag;
                DialogResult dr = MessageBox.Show(string.Format("¿Desea borrar el registro?"), "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        RegistrosBD.Borrar(reg.IdRegistro);


                        dgRegistros.Rows.Remove(r);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void iMPRIMIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTable = new PdfPTable(dgRegistros.ColumnCount);

            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            foreach (DataGridViewColumn column in dgRegistros.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }


            foreach (DataGridViewRow row in dgRegistros.Rows)
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
            using (FileStream stream = new FileStream(folderPath + "Registros.pdf", FileMode.Create))
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

        private void cAJADIARIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecaudacion frm = new frmRecaudacion();
            frm.Show();
        }
    }
}
