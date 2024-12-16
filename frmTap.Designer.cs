
namespace G_Code_Lathe_Facing
{
    partial class frmTap
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
            this.tapdepthtextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sfmtextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pitchtextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addToMainTextbox = new System.Windows.Forms.Button();
            this.generateGCodeButton = new System.Windows.Forms.Button();
            this.DialogBox = new System.Windows.Forms.TextBox();
            this.offsetNumTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolNumTextbox = new System.Windows.Forms.TextBox();
            this.toolNumberLabel = new System.Windows.Forms.Label();
            this.tapsizetextbox = new System.Windows.Forms.TextBox();
            this.odLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.escapeztextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tapdiatextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tapdepthtextbox
            // 
            this.tapdepthtextbox.Location = new System.Drawing.Point(23, 160);
            this.tapdepthtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.tapdepthtextbox.Name = "tapdepthtextbox";
            this.tapdepthtextbox.Size = new System.Drawing.Size(132, 22);
            this.tapdepthtextbox.TabIndex = 4;
            this.tapdepthtextbox.Leave += new System.EventHandler(this.tapdepthtextbox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "Tap Depth";
            // 
            // sfmtextbox
            // 
            this.sfmtextbox.Location = new System.Drawing.Point(328, 162);
            this.sfmtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.sfmtextbox.Name = "sfmtextbox";
            this.sfmtextbox.Size = new System.Drawing.Size(120, 22);
            this.sfmtextbox.TabIndex = 6;
            this.sfmtextbox.Leave += new System.EventHandler(this.sfmtextbox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 54;
            this.label4.Text = "SFM";
            // 
            // pitchtextbox
            // 
            this.pitchtextbox.Location = new System.Drawing.Point(185, 162);
            this.pitchtextbox.Margin = new System.Windows.Forms.Padding(4);
            this.pitchtextbox.Name = "pitchtextbox";
            this.pitchtextbox.Size = new System.Drawing.Size(120, 22);
            this.pitchtextbox.TabIndex = 5;
            this.pitchtextbox.Leave += new System.EventHandler(this.peckdepthtextbox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 52;
            this.label5.Text = "Pitch";
            // 
            // addToMainTextbox
            // 
            this.addToMainTextbox.Location = new System.Drawing.Point(328, 562);
            this.addToMainTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.addToMainTextbox.Name = "addToMainTextbox";
            this.addToMainTextbox.Size = new System.Drawing.Size(121, 28);
            this.addToMainTextbox.TabIndex = 10;
            this.addToMainTextbox.Text = "Add To Main";
            this.addToMainTextbox.UseVisualStyleBackColor = true;
            this.addToMainTextbox.Click += new System.EventHandler(this.addToMainTextbox_Click);
            // 
            // generateGCodeButton
            // 
            this.generateGCodeButton.Location = new System.Drawing.Point(328, 521);
            this.generateGCodeButton.Margin = new System.Windows.Forms.Padding(4);
            this.generateGCodeButton.Name = "generateGCodeButton";
            this.generateGCodeButton.Size = new System.Drawing.Size(120, 28);
            this.generateGCodeButton.TabIndex = 9;
            this.generateGCodeButton.Text = "Generate";
            this.generateGCodeButton.UseVisualStyleBackColor = true;
            this.generateGCodeButton.Click += new System.EventHandler(this.generateGCodeButton_Click);
            // 
            // DialogBox
            // 
            this.DialogBox.Location = new System.Drawing.Point(16, 194);
            this.DialogBox.Margin = new System.Windows.Forms.Padding(4);
            this.DialogBox.Multiline = true;
            this.DialogBox.Name = "DialogBox";
            this.DialogBox.Size = new System.Drawing.Size(289, 354);
            this.DialogBox.TabIndex = 47;
            // 
            // offsetNumTextbox
            // 
            this.offsetNumTextbox.Location = new System.Drawing.Point(327, 91);
            this.offsetNumTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.offsetNumTextbox.Name = "offsetNumTextbox";
            this.offsetNumTextbox.Size = new System.Drawing.Size(121, 22);
            this.offsetNumTextbox.TabIndex = 3;
            this.offsetNumTextbox.Leave += new System.EventHandler(this.offsetNumTextbox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Offset #";
            // 
            // toolNumTextbox
            // 
            this.toolNumTextbox.Location = new System.Drawing.Point(185, 91);
            this.toolNumTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.toolNumTextbox.Name = "toolNumTextbox";
            this.toolNumTextbox.Size = new System.Drawing.Size(120, 22);
            this.toolNumTextbox.TabIndex = 2;
            this.toolNumTextbox.Leave += new System.EventHandler(this.toolNumTextbox_Leave);
            // 
            // toolNumberLabel
            // 
            this.toolNumberLabel.AutoSize = true;
            this.toolNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolNumberLabel.Location = new System.Drawing.Point(183, 66);
            this.toolNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toolNumberLabel.Name = "toolNumberLabel";
            this.toolNumberLabel.Size = new System.Drawing.Size(67, 25);
            this.toolNumberLabel.TabIndex = 43;
            this.toolNumberLabel.Text = "Tool #";
            // 
            // tapsizetextbox
            // 
            this.tapsizetextbox.Location = new System.Drawing.Point(25, 94);
            this.tapsizetextbox.Name = "tapsizetextbox";
            this.tapsizetextbox.Size = new System.Drawing.Size(100, 22);
            this.tapsizetextbox.TabIndex = 1;
            // 
            // odLabel
            // 
            this.odLabel.AutoSize = true;
            this.odLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odLabel.Location = new System.Drawing.Point(17, 66);
            this.odLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.odLabel.Name = "odLabel";
            this.odLabel.Size = new System.Drawing.Size(91, 25);
            this.odLabel.TabIndex = 41;
            this.odLabel.Text = "Tap Size";
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Location = new System.Drawing.Point(395, 21);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(27, 25);
            this.minimizeButton.TabIndex = 40;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(428, 21);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(27, 25);
            this.closeButton.TabIndex = 39;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Lathe Tap";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(16, 562);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(120, 28);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // escapeztextbox
            // 
            this.escapeztextbox.Location = new System.Drawing.Point(327, 287);
            this.escapeztextbox.Margin = new System.Windows.Forms.Padding(4);
            this.escapeztextbox.Name = "escapeztextbox";
            this.escapeztextbox.Size = new System.Drawing.Size(120, 22);
            this.escapeztextbox.TabIndex = 8;
            this.escapeztextbox.Leave += new System.EventHandler(this.escapeztextbox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(322, 258);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 61;
            this.label7.Text = "Escape Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 25);
            this.label6.TabIndex = 63;
            this.label6.Text = "Tap Dia.";
            // 
            // tapdiatextbox
            // 
            this.tapdiatextbox.Location = new System.Drawing.Point(327, 223);
            this.tapdiatextbox.Margin = new System.Windows.Forms.Padding(4);
            this.tapdiatextbox.Name = "tapdiatextbox";
            this.tapdiatextbox.Size = new System.Drawing.Size(120, 22);
            this.tapdiatextbox.TabIndex = 7;
            this.escapeztextbox.Leave += new System.EventHandler(this.tapdiaTextbox_Leave);
            // 
            // frmTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 615);
            this.Controls.Add(this.tapdiatextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.escapeztextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.tapdepthtextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sfmtextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pitchtextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addToMainTextbox);
            this.Controls.Add(this.generateGCodeButton);
            this.Controls.Add(this.DialogBox);
            this.Controls.Add(this.offsetNumTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolNumTextbox);
            this.Controls.Add(this.toolNumberLabel);
            this.Controls.Add(this.tapsizetextbox);
            this.Controls.Add(this.odLabel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDrill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tapdepthtextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sfmtextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pitchtextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addToMainTextbox;
        private System.Windows.Forms.Button generateGCodeButton;
        public System.Windows.Forms.TextBox DialogBox;
        private System.Windows.Forms.TextBox offsetNumTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toolNumTextbox;
        private System.Windows.Forms.Label toolNumberLabel;
        private System.Windows.Forms.TextBox tapsizetextbox;
        private System.Windows.Forms.Label odLabel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox escapeztextbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tapdiatextbox;
    }
}