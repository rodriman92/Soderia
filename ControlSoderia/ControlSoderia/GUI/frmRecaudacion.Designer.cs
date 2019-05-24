namespace ControlSoderia.GUI
{
    partial class frmRecaudacion
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
            this.dgRecaudacion = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecaudacion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecaudacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRecaudacion
            // 
            this.dgRecaudacion.AllowUserToAddRows = false;
            this.dgRecaudacion.AllowUserToDeleteRows = false;
            this.dgRecaudacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecaudacion.Location = new System.Drawing.Point(10, 45);
            this.dgRecaudacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgRecaudacion.Name = "dgRecaudacion";
            this.dgRecaudacion.ReadOnly = true;
            this.dgRecaudacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRecaudacion.Size = new System.Drawing.Size(822, 545);
            this.dgRecaudacion.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total de ventas en  $";
            // 
            // txtRecaudacion
            // 
            this.txtRecaudacion.Enabled = false;
            this.txtRecaudacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecaudacion.Location = new System.Drawing.Point(742, 10);
            this.txtRecaudacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRecaudacion.Name = "txtRecaudacion";
            this.txtRecaudacion.Size = new System.Drawing.Size(91, 29);
            this.txtRecaudacion.TabIndex = 2;
            this.txtRecaudacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmRecaudacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(842, 618);
            this.Controls.Add(this.txtRecaudacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgRecaudacion);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(858, 657);
            this.MinimumSize = new System.Drawing.Size(858, 657);
            this.Name = "frmRecaudacion";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Historial de ventas]";
            this.Load += new System.EventHandler(this.frmRecaudacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRecaudacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRecaudacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecaudacion;
    }
}