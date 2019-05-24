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
    public partial class frmProductos : Form
    {
        private static frmProductos _instancia;
        public frmProductos()
        {
            InitializeComponent();
        }
        internal static frmProductos GetInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new frmProductos();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductosAE frm = new frmProductosAE();
            frm.Text = "Agregar producto";
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    Producto p1 = frm.GetObjeto();
                    ProductosBD.Agregar(p1);

                    DataGridViewRow r = new DataGridViewRow();
                    r.CreateCells(dgProductos);
                    SetearFilas(r, p1);
                    AgregarFila(r);


                }
                catch (Exception)
                {

                    throw;
                }
            }
            //Actualizar();
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgProductos.Rows.Add(r);
        }

        private void SetearFilas(DataGridViewRow r, Producto p1)
        {
            r.Cells[cmnDescripcionProd.Index].Value = p1.DescripcionProducto;
            r.Cells[cmnPrecioUn.Index].Value = "$" +  p1.Precio.ToString();
            r.Cells[cmnEstadoProd.Index].Value = p1.Estado;

            r.Tag = p1;
        }

        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgProductos.SelectedRows[0];
            Producto obj = (Producto)r.Tag;
            Producto objAux = (Producto)obj.Clone();
            frmProductosAE frm = new frmProductosAE();
            frm.Text = "Editar producto";
            frm.SetObjeto(obj);

            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    obj = frm.GetObjeto();
                    ProductosBD.Editar(obj);
                    SetearFilas(r, obj);

                    MessageBox.Show("Registro actualizado correctamente");
                    Actualizar();
                }
                catch (Exception)
                {

                }
            }
        }

        private void Actualizar()
        {
            List<Producto> listaUpdated = ProductosBD.GetLista();
            MostrarDatosGrilla(listaUpdated);
        }

        private void bORRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgProductos.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgProductos.SelectedRows[0];
                Producto p = (Producto)r.Tag;
                DialogResult dr = MessageBox.Show(string.Format("¿Desea borrar el producto?"), "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        ProductosBD.Borrar(p.IdProducto);


                        dgProductos.Rows.Remove(r);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
      
            List<Producto> lista = ProductosBD.GetLista();
            MostrarDatosGrilla(lista);
        }

        private void MostrarDatosGrilla(List<Producto> lista)
        {
            dgProductos.Rows.Clear();

            foreach (Producto pr in lista)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgProductos);
                SetearFilas(r, pr);
                AgregarFila(r);
            }
        }

        private void cERRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iMPRIMIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTable = new PdfPTable(dgProductos.ColumnCount);

            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            foreach (DataGridViewColumn column in dgProductos.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }


            foreach (DataGridViewRow row in dgProductos.Rows)
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
            using (FileStream stream = new FileStream(folderPath + "Productos.pdf", FileMode.Create))
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
           
            
        }
    }
}
