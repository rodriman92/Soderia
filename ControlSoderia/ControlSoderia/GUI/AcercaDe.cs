using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlSoderia.GUI
{
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();

            proc.StartInfo.FileName = "mailto:rodmancilla92@gmail.com?subject=ControlSoderiaRM";
            proc.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
