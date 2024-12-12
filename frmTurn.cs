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
    public partial class frmTurn : Form
    {
        double rpm = 0;
        public frmTurn()
        {
            InitializeComponent();
            this.ActiveControl = materialtextbox;
        }

        string workPieceCord = turnWPC.turnwpc;

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
            if (double.TryParse(materialtextbox.Text, out double materialod))
            {

            }
            else
            {
                MessageBox.Show("Enter material dia. numerically only.");
                materialtextbox.Text = "";
            }
        }

        private void toolNumTextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(toolNumTextbox.Text, out double toolnum))
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

        private void turnodtextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(turnodtextbox.Text, out double turnod))
            {

            }
            else
            {
                MessageBox.Show("Enter turn O.D. numerically only.");
                turnodtextbox.Text = "";
            }
        }

        private void turnlengthtextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(turnlengthtextbox.Text, out double turnlength))
            {

            }
            else
            {
                MessageBox.Show("Enter turn length numerically only.");
                turnlengthtextbox.Text = "";
            }
        }

        private void noseradiustextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(noseradiustextbox.Text, out double noseradius))
            {

            }
            else
            {
                MessageBox.Show("Enter nose radius numerically only.");
                noseradiustextbox.Text = "";
            }
        }

        private void finishNoseRadiusTextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(finishNoseRadiusTextbox.Text, out double finishnoseradius))
            {

            }
            else
            {
                MessageBox.Show("Enter nose radius numerically only.");
                finishNoseRadiusTextbox.Text = "";
            }
        }

        private void depthOfCutTextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(depthOfCutTextbox.Text, out double depthofcut))
            {

            }
            else
            {
                MessageBox.Show("Enter depth of cut numerically only.");
                depthOfCutTextbox.Text = "";
            }
        }

        private void finishNumTextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(finishNumTextbox.Text, out double finishNum))
            {

            }
            else
            {
                MessageBox.Show("Enter finish tool number numerically only.");
                finishNumTextbox.Text = "";
            }
        }

        private void finishOffsetTextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(finishOffsetTextbox.Text, out double finishOffset))
            {

            }
            else
            {
                MessageBox.Show("Enter finish offset number numerically only.");
                finishOffsetTextbox.Text = "";
            }
        }

        private void chamferlengthtextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(chamferlengthtextbox.Text, out double anglelength))
            {

            }
            else
            {
                MessageBox.Show("Enter angle length numerically only.");
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
                MessageBox.Show("Enter angle numerically only.");
                angletextbox.Text = "";
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
            turnodtextbox.Text = "";
            turnlengthtextbox.Text = "";
            depthOfCutTextbox.Text = "";
            toolNumTextbox.Text = "";
            offsetNumTextbox.Text = "";
            insertTypeTextbox.Text = "";
            noseradiustextbox.Text = "";
            finishNumTextbox.Text = "";
            finishOffsetTextbox.Text = "";
            insertTypeFinishTextbox.Text = "";
            finishNoseRadiusTextbox.Text = "";
            DialogBox.Text = "";
            chamferlengthtextbox.Text = "";
            angletextbox.Text = "";
        }

        private void roughChamfer()
        {
            if (double.TryParse(materialtextbox.Text, out double materialdia))
            {

            }
            if (double.TryParse(turnodtextbox.Text, out double turnOD))
            {

            }
            if (double.TryParse(noseradiustextbox.Text, out double noseradius))
            {

            }
            if (double.TryParse(finishNoseRadiusTextbox.Text, out double finishNoseRadius))
            {

            }
            if (double.TryParse(depthOfCutTextbox.Text, out double depthpass))
            {

            }
            if (double.TryParse(angletextbox.Text, out double angle))
            {

            }
            if (double.TryParse(chamferlengthtextbox.Text, out double anglelength))
            {

            }

            //
            // Variables
            //
            double turnod = Math.Round(turnOD, 3);
            double excessStock = materialdia - turnod;
            double pass = Math.Round(depthpass * 2, 3);
            double passes = Math.Round(excessStock / pass, 3);
            string insert = insertTypeTextbox.Text.ToUpper();
            string fInsert = insertTypeFinishTextbox.Text.ToUpper();
            double radians = angle * (Math.PI / 180);
            double tan = Math.Tan(radians);
            double chamferTurnLength = Math.Round(anglelength + noseradius - .02, 3);
            double finishChamferTurnLength = Math.Round(anglelength + finishNoseRadius - .020, 3);
            double angledepth = Math.Round(tan * (chamferTurnLength + noseradius) * 2, 3);
            double finishangledepth = Math.Round(tan * (finishChamferTurnLength + noseradius) * 2, 3);
            double startdia = turnod - angledepth;
            double finishstartdia = turnod - finishangledepth;


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
                double nextstartdia = currentroughstartdia - pass;

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
            if (double.TryParse(turnodtextbox.Text, out double turnOD))
            {

            }
            if (double.TryParse(noseradiustextbox.Text, out double noseradius))
            {

            }
            if (double.TryParse(finishNoseRadiusTextbox.Text, out double finishNoseRadius))
            {

            }
            if (double.TryParse(depthOfCutTextbox.Text, out double depthpass))
            {

            }
            if (double.TryParse(angletextbox.Text, out double angle))
            {

            }
            if (double.TryParse(chamferlengthtextbox.Text, out double anglelength))
            {

            }

            //
            // Variables
            //
            double turnod = Math.Round(turnOD, 3);
            double excessStock = materialdia - turnod;
            double pass = Math.Round(depthpass * 2, 3);
            double passes = Math.Round(excessStock / pass, 3);
            string insert = insertTypeTextbox.Text.ToUpper();
            string fInsert = insertTypeFinishTextbox.Text.ToUpper();
            double radians = angle * (Math.PI / 180);
            double tan = Math.Tan(radians);
            double chamferTurnLength = Math.Round(anglelength + noseradius - .02, 3);
            double finishChamferTurnLength = Math.Round(anglelength + finishNoseRadius - .020, 3);
            double angledepth = Math.Round(tan * (chamferTurnLength + noseradius) * 2, 3);
            double finishangledepth = Math.Round(tan * (finishChamferTurnLength + noseradius) * 2, 3);
            double startdia = turnod - angledepth;
            double finishstartdia = turnod - finishangledepth;

            DialogBox.Text += "(ROUGH CHAMFER);";
            DialogBox.Text += Environment.NewLine;

            // Calculates number of passes for roughing chamfer
            if ((turnod - startdia) > pass)
            {

                // Variables
                double currentroughstartdia = turnod - pass;
                double nextstartdia = currentroughstartdia - pass;               
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
            if (double.TryParse(turnodtextbox.Text, out double turnOD))
            {

            }
            if (double.TryParse(noseradiustextbox.Text, out double noseradius))
            {

            }
            if (double.TryParse(finishNoseRadiusTextbox.Text, out double finishNoseRadius))
            {

            }
            if (double.TryParse(depthOfCutTextbox.Text, out double depthpass))
            {

            }
            if (double.TryParse(angletextbox.Text, out double angle))
            {

            }
            if (double.TryParse(chamferlengthtextbox.Text, out double anglelength))
            {

            }

            //
            // Variables
            //
            double turnod = Math.Round(turnOD, 3);
            double excessStock = materialdia - turnod;
            double pass = Math.Round(depthpass * 2, 3);
            double passes = Math.Round(excessStock / pass, 3);
            string insert = insertTypeTextbox.Text.ToUpper();
            string fInsert = insertTypeFinishTextbox.Text.ToUpper();
            double radians = angle * (Math.PI / 180);
            double tan = Math.Tan(radians);
            double chamferTurnLength = Math.Round(anglelength + noseradius - .02, 3);
            double finishChamferTurnLength = Math.Round(anglelength + finishNoseRadius - .020, 3);
            double angledepth = Math.Round(tan * (chamferTurnLength + noseradius) * 2, 3);
            double finishangledepth = Math.Round(tan * (finishChamferTurnLength + noseradius) * 2, 3);
            double startdia = turnod - angledepth;
            double finishstartdia = turnod - finishangledepth;

            DialogBox.Text += "(FINISH CHAMFER);";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 X" + (finishstartdia - .05) + ";";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G1 Z0. F.012;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G1 X" + finishstartdia + " Z-.02;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G1 X" + turnod + " Z-" + (finishChamferTurnLength + .02) + ";";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 X" + (materialdia + .5) + " Z.25;";
            DialogBox.Text += Environment.NewLine;
        }

        private void finishChamfer_45()
        {
            if (double.TryParse(materialtextbox.Text, out double materialdia))
            {

            }
            if (double.TryParse(turnodtextbox.Text, out double turnOD))
            {

            }
            if (double.TryParse(noseradiustextbox.Text, out double noseradius))
            {

            }
            if (double.TryParse(finishNoseRadiusTextbox.Text, out double finishNoseRadius))
            {

            }
            if (double.TryParse(angletextbox.Text, out double angle))
            {

            }
            if (double.TryParse(chamferlengthtextbox.Text, out double anglelength))
            {

            }

            //
            // Variables
            //
            double turnod = Math.Round(turnOD, 3);
            double radians = angle * (Math.PI / 180);
            double tan = Math.Tan(radians);
            double finishChamferTurnLength = Math.Round(anglelength + finishNoseRadius - .020, 3);
            double finishangledepth = Math.Round(tan * (finishChamferTurnLength + noseradius) * 2, 3);
            double finishstartdia = turnod - finishangledepth;

            DialogBox.Text += "(FINISH CHAMFER);";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 X" + finishstartdia + ";";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G1 Z0. F.012;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G1 X" + turnod + " Z-" + finishChamferTurnLength + ";";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 X" + (materialdia + .5) + " Z.25;";
            DialogBox.Text += Environment.NewLine;
        }

        private void generateGCodeButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(materialtextbox.Text, out double materialdia))
            {

            }
            if (double.TryParse(turnodtextbox.Text, out double turnOD))
            {

            }
            if (double.TryParse(toolNumTextbox.Text, out double toolnum))
            {

            }
            if (double.TryParse(offsetNumTextbox.Text, out double offsetnum))
            {

            }
            if (double.TryParse(finishNumTextbox.Text, out double finishToolNum))
            {

            }
            if (double.TryParse(finishOffsetTextbox.Text, out double finishToolOffset))
            {

            }
            if (double.TryParse(turnlengthtextbox.Text, out double turnlength))
            {

            }
            if (double.TryParse(noseradiustextbox.Text, out double noseradius))
            {

            }
            if (double.TryParse(finishNoseRadiusTextbox.Text, out double finishNoseRadius))
            {

            }
            if (double.TryParse(depthOfCutTextbox.Text, out double depthpass))
            {

            }
            if (double.TryParse(angletextbox.Text, out double angle))
            {

            }
            if (double.TryParse(chamferlengthtextbox.Text, out double anglelength))
            {

            }

            //
            // Variables
            //
            double turnod = Math.Round(turnOD, 3);
            double excessStock = materialdia - turnod;
            double pass = Math.Round(depthpass * 2, 3);
            double passes = Math.Round(excessStock / pass, 3);
            string insert = insertTypeTextbox.Text.ToUpper();
            string fInsert = insertTypeFinishTextbox.Text.ToUpper();
            double radians = angle * (Math.PI / 180);
            double tan = Math.Tan(radians);
            double chamferTurnLength = Math.Round(anglelength + noseradius - .02, 3);
            double finishChamferTurnLength = Math.Round(anglelength + finishNoseRadius -.020, 3);
            double angledepth = Math.Round(tan * (chamferTurnLength + noseradius) * 2, 3);
            double finishangledepth = Math.Round(tan * (finishChamferTurnLength + noseradius) * 2, 3);
            double startdia = turnod - angledepth;
            double finishstartdia = turnod - finishangledepth;
            MessageBox.Show(Convert.ToString("Roughing will take " + passes + " passes"));

            Maxrpmcheck(turnod);

            // Write program to Dialog Box
            //
            // Rough passes
            //
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

            DialogBox.Text += "(ROUGH TURN);";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += workPieceCord + ";";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "M8";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G50 S" + rpm + "(MAX RPM);";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G96 S650 M3(SURFACE FOOTAGE);";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G28 U0.;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 Z.1;";
            DialogBox.Text += Environment.NewLine;

            // Calculates amount of passes and loops through to take amount of passes
            double currentTurn = materialdia - pass;

            while (passes > 1)
            {
                DialogBox.Text += "G0 X" + (currentTurn) + ";";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G1 Z-" + (turnlength - .003) + " F.012;";
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "G0 X" + (materialdia + .5) + " Z.25;";
                DialogBox.Text += Environment.NewLine;

                double nextTurn = currentTurn - pass;

                if (nextTurn < turnod)
                {
                    if (currentTurn > (turnod + .030))
                    {
                        DialogBox.Text += "G0 X" + (turnod + .030) + ";";
                        DialogBox.Text += Environment.NewLine;
                        DialogBox.Text += "G1 Z-" + (turnlength - .003) + " F.012;";
                        DialogBox.Text += Environment.NewLine;
                        DialogBox.Text += "G0 X" + (materialdia + .5) + " Z.25;";
                        DialogBox.Text += Environment.NewLine;
                    }
                    
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

                    DialogBox.Text += "G28 U0.;";
                    DialogBox.Text += Environment.NewLine;
                    DialogBox.Text += "G0 Z6.;";
                    DialogBox.Text += Environment.NewLine;
                    DialogBox.Text += "M1;";
                }                  
               
                passes -= 1;
                currentTurn -= pass;

            }

            //
            // Finish pass //
            //
            // Converts tool number and offset numbers to have 0 in front or nothing in front
            if (finishToolNum < 10)
            {
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "T0" + finishToolNum;
                if (finishToolOffset < 10)
                {
                    DialogBox.Text += "0" + finishToolOffset + "(" + fInsert + ")";
                    DialogBox.Text += Environment.NewLine;
                }
                if (finishToolOffset >= 10)
                {
                    DialogBox.Text += finishToolOffset + "(" + fInsert + ")";
                    DialogBox.Text += Environment.NewLine;
                }
            }
            if (finishToolNum >= 10)
            {
                DialogBox.Text += Environment.NewLine;
                DialogBox.Text += "T" + finishToolNum;
                if (finishToolOffset < 10)
                {
                    DialogBox.Text += "0" + finishToolOffset + "(" + fInsert + ")";
                    DialogBox.Text += Environment.NewLine;
                }
                if (finishToolOffset >= 10)
                {
                    DialogBox.Text += finishToolOffset + "(" + fInsert + ")";
                    DialogBox.Text += Environment.NewLine;                  
                }
            }

            DialogBox.Text += "(FINISH TURN);";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G54;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "M8";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G50 S" + rpm + "(MAX RPM);";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G96 S850 M3(SURFACE FOOTAGE);";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G28 U0.;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 Z.1;";
            DialogBox.Text += Environment.NewLine;
            
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

            DialogBox.Text += "G0 X" + (turnod) + ";";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G1 X" + turnod +  " Z-" + turnlength + " F.012" + "(TAPER);";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 X" + (materialdia + .5) + " Z.25;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G28 U0.;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "G0 Z6.;";
            DialogBox.Text += Environment.NewLine;
            DialogBox.Text += "M1;";
            DialogBox.Text += Environment.NewLine;

        }

    }
}
