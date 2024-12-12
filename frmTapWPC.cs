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
    public partial class frmTapWPC : Form
    {
        public frmTapWPC()
        {
            InitializeComponent();
            this.ActiveControl = wpctextbox;
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
                MessageBox.Show("Please enter WPC before continuing.");
                this.ActiveControl = wpctextbox;
            }
            else
            {
                tapWPC.tapwpc = wpctextbox.Text;
                frmTap frm = new frmTap();
                frm.ShowDialog();
                this.Close();
            }
        }

        private void wpctextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                okButton_Click(this, new EventArgs());
            }
        }
    }

    public static class tapWPC
    {
        public static string tapwpc { get; set; }
    }
}
