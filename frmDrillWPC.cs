using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Code_Lathe_Facing
{
    public partial class frmDrillWPC : Form
    {
        public frmDrillWPC()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (wpctextbox.Text == "")
            {
                MessageBox.Show("Please enter WPC before continuing");
                this.ActiveControl = wpctextbox;
            }
            else
            {
                drillWPC.drilwpc = wpctextbox.Text;
                frmDrill frm = new frmDrill();
                frm.ShowDialog();
                this.Close();
            }
        }
    }

    public static class drillWPC
    {
        public static string drilwpc { get; set; }
    }
}
