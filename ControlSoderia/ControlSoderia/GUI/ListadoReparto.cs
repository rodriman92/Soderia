using DGV2Printer;
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
    public partial class ListadoReparto : Form
    {
        string hoja = "";
        public ListadoReparto()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //creamos un objeto OpenDialog que es un cuadro de dialogo para buscar archivos
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"; //le indicamos el tipo de filtro en este caso que busque
                                                                             //solo los archivos excel

            dialog.Title = "Seleccione el archivo de Excel";//le damos un titulo a la ventana

            dialog.FileName = string.Empty;//inicializamos con vacio el nombre del archivo

            //si al seleccionar el archivo damos Ok
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //el nombre del archivo sera asignado al textbox
                txtArchivo.Text = dialog.FileName;
                hoja = txtReparto.Text; //la variable hoja tendra el valor del textbox donde colocamos el nombre de la hoja
                LLenarGrid(txtArchivo.Text, hoja); //se manda a llamar al metodo

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; //se ajustan las
                                                                                          //columnas al ancho del DataGridview para que no quede espacio en blanco (opcional)
            }
            
        }

        private void LLenarGrid(string text, string hoja)
        {
            
            //declaramos las variables         
            OleDbConnection conexion = null;
            DataSet dataSet = null;
            OleDbDataAdapter dataAdapter = null;
            string consultaHojaExcel = "Select * from [" + hoja + "$]";

            //esta cadena es para archivos excel 2007 y 2010
            string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + txtArchivo.Text + "';Extended Properties=Excel 12.0;";

            //para archivos de 97-2003 usar la siguiente cadena
            //string cadenaConexionArchivoExcel = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + archivo + "';Extended Properties=Excel 8.0;";

            //Validamos que el usuario ingrese el nombre de la hoja del archivo de excel a leer
            if (string.IsNullOrEmpty(hoja))
            {
                MessageBox.Show("No hay una hoja para leer");
            }
            else
            {
                try
                {
                    //Si el usuario escribio el nombre de la hoja se procedera con la busqueda
                    conexion = new OleDbConnection(cadenaConexionArchivoExcel);//creamos la conexion con la hoja de excel
                    conexion.Open(); //abrimos la conexion
                    dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
                    dataSet = new DataSet(); // creamos la instancia del objeto DataSet
                    dataAdapter.Fill(dataSet, hoja);//llenamos el dataset
                    dataGridView1.DataSource = dataSet.Tables[0]; //le asignamos al DataGridView el contenido del dataSet
                    conexion.Close();//cerramos la conexion
                    dataGridView1.AllowUserToAddRows = false;       //eliminamos la ultima fila del datagridview que se autoagrega
                    dataGridView1.AutoResizeColumns();
                }
                catch (Exception ex)
                {
                    //en caso de haber una excepcion que nos mande un mensaje de error
                    MessageBox.Show("Error, Verificar el archivo o el nombre de la hoja", ex.Message);
                }
            }
        }

        private void txtReparto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ListadoReparto_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
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
                    Chunk encab = new Chunk("REPARTO " + txtReparto.Text, FontFactory.GetFont("MICROSOFT SANS SERIF", 12));
                    Phrase p = new Phrase();
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
            values[0] = 400;
            values[1] = 400;
            values[2] = 400;
            values[3] = 400 ;
            values[4] = 300;
            values[5] = 300;
            values[6] = 300;
            values[7] = 300;
            values[8] = 300;
            values[9] = 300;
            values[10] = 300;
            values[11] = 300;
            values[12] = 300;
            values[13] = 300;
            values[14] = 300;
            values[15] = 300;


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


            iTextSharp.text.Font fuente = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.COURIER, 8);

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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintDataGridView pr = new PrintDataGridView(dataGridView1);
            dataGridView1.AutoResizeColumns();
            pr.isRightToLeft = false;
            
            pr.ReportHeader = "Reparto Nº" + txtReparto.Text;
            pr.ReportFooter = "Agua y Soda KALÚ- ROQUE PÉREZ";
            pr.Print();
        }
    }
}
