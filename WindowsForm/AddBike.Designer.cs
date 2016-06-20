namespace WindowsForm
{
    partial class AddBike
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBike));
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.cbBikeType = new System.Windows.Forms.ComboBox();
            this.lbType = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btOk.Location = new System.Drawing.Point(151, 226);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 0;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(247, 226);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 1;
            this.btCancel.Text = "Cancel";
            this.btCancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // cbBikeType
            // 
            this.cbBikeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBikeType.FormattingEnabled = true;
            this.cbBikeType.Location = new System.Drawing.Point(71, 17);
            this.cbBikeType.Name = "cbBikeType";
            this.cbBikeType.Size = new System.Drawing.Size(121, 21);
            this.cbBikeType.TabIndex = 2;
            this.cbBikeType.SelectedIndexChanged += new System.EventHandler(this.cbBikeType_SelectedIndexChanged);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(9, 20);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(31, 13);
            this.lbType.TabIndex = 3;
            this.lbType.Text = "Type";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panelContent.Location = new System.Drawing.Point(12, 57);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(310, 163);
            this.panelContent.TabIndex = 4;
            // 
            // AddBike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.cbBikeType);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 300);
            this.Name = "AddBike";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddBike";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddBike_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ComboBox cbBikeType;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.Panel panelContent;
    }
}