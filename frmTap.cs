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
    public partial class frmTap : Form
    {
        public frmTap()
        {
            InitializeComponent();
            this.ActiveControl = tapsizetextbox;
        }

        string workPieceCord = tapWPC.tapwpc;

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolNumTextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(toolNumTextbox.Text, out double toolNum))
            {

            }
            else
            {
                MessageBox.Show("Enter tool number numerically only.");
                toolNumTextbox.Text = "";
            }
        }

        private void offsetNumTextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(offsetNumTextbox.Text, out double offsetnum))
            {

            }
            else
            {
                MessageBox.Show("Enter offset number numerically only.");
                offsetNumTextbox.Text = "";
            }
        }

        private void tapdepthtextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(tapdepthtextbox.Text, out double tapDepth))
            {

            }
            else
            {
                MessageBox.Show("Enter tap depth numerically only.");
                tapdepthtextbox.Text = "";
            }
        }

        private void tapdiaTextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(tapdepthtextbox.Text, out double tapDia))
            {

            }
            else
            {
                MessageBox.Show("Enter tap dia numerically only.");
                tapdepthtextbox.Text = "";
            }
        }

        private void peckdepthtextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(pitchtextbox.Text, out double peckdepth))
            {

            }
            else
            {
                MessageBox.Show("Enter peck depth numerically only");
                pitchtextbox.Text = "";
            }
        }

        private void sfmtextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(sfmtextbox.Text, out double sfm))
            {

            }
            else
            {
                MessageBox.Show("Enter surface footage numerically only");
                sfmtextbox.Text = "";
            }
        }

        private void escapeztextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(escapeztextbox.Text, out double escapez))
            {

            }
            else
            {
                MessageBox.Show("Enter escape z numerically only");
                escapeztextbox.Text = "";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            tapdepthtextbox.Text = "";
            toolNumTextbox.Text = "";
            offsetNumTextbox.Text = "";
            tapdepthtextbox.Text = "";
            pitchtextbox.Text = "";
            sfmtextbox.Text = "";
            DialogBox.Text = "";
        }

        private void addToMainTextbox_Click(object sender, EventArgs e)
        {
            frmLathe frm = new frmLathe();
            frm = (frmLathe)Application.OpenForms["frmLathe"];
            frm.mainTextbox.Text += DialogBox.Text;
            this.Close();
        }

        private void generateGCodeButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(toolNumTextbox.Text, out double toolnum))
            {

            }
            if (double.TryParse(offsetNumTextbox.Text, out double offsetnum))
            {

            }
            if (double.TryParse(tapdepthtextbox.Text, out double tapDepth))
            {

            }
            if (double.TryParse(pitchtextbox.Text, out double pitch))
            {

            }
            if (double.TryParse(sfmtextbox.Text, out double sfm))
            {

            }
            if (double.TryParse(escapeztextbox.Text, out double escapez))
            {

            }
            if (double.TryParse(tapdiatextbox.Text, out double tapDia))
            {

            }

            // Variables
            // 
            // rpm calc. = 3.82 * sfm / tap dia
            double rpm = Math.Round((3.82 * sfm) / tapDia, 0);
            string tapSize = tapsizetextbox.Text;
            string insert = "(" + tapSize + " TAP)";

            DialogBox.Text += Environment.NewLine;

            // Converts tool number and offset numbers to have zero in front or nothing in front
            if (toolnum < 10)
            {
                DialogBox.Text += "T0" + toolnum;
                if (offsetnum < 10)
                {
                    DialogBox.Text += "0" + offsetnum + insert;
                    DialogBox.Text += Environment.NewLine;
                }
                if (offsetnum >= 10)
                {
                    DialogBox.Text += offsetnum + insert;
                    DialogBox.Text += Environment.NewLine;
                }
            }
            if (toolnum >= 10)
            {
                DialogBox.Text += "T" + toolnum;
                if (offsetnum < 10)
                {
                    DialogBox.Text += "0" + offsetnum + insert;
                    DialogBox.Text += Environment.NewLine;
                }
                if (offsetnum >= 10)
                {
                    DialogBox.Text += offsetnum + insert;
                    DialogBox.Text += Environment.NewLine;
                }
            }

            DialogBox.Text += "G" + workPieceCord + ";";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "M8;";
            DialogBox.Text += Environment.NewLine;

            // checks to make sure rpm is not to much
            // if rpm is higher than 2500 it sets rpm at 2500
            if (rpm > 2500)
            {
                rpm = 2500;
            }
            else
            {
                rpm = Math.Round((3.82 * sfm) / tapDia, 0);
            }
            
            DialogBox.Text += "G97 S" + rpm + " M3;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G28 U0.;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 Z.25;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 X0.;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G32 Z-" + tapDepth + " R.25" + " F" + pitch.ToString("F5") +" M3;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G32 Z.25 F" + pitch.ToString("F4") + " M4;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 Z.25;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G28 U0.;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += $"G0 Z{escapez:#.00};";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "M1;";
            DialogBox.Text += Environment.NewLine;
        }
    }
}
