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

            //
            // Variables
            //
            double turnod = Math.Round(materialdia, 3);
            double pass = Math.Round(depthofcut * 2, 3);
            double radians = angle * (Math.PI / 180);
            double tan = Math.Tan(radians);
            double chamferTurnLength = Math.Round(anglelength + noseradius - .02, 3);
            double angledepth = Math.Round(tan * (chamferTurnLength + noseradius) * 2, 3);
            double startdia = turnod - angledepth;


            //
            // Start chamfering
            //
            DialogBox.Text += "(ROUGH CHAMFER);";
            DialogBox.Text += Environment.NewLine;

            double chamferPasses = (turnod - startdia) / pass;

            // Calculates number of passes for roughing chamfer
            if (chamferPasses > 1)
            {
                // Variables
                double currentroughstartdia = turnod - pass;

                while (chamferPasses > 1)
                {

                    DialogBox.Text += "G0 X" + currentroughstartdia + ";";
                    DialogBox.Text += Environment.NewLine;
                    DialogBox.Text += "G1 Z0. F.012;";
                    DialogBox.Text += Environment.NewLine;
                    DialogBox.Text += "G1 X" + (turnod + .03) + " Z-" + (chamferTurnLength + .02) + ";";
                    DialogBox.Text += Environment.NewLine;
                    DialogBox.Text += "G0 X" + (turnod + .500) + " Z.25;";
                    DialogBox.Text += Environment.NewLine;

                    currentroughstartdia -= pass;
                    chamferPasses -= 1;

                    if (currentroughstartdia < (startdia + .03))
                    {
                        DialogBox.Text += "G0 X" + ((startdia + .030) - .05) + ";";
                        DialogBox.Text += Environment.NewLine;
                        DialogBox.Text += "G1 Z0. F.012;";
                        DialogBox.Text += Environment.NewLine;
                        DialogBox.Text += "G1 X" + (startdia + .030) + " Z-.02;";
                        DialogBox.Text += Environment.NewLine;
                        DialogBox.Text += "G1 X" + (turnod + .030) + " Z-" + (chamferTurnLength + .02) + ";";
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

            //
            // Variables
            //
            double turnod = Math.Round(materialdia, 3);
            double pass = Math.Round(depthofcut * 2, 3);
            double radians = angle * (Math.PI / 180);
            double tan = Math.Tan(radians);
            double chamferTurnLength = Math.Round(anglelength + noseradius, 3);
            double angledepth = Math.Round(tan * (chamferTurnLength + noseradius) * 2, 3);
            double startdia = turnod - angledepth;

            DialogBox.Text += "(ROUGH CHAMFER);";
            DialogBox.Text += Environment.NewLine;

            // Calculates number of passes for roughing chamfer
            if ((turnod - startdia) > pass)
            {

                // Variables
                double currentroughstartdia = turnod - pass;
                double chamferPasses = (turnod - startdia) / pass;

                while (chamferPasses > 1)
                {

                    DialogBox.Text += "G0 X" + currentroughstartdia + ";";
                    DialogBox.Text += Environment.NewLine;
                    DialogBox.Text += "G1 Z0. F.012;";
                    DialogBox.Text += Environment.NewLine;
                    DialogBox.Text += "G1 X" + turnod + " Z-" + chamferTurnLength + ";";
                    DialogBox.Text += Environment.NewLine;
                    DialogBox.Text += "G0 X" + (turnod + .500) + " Z.25;";
                    DialogBox.Text += Environment.NewLine;

                    currentroughstartdia -= pass;
                    chamferPasses -= 1;

                    if (currentroughstartdia < (startdia + .03))
                    {
                        DialogBox.Text += "G0 X" + (startdia + .030) + ";";
                        DialogBox.Text += Environment.NewLine;
                        DialogBox.Text += "G1 Z0. F.012;";
                        DialogBox.Text += Environment.NewLine;
                        DialogBox.Text += "G1 X" + (turnod + .030) + " Z-" + chamferTurnLength + ";";
                        DialogBox.Text += Environment.NewLine;
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

            //
            // Variables
            //
            double radians = angle * (Math.PI / 180);
            double tan = Math.Tan(radians);
            double chamferTurnLength = Math.Round(anglelength + noseradius - .023, 3);
            double finishChamferTurnLength = Math.Round(anglelength + noseradius - .02, 3);
            double angledepth = Math.Round(tan * (chamferTurnLength + noseradius) * 2, 3);
            double roughstartdia = (materialdia - angledepth) + .03;
            double finishstartdia = materialdia - angledepth;

            DialogBox.Text += "(FINISH CHAMFER);";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 X" + (finishstartdia - .05) + ";";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G1 Z0. F.012;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G1 X" + finishstartdia + " Z-.02;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G1 X" + materialdia + " Z-" + (finishChamferTurnLength + .02) + ";";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 X" + (materialdia + .5) + " Z.25;";
            DialogBox.Text += Environment.NewLine;
        }

        private void finishChamfer_45()
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

            //
            // Variables
            //
            double radians = angle * (Math.PI / 180);
            double tan = Math.Tan(radians);
            double finishChamferTurnLength = Math.Round(anglelength + noseradius, 3);
            double angledepth = Math.Round(tan * (finishChamferTurnLength + noseradius) * 2, 3);
            double finishstartdia = materialdia - angledepth;

            DialogBox.Text += "(FINISH CHAMFER);";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 X" + finishstartdia + ";";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G1 Z0. F.012;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G1 X" + materialdia + " Z-" + finishChamferTurnLength + ";";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 X" + (materialdia + .5) + " Z.25;";
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

            //
            // Variables
            //
            string insert = insertTypeFinishTextbox.Text.ToUpper();
            double radians = angle * (Math.PI / 180);
            double tan = Math.Tan(radians);
            double chamferTurnLength = Math.Round(anglelength + noseradius - .02, 3);
            double angledepth = Math.Round(tan * (chamferTurnLength + noseradius) * 2, 3);
            double startdia = materialdia - angledepth;
            double pass = depthofcut * 2;
            double chamferpasses = (materialdia - startdia) / pass;

            MessageBox.Show(Convert.ToString(chamferpasses));

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
                DialogBox.Text += "(ROUGH CHAMFER);";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += workPieceCord + ";";
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

                // Rough chamfer switch              
                switch (angle)
                {
                    // 0°-44.9°
                    case double i when i > 0 && i < 44.9:
                        roughChamfer();
                        break;
                    // 45°
                    case double i when i == 45:
                        roughChamfer_45();
                        break;
                    // 45.1°-90°
                    case double i when i > 45:
                        roughChamfer();
                        break;
                }


            }


            // Finish chamfer switch        
            switch (angle)
            {
                // 0°-44.9°
                case double i when i > 0 && i < 44.9:
                    finishChamfer();
                    break;
                // 45°
                case double i when i == 45:
                    finishChamfer_45();
                    break;
                // 45.1°-90°
                case double i when i > 45:
                    finishChamfer();
                    break;
            }

            DialogBox.Text += "G28 U0.;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 Z6.;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "M1;";

        }        

    }

}
