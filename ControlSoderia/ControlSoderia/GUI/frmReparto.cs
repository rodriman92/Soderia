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
    public partial class frmReparto : Form
    {
        private static frmReparto _instancia;
        public frmReparto()
        {
            InitializeComponent();
        }
        internal static frmReparto GetInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new frmReparto();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRepartoAE frm = new frmRepartoAE();
            frm.Text = "Agregar registro al reparto";
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    Reparto rp = frm.GetObjeto();
                    RepartosBD.Agregar(rp);

                    DataGridViewRow r = new DataGridViewRow();
                    r.CreateCells(dgReparto);
                    SetearFilas(r, rp);
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
            dgReparto.Rows.Add(r);
        }

        private void SetearFilas(DataGridViewRow r, Reparto rp)
        {
            r.Cells[cmnNroReparto.Index].Value = rp.NroReparto;
            r.Cells[cmnCliente.Index].Value = rp.idCliente.ApeNombre;
            r.Cells[cmnMes.Index].Value = rp.Mes;
           
            r.Cells[cmnSem1.Index].Value = rp.Sem1;
            r.Cells[cmnSem2.Index].Value = rp.Sem2;
            r.Cells[cmnSem3.Index].Value = rp.Sem3;
            r.Cells[cmnSem4.Index].Value = rp.Sem4;

            r.Tag = rp;   
        }

        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgReparto.SelectedRows[0];
            Reparto obj = (Reparto)r.Tag;
            Reparto objAux = (Reparto)obj.Clone();
            frmRepartoAE frm = new frmRepartoAE();
            frm.Text = "Editar registro";
            frm.SetObjeto(obj);

            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    obj = frm.GetObjeto();
                    RepartosBD.Editar(obj);
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
            List<Reparto> listaUpdated = RepartosBD.GetLista();
            MostrarDatosGrilla(listaUpdated);
        }

        private void MostrarDatosGrilla(List<Reparto> listaUpdated)
        {
            dgReparto.Rows.Clear();

            foreach (Reparto rep in listaUpdated)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgReparto);
                SetearFilas(r, rep);
                AgregarFila(r);
            }
        }
        //bool IsTheSameCellValue(int column, int row)
        //{
        //    DataGridViewCell cell1 = dgReparto[column, row];
        //    DataGridViewCell cell2 = dgReparto[column, row - 1];
        //    if (cell1.Value == null || cell2.Value == null)
        //    {
        //        return false;
        //    }
        //    return cell1.Value.ToString() == cell2.Value.ToString();
        //}

        private void frmReparto_Load(object sender, EventArgs e)
        {
            dgReparto.AutoGenerateColumns = false;
            List<Reparto> lista = new List<Reparto>();

            try
            {
                lista = RepartosBD.GetLista();
                MostrarDatosGrilla(lista);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al cargar los datos", ex.Message);
            }
           
            
        }

        private void bORRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgReparto.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgReparto.SelectedRows[0];
                Reparto rep = (Reparto)r.Tag;
                DialogResult dr = MessageBox.Show(string.Format("¿Desea borrar el reparto?"), "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        RepartosBD.Borrar(rep.IdReparto);


                        dgReparto.Rows.Remove(r);
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
            PdfPTable pdfTable = new PdfPTable(dgReparto.ColumnCount);

            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            foreach (DataGridViewColumn column in dgReparto.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }


            foreach (DataGridViewRow row in dgReparto.Rows)
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
            using (FileStream stream = new FileStream(folderPath + "Reparto" + textBox1.Text+ ".pdf", FileMode.Create))
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

        private void dgReparto_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            //if (e.RowIndex < 1 || e.ColumnIndex < 0)
            //    return;
            //if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            //{
            //    e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
            //}
            //else
            //{
            //    e.AdvancedBorderStyle.Top = dgReparto.AdvancedCellBorderStyle.Top;
            //}
        }

        private void dgReparto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.RowIndex == 0)
            //    return;
            //if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            //{
            //    e.Value = "";
            //    e.FormattingApplied = true;
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String nroReparto;
            nroReparto = textBox1.Text;
            List<Reparto> listaFiltrada = new List<Reparto>();
            listaFiltrada = RepartosBD.GetListaFilrada(nroReparto);
            MostrarDatosGrilla(listaFiltrada);
            this.DialogResult = DialogResult.OK;
        }
    }
}
