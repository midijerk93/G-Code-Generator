
namespace G_Code_Lathe_Facing
{
    partial class Dashboard
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
            this.dashboardlabel = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.millbutton = new System.Windows.Forms.Button();
            this.lathebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dashboardlabel
            // 
            this.dashboardlabel.AutoSize = true;
            this.dashboardlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardlabel.Location = new System.Drawing.Point(12, 9);
            this.dashboardlabel.Name = "dashboardlabel";
            this.dashboardlabel.Size = new System.Drawing.Size(97, 20);
            this.dashboardlabel.TabIndex = 22;
            this.dashboardlabel.Text = "Dashboard";
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.Location = new System.Drawing.Point(379, 9);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(20, 20);
            this.minimizeButton.TabIndex = 21;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(404, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 20);
            this.closeButton.TabIndex = 23;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "What kind of program do you want?";
            // 
            // millbutton
            // 
            this.millbutton.Location = new System.Drawing.Point(113, 166);
            this.millbutton.Name = "millbutton";
            this.millbutton.Size = new System.Drawing.Size(75, 23);
            this.millbutton.TabIndex = 25;
            this.millbutton.Text = "Mill";
            this.millbutton.UseVisualStyleBackColor = true;
            //this.millbutton.Click += new System.EventHandler(this.millbutton_Click);
            // 
            // lathebutton
            // 
            this.lathebutton.Location = new System.Drawing.Point(238, 166);
            this.lathebutton.Name = "lathebutton";
            this.lathebutton.Size = new System.Drawing.Size(75, 23);
            this.lathebutton.TabIndex = 26;
            this.lathebutton.Text = "Lathe";
            this.lathebutton.UseVisualStyleBackColor = true;
            this.lathebutton.Click += new System.EventHandler(this.lathebutton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 304);
            this.Controls.Add(this.lathebutton);
            this.Controls.Add(this.millbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dashboardlabel);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dashboardlabel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button millbutton;
        private System.Windows.Forms.Button lathebutton;
    }
}