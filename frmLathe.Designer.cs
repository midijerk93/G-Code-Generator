﻿
namespace G_Code_Lathe_Facing
{
    partial class frmLathe
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
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainTextbox = new System.Windows.Forms.TextBox();
            this.facingButton = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.turnButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.drillButton = new System.Windows.Forms.Button();
            this.boreButton = new System.Windows.Forms.Button();
            this.tapButton = new System.Windows.Forms.Button();
            this.partNum = new System.Windows.Forms.Button();
            this.chamferButton = new System.Windows.Forms.Button();
            this.flipButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Location = new System.Drawing.Point(505, 15);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(27, 25);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(539, 15);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(27, 25);
            this.closeButton.TabIndex = 20;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lathe G Code Generator";
            // 
            // mainTextbox
            // 
            this.mainTextbox.Location = new System.Drawing.Point(136, 105);
            this.mainTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainTextbox.Multiline = true;
            this.mainTextbox.Name = "mainTextbox";
            this.mainTextbox.Size = new System.Drawing.Size(431, 431);
            this.mainTextbox.TabIndex = 15;
            // 
            // facingButton
            // 
            this.facingButton.Location = new System.Drawing.Point(21, 182);
            this.facingButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.facingButton.Name = "facingButton";
            this.facingButton.Size = new System.Drawing.Size(100, 28);
            this.facingButton.TabIndex = 2;
            this.facingButton.Text = "Face";
            this.facingButton.UseVisualStyleBackColor = true;
            this.facingButton.Click += new System.EventHandler(this.facingButton_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.AutoSize = true;
            this.mainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainLabel.Location = new System.Drawing.Point(308, 76);
            this.mainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(83, 25);
            this.mainLabel.TabIndex = 13;
            this.mainLabel.Text = "--Main--";
            // 
            // turnButton
            // 
            this.turnButton.Location = new System.Drawing.Point(21, 254);
            this.turnButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.turnButton.Name = "turnButton";
            this.turnButton.Size = new System.Drawing.Size(100, 28);
            this.turnButton.TabIndex = 4;
            this.turnButton.Text = "Turn";
            this.turnButton.UseVisualStyleBackColor = true;
            this.turnButton.Click += new System.EventHandler(this.turnButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.clearButton.Location = new System.Drawing.Point(136, 544);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 28);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.saveButton.Location = new System.Drawing.Point(468, 544);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 28);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // drillButton
            // 
            this.drillButton.Location = new System.Drawing.Point(21, 290);
            this.drillButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drillButton.Name = "drillButton";
            this.drillButton.Size = new System.Drawing.Size(100, 28);
            this.drillButton.TabIndex = 5;
            this.drillButton.Text = "Drill";
            this.drillButton.UseVisualStyleBackColor = true;
            this.drillButton.Click += new System.EventHandler(this.drillButton_Click);
            // 
            // boreButton
            // 
            this.boreButton.Location = new System.Drawing.Point(21, 326);
            this.boreButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boreButton.Name = "boreButton";
            this.boreButton.Size = new System.Drawing.Size(100, 28);
            this.boreButton.TabIndex = 6;
            this.boreButton.Text = "Bore";
            this.boreButton.UseVisualStyleBackColor = true;
            this.boreButton.Click += new System.EventHandler(this.boreButton_Click);
            // 
            // tapButton
            // 
            this.tapButton.Location = new System.Drawing.Point(21, 362);
            this.tapButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tapButton.Name = "tapButton";
            this.tapButton.Size = new System.Drawing.Size(100, 28);
            this.tapButton.TabIndex = 7;
            this.tapButton.Text = "Tap";
            this.tapButton.UseVisualStyleBackColor = true;
            this.tapButton.Click += new System.EventHandler(this.tapButton_Click);
            // 
            // partNum
            // 
            this.partNum.Location = new System.Drawing.Point(21, 102);
            this.partNum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.partNum.Name = "partNum";
            this.partNum.Size = new System.Drawing.Size(100, 28);
            this.partNum.TabIndex = 1;
            this.partNum.Text = "Part #";
            this.partNum.UseVisualStyleBackColor = true;
            this.partNum.Click += new System.EventHandler(this.partNum_Click);
            // 
            // chamferButton
            // 
            this.chamferButton.Location = new System.Drawing.Point(21, 218);
            this.chamferButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chamferButton.Name = "chamferButton";
            this.chamferButton.Size = new System.Drawing.Size(100, 28);
            this.chamferButton.TabIndex = 3;
            this.chamferButton.Text = "Chamfer";
            this.chamferButton.UseVisualStyleBackColor = true;
            this.chamferButton.Click += new System.EventHandler(this.chamferButton_Click);
            // 
            // flipButton
            // 
            this.flipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.flipButton.Location = new System.Drawing.Point(292, 544);
            this.flipButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(100, 28);
            this.flipButton.TabIndex = 12;
            this.flipButton.Text = "Flip";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
            // 
            // frmLathe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 602);
            this.Controls.Add(this.flipButton);
            this.Controls.Add(this.chamferButton);
            this.Controls.Add(this.partNum);
            this.Controls.Add(this.tapButton);
            this.Controls.Add(this.boreButton);
            this.Controls.Add(this.drillButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.turnButton);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.facingButton);
            this.Controls.Add(this.mainTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLathe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox mainTextbox;
        private System.Windows.Forms.Button facingButton;
        private System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.Button turnButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button drillButton;
        private System.Windows.Forms.Button boreButton;
        private System.Windows.Forms.Button tapButton;
        private System.Windows.Forms.Button partNum;
        private System.Windows.Forms.Button chamferButton;
        private System.Windows.Forms.Button flipButton;
    }
}