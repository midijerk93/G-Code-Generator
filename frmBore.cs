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
    public partial class frmBore : Form
    {
        double rpm = 0;

        public frmBore()
        {
            InitializeComponent();
            this.ActiveControl = startdiatextbox;
        }

        string workPieceCord = boreWPC.borewpc;

        private void Maxrpmcheck(double od)
        {
            if (od >= 0.0 && od <= 1.5)
            {
                rpm = 2500;
            }
            if (od >= 1.5 && od <= 2.0)
            {
                rpm = 2000;
            }
            if (od >= 2.0 && od <= 2.5)
            {
                rpm = 1500;
            }
            if (od >= 2.5 && od <= 4.00)
            {
                rpm = 1000;
            }
            if (od >= 4.00 && od <= 10.00)
            {
                rpm = Math.Round(3.82 * 650 / od, 2);
            }
            if (od >= 10.00)
            {
                rpm = Math.Round(3.82 * 650 / od, 2);
            }
        }

        private void toolNumTextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(toolNumTextbox.Text, out double toolnum))
            {

            }
            else
            {
                MessageBox.Show("Enter tool number numerically only");
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
                MessageBox.Show("Enter offset number numerically only");
                offsetNumTextbox.Text = "";
            }
        }

        private void noseradiustextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(noseradiustextbox.Text, out double noseradius))
            {

            }
            else
            {
                MessageBox.Show("Enter nose radius numerically only with a zero in front of the decimal");
                noseradiustextbox.Text = "";
            }
        }

        private void frtextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(frtextbox.Text, out double fr))
            {

            }
            else
            {
                MessageBox.Show("Enter feed rate numerically only");
                frtextbox.Text = "";
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

        private void chamferlengthtextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(chamferlengthtextbox.Text, out double chamferlength))
            {

            }
            else
            {
                MessageBox.Show("Enter chamfer length numerically only");
                chamferlengthtextbox.Text = "";
            }
        }

        private void angletextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(angletextbox.Text, out double angle))
            {

            }
            else
            {
                MessageBox.Show("Enter angle numerically only");
                angletextbox.Text = "";
            }
        }

        private void startdiatextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(startdiatextbox.Text, out double startdia))
            {

            }
            else
            {
                MessageBox.Show("Enter start numerically only");
                startdiatextbox.Text = "";
            }
        }

        private void boredepthtextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(boredepthtextbox.Text, out double boredepth))
            {

            }
            else
            {
                MessageBox.Show("Enter bore depth numerically only");
                boredepthtextbox.Text = "";
            }
        }

        private void depthofcuttextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(depthofcuttextbox.Text, out double depthcut))
            {

            }
            else
            {
                MessageBox.Show("Enter depth of cut numerically only");
                depthofcuttextbox.Text = "";
            }
        }

        private void borediatextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(boredepthtextbox.Text, out double boredia))
            {

            }
            else
            {
                MessageBox.Show("Enter bore dia numerically only");
                boredepthtextbox.Text = "";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
     
        private void clearButton_Click(object sender, EventArgs e)
        {
            toolNumTextbox.Text = "";
            offsetNumTextbox.Text = "";
            noseradiustextbox.Text = "";
            frtextbox.Text = "";
            svtextbox.Text = "";
            escapeztextbox.Text = "";
            chamferlengthtextbox.Text = "";
            angletextbox.Text = "";
            startdiatextbox.Text = "";
            boredepthtextbox.Text = "";
            depthofcuttextbox.Text = "";
            borediatextbox.Text = "";
            DialogBox.Text = "";
        }

        private void addToMainTextbox_Click(object sender, EventArgs e)
        {
            frmLathe frm = new frmLathe();
            frm = (frmLathe)Application.OpenForms["frmLathe"];
            frm.mainTextbox.Text += DialogBox.Text;
            this.Close();
        }
      
        private void generateGCodeButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                generateGCodeButton_Click(this, new EventArgs());
            }
        }

        private void generateGCodeButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(toolNumTextbox.Text, out double toolnum))
            {

            }
            if (double.TryParse(offsetNumTextbox.Text, out double offsetnum))
            {

            }
            if (double.TryParse(noseradiustextbox.Text, out double noseradius))
            {

            }
            if (double.TryParse(frtextbox.Text, out double fr))
            {

            }
            if (double.TryParse(svtextbox.Text, out double sv))
            {

            }
            if (double.TryParse(escapeztextbox.Text, out double escapez))
            {

            }
            if (double.TryParse(chamferlengthtextbox.Text, out double chamferlength))
            {

            }
            if (double.TryParse(angletextbox.Text, out double angle))
            {

            }
            if (double.TryParse(startdiatextbox.Text, out double startdia))
            {

            }
            if (double.TryParse(boredepthtextbox.Text, out double boredepth))
            {

            }
            if (double.TryParse(depthofcuttextbox.Text, out double depthofcut))
            {

            }
            if (double.TryParse(borediatextbox.Text, out double boredia))
            {

            }

            // Variables
            //
            string insert = "(BORINGBAR);";
            double excessStock = boredia - startdia;
            double pass = Math.Round(depthofcut * 2, 3);
            double passes = Math.Round(excessStock / pass, 3);
            double radians = angle * (Math.PI / 180);
            double tan = Math.Tan(radians);
            double chamferTurnLength = Math.Round(chamferlength + noseradius - .02, 3);
            double angledepth = Math.Round(tan * (chamferTurnLength + noseradius) * 2, 3);
            double chamferstartdia = boredia + angledepth;
            MessageBox.Show("Boring will take " + passes + " passes");

            Maxrpmcheck(startdia);

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
            DialogBox.Text += "G50 S" + rpm + "(MAXRPM);";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G96 S" + sv + " M3(SURFACE FOOTAGE);";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G28 U0.;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 Z.25;";
            DialogBox.Text += Environment.NewLine;

            Maxrpmcheck(boredia);

            // Calculates amount of passes and loops through to take amount of passes
            double currentTurn = startdia + pass;

            while (passes > 1)
            {
                DialogBox.Text += "G0 X" + (currentTurn) + ";";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G1 Z-" + (boredepth - .003) + " F" + fr + ";";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G0 X" + (currentTurn - .05) + " Z.25;";
                DialogBox.Text += Environment.NewLine;

                double nextTurn = currentTurn + pass;

                if (nextTurn > boredia)
                {
                    if (currentTurn < (boredia - .030))
                    {
                        DialogBox.Text += "G0 X" + (boredia - .030) + ";";
                        DialogBox.Text += Environment.NewLine;
                        DialogBox.Text += "G1 Z-" + (boredepth - .003) + " F" + fr + ";";
                        DialogBox.Text += Environment.NewLine;
                        DialogBox.Text += "G0 X" + (currentTurn - .05) + " Z.25;";
                        DialogBox.Text += Environment.NewLine;
                    }

                    double chamferPasses = (chamferstartdia - boredia) / pass;

                    if (angle > 0)
                    {
                        DialogBox.Text += "(BORE CHAMFER);";
                        DialogBox.Text += Environment.NewLine;



                        // Calculates number of passes for roughing chamfer
                        if ((chamferstartdia - boredia) > pass)
                        {
                            // Variables
                            double currentroughstartdia = boredia + pass;
                            double nextstartdia = currentroughstartdia + pass;

                            MessageBox.Show(Convert.ToString("Rough chamfering will take " + Math.Round(chamferPasses, 3) + " passes"));


                            while (chamferPasses > 1)
                            {

                                DialogBox.Text += "G0 X" + currentroughstartdia + ";";
                                DialogBox.Text += Environment.NewLine;
                                DialogBox.Text += "G1 Z0. F" + fr + ";";
                                DialogBox.Text += Environment.NewLine;
                                DialogBox.Text += "G1 X" + boredia + " Z-" + (chamferTurnLength + .02) + ";";
                                DialogBox.Text += Environment.NewLine;
                                DialogBox.Text += "G0 X" + (boredia - .050) + " Z.25;";
                                DialogBox.Text += Environment.NewLine;

                                currentroughstartdia += pass;
                                chamferPasses -= 1;

                                if (currentroughstartdia > (chamferstartdia - .03))
                                {
                                    DialogBox.Text += "G0 X" + (chamferstartdia + .05) + ";";
                                    DialogBox.Text += Environment.NewLine;
                                    DialogBox.Text += "G1 Z0. F" + fr + ";";
                                    DialogBox.Text += Environment.NewLine;
                                    DialogBox.Text += "G1 X" + chamferstartdia + " Z-.02;";
                                    DialogBox.Text += Environment.NewLine;
                                    DialogBox.Text += "G1 X" + boredia + " Z-" + (chamferTurnLength + .02) + ";";
                                    DialogBox.Text += Environment.NewLine;
                                    DialogBox.Text += "G0 X" + (boredia - .05) + " Z.25;";
                                    DialogBox.Text += Environment.NewLine;
                                }

                            }

                        }

                    }

                    DialogBox.Text += "G28 U0.;";
                    DialogBox.Text += Environment.NewLine;
                    DialogBox.Text += $"G0 Z{escapez:#.00};";
                    DialogBox.Text += Environment.NewLine;
                    DialogBox.Text += "M1;";
                }


                passes -= 1;
                currentTurn += pass;
            }

        }
    
    }
}

