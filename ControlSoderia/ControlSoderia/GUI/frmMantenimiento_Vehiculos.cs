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
    public partial class frmMantenimiento_Vehiculos : Form
    {
        public static frmMantenimiento_Vehiculos _instancia;

        public frmMantenimiento_Vehiculos()
        {
            InitializeComponent();
        }

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantenimiento_VechiulosAE frm = new frmMantenimiento_VechiulosAE();
            frm.Text = "Agregar mantenimiento";
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    Mantenimiento_Vehiculo man = frm.GetObjeto();
                    Mantenimiento_VehiculosBD.Agregar(man);

                    DataGridViewRow r = new DataGridViewRow();
                    r.CreateCells(dgMantenimiento);
                    SetearFilas(r, man);
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
            dgMantenimiento.Rows.Add(r);
        }

        private void SetearFilas(DataGridViewRow r, Mantenimiento_Vehiculo man)
        {
            r.Cells[cmnDescripcion.Index].Value = man.DescripcionVehiculo;
            r.Cells[cmnDominio.Index].Value = man.Dominio;
            r.Cells[cmnFechaManten.Index].Value = man.FechaMantenimiento.ToShortDateString();
            r.Cells[cmnDetalleManten.Index].Value = man.DetalleMantenimiento;
            r.Cells[cmnObservaciones.Index].Value = man.Observaciones;
            r.Cells[cmnFechaProxManten.Index].Value = man.FechaProxMantenimiento.ToShortDateString();

            r.Tag = man;
        }

        internal static frmMantenimiento_Vehiculos GetInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new frmMantenimiento_Vehiculos();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgMantenimiento.SelectedRows[0];
            Mantenimiento_Vehiculo obj = (Mantenimiento_Vehiculo)r.Tag;
            Mantenimiento_Vehiculo objAux = (Mantenimiento_Vehiculo)obj.Clone();
            frmMantenimiento_VechiulosAE frm = new frmMantenimiento_VechiulosAE();
            frm.Text = "Editar mantenimiento";
            frm.SetObjeto(obj);

            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    obj = frm.GetObjeto();
                    Mantenimiento_VehiculosBD.Editar(obj);
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
            List<Mantenimiento_Vehiculo> listaUpdate = new List<Mantenimiento_Vehiculo>();
            listaUpdate = Mantenimiento_VehiculosBD.GetLista();
            MostrarDatosGrilla(listaUpdate);
        }

        private void bORRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgMantenimiento.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgMantenimiento.SelectedRows[0];
                Mantenimiento_Vehiculo c = (Mantenimiento_Vehiculo)r.Tag;
                DialogResult dr = MessageBox.Show(string.Format("¿Desea borrar el registro?"), "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        Mantenimiento_VehiculosBD.Borrar(c.IdMatenimiento);


                        dgMantenimiento.Rows.Remove(r);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void frmMantenimiento_Vehiculos_Load(object sender, EventArgs e)
        {
            List<Mantenimiento_Vehiculo> listaMantenimiento = new List<Mantenimiento_Vehiculo>();
            listaMantenimiento = Mantenimiento_VehiculosBD.GetLista();
            MostrarDatosGrilla(listaMantenimiento);

        }

        private void MostrarDatosGrilla(List<Mantenimiento_Vehiculo> listaMantenimiento)
        {
            dgMantenimiento.Rows.Clear();

            foreach (Mantenimiento_Vehiculo man in listaMantenimiento)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgMantenimiento);
                SetearFilas(r, man);
                AgregarFila(r);   
            }
        }

        private void iMPRIMIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTable = new PdfPTable(dgMantenimiento.ColumnCount);

            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            foreach (DataGridViewColumn column in dgMantenimiento.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }


            foreach (DataGridViewRow row in dgMantenimiento.Rows)
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
            using (FileStream stream = new FileStream(folderPath + "Mantenimiento_Vehiculos.pdf", FileMode.Create))
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
    }
}
