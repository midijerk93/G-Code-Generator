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
    public partial class frmPartNum : Form
    {
        public frmPartNum()
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
                MessageBox.Show("Please enter the last four numbers of your part numbers.");
                this.ActiveControl = wpctextbox;
            }
            else
            {
                frmLathe frm = new frmLathe();
                frm = (frmLathe)Application.OpenForms["frmLathe"];
                frm.mainTextbox.Text += Environment.NewLine;
                frm.mainTextbox.Text += "0" + wpctextbox.Text;
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

}
