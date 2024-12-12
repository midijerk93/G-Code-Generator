
namespace G_Code_Lathe_Facing
{
    partial class frmDrill
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
            this.drilldepthtextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.svtextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.peckdepthtextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addToMainTextbox = new System.Windows.Forms.Button();
            this.generateGCodeButton = new System.Windows.Forms.Button();
            this.DialogBox = new System.Windows.Forms.TextBox();
            this.offsetNumTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolNumTextbox = new System.Windows.Forms.TextBox();
            this.toolNumberLabel = new System.Windows.Forms.Label();
            this.drilldiatextbox = new System.Windows.Forms.TextBox();
            this.odLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.frtextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.escapeztextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // drilldepthtextbox
            // 
            this.drilldepthtextbox.Location = new System.Drawing.Point(17, 130);
            this.drilldepthtextbox.Name = "drilldepthtextbox";
            this.drilldepthtextbox.Size = new System.Drawing.Size(100, 20);
            this.drilldepthtextbox.TabIndex = 4;
            this.drilldepthtextbox.Leave += new System.EventHandler(this.drilldepthtextbox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Drill Depth";
            // 
            // svtextbox
            // 
            this.svtextbox.Location = new System.Drawing.Point(246, 132);
            this.svtextbox.Name = "svtextbox";
            this.svtextbox.Size = new System.Drawing.Size(91, 20);
            this.svtextbox.TabIndex = 6;
            this.svtextbox.Leave += new System.EventHandler(this.svtextbox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "SV";
            // 
            // peckdepthtextbox
            // 
            this.peckdepthtextbox.Location = new System.Drawing.Point(139, 132);
            this.peckdepthtextbox.Name = "peckdepthtextbox";
            this.peckdepthtextbox.Size = new System.Drawing.Size(91, 20);
            this.peckdepthtextbox.TabIndex = 5;
            this.peckdepthtextbox.Leave += new System.EventHandler(this.peckdepthtextbox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(135, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Peck Depth";
            // 
            // addToMainTextbox
            // 
            this.addToMainTextbox.Location = new System.Drawing.Point(246, 457);
            this.addToMainTextbox.Name = "addToMainTextbox";
            this.addToMainTextbox.Size = new System.Drawing.Size(91, 23);
            this.addToMainTextbox.TabIndex = 10;
            this.addToMainTextbox.Text = "Add To Main";
            this.addToMainTextbox.UseVisualStyleBackColor = true;
            this.addToMainTextbox.Click += new System.EventHandler(this.addToMainTextbox_Click);
            // 
            // generateGCodeButton
            // 
            this.generateGCodeButton.Location = new System.Drawing.Point(246, 423);
            this.generateGCodeButton.Name = "generateGCodeButton";
            this.generateGCodeButton.Size = new System.Drawing.Size(90, 23);
            this.generateGCodeButton.TabIndex = 9;
            this.generateGCodeButton.Text = "Generate";
            this.generateGCodeButton.UseVisualStyleBackColor = true;
            this.generateGCodeButton.Click += new System.EventHandler(this.generateGCodeButton_Click);
            // 
            // DialogBox
            // 
            this.DialogBox.Location = new System.Drawing.Point(12, 158);
            this.DialogBox.Multiline = true;
            this.DialogBox.Name = "DialogBox";
            this.DialogBox.Size = new System.Drawing.Size(218, 288);
            this.DialogBox.TabIndex = 47;
            // 
            // offsetNumTextbox
            // 
            this.offsetNumTextbox.Location = new System.Drawing.Point(245, 74);
            this.offsetNumTextbox.Name = "offsetNumTextbox";
            this.offsetNumTextbox.Size = new System.Drawing.Size(92, 20);
            this.offsetNumTextbox.TabIndex = 3;
            this.offsetNumTextbox.Leave += new System.EventHandler(this.offsetNumTextbox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 45;
            this.label2.Text = "Offset #";
            // 
            // toolNumTextbox
            // 
            this.toolNumTextbox.Location = new System.Drawing.Point(139, 74);
            this.toolNumTextbox.Name = "toolNumTextbox";
            this.toolNumTextbox.Size = new System.Drawing.Size(91, 20);
            this.toolNumTextbox.TabIndex = 2;
            this.toolNumTextbox.Leave += new System.EventHandler(this.toolNumTextbox_Leave);
            // 
            // toolNumberLabel
            // 
            this.toolNumberLabel.AutoSize = true;
            this.toolNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolNumberLabel.Location = new System.Drawing.Point(137, 54);
            this.toolNumberLabel.Name = "toolNumberLabel";
            this.toolNumberLabel.Size = new System.Drawing.Size(52, 20);
            this.toolNumberLabel.TabIndex = 43;
            this.toolNumberLabel.Text = "Tool #";
            // 
            // drilldiatextbox
            // 
            this.drilldiatextbox.Location = new System.Drawing.Point(15, 74);
            this.drilldiatextbox.Name = "drilldiatextbox";
            this.drilldiatextbox.Size = new System.Drawing.Size(102, 20);
            this.drilldiatextbox.TabIndex = 1;
            this.drilldiatextbox.Leave += new System.EventHandler(this.drilldiatextbox_Leave);
            // 
            // odLabel
            // 
            this.odLabel.AutoSize = true;
            this.odLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odLabel.Location = new System.Drawing.Point(13, 54);
            this.odLabel.Name = "odLabel";
            this.odLabel.Size = new System.Drawing.Size(67, 20);
            this.odLabel.TabIndex = 41;
            this.odLabel.Text = "Drill Dia.";
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Location = new System.Drawing.Point(296, 17);
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
            this.closeButton.Location = new System.Drawing.Point(321, 17);
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
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Lathe Drill ";
            // 
            // frtextbox
            // 
            this.frtextbox.Location = new System.Drawing.Point(245, 190);
            this.frtextbox.Name = "frtextbox";
            this.frtextbox.Size = new System.Drawing.Size(91, 20);
            this.frtextbox.TabIndex = 7;
            this.frtextbox.Leave += new System.EventHandler(this.frtextbox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(241, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 58;
            this.label6.Text = "Feed Rate";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 457);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(90, 23);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // escapeztextbox
            // 
            this.escapeztextbox.Location = new System.Drawing.Point(246, 248);
            this.escapeztextbox.Name = "escapeztextbox";
            this.escapeztextbox.Size = new System.Drawing.Size(91, 20);
            this.escapeztextbox.TabIndex = 8;
            this.escapeztextbox.Leave += new System.EventHandler(this.escapeztextbox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(242, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Escape Z";
            // 
            // frmDrill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.escapeztextbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.frtextbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.drilldepthtextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.svtextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.peckdepthtextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addToMainTextbox);
            this.Controls.Add(this.generateGCodeButton);
            this.Controls.Add(this.DialogBox);
            this.Controls.Add(this.offsetNumTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolNumTextbox);
            this.Controls.Add(this.toolNumberLabel);
            this.Controls.Add(this.drilldiatextbox);
            this.Controls.Add(this.odLabel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDrill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDrill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox drilldepthtextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox svtextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox peckdepthtextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addToMainTextbox;
        private System.Windows.Forms.Button generateGCodeButton;
        public System.Windows.Forms.TextBox DialogBox;
        private System.Windows.Forms.TextBox offsetNumTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toolNumTextbox;
        private System.Windows.Forms.Label toolNumberLabel;
        private System.Windows.Forms.TextBox drilldiatextbox;
        private System.Windows.Forms.Label odLabel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox frtextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox escapeztextbox;
        private System.Windows.Forms.Label label7;
    }
}