using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Code_Lathe_Facing
{
    //
    // Things to do/add
    //
    // checking for previous tool, add multi turn capablity, update all forms for active controls on load

   

    public partial class frmLathe : Form
    {

        // Cannot have things between DLLImport and private static extern
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

      

        public frmLathe()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            // sets intial boot dialog for main textbox
            mainTextbox.Text += "%";

            this.ActiveControl = partNum;

        }      

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void facingButton_Click(object sender, EventArgs e)
        {
            frmFacingWPC frm = new frmFacingWPC();
            frm.ShowDialog();
        }

        private void turnButton_Click(object sender, EventArgs e)
        {
            frmTurnWPC frm = new frmTurnWPC();
            frm.ShowDialog();
        }

        private void drillButton_Click(object sender, EventArgs e)
        {
            frmDrill frm = new frmDrill();
            frm.ShowDialog();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            mainTextbox.Text = "%";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            mainTextbox.Text += "M30;";
            mainTextbox.Text += Environment.NewLine;
            mainTextbox.Text += "%";

            //   MessageBox.Show("This will allow you to export Main Textbox to .txt file in the future");

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.FilterIndex = 1;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, mainTextbox.Text);
                }
            }            
        }

        private void tap_Click(object sender, EventArgs e)
        {
            frmTap frm = new frmTap();
            frm.ShowDialog();
        }

        private void partNum_Click(object sender, EventArgs e)
        {
            frmPartNum frm = new frmPartNum();
            frm.ShowDialog();
        }

        private void boreButton_Click(object sender, EventArgs e)
        {
            frmBore frm = new frmBore();
            frm.ShowDialog();
        }

        private void flipButton_Click(object sender, EventArgs e)
        {
            mainTextbox.Text += "M0(FLIP PART);";
            mainTextbox.Text += Environment.NewLine;
        }

        private void chamferButton_Click(object sender, EventArgs e)
        {
            frmChamferWPC frm = new frmChamferWPC();
            frm.ShowDialog();
        }
    
    }

}
