namespace ControlSoderia.GUI
{
    partial class frmReparto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReparto));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nUEVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bORRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iMPRIMIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dgReparto = new System.Windows.Forms.DataGridView();
            this.cmnNroReparto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnSem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnSem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnSem3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmnSem4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReparto)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUEVOToolStripMenuItem,
            this.eDITARToolStripMenuItem,
            this.bORRARToolStripMenuItem,
            this.iMPRIMIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(851, 30);
            this.menuStrip1.TabIndex = 2;
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "BUSCAR POR Nº REPARTO";
            // 
            // dgReparto
            // 
            this.dgReparto.AllowUserToAddRows = false;
            this.dgReparto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReparto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cmnNroReparto,
            this.cmnCliente,
            this.cmnMes,
            this.cmnSem1,
            this.cmnSem2,
            this.cmnSem3,
            this.cmnSem4});
            this.dgReparto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgReparto.Location = new System.Drawing.Point(0, 30);
            this.dgReparto.MultiSelect = false;
            this.dgReparto.Name = "dgReparto";
            this.dgReparto.ReadOnly = true;
            this.dgReparto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReparto.Size = new System.Drawing.Size(851, 424);
            this.dgReparto.TabIndex = 5;
            this.dgReparto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgReparto_CellFormatting);
            this.dgReparto.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgReparto_CellPainting);
            // 
            // cmnNroReparto
            // 
            this.cmnNroReparto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.cmnNroReparto.HeaderText = "Numero de reparto";
            this.cmnNroReparto.Name = "cmnNroReparto";
            this.cmnNroReparto.ReadOnly = true;
            this.cmnNroReparto.Width = 96;
            // 
            // cmnCliente
            // 
            this.cmnCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnCliente.HeaderText = "Cliente";
            this.cmnCliente.Name = "cmnCliente";
            this.cmnCliente.ReadOnly = true;
            // 
            // cmnMes
            // 
            this.cmnMes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnMes.HeaderText = "Mes";
            this.cmnMes.Name = "cmnMes";
            this.cmnMes.ReadOnly = true;
            // 
            // cmnSem1
            // 
            this.cmnSem1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnSem1.HeaderText = "Semana 1";
            this.cmnSem1.Name = "cmnSem1";
            this.cmnSem1.ReadOnly = true;
            // 
            // cmnSem2
            // 
            this.cmnSem2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnSem2.HeaderText = "Semana 2";
            this.cmnSem2.Name = "cmnSem2";
            this.cmnSem2.ReadOnly = true;
            // 
            // cmnSem3
            // 
            this.cmnSem3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnSem3.HeaderText = "Semana 3";
            this.cmnSem3.Name = "cmnSem3";
            this.cmnSem3.ReadOnly = true;
            // 
            // cmnSem4
            // 
            this.cmnSem4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cmnSem4.HeaderText = "Semana 4";
            this.cmnSem4.Name = "cmnSem4";
            this.cmnSem4.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(505, 1);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 25);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // frmReparto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 454);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgReparto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(867, 493);
            this.Name = "frmReparto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Reparto]";
            this.Load += new System.EventHandler(this.frmReparto_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReparto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nUEVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bORRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iMPRIMIRToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgReparto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnNroReparto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnSem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnSem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnSem3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cmnSem4;
        private System.Windows.Forms.TextBox textBox1;
    }
}