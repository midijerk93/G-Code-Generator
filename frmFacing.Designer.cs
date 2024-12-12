
namespace G_Code_Lathe_Facing
{
    partial class frmFacing
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
            this.escapeztextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.depthperpasstextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.facingstocktextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.clearbutton = new System.Windows.Forms.Button();
            this.addToMainTextbox = new System.Windows.Forms.Button();
            this.offsetNumTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.insertTypeTextbox = new System.Windows.Forms.TextBox();
            this.insertnamelabel = new System.Windows.Forms.Label();
            this.startabovetextbox = new System.Windows.Forms.TextBox();
            this.startaboveod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolNumTextbox = new System.Windows.Forms.TextBox();
            this.toolNumberLabel = new System.Windows.Forms.Label();
            this.generateGCodeButton = new System.Windows.Forms.Button();
            this.DialogBox = new System.Windows.Forms.TextBox();
            this.odTextbox = new System.Windows.Forms.TextBox();
            this.odLabel = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // escapeztextbox
            // 
            this.escapeztextbox.Location = new System.Drawing.Point(243, 269);
            this.escapeztextbox.Name = "escapeztextbox";
            this.escapeztextbox.Size = new System.Drawing.Size(98, 20);
            this.escapeztextbox.TabIndex = 8;
            this.escapeztextbox.Leave += new System.EventHandler(this.escapeztextbox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Escape Z";
            // 
            // depthperpasstextbox
            // 
            this.depthperpasstextbox.Location = new System.Drawing.Point(243, 206);
            this.depthperpasstextbox.Name = "depthperpasstextbox";
            this.depthperpasstextbox.Size = new System.Drawing.Size(98, 20);
            this.depthperpasstextbox.TabIndex = 7;
            this.depthperpasstextbox.Leave += new System.EventHandler(this.depthperpasstextbox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Depth/Pass";
            // 
            // facingstocktextbox
            // 
            this.facingstocktextbox.Location = new System.Drawing.Point(243, 141);
            this.facingstocktextbox.Name = "facingstocktextbox";
            this.facingstocktextbox.Size = new System.Drawing.Size(98, 20);
            this.facingstocktextbox.TabIndex = 6;
            this.facingstocktextbox.Leave += new System.EventHandler(this.facingstocktextbox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Facing Stock";
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(12, 411);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(91, 23);
            this.clearbutton.TabIndex = 39;
            this.clearbutton.Text = "Clear";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // addToMainTextbox
            // 
            this.addToMainTextbox.Location = new System.Drawing.Point(145, 411);
            this.addToMainTextbox.Name = "addToMainTextbox";
            this.addToMainTextbox.Size = new System.Drawing.Size(91, 23);
            this.addToMainTextbox.TabIndex = 10;
            this.addToMainTextbox.Text = "Add To Main";
            this.addToMainTextbox.UseVisualStyleBackColor = true;
            this.addToMainTextbox.Click += new System.EventHandler(this.addToMainTextbox_Click);
            // 
            // offsetNumTextbox
            // 
            this.offsetNumTextbox.Location = new System.Drawing.Point(244, 76);
            this.offsetNumTextbox.Name = "offsetNumTextbox";
            this.offsetNumTextbox.Size = new System.Drawing.Size(98, 20);
            this.offsetNumTextbox.TabIndex = 3;
            this.offsetNumTextbox.Leave += new System.EventHandler(this.offsetNumTextbox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Offset #";
            // 
            // insertTypeTextbox
            // 
            this.insertTypeTextbox.Location = new System.Drawing.Point(128, 141);
            this.insertTypeTextbox.Name = "insertTypeTextbox";
            this.insertTypeTextbox.Size = new System.Drawing.Size(100, 20);
            this.insertTypeTextbox.TabIndex = 5;
            // 
            // insertnamelabel
            // 
            this.insertnamelabel.AutoSize = true;
            this.insertnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertnamelabel.Location = new System.Drawing.Point(126, 121);
            this.insertnamelabel.Name = "insertnamelabel";
            this.insertnamelabel.Size = new System.Drawing.Size(96, 20);
            this.insertnamelabel.TabIndex = 34;
            this.insertnamelabel.Text = "Insert Name";
            // 
            // startabovetextbox
            // 
            this.startabovetextbox.Location = new System.Drawing.Point(14, 141);
            this.startabovetextbox.Name = "startabovetextbox";
            this.startabovetextbox.Size = new System.Drawing.Size(100, 20);
            this.startabovetextbox.TabIndex = 4;
            this.startabovetextbox.Leave += new System.EventHandler(this.startabovetextbox_Leave);
            // 
            // startaboveod
            // 
            this.startaboveod.AutoSize = true;
            this.startaboveod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startaboveod.Location = new System.Drawing.Point(11, 121);
            this.startaboveod.Name = "startaboveod";
            this.startaboveod.Size = new System.Drawing.Size(93, 20);
            this.startaboveod.TabIndex = 32;
            this.startaboveod.Text = "Start Above";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Lathe Facing Generator";
            // 
            // toolNumTextbox
            // 
            this.toolNumTextbox.Location = new System.Drawing.Point(126, 76);
            this.toolNumTextbox.Name = "toolNumTextbox";
            this.toolNumTextbox.Size = new System.Drawing.Size(102, 20);
            this.toolNumTextbox.TabIndex = 2;
            this.toolNumTextbox.Leave += new System.EventHandler(this.toolNumTextbox_Leave);
            // 
            // toolNumberLabel
            // 
            this.toolNumberLabel.AutoSize = true;
            this.toolNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolNumberLabel.Location = new System.Drawing.Point(123, 56);
            this.toolNumberLabel.Name = "toolNumberLabel";
            this.toolNumberLabel.Size = new System.Drawing.Size(52, 20);
            this.toolNumberLabel.TabIndex = 29;
            this.toolNumberLabel.Text = "Tool #";
            // 
            // generateGCodeButton
            // 
            this.generateGCodeButton.Location = new System.Drawing.Point(246, 411);
            this.generateGCodeButton.Name = "generateGCodeButton";
            this.generateGCodeButton.Size = new System.Drawing.Size(90, 23);
            this.generateGCodeButton.TabIndex = 9;
            this.generateGCodeButton.Text = "Generate";
            this.generateGCodeButton.UseVisualStyleBackColor = true;
            this.generateGCodeButton.Click += new System.EventHandler(this.generateGCodeButton_Click);
            // 
            // DialogBox
            // 
            this.DialogBox.Location = new System.Drawing.Point(11, 165);
            this.DialogBox.Multiline = true;
            this.DialogBox.Name = "DialogBox";
            this.DialogBox.Size = new System.Drawing.Size(224, 227);
            this.DialogBox.TabIndex = 27;
            // 
            // odTextbox
            // 
            this.odTextbox.Location = new System.Drawing.Point(12, 76);
            this.odTextbox.Name = "odTextbox";
            this.odTextbox.Size = new System.Drawing.Size(100, 20);
            this.odTextbox.TabIndex = 1;
            this.odTextbox.Leave += new System.EventHandler(this.odTextbox_Leave);
            // 
            // odLabel
            // 
            this.odLabel.AutoSize = true;
            this.odLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odLabel.Location = new System.Drawing.Point(9, 56);
            this.odLabel.Name = "odLabel";
            this.odLabel.Size = new System.Drawing.Size(76, 20);
            this.odLabel.TabIndex = 25;
            this.odLabel.Text = "Enter OD";
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Location = new System.Drawing.Point(296, 15);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 24;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(321, 15);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 23;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Facing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 449);
            this.Controls.Add(this.escapeztextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.depthperpasstextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.facingstocktextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.addToMainTextbox);
            this.Controls.Add(this.offsetNumTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.insertTypeTextbox);
            this.Controls.Add(this.insertnamelabel);
            this.Controls.Add(this.startabovetextbox);
            this.Controls.Add(this.startaboveod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolNumTextbox);
            this.Controls.Add(this.toolNumberLabel);
            this.Controls.Add(this.generateGCodeButton);
            this.Controls.Add(this.DialogBox);
            this.Controls.Add(this.odTextbox);
            this.Controls.Add(this.odLabel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox escapeztextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox depthperpasstextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox facingstocktextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button addToMainTextbox;
        private System.Windows.Forms.TextBox offsetNumTextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox insertTypeTextbox;
        private System.Windows.Forms.Label insertnamelabel;
        private System.Windows.Forms.TextBox startabovetextbox;
        private System.Windows.Forms.Label startaboveod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox toolNumTextbox;
        private System.Windows.Forms.Label toolNumberLabel;
        private System.Windows.Forms.Button generateGCodeButton;
        public System.Windows.Forms.TextBox DialogBox;
        private System.Windows.Forms.TextBox odTextbox;
        private System.Windows.Forms.Label odLabel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
    }
}

