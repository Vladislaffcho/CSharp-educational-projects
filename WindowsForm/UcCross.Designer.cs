namespace WindowsForm
{
    partial class UcCross
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
            this.lbSpeedCount = new System.Windows.Forms.Label();
            this.tbSpeedCount = new System.Windows.Forms.TextBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbWheelDiameter = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbWheelDiameter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbSpeedCount
            // 
            this.lbSpeedCount.AutoSize = true;
            this.lbSpeedCount.Location = new System.Drawing.Point(16, 65);
            this.lbSpeedCount.Name = "lbSpeedCount";
            this.lbSpeedCount.Size = new System.Drawing.Size(69, 13);
            this.lbSpeedCount.TabIndex = 0;
            this.lbSpeedCount.Text = "Speed Count";
            // 
            // tbSpeedCount
            // 
            this.tbSpeedCount.Location = new System.Drawing.Point(101, 65);
            this.tbSpeedCount.Name = "tbSpeedCount";
            this.tbSpeedCount.Size = new System.Drawing.Size(93, 20);
            this.tbSpeedCount.TabIndex = 3;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(16, 91);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(31, 13);
            this.lbColor.TabIndex = 0;
            this.lbColor.Text = "Color";
            // 
            // cbColor
            // 
            this.cbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(101, 91);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(93, 21);
            this.cbColor.TabIndex = 4;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(14, 16);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Name";
            // 
            // lbWheelDiameter
            // 
            this.lbWheelDiameter.AutoSize = true;
            this.lbWheelDiameter.Location = new System.Drawing.Point(14, 42);
            this.lbWheelDiameter.Name = "lbWheelDiameter";
            this.lbWheelDiameter.Size = new System.Drawing.Size(83, 13);
            this.lbWheelDiameter.TabIndex = 7;
            this.lbWheelDiameter.Text = "Wheel Diameter";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(101, 13);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(93, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbWheelDiameter
            // 
            this.tbWheelDiameter.Location = new System.Drawing.Point(101, 39);
            this.tbWheelDiameter.Name = "tbWheelDiameter";
            this.tbWheelDiameter.Size = new System.Drawing.Size(93, 20);
            this.tbWheelDiameter.TabIndex = 2;
            // 
            // UcCross
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbWheelDiameter);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbWheelDiameter);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.tbSpeedCount);
            this.Controls.Add(this.lbSpeedCount);
            this.Name = "UcCross";
            this.Size = new System.Drawing.Size(210, 140);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbSpeedCount;
        private System.Windows.Forms.TextBox tbSpeedCount;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbWheelDiameter;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbWheelDiameter;
    }
}
