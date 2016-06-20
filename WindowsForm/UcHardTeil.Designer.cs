namespace WindowsForm
{
    partial class UcHardTeil
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAbsorbers = new System.Windows.Forms.Label();
            this.tbAbsorbers = new System.Windows.Forms.TextBox();
            this.lbSpeedNo = new System.Windows.Forms.Label();
            this.tbSpeedNo = new System.Windows.Forms.TextBox();
            this.cbWithAirPump = new System.Windows.Forms.CheckBox();
            this.tbWheelDiameter = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbWheelDiameter = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAbsorbers
            // 
            this.lbAbsorbers.AutoSize = true;
            this.lbAbsorbers.Location = new System.Drawing.Point(15, 64);
            this.lbAbsorbers.Name = "lbAbsorbers";
            this.lbAbsorbers.Size = new System.Drawing.Size(54, 13);
            this.lbAbsorbers.TabIndex = 0;
            this.lbAbsorbers.Text = "Absorbers";
            // 
            // tbAbsorbers
            // 
            this.tbAbsorbers.Location = new System.Drawing.Point(101, 61);
            this.tbAbsorbers.Name = "tbAbsorbers";
            this.tbAbsorbers.Size = new System.Drawing.Size(93, 20);
            this.tbAbsorbers.TabIndex = 3;
            // 
            // lbSpeedNo
            // 
            this.lbSpeedNo.AutoSize = true;
            this.lbSpeedNo.Location = new System.Drawing.Point(14, 90);
            this.lbSpeedNo.Name = "lbSpeedNo";
            this.lbSpeedNo.Size = new System.Drawing.Size(55, 13);
            this.lbSpeedNo.TabIndex = 0;
            this.lbSpeedNo.Text = "Speed No";
            // 
            // tbSpeedNo
            // 
            this.tbSpeedNo.Location = new System.Drawing.Point(101, 87);
            this.tbSpeedNo.Name = "tbSpeedNo";
            this.tbSpeedNo.Size = new System.Drawing.Size(93, 20);
            this.tbSpeedNo.TabIndex = 4;
            // 
            // cbWithAirPump
            // 
            this.cbWithAirPump.AutoSize = true;
            this.cbWithAirPump.Location = new System.Drawing.Point(101, 113);
            this.cbWithAirPump.Name = "cbWithAirPump";
            this.cbWithAirPump.Size = new System.Drawing.Size(93, 17);
            this.cbWithAirPump.TabIndex = 5;
            this.cbWithAirPump.Text = "With Air Pump";
            this.cbWithAirPump.UseVisualStyleBackColor = true;
            // 
            // tbWheelDiameter
            // 
            this.tbWheelDiameter.Location = new System.Drawing.Point(101, 35);
            this.tbWheelDiameter.Name = "tbWheelDiameter";
            this.tbWheelDiameter.Size = new System.Drawing.Size(93, 20);
            this.tbWheelDiameter.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(101, 9);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(93, 20);
            this.tbName.TabIndex = 1;
            // 
            // lbWheelDiameter
            // 
            this.lbWheelDiameter.AutoSize = true;
            this.lbWheelDiameter.Location = new System.Drawing.Point(14, 38);
            this.lbWheelDiameter.Name = "lbWheelDiameter";
            this.lbWheelDiameter.Size = new System.Drawing.Size(83, 13);
            this.lbWheelDiameter.TabIndex = 3;
            this.lbWheelDiameter.Text = "Wheel Diameter";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(14, 12);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            // 
            // UcHardTeil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbWheelDiameter);
            this.Controls.Add(this.cbWithAirPump);
            this.Controls.Add(this.tbSpeedNo);
            this.Controls.Add(this.lbSpeedNo);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbWheelDiameter);
            this.Controls.Add(this.tbAbsorbers);
            this.Controls.Add(this.lbAbsorbers);
            this.Name = "UcHardTeil";
            this.Size = new System.Drawing.Size(210, 140);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAbsorbers;
        private System.Windows.Forms.TextBox tbAbsorbers;
        private System.Windows.Forms.Label lbSpeedNo;
        private System.Windows.Forms.TextBox tbSpeedNo;
        private System.Windows.Forms.CheckBox cbWithAirPump;
        private System.Windows.Forms.TextBox tbWheelDiameter;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbWheelDiameter;
        private System.Windows.Forms.Label lbName;
    }
}
