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
    public partial class frmProveedores : Form
    {
        private static frmProveedores _instancia;
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedoresAE frm = new frmProveedoresAE();
            frm.Text = "Agregar proveedor";
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    Proveedor prov = frm.GetObjeto();
                    ProveedoresBD.Agregar(prov);

                    DataGridViewRow r = new DataGridViewRow();
                    r.CreateCells(dgProveedor);
                    SetearFilas(r, prov);
                    AgregarFila(r);


                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void AgregarFila(DataGridViewRow r)
        {
            dgProveedor.Rows.Add(r);
        }

        private void SetearFilas(DataGridViewRow r, Proveedor prov)
        {
            r.Cells[cmnRazonSocial.Index].Value = prov.RazonSocial;
            r.Cells[cmnCUIT.Index].Value = prov.CUIT;
            r.Cells[cmnDomicilio.Index].Value = prov.Domicilio;
            r.Cells[cmnTel.Index].Value = prov.Telefono;
            r.Cells[cmnEmail.Index].Value = prov.Email;
            r.Cells[cmnLocalidad.Index].Value = prov.Localidad;

            r.Tag = prov;
        }

        internal static frmProveedores GetInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new frmProveedores();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgProveedor.SelectedRows[0];
            Proveedor obj = (Proveedor)r.Tag;
            Proveedor objAux = (Proveedor)obj.Clone();
            frmProveedoresAE frm = new frmProveedoresAE();
            frm.Text = "Editar proveedor";
            frm.SetObjeto(obj);

            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    obj = frm.GetObjeto();
                    ProveedoresBD.Editar(obj);
                    SetearFilas(r, obj);

                    MessageBox.Show("Registro actualizado correctamente");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar editar registro", ex.Message);
                }
            }
        }

        private void Actualizar()
        {
            List<Proveedor> listaUpdated = new List<Proveedor>();
            listaUpdated = ProveedoresBD.GetLista();
            MostrarDatosGrilla(listaUpdated);
        }

        private void bORRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgProveedor.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgProveedor.SelectedRows[0];
                Proveedor prov = (Proveedor)r.Tag;
                DialogResult dr = MessageBox.Show(string.Format("¿Desea borrar el proveedor?"), "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        ProveedoresBD.Borrar(prov.IdProveedor);


                        dgProveedor.Rows.Remove(r);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void MostrarDatosGrilla(List<Proveedor> listaFiltrada)
        {
            dgProveedor.Rows.Clear();

            foreach (Proveedor pro in listaFiltrada)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgProveedor);
                SetearFilas(r, pro);
                AgregarFila(r);
            }
        }

        private void iMPRIMIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTable = new PdfPTable(dgProveedor.ColumnCount);

            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            foreach (DataGridViewColumn column in dgProveedor.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }


            foreach (DataGridViewRow row in dgProveedor.Rows)
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
            using (FileStream stream = new FileStream(folderPath + "Proveedores.pdf", FileMode.Create))
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

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            List<Proveedor> lista = new List<Proveedor>();
            lista = ProveedoresBD.GetLista();
            MostrarDatosGrilla(lista);
        }
    }
}
