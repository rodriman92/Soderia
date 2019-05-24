namespace ControlSoderia.GUI
{
    partial class frmFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatosCliente = new System.Windows.Forms.TextBox();
            this.lbSaldoAnterior = new System.Windows.Forms.Label();
            this.txtSaldoAnterior = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cboProducto = new System.Windows.Forms.ComboBox();
            this.txtDetalleProducto = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboReparto = new System.Windows.Forms.ComboBox();
            this.lbPaga = new System.Windows.Forms.Label();
            this.lbDebe = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFiltroCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio unitario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(234, 507);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Importe";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(300, 471);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(93, 25);
            this.txtCantidad.TabIndex = 9;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(118, 471);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(86, 25);
            this.txtPrecio.TabIndex = 7;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // txtImporte
            // 
            this.txtImporte.Enabled = false;
            this.txtImporte.Location = new System.Drawing.Point(300, 504);
            this.txtImporte.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(93, 25);
            this.txtImporte.TabIndex = 9;
            this.txtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(300, 558);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(93, 30);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(454, 77);
            this.DGV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(491, 447);
            this.DGV.TabIndex = 8;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(858, 24);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(87, 30);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Seleccionar cliente";
            // 
            // txtDatosCliente
            // 
            this.txtDatosCliente.Enabled = false;
            this.txtDatosCliente.Location = new System.Drawing.Point(21, 226);
            this.txtDatosCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtDatosCliente.Multiline = true;
            this.txtDatosCliente.Name = "txtDatosCliente";
            this.txtDatosCliente.Size = new System.Drawing.Size(372, 93);
            this.txtDatosCliente.TabIndex = 13;
            // 
            // lbSaldoAnterior
            // 
            this.lbSaldoAnterior.AutoSize = true;
            this.lbSaldoAnterior.Location = new System.Drawing.Point(184, 332);
            this.lbSaldoAnterior.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSaldoAnterior.Name = "lbSaldoAnterior";
            this.lbSaldoAnterior.Size = new System.Drawing.Size(91, 17);
            this.lbSaldoAnterior.TabIndex = 14;
            this.lbSaldoAnterior.Text = "Saldo anterior";
            // 
            // txtSaldoAnterior
            // 
            this.txtSaldoAnterior.Location = new System.Drawing.Point(328, 329);
            this.txtSaldoAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldoAnterior.Name = "txtSaldoAnterior";
            this.txtSaldoAnterior.Size = new System.Drawing.Size(65, 25);
            this.txtSaldoAnterior.TabIndex = 7;
            this.txtSaldoAnterior.Text = "0,00";
            this.txtSaldoAnterior.TextChanged += new System.EventHandler(this.txtSaldoAnterior_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 77);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Día:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 77);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mes:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 77);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Año:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(292, 74);
            this.txtAño.Margin = new System.Windows.Forms.Padding(2);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(101, 25);
            this.txtAño.TabIndex = 3;
            this.txtAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(303, 19);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(364, 32);
            this.label9.TabIndex = 19;
            this.label9.Text = "GENERAR RECIBO DE CONSUMO";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(149, 191);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(2);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(244, 25);
            this.cboCliente.TabIndex = 6;
            this.cboCliente.SelectionChangeCommitted += new System.EventHandler(this.cboCliente_SelectionChangeCommitted);
            // 
            // cboProducto
            // 
            this.cboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducto.FormattingEnabled = true;
            this.cboProducto.Location = new System.Drawing.Point(187, 367);
            this.cboProducto.Margin = new System.Windows.Forms.Padding(2);
            this.cboProducto.Name = "cboProducto";
            this.cboProducto.Size = new System.Drawing.Size(206, 25);
            this.cboProducto.TabIndex = 8;
            this.cboProducto.SelectionChangeCommitted += new System.EventHandler(this.cboProducto_SelectionChangeCommitted);
            // 
            // txtDetalleProducto
            // 
            this.txtDetalleProducto.Location = new System.Drawing.Point(22, 396);
            this.txtDetalleProducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtDetalleProducto.Multiline = true;
            this.txtDetalleProducto.Name = "txtDetalleProducto";
            this.txtDetalleProducto.Size = new System.Drawing.Size(371, 68);
            this.txtDetalleProducto.TabIndex = 22;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(79, 74);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(55, 25);
            this.txtDia.TabIndex = 1;
            this.txtDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(187, 74);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(55, 25);
            this.txtMes.TabIndex = 2;
            this.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 23;
            this.label10.Text = "Reparto";
            // 
            // cboReparto
            // 
            this.cboReparto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReparto.FormattingEnabled = true;
            this.cboReparto.Items.AddRange(new object[] {
            "↓",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cboReparto.Location = new System.Drawing.Point(80, 156);
            this.cboReparto.Name = "cboReparto";
            this.cboReparto.Size = new System.Drawing.Size(52, 25);
            this.cboReparto.TabIndex = 4;
            this.cboReparto.SelectionChangeCommitted += new System.EventHandler(this.cboReparto_SelectionChangeCommitted);
            // 
            // lbPaga
            // 
            this.lbPaga.AutoSize = true;
            this.lbPaga.Location = new System.Drawing.Point(451, 558);
            this.lbPaga.Name = "lbPaga";
            this.lbPaga.Size = new System.Drawing.Size(37, 17);
            this.lbPaga.TabIndex = 4;
            this.lbPaga.Text = "Paga";
            // 
            // lbDebe
            // 
            this.lbDebe.AutoSize = true;
            this.lbDebe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDebe.Location = new System.Drawing.Point(641, 558);
            this.lbDebe.Name = "lbDebe";
            this.lbDebe.Size = new System.Drawing.Size(40, 17);
            this.lbDebe.TabIndex = 4;
            this.lbDebe.Text = "Debe";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(518, 555);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(93, 25);
            this.txtEntrada.TabIndex = 11;
            this.txtEntrada.Text = "0,00";
            this.txtEntrada.TextChanged += new System.EventHandler(this.txtEntrada_TextChanged_1);
            // 
            // txtSalida
            // 
            this.txtSalida.Location = new System.Drawing.Point(687, 555);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(93, 25);
            this.txtSalida.TabIndex = 12;
            this.txtSalida.Text = "0,00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(852, 555);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Registrar pago";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(146, 159);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Buscar cliente";
            // 
            // txtFiltroCliente
            // 
            this.txtFiltroCliente.Location = new System.Drawing.Point(233, 156);
            this.txtFiltroCliente.Name = "txtFiltroCliente";
            this.txtFiltroCliente.Size = new System.Drawing.Size(160, 25);
            this.txtFiltroCliente.TabIndex = 5;
            this.txtFiltroCliente.TextChanged += new System.EventHandler(this.txtFiltroCliente_TextChanged);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 624);
            this.Controls.Add(this.txtFiltroCliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.cboReparto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtDetalleProducto);
            this.Controls.Add(this.cboProducto);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtSaldoAnterior);
            this.Controls.Add(this.lbSaldoAnterior);
            this.Controls.Add(this.txtDatosCliente);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lbDebe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPaga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmFactura";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "r";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatosCliente;
        private System.Windows.Forms.Label lbSaldoAnterior;
        private System.Windows.Forms.TextBox txtSaldoAnterior;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.ComboBox cboProducto;
        private System.Windows.Forms.TextBox txtDetalleProducto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.ComboBox cboReparto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label lbDebe;
        private System.Windows.Forms.Label lbPaga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFiltroCliente;
        private System.Windows.Forms.Label label11;
    }
}