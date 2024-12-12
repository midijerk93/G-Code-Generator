using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Code_Lathe_Facing
{
    public partial class frmFacing : Form
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

        double rpm = 0;

        string workpiececord = facingWPC.facingwpc.ToUpper();

        public frmFacing()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.ActiveControl = odTextbox;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void odTextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(odTextbox.Text, out double od))
            {

            }
            else
            {
                MessageBox.Show("");
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
                offsetNumTextbox.Text = "";
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

        private void startabovetextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(startabovetextbox.Text, out double startabove))
            {

            }
            else
            {
                MessageBox.Show("Enter start above numerically only");
                startabovetextbox.Text = "";
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

        private void clearbutton_Click(object sender, EventArgs e)
        {
            odTextbox.Text = "";
            toolNumTextbox.Text = "";
            offsetNumTextbox.Text = "";
            startabovetextbox.Text = "";
            insertTypeTextbox.Text = "";
            facingstocktextbox.Text = "";
            depthperpasstextbox.Text = "";
            escapeztextbox.Text = "";
            DialogBox.Text = "";
        }

        private void facingstocktextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(facingstocktextbox.Text, out double facingstock))
            {

            }
            else
            {
                MessageBox.Show("Enter facing stock numerically only");
                facingstocktextbox.Text = "";
            }
        }

        private void depthperpasstextbox_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(depthperpasstextbox.Text, out double depthpass))
            {

            }
            else
            {
                MessageBox.Show("Enter depth per pass numerically only");
                depthperpasstextbox.Text = "";
            }
        }

        private void addToMainTextbox_Click(object sender, EventArgs e)
        {
            frmLathe frm = new frmLathe();
            frm = (frmLathe)Application.OpenForms["frmLathe"];
            frm.mainTextbox.Text += DialogBox.Text;
            this.Close();
                
        }

        // 3.82 * SF / DIA = RPM
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

        private void generateGCodeButton_Click(object sender, EventArgs e)
        {

            if (double.TryParse(offsetNumTextbox.Text, out double offsetnum))
            {

            }
            if (double.TryParse(toolNumTextbox.Text, out double toolnum))
            {

            }
            if (double.TryParse(facingstocktextbox.Text, out double facingstock))
            {

            }
            if (double.TryParse(depthperpasstextbox.Text, out double depthpass))
            {

            }
            if (double.TryParse(escapeztextbox.Text, out double escapez))
            {

            }
            if (double.TryParse(odTextbox.Text, out double od))
            
            {
                if (double.TryParse(startabovetextbox.Text, out double startabove))
                {
                    if (double.TryParse(offsetNumTextbox.Text, out double offset))
                    {

                        // Variables
                        double odCut = od + startabove;
                        string insert = insertTypeTextbox.Text.ToUpper();
                        double passes = facingstock / depthpass;

                        Maxrpmcheck(od);

                        DialogBox.Text += Environment.NewLine;

                        // Converts tool number and offset numbers to have zero in front or nothing in front
                        if (toolnum < 10)
                        {
                            DialogBox.Text += "T0" + toolnum;
                            if (offsetnum < 10)
                            {
                                DialogBox.Text += "0" + offsetnum + "(" + insert + ");";
                                DialogBox.Text += Environment.NewLine;
                            }
                            if (offsetnum >= 10)
                            {
                                DialogBox.Text += offsetnum + "(" + insert + ");";
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

                        // Generics
                        DialogBox.Text += "(FACING);";
                        DialogBox.Text += Environment.NewLine;
                        DialogBox.Text += workpiececord + ";";
                        DialogBox.Text += Environment.NewLine;
                        DialogBox.Text += "M8;";
                        DialogBox.Text += Environment.NewLine;
                        DialogBox.Text += "G50 S" + rpm + ";";
                        DialogBox.Text += Environment.NewLine;
                        DialogBox.Text += "G96 S650 M3;";
                        DialogBox.Text += Environment.NewLine;
                        DialogBox.Text += "G28 U0.";
                        DialogBox.Text += Environment.NewLine;

                        // sets variable for pass calculation
                        double currentz = facingstock - depthpass;

                        // Starts while loop for amount of passes
                        if (passes > 1)
                        {
                            while (passes > 1)
                            {
                                DialogBox.Text += "G0 Z" + currentz + ";";
                                DialogBox.Text += Environment.NewLine;
                                DialogBox.Text += "G0 X" + odCut + ";";
                                DialogBox.Text += Environment.NewLine;
                                DialogBox.Text += "G1 X-.05 F.010;";
                                DialogBox.Text += Environment.NewLine;
                                DialogBox.Text += "G0 Z" + (currentz + .1) + ";";
                                DialogBox.Text += Environment.NewLine;
                                DialogBox.Text += "G0 X" + odCut + ";";
                                DialogBox.Text += Environment.NewLine;

                                double nextz = currentz - depthpass;

                                if (nextz < depthpass)
                                {

                                    DialogBox.Text += "G0 Z0.;";
                                    DialogBox.Text += Environment.NewLine;
                                    DialogBox.Text += "G1 X-.05 F.010;";
                                    DialogBox.Text += Environment.NewLine;
                                    DialogBox.Text += "G0 Z.100;";
                                    DialogBox.Text += Environment.NewLine;
                                    DialogBox.Text += "G28 U0.;";
                                    DialogBox.Text += Environment.NewLine;
                                    DialogBox.Text += $"G0 Z{escapez:#.00};";
                                    DialogBox.Text += Environment.NewLine;
                                    DialogBox.Text += "M1;";

                                }

                                passes -= 1;
                                currentz -= depthpass;
                            }
                           
                        }                       
                        else if (passes <= 1)
                        {
                            DialogBox.Text += "G0 Z0.;";
                            DialogBox.Text += Environment.NewLine;
                            DialogBox.Text += "G0 X" + odCut + ";";
                            DialogBox.Text += Environment.NewLine;
                            DialogBox.Text += "G1 X-.05 F.010;";
                            DialogBox.Text += Environment.NewLine;
                            DialogBox.Text += "G0 Z.100;";
                            DialogBox.Text += Environment.NewLine;
                            DialogBox.Text += "G28 U0.;";
                            DialogBox.Text += Environment.NewLine;
                            DialogBox.Text += $"G0 Z{escapez:#.00};";
                            DialogBox.Text += Environment.NewLine;
                            DialogBox.Text += "M1;";
                        }

                    }
                    else
                    {
                        MessageBox.Show("Enter Offset # numerically only.");
                        offsetNumTextbox.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Enter Start Above numerically only.");
                    startabovetextbox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Enter O.D. & Tool # numerically only.");
                odTextbox.Text = "";
                toolNumTextbox.Text = "";
                startabovetextbox.Text = "";
            }
        }

    }
}
