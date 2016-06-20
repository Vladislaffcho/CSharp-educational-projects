namespace WindowsForm
{
    partial class UcHard
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
            this.lbWeight = new System.Windows.Forms.Label();
            this.lbTireType = new System.Windows.Forms.Label();
            this.lbMaterial = new System.Windows.Forms.Label();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.tbTireType = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbWheelDiameter = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbWheelDiameter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbWeight
            // 
            this.lbWeight.AutoSize = true;
            this.lbWeight.Location = new System.Drawing.Point(14, 61);
            this.lbWeight.Name = "lbWeight";
            this.lbWeight.Size = new System.Drawing.Size(41, 13);
            this.lbWeight.TabIndex = 0;
            this.lbWeight.Text = "Weight";
            // 
            // lbTireType
            // 
            this.lbTireType.AutoSize = true;
            this.lbTireType.Location = new System.Drawing.Point(14, 88);
            this.lbTireType.Name = "lbTireType";
            this.lbTireType.Size = new System.Drawing.Size(52, 13);
            this.lbTireType.TabIndex = 0;
            this.lbTireType.Text = "Tire Type";
            // 
            // lbMaterial
            // 
            this.lbMaterial.AutoSize = true;
            this.lbMaterial.Location = new System.Drawing.Point(14, 114);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(44, 13);
            this.lbMaterial.TabIndex = 1;
            this.lbMaterial.Text = "Material";
            // 
            // cbMaterial
            // 
            this.cbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(101, 111);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(93, 21);
            this.cbMaterial.TabIndex = 5;
            // 
            // tbTireType
            // 
            this.tbTireType.Location = new System.Drawing.Point(101, 85);
            this.tbTireType.Name = "tbTireType";
            this.tbTireType.Size = new System.Drawing.Size(93, 20);
            this.tbTireType.TabIndex = 4;
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(101, 58);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(93, 20);
            this.tbWeight.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(14, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 14;
            this.lbName.Text = "Name";
            // 
            // lbWheelDiameter
            // 
            this.lbWheelDiameter.AutoSize = true;
            this.lbWheelDiameter.Location = new System.Drawing.Point(14, 35);
            this.lbWheelDiameter.Name = "lbWheelDiameter";
            this.lbWheelDiameter.Size = new System.Drawing.Size(83, 13);
            this.lbWheelDiameter.TabIndex = 15;
            this.lbWheelDiameter.Text = "Wheel Diameter";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(101, 6);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(93, 20);
            this.tbName.TabIndex = 1;
            // 
            // tbWheelDiameter
            // 
            this.tbWheelDiameter.Location = new System.Drawing.Point(101, 32);
            this.tbWheelDiameter.Name = "tbWheelDiameter";
            this.tbWheelDiameter.Size = new System.Drawing.Size(93, 20);
            this.tbWheelDiameter.TabIndex = 2;
            // 
            // UcHard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbWheelDiameter);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbWheelDiameter);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.tbTireType);
            this.Controls.Add(this.cbMaterial);
            this.Controls.Add(this.lbMaterial);
            this.Controls.Add(this.lbTireType);
            this.Controls.Add(this.lbWeight);
            this.Name = "UcHard";
            this.Size = new System.Drawing.Size(210, 140);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWeight;
        private System.Windows.Forms.Label lbTireType;
        private System.Windows.Forms.Label lbMaterial;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.TextBox tbTireType;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbWheelDiameter;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbWheelDiameter;
    }
}
