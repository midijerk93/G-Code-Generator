namespace G_Code_Lathe_Facing
{
    partial class frmChamfer
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
            this.angletextbox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.chamferlengthtextbox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cleardialogbox = new System.Windows.Forms.Button();
            this.addToMainTextbox = new System.Windows.Forms.Button();
            this.generateGCodeButton = new System.Windows.Forms.Button();
            this.DialogBox = new System.Windows.Forms.TextBox();
            this.materialtextbox = new System.Windows.Forms.TextBox();
            this.odLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.depthOfCutTextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.finishNoseRadiusTextbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.insertTypeFinishTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.finishOffsetTextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.finishNumTextbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // angletextbox
            // 
            this.angletextbox.Location = new System.Drawing.Point(182, 124);
            this.angletextbox.Name = "angletextbox";
            this.angletextbox.Size = new System.Drawing.Size(138, 20);
            this.angletextbox.TabIndex = 4;
            this.angletextbox.Leave += new System.EventHandler(this.angletextbox_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(178, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 20);
            this.label11.TabIndex = 108;
            this.label11.Text = "Angle";
            // 
            // chamferlengthtextbox
            // 
            this.chamferlengthtextbox.Location = new System.Drawing.Point(16, 124);
            this.chamferlengthtextbox.Name = "chamferlengthtextbox";
            this.chamferlengthtextbox.Size = new System.Drawing.Size(142, 20);
            this.chamferlengthtextbox.TabIndex = 3;
            this.chamferlengthtextbox.Leave += new System.EventHandler(this.chamferlengthtextbox_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 20);
            this.label12.TabIndex = 107;
            this.label12.Text = "Chamfer Length";
            // 
            // cleardialogbox
            // 
            this.cleardialogbox.Location = new System.Drawing.Point(14, 465);
            this.cleardialogbox.Name = "cleardialogbox";
            this.cleardialogbox.Size = new System.Drawing.Size(75, 23);
            this.cleardialogbox.TabIndex = 11;
            this.cleardialogbox.Text = "Clear";
            this.cleardialogbox.UseVisualStyleBackColor = true;
            this.cleardialogbox.Click += new System.EventHandler(this.cleardialogbox_Click);
            // 
            // addToMainTextbox
            // 
            this.addToMainTextbox.Location = new System.Drawing.Point(117, 465);
            this.addToMainTextbox.Name = "addToMainTextbox";
            this.addToMainTextbox.Size = new System.Drawing.Size(91, 23);
            this.addToMainTextbox.TabIndex = 10;
            this.addToMainTextbox.Text = "Add To Main";
            this.addToMainTextbox.UseVisualStyleBackColor = true;
            this.addToMainTextbox.Click += new System.EventHandler(this.addToMainTextbox_Click);
            // 
            // generateGCodeButton
            // 
            this.generateGCodeButton.Location = new System.Drawing.Point(229, 465);
            this.generateGCodeButton.Name = "generateGCodeButton";
            this.generateGCodeButton.Size = new System.Drawing.Size(91, 23);
            this.generateGCodeButton.TabIndex = 9;
            this.generateGCodeButton.Text = "Generate";
            this.generateGCodeButton.UseVisualStyleBackColor = true;
            this.generateGCodeButton.Click += new System.EventHandler(this.generateGCodeButton_Click);
            // 
            // DialogBox
            // 
            this.DialogBox.Location = new System.Drawing.Point(14, 256);
            this.DialogBox.Multiline = true;
            this.DialogBox.Name = "DialogBox";
            this.DialogBox.Size = new System.Drawing.Size(306, 203);
            this.DialogBox.TabIndex = 97;
            // 
            // materialtextbox
            // 
            this.materialtextbox.Location = new System.Drawing.Point(30, 73);
            this.materialtextbox.Name = "materialtextbox";
            this.materialtextbox.Size = new System.Drawing.Size(144, 20);
            this.materialtextbox.TabIndex = 1;
            this.materialtextbox.Leave += new System.EventHandler(this.materialtextbox_Leave);
            // 
            // odLabel
            // 
            this.odLabel.AutoSize = true;
            this.odLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odLabel.Location = new System.Drawing.Point(10, 50);
            this.odLabel.Name = "odLabel";
            this.odLabel.Size = new System.Drawing.Size(97, 20);
            this.odLabel.TabIndex = 94;
            this.odLabel.Text = "Material Dia.";
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Location = new System.Drawing.Point(275, 12);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 93;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(300, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 92;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "Lathe Chamfer";
            // 
            // depthOfCutTextbox
            // 
            this.depthOfCutTextbox.Location = new System.Drawing.Point(180, 70);
            this.depthOfCutTextbox.Name = "depthOfCutTextbox";
            this.depthOfCutTextbox.Size = new System.Drawing.Size(140, 20);
            this.depthOfCutTextbox.TabIndex = 2;
            this.depthOfCutTextbox.Leave += new System.EventHandler(this.depthOfCutTextbox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(176, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 110;
            this.label7.Text = "Depth of Cut";
            // 
            // finishNoseRadiusTextbox
            // 
            this.finishNoseRadiusTextbox.Location = new System.Drawing.Point(180, 230);
            this.finishNoseRadiusTextbox.Name = "finishNoseRadiusTextbox";
            this.finishNoseRadiusTextbox.Size = new System.Drawing.Size(140, 20);
            this.finishNoseRadiusTextbox.TabIndex = 8;
            this.finishNoseRadiusTextbox.Leave += new System.EventHandler(this.finishNoseRadiusTextbox_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(176, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 20);
            this.label10.TabIndex = 118;
            this.label10.Text = "Nose Radius";
            // 
            // insertTypeFinishTextbox
            // 
            this.insertTypeFinishTextbox.Location = new System.Drawing.Point(15, 230);
            this.insertTypeFinishTextbox.Name = "insertTypeFinishTextbox";
            this.insertTypeFinishTextbox.Size = new System.Drawing.Size(143, 20);
            this.insertTypeFinishTextbox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 20);
            this.label9.TabIndex = 117;
            this.label9.Text = "Insert Name";
            // 
            // finishOffsetTextbox
            // 
            this.finishOffsetTextbox.Location = new System.Drawing.Point(180, 177);
            this.finishOffsetTextbox.Name = "finishOffsetTextbox";
            this.finishOffsetTextbox.Size = new System.Drawing.Size(140, 20);
            this.finishOffsetTextbox.TabIndex = 6;
            this.finishOffsetTextbox.Leave += new System.EventHandler(this.finishOffsetTextbox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 116;
            this.label4.Text = "Offset #";
            // 
            // finishNumTextbox
            // 
            this.finishNumTextbox.Location = new System.Drawing.Point(15, 177);
            this.finishNumTextbox.Name = "finishNumTextbox";
            this.finishNumTextbox.Size = new System.Drawing.Size(143, 20);
            this.finishNumTextbox.TabIndex = 5;
            this.finishNumTextbox.Leave += new System.EventHandler(this.finishNumTextbox_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 115;
            this.label8.Text = "Tool #";
            // 
            // frmChamfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 500);
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
            this.Controls.Add(this.angletextbox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chamferlengthtextbox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cleardialogbox);
            this.Controls.Add(this.addToMainTextbox);
            this.Controls.Add(this.generateGCodeButton);
            this.Controls.Add(this.DialogBox);
            this.Controls.Add(this.materialtextbox);
            this.Controls.Add(this.odLabel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChamfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox angletextbox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox chamferlengthtextbox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button cleardialogbox;
        private System.Windows.Forms.Button addToMainTextbox;
        private System.Windows.Forms.Button generateGCodeButton;
        public System.Windows.Forms.TextBox DialogBox;
        private System.Windows.Forms.TextBox materialtextbox;
        private System.Windows.Forms.Label odLabel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox depthOfCutTextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox finishNoseRadiusTextbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox insertTypeFinishTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox finishOffsetTextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox finishNumTextbox;
        private System.Windows.Forms.Label label8;
    }
}