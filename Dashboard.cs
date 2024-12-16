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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //private void millbutton_Click(object sender, EventArgs e)
        //{
            //frmMill frm = new frmMill();
            //frm.ShowDialog();
            //this.Close();
        //}

        private void lathebutton_Click(object sender, EventArgs e)
        {
            frmLathe frm = new frmLathe();
            frm.ShowDialog();
            this.Close();  
        }
    }
}
