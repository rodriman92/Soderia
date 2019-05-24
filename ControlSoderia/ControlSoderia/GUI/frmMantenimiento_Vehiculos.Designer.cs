namespace ControlSoderia.GUI
{
    partial class frmMantenimiento_Vehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMantenimiento_Vehiculos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nUEVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bORRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMPRIMIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgMantenimiento = new System.Windows.Forms.DataGridView();
            this.cmnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnDominio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnFechaManten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnDetalleManten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnFechaProxManten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUEVOToolStripMenuItem,
            this.eDITARToolStripMenuItem,
            this.bORRARToolStripMenuItem,
            this.iMPRIMIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(16, 7, 0, 7);
            this.menuStrip1.Size = new System.Drawing.Size(765, 38);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nUEVOToolStripMenuItem
            // 
            this.nUEVOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nUEVOToolStripMenuItem.Image")));
            this.nUEVOToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nUEVOToolStripMenuItem.Name = "nUEVOToolStripMenuItem";
            this.nUEVOToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.nUEVOToolStripMenuItem.Text = "NUEVO";
            this.nUEVOToolStripMenuItem.Click += new System.EventHandler(this.nUEVOToolStripMenuItem_Click);
            // 
            // eDITARToolStripMenuItem
            // 
            this.eDITARToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eDITARToolStripMenuItem.Image")));
            this.eDITARToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eDITARToolStripMenuItem.Name = "eDITARToolStripMenuItem";
            this.eDITARToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.eDITARToolStripMenuItem.Text = "EDITAR";
            this.eDITARToolStripMenuItem.Click += new System.EventHandler(this.eDITARToolStripMenuItem_Click);
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
            // dgMantenimiento
            // 
            this.dgMantenimiento.AllowUserToAddRows = false;
            this.dgMantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMantenimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnDescripcion,
            this.cmnDominio,
            this.cmnFechaManten,
            this.cmnDetalleManten,
            this.cmnObservaciones,
            this.cmnFechaProxManten});
            this.dgMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMantenimiento.Location = new System.Drawing.Point(0, 38);
            this.dgMantenimiento.Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            this.dgMantenimiento.MultiSelect = false;
            this.dgMantenimiento.Name = "dgMantenimiento";
            this.dgMantenimiento.ReadOnly = true;
            this.dgMantenimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMantenimiento.Size = new System.Drawing.Size(765, 416);
            this.dgMantenimiento.TabIndex = 7;
            // 
            // cmnDescripcion
            // 
            this.cmnDescripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnDescripcion.HeaderText = "Descripcion del vehiculo";
            this.cmnDescripcion.Name = "cmnDescripcion";
            this.cmnDescripcion.ReadOnly = true;
            // 
            // cmnDominio
            // 
            this.cmnDominio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnDominio.HeaderText = "Dominio";
            this.cmnDominio.Name = "cmnDominio";
            this.cmnDominio.ReadOnly = true;
            // 
            // cmnFechaManten
            // 
            this.cmnFechaManten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cmnFechaManten.HeaderText = "Fecha de mantenimiento";
            this.cmnFechaManten.Name = "cmnFechaManten";
            this.cmnFechaManten.ReadOnly = true;
            this.cmnFechaManten.Width = 159;
            // 
            // cmnDetalleManten
            // 
            this.cmnDetalleManten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnDetalleManten.HeaderText = "Detalle de mantenimiento";
            this.cmnDetalleManten.Name = "cmnDetalleManten";
            this.cmnDetalleManten.ReadOnly = true;
            // 
            // cmnObservaciones
            // 
            this.cmnObservaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnObservaciones.HeaderText = "Observaciones";
            this.cmnObservaciones.Name = "cmnObservaciones";
            this.cmnObservaciones.ReadOnly = true;
            // 
            // cmnFechaProxManten
            // 
            this.cmnFechaProxManten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cmnFechaProxManten.HeaderText = "Fecha de prox mantenimiento";
            this.cmnFechaProxManten.Name = "cmnFechaProxManten";
            this.cmnFechaProxManten.ReadOnly = true;
            this.cmnFechaProxManten.Width = 187;
            // 
            // frmMantenimiento_Vehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 454);
            this.Controls.Add(this.dgMantenimiento);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(781, 493);
            this.Name = "frmMantenimiento_Vehiculos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Mantenimiento de vehiculos]";
            this.Load += new System.EventHandler(this.frmMantenimiento_Vehiculos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMantenimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nUEVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bORRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMPRIMIRToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgMantenimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnDominio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnFechaManten;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnDetalleManten;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnObservaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnFechaProxManten;
    }
}