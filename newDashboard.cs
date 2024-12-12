using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace G_Code_Lathe_Facing
{
    public partial class newDashboard : Form
    {

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

        public newDashboard()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = mainButton.Height;
            pnlNav.Top = mainButton.Top;
            pnlNav.Left = mainButton.Left;
            mainButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = mainButton.Height;
            pnlNav.Top = mainButton.Top;
            pnlNav.Left = mainButton.Left;
            mainButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void partNumberButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = partNumberButton.Height;
            pnlNav.Top = partNumberButton.Top;
            pnlNav.Left = partNumberButton.Left;
            partNumberButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void faceButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = faceButton.Height;
            pnlNav.Top = faceButton.Top;
            pnlNav.Left = faceButton.Left;
            faceButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void chamferButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = chamferButton.Height;
            pnlNav.Top = chamferButton.Top;
            pnlNav.Left = chamferButton.Left;
            chamferButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void turnButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = turnButton.Height;
            pnlNav.Top = turnButton.Top;
            pnlNav.Left = turnButton.Left;
            turnButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void drillButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = turnButton.Height;
            pnlNav.Top = turnButton.Top;
            pnlNav.Left = turnButton.Left;
            turnButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void boreButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = boreButton.Height;
            pnlNav.Top = boreButton.Top;
            pnlNav.Left = boreButton.Left;
            boreButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void tapButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = tapButton.Height;
            pnlNav.Top = tapButton.Top;
            pnlNav.Left = tapButton.Left;
            tapButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            pnlNav.Height = saveButton.Height;
            pnlNav.Top = saveButton.Top;
            pnlNav.Left = saveButton.Left;
            saveButton.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void mainButton_Leave(object sender, EventArgs e)
        {
            mainButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void partNumberButton_Leave(object sender, EventArgs e)
        {
            partNumberButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void faceButton_Leave(object sender, EventArgs e)
        {
            faceButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void chamferButton_Leave(object sender, EventArgs e)
        {
            chamferButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void turnButton_Leave(object sender, EventArgs e)
        {
            turnButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void drillButton_Leave(object sender, EventArgs e)
        {
            drillButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void boreButton_Leave(object sender, EventArgs e)
        {
            boreButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void tapButton_Leave(object sender, EventArgs e)
        {
            tapButton.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void saveButton_Leave(object sender, EventArgs e)
        {
            saveButton.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
