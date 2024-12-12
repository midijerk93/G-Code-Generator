
namespace G_Code_Lathe_Facing
{
    partial class frmTurn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.depthOfCutTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.noseradiustextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.turnodtextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.turnlengthtextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addToMainTextbox = new System.Windows.Forms.Button();
            this.insertTypeTextbox = new System.Windows.Forms.TextBox();
            this.insertnamelabel = new System.Windows.Forms.Label();
            this.generateGCodeButton = new System.Windows.Forms.Button();
            this.DialogBox = new System.Windows.Forms.TextBox();
            this.offsetNumTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolNumTextbox = new System.Windows.Forms.TextBox();
            this.toolNumberLabel = new System.Windows.Forms.Label();
            this.materialtextbox = new System.Windows.Forms.TextBox();
            this.odLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.finishOffsetTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.finishNumTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.insertTypeFinishTextbox = new System.Windows.Forms.TextBox();
            this.finishNoseRadiusTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cleardialogbox = new System.Windows.Forms.Button();
            this.angletextbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chamferlengthtextbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // depthOfCutTextbox
            // 
            this.depthOfCutTextbox.Location = new System.Drawing.Point(339, 70);
            this.depthOfCutTextbox.Name = "depthOfCutTextbox";
            this.depthOfCutTextbox.Size = new System.Drawing.Size(96, 20);
            this.depthOfCutTextbox.TabIndex = 4;
            this.depthOfCutTextbox.Leave += new System.EventHandler(this.depthOfCutTextbox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(335, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 60;
            this.label7.Text = "Depth of Cut";
            // 
            // noseradiustextbox
            // 
            this.noseradiustextbox.Location = new System.Drawing.Point(339, 126);
            this.noseradiustextbox.Name = "noseradiustextbox";
            this.noseradiustextbox.Size = new System.Drawing.Size(96, 20);
            this.noseradiustextbox.TabIndex = 8;
            this.noseradiustextbox.Leave += new System.EventHandler(this.noseradiustextbox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "Nose Radius";
            // 
            // turnodtextbox
            // 
            this.turnodtextbox.Location = new System.Drawing.Point(122, 70);
            this.turnodtextbox.Name = "turnodtextbox";
            this.turnodtextbox.Size = new System.Drawing.Size(105, 20);
            this.turnodtextbox.TabIndex = 2;
            this.turnodtextbox.Leave += new System.EventHandler(this.turnodtextbox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Turn Dia";
            // 
            // turnlengthtextbox
            // 
            this.turnlengthtextbox.Location = new System.Drawing.Point(237, 70);
            this.turnlengthtextbox.Name = "turnlengthtextbox";
            this.turnlengthtextbox.Size = new System.Drawing.Size(92, 20);
            this.turnlengthtextbox.TabIndex = 3;
            this.turnlengthtextbox.Leave += new System.EventHandler(this.turnlengthtextbox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Turn Length";
            // 
            // addToMainTextbox
            // 
            this.addToMainTextbox.Location = new System.Drawing.Point(344, 465);
            this.addToMainTextbox.Name = "addToMainTextbox";
            this.addToMainTextbox.Size = new System.Drawing.Size(91, 23);
            this.addToMainTextbox.TabIndex = 16;
            this.addToMainTextbox.Text = "Add To Main";
            this.addToMainTextbox.UseVisualStyleBackColor = true;
            this.addToMainTextbox.Click += new System.EventHandler(this.addToMainTextbox_Click);
            // 
            // insertTypeTextbox
            // 
            this.insertTypeTextbox.Location = new System.Drawing.Point(237, 126);
            this.insertTypeTextbox.Name = "insertTypeTextbox";
            this.insertTypeTextbox.Size = new System.Drawing.Size(92, 20);
            this.insertTypeTextbox.TabIndex = 7;
            // 
            // insertnamelabel
            // 
            this.insertnamelabel.AutoSize = true;
            this.insertnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertnamelabel.Location = new System.Drawing.Point(233, 106);
            this.insertnamelabel.Name = "insertnamelabel";
            this.insertnamelabel.Size = new System.Drawing.Size(96, 20);
            this.insertnamelabel.TabIndex = 49;
            this.insertnamelabel.Text = "Insert Name";
            // 
            // generateGCodeButton
            // 
            this.generateGCodeButton.Location = new System.Drawing.Point(344, 436);
            this.generateGCodeButton.Name = "generateGCodeButton";
            this.generateGCodeButton.Size = new System.Drawing.Size(91, 23);
            this.generateGCodeButton.TabIndex = 15;
            this.generateGCodeButton.Text = "Generate";
            this.generateGCodeButton.UseVisualStyleBackColor = true;
            this.generateGCodeButton.Click += new System.EventHandler(this.generateGCodeButton_Click);
            // 
            // DialogBox
            // 
            this.DialogBox.Location = new System.Drawing.Point(11, 209);
            this.DialogBox.Multiline = true;
            this.DialogBox.Name = "DialogBox";
            this.DialogBox.Size = new System.Drawing.Size(219, 250);
            this.DialogBox.TabIndex = 47;
            // 
            // offsetNumTextbox
            // 
            this.offsetNumTextbox.Location = new System.Drawing.Point(122, 126);
            this.offsetNumTextbox.Name = "offsetNumTextbox";
            this.offsetNumTextbox.Size = new System.Drawing.Size(105, 20);
            this.offsetNumTextbox.TabIndex = 6;
            this.offsetNumTextbox.Leave += new System.EventHandler(this.offsetNumTextbox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Rough Offset #";
            // 
            // toolNumTextbox
            // 
            this.toolNumTextbox.Location = new System.Drawing.Point(10, 126);
            this.toolNumTextbox.Name = "toolNumTextbox";
            this.toolNumTextbox.Size = new System.Drawing.Size(100, 20);
            this.toolNumTextbox.TabIndex = 5;
            this.toolNumTextbox.Leave += new System.EventHandler(this.toolNumTextbox_Leave);
            // 
            // toolNumberLabel
            // 
            this.toolNumberLabel.AutoSize = true;
            this.toolNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolNumberLabel.Location = new System.Drawing.Point(6, 106);
            this.toolNumberLabel.Name = "toolNumberLabel";
            this.toolNumberLabel.Size = new System.Drawing.Size(104, 20);
            this.toolNumberLabel.TabIndex = 43;
            this.toolNumberLabel.Text = "Rough Tool #";
            // 
            // materialtextbox
            // 
            this.materialtextbox.Location = new System.Drawing.Point(10, 70);
            this.materialtextbox.Name = "materialtextbox";
            this.materialtextbox.Size = new System.Drawing.Size(102, 20);
            this.materialtextbox.TabIndex = 1;
            this.materialtextbox.Leave += new System.EventHandler(this.materialtextbox_Leave);
            // 
            // odLabel
            // 
            this.odLabel.AutoSize = true;
            this.odLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odLabel.Location = new System.Drawing.Point(7, 50);
            this.odLabel.Name = "odLabel";
            this.odLabel.Size = new System.Drawing.Size(82, 20);
            this.odLabel.TabIndex = 41;
            this.odLabel.Text = "Stock Dia.";
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Location = new System.Drawing.Point(396, 13);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 40;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(421, 13);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 39;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Lathe Turn Generator";
            // 
            // finishOffsetTextbox
            // 
            this.finishOffsetTextbox.Location = new System.Drawing.Point(122, 183);
            this.finishOffsetTextbox.Name = "finishOffsetTextbox";
            this.finishOffsetTextbox.Size = new System.Drawing.Size(105, 20);
            this.finishOffsetTextbox.TabIndex = 10;
            this.finishOffsetTextbox.Leave += new System.EventHandler(this.finishOffsetTextbox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 64;
            this.label4.Text = "Finish Offset #";
            // 
            // finishNumTextbox
            // 
            this.finishNumTextbox.Location = new System.Drawing.Point(10, 183);
            this.finishNumTextbox.Name = "finishNumTextbox";
            this.finishNumTextbox.Size = new System.Drawing.Size(100, 20);
            this.finishNumTextbox.TabIndex = 9;
            this.finishNumTextbox.Leave += new System.EventHandler(this.finishNumTextbox_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 62;
            this.label8.Text = "Finish Tool #";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(233, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 66;
            this.label9.Text = "Insert Name";
            // 
            // insertTypeFinishTextbox
            // 
            this.insertTypeFinishTextbox.Location = new System.Drawing.Point(237, 183);
            this.insertTypeFinishTextbox.Name = "insertTypeFinishTextbox";
            this.insertTypeFinishTextbox.Size = new System.Drawing.Size(92, 20);
            this.insertTypeFinishTextbox.TabIndex = 11;
            // 
            // finishNoseRadiusTextbox
            // 
            this.finishNoseRadiusTextbox.Location = new System.Drawing.Point(339, 183);
            this.finishNoseRadiusTextbox.Name = "finishNoseRadiusTextbox";
            this.finishNoseRadiusTextbox.Size = new System.Drawing.Size(96, 20);
            this.finishNoseRadiusTextbox.TabIndex = 12;
            this.finishNoseRadiusTextbox.Leave += new System.EventHandler(this.finishNoseRadiusTextbox_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(335, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 68;
            this.label10.Text = "Nose Radius";
            // 
            // cleardialogbox
            // 
            this.cleardialogbox.Location = new System.Drawing.Point(11, 465);
            this.cleardialogbox.Name = "cleardialogbox";
            this.cleardialogbox.Size = new System.Drawing.Size(75, 23);
            this.cleardialogbox.TabIndex = 17;
            this.cleardialogbox.Text = "Clear";
            this.cleardialogbox.UseVisualStyleBackColor = true;
            this.cleardialogbox.Click += new System.EventHandler(this.cleardialogbox_Click);
            // 
            // angletextbox
            // 
            this.angletextbox.Location = new System.Drawing.Point(372, 240);
            this.angletextbox.Name = "angletextbox";
            this.angletextbox.Size = new System.Drawing.Size(63, 20);
            this.angletextbox.TabIndex = 14;
            this.angletextbox.Leave += new System.EventHandler(this.angletextbox_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(368, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 73;
            this.label11.Text = "Angle";
            // 
            // chamferlengthtextbox
            // 
            this.chamferlengthtextbox.Location = new System.Drawing.Point(238, 240);
            this.chamferlengthtextbox.Name = "chamferlengthtextbox";
            this.chamferlengthtextbox.Size = new System.Drawing.Size(122, 20);
            this.chamferlengthtextbox.TabIndex = 13;
            this.chamferlengthtextbox.Leave += new System.EventHandler(this.chamferlengthtextbox_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(236, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 20);
            this.label12.TabIndex = 71;
            this.label12.Text = "Chamfer Length";
            // 
            // frmTurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 500);
            this.Controls.Add(this.angletextbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chamferlengthtextbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cleardialogbox);
            this.Controls.Add(this.finishNoseRadiusTextbox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.insertTypeFinishTextbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.finishOffsetTextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.finishNumTextbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.depthOfCutTextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.noseradiustextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.turnodtextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.turnlengthtextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addToMainTextbox);
            this.Controls.Add(this.insertTypeTextbox);
            this.Controls.Add(this.insertnamelabel);
            this.Controls.Add(this.generateGCodeButton);
            this.Controls.Add(this.DialogBox);
            this.Controls.Add(this.offsetNumTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolNumTextbox);
            this.Controls.Add(this.toolNumberLabel);
            this.Controls.Add(this.materialtextbox);
            this.Controls.Add(this.odLabel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTurn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTurn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox depthOfCutTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox noseradiustextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox turnodtextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox turnlengthtextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addToMainTextbox;
        private System.Windows.Forms.TextBox insertTypeTextbox;
        private System.Windows.Forms.Label insertnamelabel;
        private System.Windows.Forms.Button generateGCodeButton;
        public System.Windows.Forms.TextBox DialogBox;
        private System.Windows.Forms.TextBox offsetNumTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toolNumTextbox;
        private System.Windows.Forms.Label toolNumberLabel;
        private System.Windows.Forms.TextBox materialtextbox;
        private System.Windows.Forms.Label odLabel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox finishOffsetTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox finishNumTextbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox insertTypeFinishTextbox;
        private System.Windows.Forms.TextBox finishNoseRadiusTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button cleardialogbox;
        private System.Windows.Forms.TextBox angletextbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox chamferlengthtextbox;
        private System.Windows.Forms.Label label12;
    }
}