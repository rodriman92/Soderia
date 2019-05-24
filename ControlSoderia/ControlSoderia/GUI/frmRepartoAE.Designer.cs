namespace ControlSoderia.GUI
{
    partial class frmRepartoAE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepartoAE));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.txtDetalleSem1 = new System.Windows.Forms.TextBox();
            this.txtDetalleSem2 = new System.Windows.Forms.TextBox();
            this.txtDetalleSem3 = new System.Windows.Forms.TextBox();
            this.txtDetalleSem4 = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtMes = new System.Windows.Forms.TextBox();
            this.numReparto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(486, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reparto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Reparto primera semana";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Reparto segunda semana";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(486, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Reparto tercera semana";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(486, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Reparto cuarta semana";
            // 
            // cboCliente
            // 
            this.cboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(179, 12);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(263, 25);
            this.cboCliente.TabIndex = 1;
            this.cboCliente.SelectionChangeCommitted += new System.EventHandler(this.cboCliente_SelectionChangeCommitted);
            // 
            // txtDetalleSem1
            // 
            this.txtDetalleSem1.Location = new System.Drawing.Point(179, 60);
            this.txtDetalleSem1.Multiline = true;
            this.txtDetalleSem1.Name = "txtDetalleSem1";
            this.txtDetalleSem1.Size = new System.Drawing.Size(263, 43);
            this.txtDetalleSem1.TabIndex = 4;
            // 
            // txtDetalleSem2
            // 
            this.txtDetalleSem2.Location = new System.Drawing.Point(179, 116);
            this.txtDetalleSem2.Multiline = true;
            this.txtDetalleSem2.Name = "txtDetalleSem2";
            this.txtDetalleSem2.Size = new System.Drawing.Size(263, 44);
            this.txtDetalleSem2.TabIndex = 5;
            // 
            // txtDetalleSem3
            // 
            this.txtDetalleSem3.Location = new System.Drawing.Point(659, 60);
            this.txtDetalleSem3.Multiline = true;
            this.txtDetalleSem3.Name = "txtDetalleSem3";
            this.txtDetalleSem3.Size = new System.Drawing.Size(263, 43);
            this.txtDetalleSem3.TabIndex = 6;
            // 
            // txtDetalleSem4
            // 
            this.txtDetalleSem4.Location = new System.Drawing.Point(659, 116);
            this.txtDetalleSem4.Multiline = true;
            this.txtDetalleSem4.Name = "txtDetalleSem4";
            this.txtDetalleSem4.Size = new System.Drawing.Size(263, 44);
            this.txtDetalleSem4.TabIndex = 7;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(867, 179);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(55, 34);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Green;
            this.btnOk.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.Image")));
            this.btnOk.Location = new System.Drawing.Point(792, 179);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(55, 34);
            this.btnOk.TabIndex = 9;
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(702, 17);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(220, 25);
            this.txtMes.TabIndex = 10;
            this.txtMes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numReparto
            // 
            this.numReparto.Enabled = false;
            this.numReparto.Location = new System.Drawing.Point(547, 17);
            this.numReparto.Name = "numReparto";
            this.numReparto.Size = new System.Drawing.Size(61, 25);
            this.numReparto.TabIndex = 11;
            // 
            // frmRepartoAE
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(958, 236);
            this.Controls.Add(this.numReparto);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDetalleSem4);
            this.Controls.Add(this.txtDetalleSem3);
            this.Controls.Add(this.txtDetalleSem2);
            this.Controls.Add(this.txtDetalleSem1);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRepartoAE";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reparto";
            this.Load += new System.EventHandler(this.frmRepartoAE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.TextBox txtDetalleSem1;
        private System.Windows.Forms.TextBox txtDetalleSem2;
        private System.Windows.Forms.TextBox txtDetalleSem3;
        private System.Windows.Forms.TextBox txtDetalleSem4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox numReparto;
    }
}