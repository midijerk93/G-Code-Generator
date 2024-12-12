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
    public partial class frmMill : Form
    {
        public frmMill()
        {
            InitializeComponent();
        }

        private void partNum_Click(object sender, EventArgs e)
        {
            frmPartNum frm = new frmPartNum();
            frm.ShowDialog();
        }
    }
}
