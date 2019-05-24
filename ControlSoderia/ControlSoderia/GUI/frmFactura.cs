using ControlSoderia.BL;
using ControlSoderia.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSoderia.GUI
{
    public partial class frmFactura : Form
    {
        private DataTable dt;
        private Image facModelo;

        private static frmFactura _instancia;
        internal static frmFactura GetInstancia()
        {
            if (_instancia == null || _instancia.IsDisposed)
            {
                _instancia = new frmFactura();
            }
            _instancia.BringToFront();
            return _instancia;
        }
        public frmFactura()
        {
            InitializeComponent();

            dt = new DataTable();
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Precio Unitario");
            dt.Columns.Add("Importe");

            DGV.DataSource = dt;
           
            facModelo = ControlSoderia.Properties.Resources.FactModel;
        }

        private Boolean camposCompletos()
        {
            if (txtCantidad.Text.Equals("") || cboCliente.SelectedIndex.Equals(0) ||
txtPrecio.Text.Equals("") || txtImporte.Text.Equals("") || txtAño.Text.Equals(""))
                return false;

            else
                return true;
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (!(txtCantidad.Text.Equals("") || txtPrecio.Text.Equals("")))
            txtImporte.Text = (Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text)).ToString();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (!(txtCantidad.Text.Equals("") || txtPrecio.Text.Equals("")))
                txtImporte.Text = (Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text)).ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (camposCompletos() && DGV.Rows.Count < 6)
            {
                añadirRegistro();
                AgregarABD();
                
                vaciarCampos();
                txtSaldoAnterior.Clear();
                ObtenerSaldo();
            }
            
            
            else
            {
                MessageBox.Show("Se supero el limite de items. Realice otra factura");
            }
        }
        //-//
        Recibo recibo;
        Saldo_Cliente saldo;
        private void AgregarABD()
        {
            
            if (recibo==null)
            {
                recibo = new Recibo();
            }
            recibo.dia = int.Parse(txtDia.Text);
            recibo.mes = int.Parse(txtMes.Text);
            recibo.año = int.Parse(txtAño.Text);
            recibo.cliente = (Cliente)cboCliente.SelectedItem;
            recibo.producto = (Producto)cboProducto.SelectedItem;
            recibo.Cantidad = int.Parse(txtCantidad.Text);
            recibo.PrecioU = decimal.Parse(txtPrecio.Text);
            recibo.Importe = decimal.Parse(txtImporte.Text.ToString());
            recibo.SaldoA =  decimal.Parse(txtSaldoAnterior.Text);
            recibo.Entrada = decimal.Parse(txtEntrada.Text);
            recibo.Salida = decimal.Parse(txtSalida.Text);

            if (saldo==null)
            {
                saldo = new Saldo_Cliente();
            }


            saldo.Mes = int.Parse(txtMes.Text);
            saldo.Año = int.Parse(txtAño.Text);
            saldo.idCliente = (Cliente)cboCliente.SelectedItem;
            saldo.SaldoMes = decimal.Parse(txtSaldoAnterior.Text);

            this.DialogResult = DialogResult.OK;

            RecibosBD.Guardar(recibo, saldo);

           
        }

        private void vaciarCampos()
        {
            txtCantidad.Text = String.Empty;
            
            txtPrecio.Text = String.Empty;
            txtImporte.Text = String.Empty;
            cboCliente.Focus();

        }
        

        
        private void añadirRegistro()
        {
            
            dt.Rows.Add(txtCantidad.Text, cboProducto.Text, txtPrecio.Text, txtImporte.Text);
            DGV.DataSource = dt;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                int[] x = { 12, 106, 427, 523 };
                int fechaX = 500;
                int fechaY = 90;
                int encabezadoX = 11;
                int encabezadoY = 50;
                int saldoAnteriorX = 102;
                int saldoAnteriorY = 250;
                int firstY = 142;
                int y = 142;
                int totalX = 516;
                int totalY = 249;
                int total = 0;
                Image facturaActual = facModelo;
                Graphics g = Graphics.FromImage(facturaActual);
                StringFormat formatter = new StringFormat();
                formatter.LineAlignment = StringAlignment.Center;
                formatter.Alignment = StringAlignment.Near;

                Font font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                SolidBrush brush = new SolidBrush(Color.Black);
                for (int i = 0; i < DGV.Rows.Count; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (i == 0)
                            g.DrawString(DGV.Rows[i].Cells[j].Value.ToString(), font, brush, new Point(x[j], firstY), formatter);
                        else
                            g.DrawString(DGV.Rows[i].Cells[j].Value.ToString(), font, brush, new Point(x[j], y), formatter);
                    }

                    y += 26;


                    Font fontFecha = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                    g.DrawString(txtDia.Text + "-" + txtMes.Text + "-" + txtAño.Text, fontFecha, brush, new Point(fechaX, fechaY), formatter);

                    total += Convert.ToInt32(DGV.Rows[i].Cells[3].Value.ToString());
                    Font fontEncabezado = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                    g.DrawString(txtDatosCliente.Text, fontEncabezado, brush, new Point(encabezadoX, encabezadoY), formatter);

                    Font fontSaldoAnterior = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                    g.DrawString(lbSaldoAnterior.Text + " " + "$" + " " + saldo.SaldoMes + "               " + "Paga:$ " + txtEntrada.Text + " " + "Debe:$ " + txtSalida.Text, fontSaldoAnterior, brush, new Point(saldoAnteriorX, saldoAnteriorY), formatter);


                    

                }
                font = new Font("Microsoft Sans Serif", 14, FontStyle.Bold);
                g.DrawString(total.ToString("0.00", CultureInfo.InvariantCulture), font, brush, new Point(totalX, totalY), formatter);







                Form f2 = new Form();
                f2.StartPosition = FormStartPosition.CenterScreen;
                f2.Show();
                
                f2.Validate();
                PictureBox pbox = new PictureBox();
                pbox.Image = facturaActual;
                pbox.SizeMode = PictureBoxSizeMode.AutoSize;
                f2.Width = pbox.Width + 17;
                f2.Height = pbox.Height + 37;
                f2.Controls.Add(pbox);
                InicializarControles();
                DialogResult dr = MessageBox.Show(string.Format("¿Imprimir la factura?"), "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.Yes)
                {
                     
                    imprimirFactura(facturaActual);
                    
                    
                    
                }
                else
                {
                    dr = DialogResult.Cancel;
                }



            }


        }


        private void InicializarControles()
        {
            txtAño.Clear();
            txtMes.Clear();
            txtDia.Clear();
            cboReparto.SelectedIndex = 0;
            cboCliente.SelectedIndex = 0;
            cboProducto.SelectedIndex = 0;
            txtCantidad.Clear();
            txtEntrada.Clear();
            txtSalida.Clear();
            DGV.DataSource = null;
            
        }

        private bool validarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();

            if (string.IsNullOrEmpty(txtAño.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtAño, "El campo no puede estar vacio");
            }
            if (cboCliente.SelectedIndex.Equals(0))
            {
                valido = false;
                errorProvider1.SetError(cboCliente, "El campo no es valido");
            }
            if (cboProducto.SelectedIndex.Equals(0))
            {
                valido = false;
                errorProvider1.SetError(cboProducto, "El campo no es valido");
            }
             
            if (string.IsNullOrEmpty(txtSaldoAnterior.Text.Trim()))
            {
                valido = false;
                errorProvider1.SetError(txtSaldoAnterior, "El campo no puede estar vacio. El minimo valor para este campo es 0");
            }
            return valido;
        }

        private Boolean imprimirFactura(Image facturaActual)
        {
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrintPage += (sender, e) => e.Graphics.DrawImage(facturaActual, 0, 0);
                pd.Print();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al imprimir la factura. Compruebe que la impresora esté conectada y encendida", "Advertencia");
                return false;
            }
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            cboReparto.SelectedIndex = 0;
            ClientesBD.CargarCombo(ref cboCliente);
            ProductosBD.CargarCombo(ref cboProducto);
        }

        private void cboCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Cliente cl = new Cliente();

            cl = (Cliente)cboCliente.SelectedItem;
            txtDatosCliente.Text = "Apellido y Nombre: " + cl.ApeNombre + Environment.NewLine + "CUIT: " + cl.CUIT + Environment.NewLine + "Domicilio: " + cl.Direccion + Environment.NewLine + "Telefono: " + cl.Telefono + Environment.NewLine + "Consumo habitual: " + cl.ConsumoHabitual;
            try
            {
                ObtenerSaldo();

                

            }
            catch (Exception)
            {

                throw;
            }
                        
        }

        private void ObtenerSaldo()
        {

            Cliente cl = new Cliente();
            cl = (Cliente)cboCliente.SelectedItem;
            decimal saldo = 0;



            saldo = SaldosBD.GetSaldo(cl.IdCliente);

            txtSaldoAnterior.Text = saldo.ToString();
        }

        private void cboProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Producto prod = new Producto();

            prod = (Producto)cboProducto.SelectedItem;
            txtDetalleProducto.Text = "Descripcion: " + prod.DescripcionProducto + Environment.NewLine + "Precio: " + "$" + prod.Precio + Environment.NewLine + "Estado: " + prod.Estado;
            txtPrecio.Text = prod.Precio.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtSaldoAnterior_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboReparto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int nroReparto = 0;
            nroReparto = cboReparto.SelectedIndex;
            cboCliente.Enabled = true;
            List<Cliente> lista = new List<Cliente>();
            lista = ClientesBD.FiltrarClientesReparto(nroReparto);
            ClientesBD.CargarCombo(ref cboCliente, nroReparto);
        }

        private void txtEntrada_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recibo = new Recibo();
            Cliente cliente = (Cliente)cboCliente.SelectedItem;
            recibo.Entrada = decimal.Parse(txtEntrada.Text);
            recibo.Salida = decimal.Parse(txtSalida.Text);
            recibo.SaldoA = decimal.Parse(txtSaldoAnterior.Text);

            decimal sumatoria = 0;

            foreach (DataGridViewRow row in DGV.Rows)
            {
                sumatoria += Convert.ToDecimal(row.Cells["Importe"].Value);
                
            }

            

            if (sumatoria == recibo.Entrada)
            {
                recibo.Salida = 0;
                txtSalida.Text = recibo.Salida.ToString();
                SaldosBD.ActualizarSaldoSuma(cliente, recibo.Entrada);
                txtSaldoAnterior.Text = SaldosBD.GetSaldo(cliente.IdCliente).ToString();
            }

            else
            {
                recibo.Salida = (sumatoria - recibo.Entrada);
                txtSalida.Text = recibo.Salida.ToString();
                decimal saldoAnterior = 0;
                saldoAnterior = SaldosBD.GetSaldo(cliente.IdCliente);
                decimal diferencia = 0;
                if (recibo.Entrada==recibo.Salida)
                {
                    diferencia = (recibo.Entrada - recibo.Salida) - recibo.Salida; ;
                }
                else
                {
                    diferencia = recibo.Entrada - recibo.Salida;
                }
                
                #region Posibles Soluciones
                //saldoAnterior + sumatoria - (recibo.Entrada - recibo.Salida);
                //saldoAnterior- (sumatoria - (recibo.Entrada-recibo.Salida));
                //((sumatoria + recibo.Entrada) - recibo.Salida);
                #endregion
                SaldosBD.ActualizarSaldoResta(cliente, diferencia);


                txtSaldoAnterior.Text = SaldosBD.GetSaldo(cliente.IdCliente).ToString();


            }

            

        }

        private void DeshabilitarIngreso()
        {
            txtDia.Enabled = false;
            txtMes.Enabled = false;
            txtAño.Enabled = false;
            cboCliente.Enabled = false;
            cboProducto.Enabled = false;
            txtCantidad.Enabled = false;
        }

        private void HabilitarPago()
        {
            lbDebe.Visible = true;
            lbPaga.Visible = true;
            txtEntrada.Visible = true;
            txtSalida.Visible = true;
        }

        private void txtEntrada_TextChanged_1(object sender, EventArgs e)
        {
            //recibo = new Recibo();
            //Cliente cliente = (Cliente)cboCliente.SelectedItem;
            //recibo.Entrada = decimal.Parse(txtEntrada.Text);
            //recibo.Salida = decimal.Parse(txtSalida.Text);

            //decimal sumatoria = 0;

            //foreach (DataGridViewRow row in DGV.Rows)
            //{
            //    sumatoria += Convert.ToDecimal(row.Cells["Importe"].Value);
            //}

            

            //if (sumatoria == recibo.Entrada)
            //{
            //    recibo.Salida = 0;
            //    txtSalida.Text = recibo.Salida.ToString();
            //    SaldosBD.ActualizarSaldoSuma(cliente, sumatoria);
            //}
            //else
            //{
            //    recibo.Salida = (sumatoria - recibo.Entrada);
            //     txtSalida.Text = recibo.Salida.ToString();
            //    decimal diferencia = 0;
            //    diferencia = (recibo.Entrada - recibo.Salida) + recibo.SaldoA;
            //    SaldosBD.ActualizarSaldoResta(cliente, diferencia);
            //}

            //cboCliente.SelectedIndex = 0;

        }

        private void txtFiltroCliente_TextChanged(object sender, EventArgs e)
        {
            string filtro = "";
            filtro = txtFiltroCliente.Text;
            ClientesBD.CargarComboFiltrado(ref cboCliente, filtro);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = DGV.SelectedRows[0];
            DGV.Rows.Remove(r);
        }
    }
}