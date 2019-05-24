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
    public partial class frmClientes : Form
    {
        private static frmClientes _instancia;

        public frmClientes()
        {
            InitializeComponent();
        }
        internal static frmClientes GetInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new frmClientes();
            }
            _instancia.BringToFront();
            return _instancia;
        }

        private void nUEVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientesAE frm = new frmClientesAE();
            frm.Text = "Agregar cliente";
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                try
                {
                    Cliente cl = frm.GetObjeto();
                    ClientesBD.Agregar(cl);

                    DataGridViewRow r = new DataGridViewRow();
                    r.CreateCells(dgClientes);
                    SetearFilas(r, cl);
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
            dgClientes.Rows.Add(r);
        }

        private void SetearFilas(DataGridViewRow r, Cliente cl)
        {
            r.Cells[cmnId.Index].Value = cl.IdCliente;
            r.Cells[cmnApeNombre.Index].Value = cl.ApeNombre;
            r.Cells[cmnCUIT.Index].Value = cl.CUIT;
            r.Cells[cmnDireccion.Index].Value = cl.Direccion;
            r.Cells[cmnTel.Index].Value = cl.Telefono;
            r.Cells[cmnEmail.Index].Value = cl.Email;
            r.Cells[cmnLocalidad.Index].Value = cl.Localidad;
            r.Cells[cmnConsumo.Index].Value = cl.ConsumoHabitual;
            r.Cells[cmnNroReparto.Index].Value = cl.NroReparto;

            r.Tag = cl;
        }

        private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = dgClientes.SelectedRows[0];
            Cliente obj = (Cliente)r.Tag;
            Cliente objAux = (Cliente)obj.Clone();
            frmClientesAE frm = new frmClientesAE();
            frm.Text = "Editar cliente";
            frm.SetObjeto(obj);

            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                try
                {
                    obj = frm.GetObjeto();
                    ClientesBD.Editar(obj);
                    SetearFilas(r, obj);

                   
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar", ex.Message);
                }
            }
        }

        private void Actualizar()
        {
            List<Cliente> listaUpdate = new List<Cliente>();
            listaUpdate = ClientesBD.GetLista();
            MostrarDatosGrilla(listaUpdate);
        }

        private void bORRARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgClientes.SelectedRows.Count > 0)
            {
                DataGridViewRow r = dgClientes.SelectedRows[0];
                Cliente c = (Cliente)r.Tag;
                DialogResult dr = MessageBox.Show(string.Format("¿Desea borrar el cliente?"), "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        ClientesBD.Borrar(c.IdCliente);


                        dgClientes.Rows.Remove(r);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            cboReparto.SelectedIndex = 0;
            textBox1.Select();
            textBox1.Focus();
            
            //List<Cliente> listaC = new List<Cliente>();
            //listaC = ClientesBD.GetLista();
            //MostrarDatosGrilla(listaC);
        }

        private void MostrarDatosGrilla(List<Cliente> listaCl)
        {
            dgClientes.Rows.Clear();

            foreach (Cliente c2 in listaCl)
            {
                DataGridViewRow r = new DataGridViewRow();
                r.CreateCells(dgClientes);
                SetearFilas(r, c2);
                AgregarFila(r);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void iMPRIMIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTable = new PdfPTable(dgClientes.ColumnCount);

            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            foreach (DataGridViewColumn column in dgClientes.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }


            foreach (DataGridViewRow row in dgClientes.Rows)
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
            using (FileStream stream = new FileStream(folderPath + "Clientes.pdf", FileMode.Create))
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

        private void txtCliente_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox1.Clear();
            dgClientes.Rows.Clear();
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cliente = "";


            cliente = textBox1.Text;
            List<Cliente> listaFiltrada = new List<Cliente>();
            listaFiltrada = ClientesBD.GetListaFilrada(cliente);
            MostrarDatosGrilla(listaFiltrada);
            this.DialogResult = DialogResult.OK;
        }

        private void cboReparto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int nroRep = 0;
            nroRep = cboReparto.SelectedIndex;

            List<Cliente> listaFiltrada = new List<Cliente>();

            listaFiltrada=ClientesBD.FiltrarClientesReparto(nroRep);
            MostrarDatosGrilla(listaFiltrada);

          
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            DialogResult dr = MessageBox.Show(string.Format("La carga de todos los datos puede demorar y provocar que el sistema se vuelva inestable. ¿Desea continuar?"), "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    List<Cliente> listaCompleta = new List<Cliente>();

                    listaCompleta=ClientesBD.GetLista();

                    MostrarDatosGrilla(listaCompleta);



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "Error al cargar la lista. Reintente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }
    }
 }
