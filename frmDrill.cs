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
    public partial class frmDrill : Form
    {
        public frmDrill()
        {
            InitializeComponent();
            this.ActiveControl = drilldiatextbox;
        }

        string workPieceCord = drillWPC.drilwpc;

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void drilldiatextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(drilldiatextbox.Text, out double drilldia))
            {

            }
            else
            {
                MessageBox.Show("Enter drill dia numerically only.");
                drilldiatextbox.Text = "";
            }
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

        private void drilldepthtextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(drilldepthtextbox.Text, out double drilldepth))
            {

            }
            else
            {
                MessageBox.Show("Enter drill depth numerically only.");
                drilldepthtextbox.Text = "";
            }
        }

        private void peckdepthtextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(peckdepthtextbox.Text, out double peckdepth))
            {

            }
            else
            {
                MessageBox.Show("Enter peck depth numerically only");
                peckdepthtextbox.Text = "";
            }
        }

        private void svtextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(svtextbox.Text, out double sv))
            {

            }
            else
            {
                MessageBox.Show("Enter surface footage numerically only");
                svtextbox.Text = "";
            }
        }

        private void frtextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(frtextbox.Text, out double fr))
            {

            }
            else
            {
                MessageBox.Show("Enter feedrate numerically only.");
                frtextbox.Text = "";
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
            drilldepthtextbox.Text = "";
            toolNumTextbox.Text = "";
            offsetNumTextbox.Text = "";
            drilldepthtextbox.Text = "";
            peckdepthtextbox.Text = "";
            svtextbox.Text = "";
            frtextbox.Text = "";
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
            if (double.TryParse(drilldiatextbox.Text, out double drilldia))
            {

            }
            if (double.TryParse(toolNumTextbox.Text, out double toolnum))
            {

            }
            if (double.TryParse(offsetNumTextbox.Text, out double offsetnum))
            {

            }
            if (double.TryParse(drilldepthtextbox.Text, out double drilldepth))
            {

            }
            if (double.TryParse(peckdepthtextbox.Text, out double peckdepth))
            {

            }
            if (double.TryParse(svtextbox.Text, out double sv))
            {

            }
            if (double.TryParse(frtextbox.Text, out double fr))
            {

            }
            if (double.TryParse(escapeztextbox.Text, out double escapez))
            {

            }

            // Variables
            // 
            // rpm calc. = 3.82 * sv / drill dia
            double rpm = Math.Round((3.82 * sv) / drilldia, 0);
            string insert = "(" + drilldia + " DRILL)";
            double q = peckdepth * 10000;

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

            DialogBox.Text += workPieceCord + ";";
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
                rpm = Math.Round((3.82 * sv) / drilldia, 0);
            }
            
            DialogBox.Text += "G97 S" + rpm + " M3;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G28 U0.;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 Z.25;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 X0.;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G83 Z-" + drilldepth + " R.25" + " F" + fr + " Q" + q  +";";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 Z.25;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G28 U0.;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += $"G0 Z{escapez:#.00};";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "M1;";


        }
      
    }
}
