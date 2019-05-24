using ControlSoderia.BL;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSoderia.GUI
{
    public partial class frmListaReparto : Form
    {
        string hoja = "";
        public frmListaReparto()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }
        private void LLenarGrid(string archivo, string hoja)
        {       
            OleDbConnection conexion = null;
            DataSet dataSet = null;
            OleDbDataAdapter dataAdapter = null;
            string consultaHojaExcel = "Select * from [" + hoja + "$]";

            string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + archivo + "';Extended Properties=Excel 12.0;";

            if (string.IsNullOrEmpty(hoja))
            {
                MessageBox.Show("No hay una hoja para leer");
            }
            else
            {
                try
                {

                    conexion = new OleDbConnection(cadenaConexionArchivoExcel);
                    conexion.Open(); 
                    dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); 
                    dataSet = new DataSet(); 
                    dataAdapter.Fill(dataSet, hoja);
                    dataGridView1.DataSource = dataSet.Tables[0];
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    conexion.Close();
                    dataGridView1.AllowUserToAddRows = false;       
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error, Verificar el archivo o el nombre de la hoja", ex.Message);
                }
            }
        }

        private void cboReparto_SelectedIndexChanged(object sender, EventArgs e)
        {
            RutaArchivo r = new RutaArchivo();
            
            txtArchivo.Text = r.DireccionArchivo();
            hoja = cboReparto.Text;
            LLenarGrid(txtArchivo.Text, hoja);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("No Hay Datos Para Realizar Un Reporte");
            }
            else
            {    
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string filename = save.FileName;
                    Document doc = new Document(PageSize.A4, 20, 20, 20, 20);
                    Chunk encab = new Chunk("REPARTO " + cboReparto.Text , FontFactory.GetFont("MICROSOFT SANS SERIF", 12));
                    try
                    {
                        FileStream file = new FileStream(filename, FileMode.OpenOrCreate);
                        PdfWriter writer = PdfWriter.GetInstance(doc, file);
                        writer.ViewerPreferences = PdfWriter.PageModeUseThumbs;
                        writer.ViewerPreferences = PdfWriter.PageLayoutOneColumn;
                        doc.Open();

                        doc.Add(new Paragraph(encab));
                        GenerarDocumentos(doc);

                        Process.Start(filename);
                        doc.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }

        }

        private void GenerarDocumentos(Document document)
        {
            PdfPTable datatable = new PdfPTable(16);


            float[] values = new float[16];
            values[0] = 300;
            values[1] = 300;
            values[2] = 300;
            values[3] = 300;
            values[4] = 100;
            values[5] = 100;
            values[6] = 100;
            values[7] = 100;
            values[8] = 100;
            values[9] = 100;
            values[10] = 100;
            values[11] = 100;
            values[12] = 100;
            values[13] = 100;
            values[14] = 100;
            values[15] = 200;
            

            datatable.SetWidths(values);
            datatable.DefaultCell.BorderWidth = 1;
            datatable.WidthPercentage = 100;



           
            //datatable.DefaultCell.Padding = 1;
            //float[] headerwidths = GetTamañoColumnas(dataGridView1);

            //datatable.SetWidths(headerwidths);
            //datatable.WidthPercentage = 100;
            //datatable.DefaultCell.BorderWidth = 1;

            
            datatable.DefaultCell.BackgroundColor = iTextSharp.text.BaseColor.WHITE;

            
            datatable.DefaultCell.BorderColor = iTextSharp.text.BaseColor.BLACK;

           
            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER,8);

            Phrase objP = new Phrase("A", fuente);

            datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;

              
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {

                objP = new Phrase(dataGridView1.Columns[i].HeaderText, fuente);
                datatable.HorizontalAlignment = Element.ALIGN_CENTER;
                
                datatable.AddCell(objP);

            }
            datatable.HeaderRows = 2;
            datatable.WidthPercentage = 100;
            datatable.DefaultCell.BorderWidth = 1;

             
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    objP = new Phrase(dataGridView1[j, i].Value.ToString(), fuente);
                    datatable.AddCell(objP);
                }
                datatable.CompleteRow();
            }
            document.Add(datatable);
            
        }


        
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            
            float[] values = new float[dg.ColumnCount];
            for (int i = 0; i < dg.ColumnCount; i++)
            {
                
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }







        private void frmListaReparto_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ////creamos un objeto OpenDialog que es un cuadro de dialogo para buscar archivos
            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"; //le indicamos el tipo de filtro en este caso que busque
            //                                                                 //solo los archivos excel

            //dialog.Title = "Seleccione el archivo de Excel";//le damos un titulo a la ventana

            //dialog.FileName = string.Empty;//inicializamos con vacio el nombre del archivo

            ////si al seleccionar el archivo damos Ok
            //if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    //el nombre del archivo sera asignado al textbox
            //    txtArchivo.Text = "C:/Users/Rodrigo/Downloads/listasnuevas.xlsx";
            //    hoja = cboReparto.Text; //la variable hoja tendra el valor del textbox donde colocamos el nombre de la hoja
            //    LLenarGrid(txtArchivo.Text, hoja); //se manda a llamar al metodo

            //    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //se ajustan las
            //                                                                              //columnas al ancho del DataGridview para que no quede espacio en blanco (opcional)
            //}
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            
        }

        private void txtArchivo_Click(object sender, EventArgs e)
        {

        }
    }
}
