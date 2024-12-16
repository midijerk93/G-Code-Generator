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
    public partial class frmChamfer : Form
    {

        double rpm = 0;

        public frmChamfer()
        {
            InitializeComponent();

            this.ActiveControl = materialtextbox;
        }

        string workPieceCord = chamferWPC.chamferwpc;

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

        private void roughChamfer()
        {
            if (double.TryParse(materialtextbox.Text, out double materialdia))
            {

            }
            if (double.TryParse(chamferlengthtextbox.Text, out double anglelength))
            {

            }
            if (double.TryParse(angletextbox.Text, out double angle))
            {

            }
            if (double.TryParse(finishNoseRadiusTextbox.Text, out double noseradius))
            {

            }
            if (double.TryParse(depthOfCutTextbox.Text, out double depthofcut))
            {

            }

            // Variables
            double turnod = Math.Round(materialdia, 3);
            double pass = Math.Round(depthofcut * 2, 3);
            double radians = angle * (Math.PI / 180);
            double tan = Math.Tan(radians);
            double chamferTurnLength = Math.Round(anglelength + noseradius - .02, 3);
            double angledepth = Math.Round(tan * chamferTurnLength * 2, 3);
            double startdia = turnod - angledepth;

            // Start chamfering

            double chamferPasses = (turnod - startdia) / pass;

            // Calculates number of passes for roughing chamfer
            if (chamferPasses > 1)
            {
                // Variables
                double currentroughstartdia = turnod - pass;

                while (chamferPasses > 1)
                {

                    DialogBox.Text += "G0 X" + currentroughstartdia.ToString("F4") + ";";
                    DialogBox.Text += Environment.NewLine;
                    DialogBox.Text += "G1 Z0. F.012;";
                    DialogBox.Text += Environment.NewLine;
                    DialogBox.Text += "G1 X" + (turnod + .03).ToString("F4") + " Z-" + (chamferTurnLength + .02).ToString("F4") + ";";
                    DialogBox.Text += Environment.NewLine;
                    DialogBox.Text += "G0 X" + (turnod + .500).ToString("F4") + " Z.25;";
                    DialogBox.Text += Environment.NewLine;

                    currentroughstartdia -= pass;
                    chamferPasses -= 1;

                    if (currentroughstartdia < (startdia + .03))
                    {
                        DialogBox.Text += "G0 X" + ((startdia + .030) - .05).ToString("F4") + ";";
                        DialogBox.Text += Environment.NewLine;
                        DialogBox.Text += "G1 Z0. F.012;";
                        DialogBox.Text += Environment.NewLine;
                        DialogBox.Text += "G1 X" + (startdia + .030).ToString("F4") + " Z-.02;";
                        DialogBox.Text += Environment.NewLine;
                        DialogBox.Text += "G1 X" + (turnod + .030).ToString("F4") + " Z-" + (chamferTurnLength + .02).ToString("F4") + ";";
                        DialogBox.Text += Environment.NewLine;
                    }

                }

            }
        }

        private void roughChamfer_45()
        {
            if (double.TryParse(materialtextbox.Text, out double materialdia))
            {

            }
            if (double.TryParse(chamferlengthtextbox.Text, out double anglelength))
            {

            }
            if (double.TryParse(angletextbox.Text, out double angle))
            {

            }
            if (double.TryParse(finishNoseRadiusTextbox.Text, out double noseradius))
            {

            }
            if (double.TryParse(depthOfCutTextbox.Text, out double depthofcut))
            {

            }

            // Variables
            double turnod = Math.Round(materialdia, 3);
            double pass = Math.Round(depthofcut * 2, 3);
            double chamferTurnLength = Math.Round(anglelength + noseradius, 3);
            double angledepth = chamferTurnLength * 2;
            double startdia = turnod - angledepth;
            double maxDepth = (turnod - angledepth) + .03;

            // Calculates number of passes for roughing chamfer
            if ((turnod - startdia) > pass)
            {

                // Variables
                double currentroughstartdia = turnod - pass;
                double chamferPasses = (turnod - startdia) / pass;

                while (chamferPasses > 1)
                {

                    DialogBox.Text += "G0 X" + currentroughstartdia.ToString("F4") + ";";
                    DialogBox.Text += Environment.NewLine;
                    DialogBox.Text += "G1 Z0. F.012;";
                    DialogBox.Text += Environment.NewLine;
                    DialogBox.Text += "G1 X" + turnod.ToString("F4") + " Z-" + chamferTurnLength.ToString("F4") + ";";
                    DialogBox.Text += Environment.NewLine;
                    DialogBox.Text += "G0 X" + (turnod + .500).ToString("F4") + " Z.25;";
                    DialogBox.Text += Environment.NewLine;

                    currentroughstartdia -= pass;
                    chamferPasses -= 1;

                    if (currentroughstartdia < maxDepth)
                    {
                        currentroughstartdia = maxDepth;
                    }

                }

            }
        }

        private void finishChamfer()
        {
            if (double.TryParse(materialtextbox.Text, out double materialdia))
            {

            }
            if (double.TryParse(chamferlengthtextbox.Text, out double anglelength))
            {

            }
            if (double.TryParse(angletextbox.Text, out double angle))
            {

            }
            if (double.TryParse(finishNoseRadiusTextbox.Text, out double noseradius))
            {

            }

            // Variables
            double radians = angle * (Math.PI / 180);
            double tan = Math.Tan(radians);
            double chamferTurnLength = Math.Round(anglelength + noseradius - .020, 3);
            double finishChamferTurnLength = Math.Round(anglelength + noseradius - .02, 3);
            double angledepth = Math.Round(tan * chamferTurnLength * 2, 3);
            double roughstartdia = (materialdia - angledepth) + .03;
            double finishstartdia = materialdia - angledepth;

            DialogBox.Text += "G0 X" + (materialdia + 1.000).ToString("F4") + " Z.1";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 X" + (finishstartdia - .05).ToString("F4") + ";";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G1 Z0. F.012;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G1 X" + finishstartdia.ToString("F4") + " Z-.02;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G1 X" + materialdia.ToString("F4") + " Z-" + (finishChamferTurnLength + .02).ToString("F4") + ";";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 X" + (materialdia + .5).ToString("F4") + " Z.25;";
            DialogBox.Text += Environment.NewLine;
        }

        private void FinishChamfer_45()
        {
            if (double.TryParse(materialtextbox.Text, out double materialdia))
            {

            }
            if (double.TryParse(chamferlengthtextbox.Text, out double anglelength))
            {

            }
            if (double.TryParse(angletextbox.Text, out double angle))
            {

            }
            if (double.TryParse(finishNoseRadiusTextbox.Text, out double noseradius))
            {

            }

            // Variables
            double finishChamferTurnLength = Math.Round(anglelength + noseradius, 3);
            double angledepth = finishChamferTurnLength * 2;
            double finishstartdia = materialdia - angledepth;

            DialogBox.Text += "G0 X" + (materialdia + 1.000).ToString("F4") + " Z.1";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 X" + finishstartdia.ToString("F4") + ";";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G1 Z0. F.012;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G1 X" + materialdia.ToString("F4") + " Z-" + finishChamferTurnLength.ToString("F4") + ";";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 X" + (materialdia + .5).ToString("F4") + " Z.25;";
            DialogBox.Text += Environment.NewLine;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void materialtextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(materialtextbox.Text, out double materialdia))
            {

            }
            else
            {
                MessageBox.Show("Enter material dia. numerically only.");
            }
        }

        private void depthOfCutTextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(depthOfCutTextbox.Text, out double depthOfCut))
            {

            }
            else
            {
                MessageBox.Show("Enter depth of cut numerically only.");
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
            }
        }

        private void finishNumTextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(finishNumTextbox.Text, out double finishNum))
            {

            }
            else
            {
                MessageBox.Show("Enter tool number numerically only");
            }
        }

        private void finishOffsetTextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(finishOffsetTextbox.Text, out double finishToolOffset))
            {

            }
            else
            {
                MessageBox.Show("Enter offset number numerically only");
            }
        }

        private void finishNoseRadiusTextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(finishNoseRadiusTextbox.Text, out double noseradius))
            {

            }
            else
            {
                MessageBox.Show("Enter nose radius numerically only");
            }
        }

        private void addToMainTextbox_Click(object sender, EventArgs e)
        {
            frmLathe frm = new frmLathe();
            frm = (frmLathe)Application.OpenForms["frmLathe"];
            frm.mainTextbox.Text += DialogBox.Text;
            this.Close();
        }

        private void cleardialogbox_Click(object sender, EventArgs e)
        {
            materialtextbox.Text = "";
            depthOfCutTextbox.Text = "";
            chamferlengthtextbox.Text = "";
            angletextbox.Text = "";
            finishNumTextbox.Text = "";
            finishOffsetTextbox.Text = "";
            insertTypeFinishTextbox.Text = "";
            finishNoseRadiusTextbox.Text = "";
        }

        private void generateGCodeButton_Click(object sender, EventArgs e)
        {

            if (double.TryParse(materialtextbox.Text, out double materialdia))
            {

            }
            if (double.TryParse(depthOfCutTextbox.Text, out double depthofcut))
            {

            }
            if (double.TryParse(chamferlengthtextbox.Text, out double anglelength))
            {

            }
            if (double.TryParse(angletextbox.Text, out double angle))
            {

            }
            if (double.TryParse(finishNumTextbox.Text, out double toolnum))
            {

            }
            if (double.TryParse(finishOffsetTextbox.Text, out double offsetnum))
            {

            }
            if (double.TryParse(finishNoseRadiusTextbox.Text, out double noseradius))
            {

            }

            // Variables
            string insert = insertTypeFinishTextbox.Text.ToUpper();
            double radians = angle * (Math.PI / 180);
            double tan = Math.Tan(radians);
            double chamferTurnLength = Math.Round(anglelength + noseradius, 3);
            double angledepth = Math.Round(tan * (chamferTurnLength + noseradius) * 2, 3);
            double startdia = materialdia - angledepth;
            double pass = depthofcut * 2;
            double chamferpasses = (materialdia - startdia) / pass;

            Maxrpmcheck(materialdia);


            if (chamferpasses > 1)
            {

                DialogBox.Text = "";

                DialogBox.Text += Environment.NewLine;

                // Converts tool number and offset numbers to have zero in front or nothing in front
                if (toolnum < 10)
                {
                    DialogBox.Text += "T0" + toolnum;
                    if (offsetnum < 10)
                    {
                        DialogBox.Text += "0" + offsetnum + "(" + insert + ")";
                        DialogBox.Text += Environment.NewLine;
                    }
                    if (offsetnum >= 10)
                    {
                        DialogBox.Text += offsetnum + "(" + insert + ")";
                        DialogBox.Text += Environment.NewLine;
                    }
                }
                if (toolnum >= 10)
                {
                    DialogBox.Text += "T" + toolnum;
                    if (offsetnum < 10)
                    {
                        DialogBox.Text += "0" + offsetnum + "(" + insert + ")";
                        DialogBox.Text += Environment.NewLine;
                    }
                    if (offsetnum >= 10)
                    {
                        DialogBox.Text += offsetnum + "(" + insert + ")";
                        DialogBox.Text += Environment.NewLine;
                    }
                }

                // starts rough chamfering g code
                DialogBox.Text += "(" + angle + "° ANGLE CHAMFER)";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G" + workPieceCord + ";";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "M8;";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G50 S" + rpm + "(MAX RPM);";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G96 S650 M3(SURFACE FOOTAGE);";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G28 U0.;";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G0 Z.1;";
                DialogBox.Text += Environment.NewLine;

                // rought chamfer if else
                if (angle == 45)
                {
                    roughChamfer_45();
                }
                else
                {                
                    roughChamfer();
                }

                // finish chamfer if else
                if (angle == 45)
                {
                    FinishChamfer_45();
                }
                else
                {
                    finishChamfer();
                }
            }

            if (chamferpasses <= 1)
            {

                DialogBox.Text = "";

                DialogBox.Text += Environment.NewLine;

                // Converts tool number and offset numbers to have zero in front or nothing in front
                if (toolnum < 10)
                {
                    DialogBox.Text += "T0" + toolnum;
                    if (offsetnum < 10)
                    {
                        DialogBox.Text += "0" + offsetnum + "(" + insert + ")";
                        DialogBox.Text += Environment.NewLine;
                    }
                    if (offsetnum >= 10)
                    {
                        DialogBox.Text += offsetnum + "(" + insert + ")";
                        DialogBox.Text += Environment.NewLine;
                    }
                }
                if (toolnum >= 10)
                {
                    DialogBox.Text += "T" + toolnum;
                    if (offsetnum < 10)
                    {
                        DialogBox.Text += "0" + offsetnum + "(" + insert + ")";
                        DialogBox.Text += Environment.NewLine;
                    }
                    if (offsetnum >= 10)
                    {
                        DialogBox.Text += offsetnum + "(" + insert + ")";
                        DialogBox.Text += Environment.NewLine;
                    }
                }

                // starts rough chamfering g code
                DialogBox.Text += "(" + angle + "° ANGLE CHAMFER)";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G" + workPieceCord + ";";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "M8;";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G50 S" + rpm + "(MAX RPM);";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G96 S650 M3(SURFACE FOOTAGE);";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G28 U0.;";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G0 Z.1;";
                DialogBox.Text += Environment.NewLine;

                // finish chamfer if else
                if (angle == 45)
                {
                    FinishChamfer_45();
                }
                else
                {
                    finishChamfer();
                }
            }

            DialogBox.Text += "G28 U0.;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 Z6.;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "M1;";

        }

    }

}
