namespace ControlSoderia.GUI
{
    partial class frmSaldoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaldoCliente));
            this.menuProducto = new System.Windows.Forms.MenuStrip();
            this.iMPRIMIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgSaldo = new System.Windows.Forms.DataGridView();
            this.vistaSaldoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.controlSoderiaDataSet = new ControlSoderia.ControlSoderiaDataSet();
            this.vistaSaldoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.controlSoderiaDataSet3 = new ControlSoderia.ControlSoderiaDataSet3();
            this.vistaSaldoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaSaldoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vista_SaldoTableAdapter2 = new ControlSoderia.ControlSoderiaDataSet3TableAdapters.Vista_SaldoTableAdapter();
            this.vista_SaldoTableAdapter = new ControlSoderia.ControlSoderiaDataSetTableAdapters.Vista_SaldoTableAdapter();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apeNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaSaldoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlSoderiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaSaldoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlSoderiaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaSaldoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaSaldoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuProducto
            // 
            this.menuProducto.AllowMerge = false;
            this.menuProducto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuProducto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iMPRIMIRToolStripMenuItem});
            this.menuProducto.Location = new System.Drawing.Point(0, 0);
            this.menuProducto.Name = "menuProducto";
            this.menuProducto.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuProducto.Size = new System.Drawing.Size(765, 30);
            this.menuProducto.TabIndex = 1;
            this.menuProducto.Text = "menuStrip1";
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
            // dgSaldo
            // 
            this.dgSaldo.AllowUserToAddRows = false;
            this.dgSaldo.AutoGenerateColumns = false;
            this.dgSaldo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaldo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.apeNombreDataGridViewTextBoxColumn,
            this.sumaDataGridViewTextBoxColumn});
            this.dgSaldo.DataSource = this.vistaSaldoBindingSource3;
            this.dgSaldo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSaldo.Location = new System.Drawing.Point(0, 30);
            this.dgSaldo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgSaldo.MultiSelect = false;
            this.dgSaldo.Name = "dgSaldo";
            this.dgSaldo.ReadOnly = true;
            this.dgSaldo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSaldo.Size = new System.Drawing.Size(765, 424);
            this.dgSaldo.TabIndex = 2;
            // 
            // vistaSaldoBindingSource3
            // 
            this.vistaSaldoBindingSource3.DataMember = "Vista_Saldo";
            this.vistaSaldoBindingSource3.DataSource = this.controlSoderiaDataSet;
            // 
            // controlSoderiaDataSet
            // 
            this.controlSoderiaDataSet.DataSetName = "ControlSoderiaDataSet";
            this.controlSoderiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaSaldoBindingSource2
            // 
            this.vistaSaldoBindingSource2.DataMember = "Vista_Saldo";
            this.vistaSaldoBindingSource2.DataSource = this.controlSoderiaDataSet3;
            // 
            // controlSoderiaDataSet3
            // 
            this.controlSoderiaDataSet3.DataSetName = "ControlSoderiaDataSet3";
            this.controlSoderiaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vistaSaldoBindingSource
            // 
            this.vistaSaldoBindingSource.DataMember = "Vista_Saldo";
            // 
            // vistaSaldoBindingSource1
            // 
            this.vistaSaldoBindingSource1.DataMember = "Vista_Saldo";
            // 
            // vista_SaldoTableAdapter2
            // 
            this.vista_SaldoTableAdapter2.ClearBeforeFill = true;
            // 
            // vista_SaldoTableAdapter
            // 
            this.vista_SaldoTableAdapter.ClearBeforeFill = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "IdCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "Cod Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apeNombreDataGridViewTextBoxColumn
            // 
            this.apeNombreDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apeNombreDataGridViewTextBoxColumn.DataPropertyName = "ApeNombre";
            this.apeNombreDataGridViewTextBoxColumn.HeaderText = "Ape / Nombre";
            this.apeNombreDataGridViewTextBoxColumn.Name = "apeNombreDataGridViewTextBoxColumn";
            this.apeNombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumaDataGridViewTextBoxColumn
            // 
            this.sumaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sumaDataGridViewTextBoxColumn.DataPropertyName = "Suma";
            this.sumaDataGridViewTextBoxColumn.HeaderText = "Saldo";
            this.sumaDataGridViewTextBoxColumn.Name = "sumaDataGridViewTextBoxColumn";
            this.sumaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmSaldoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 454);
            this.Controls.Add(this.dgSaldo);
            this.Controls.Add(this.menuProducto);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(781, 493);
            this.Name = "frmSaldoCliente";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Saldos]";
            this.Load += new System.EventHandler(this.frmSaldoCliente_Load);
            this.menuProducto.ResumeLayout(false);
            this.menuProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaSaldoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlSoderiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaSaldoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlSoderiaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaSaldoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaSaldoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuProducto;
        private System.Windows.Forms.ToolStripMenuItem iMPRIMIRToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgSaldo;
        
        private System.Windows.Forms.BindingSource vistaSaldoBindingSource;
        
        private System.Windows.Forms.BindingSource vistaSaldoBindingSource1;
        
        private ControlSoderiaDataSet3 controlSoderiaDataSet3;
        private System.Windows.Forms.BindingSource vistaSaldoBindingSource2;
        private ControlSoderiaDataSet3TableAdapters.Vista_SaldoTableAdapter vista_SaldoTableAdapter2;
        private ControlSoderiaDataSet controlSoderiaDataSet;
        private System.Windows.Forms.BindingSource vistaSaldoBindingSource3;
        private ControlSoderiaDataSetTableAdapters.Vista_SaldoTableAdapter vista_SaldoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apeNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumaDataGridViewTextBoxColumn;
    }
}