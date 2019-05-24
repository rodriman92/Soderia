namespace ControlSoderia.GUI
{
    partial class frmRegistros_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistros_Ventas));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bORRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMPRIMIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAJADIARIAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgRegistros = new System.Windows.Forms.DataGridView();
            this.cmnDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnSaldoAnterior = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bORRARToolStripMenuItem,
            this.iMPRIMIRToolStripMenuItem,
            this.cAJADIARIAToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(765, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bORRARToolStripMenuItem
            // 
            this.bORRARToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bORRARToolStripMenuItem.Image")));
            this.bORRARToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bORRARToolStripMenuItem.Name = "bORRARToolStripMenuItem";
            this.bORRARToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.bORRARToolStripMenuItem.Text = "BORRAR";
            this.bORRARToolStripMenuItem.Click += new System.EventHandler(this.bORRARToolStripMenuItem_Click);
            // 
            // iMPRIMIRToolStripMenuItem
            // 
            this.iMPRIMIRToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("iMPRIMIRToolStripMenuItem.Image")));
            this.iMPRIMIRToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iMPRIMIRToolStripMenuItem.Name = "iMPRIMIRToolStripMenuItem";
            this.iMPRIMIRToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.iMPRIMIRToolStripMenuItem.Text = "IMPRIMIR";
            this.iMPRIMIRToolStripMenuItem.Click += new System.EventHandler(this.iMPRIMIRToolStripMenuItem_Click);
            // 
            // cAJADIARIAToolStripMenuItem
            // 
            this.cAJADIARIAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cAJADIARIAToolStripMenuItem.Image")));
            this.cAJADIARIAToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cAJADIARIAToolStripMenuItem.Name = "cAJADIARIAToolStripMenuItem";
            this.cAJADIARIAToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.cAJADIARIAToolStripMenuItem.Text = "DETALLE DE VENTAS";
            this.cAJADIARIAToolStripMenuItem.Click += new System.EventHandler(this.cAJADIARIAToolStripMenuItem_Click);
            // 
            // dgRegistros
            // 
            this.dgRegistros.AllowUserToAddRows = false;
            this.dgRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnDia,
            this.cmnMes,
            this.cmnAño,
            this.cmnCliente,
            this.cmnProductos,
            this.cmnCantidad,
            this.cmnPrecio,
            this.cmnImporte,
            this.cmnSaldoAnterior});
            this.dgRegistros.Location = new System.Drawing.Point(0, 23);
            this.dgRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.dgRegistros.MultiSelect = false;
            this.dgRegistros.Name = "dgRegistros";
            this.dgRegistros.ReadOnly = true;
            this.dgRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRegistros.Size = new System.Drawing.Size(765, 431);
            this.dgRegistros.TabIndex = 5;
            // 
            // cmnDia
            // 
            this.cmnDia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cmnDia.HeaderText = "Dia";
            this.cmnDia.Name = "cmnDia";
            this.cmnDia.ReadOnly = true;
            this.cmnDia.Width = 52;
            // 
            // cmnMes
            // 
            this.cmnMes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnMes.HeaderText = "Mes";
            this.cmnMes.Name = "cmnMes";
            this.cmnMes.ReadOnly = true;
            // 
            // cmnAño
            // 
            this.cmnAño.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnAño.HeaderText = "Año";
            this.cmnAño.Name = "cmnAño";
            this.cmnAño.ReadOnly = true;
            // 
            // cmnCliente
            // 
            this.cmnCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnCliente.HeaderText = "Cliente";
            this.cmnCliente.Name = "cmnCliente";
            this.cmnCliente.ReadOnly = true;
            // 
            // cmnProductos
            // 
            this.cmnProductos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnProductos.HeaderText = "Productos";
            this.cmnProductos.Name = "cmnProductos";
            this.cmnProductos.ReadOnly = true;
            // 
            // cmnCantidad
            // 
            this.cmnCantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cmnCantidad.HeaderText = "Cantidad";
            this.cmnCantidad.Name = "cmnCantidad";
            this.cmnCantidad.ReadOnly = true;
            this.cmnCantidad.Width = 85;
            // 
            // cmnPrecio
            // 
            this.cmnPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cmnPrecio.HeaderText = "Precio Un";
            this.cmnPrecio.Name = "cmnPrecio";
            this.cmnPrecio.ReadOnly = true;
            this.cmnPrecio.Width = 89;
            // 
            // cmnImporte
            // 
            this.cmnImporte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cmnImporte.HeaderText = "Importe";
            this.cmnImporte.Name = "cmnImporte";
            this.cmnImporte.ReadOnly = true;
            this.cmnImporte.Width = 79;
            // 
            // cmnSaldoAnterior
            // 
            this.cmnSaldoAnterior.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cmnSaldoAnterior.HeaderText = "Saldo Anterior";
            this.cmnSaldoAnterior.Name = "cmnSaldoAnterior";
            this.cmnSaldoAnterior.ReadOnly = true;
            this.cmnSaldoAnterior.Width = 117;
            // 
            // frmRegistros_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 454);
            this.Controls.Add(this.dgRegistros);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(781, 493);
            this.Name = "frmRegistros_Ventas";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Registros]";
            this.Load += new System.EventHandler(this.frmRegistros_Ventas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bORRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMPRIMIRToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnAño;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnImporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnSaldoAnterior;
        private System.Windows.Forms.ToolStripMenuItem cAJADIARIAToolStripMenuItem;
    }
}