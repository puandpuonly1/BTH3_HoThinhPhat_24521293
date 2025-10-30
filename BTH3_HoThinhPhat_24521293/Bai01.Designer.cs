namespace BTH3_HoThinhPhat_24521293
{
    partial class Bai01
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
            this.Label = new System.Windows.Forms.Label();
            this.MoButton = new System.Windows.Forms.Button();
            this.DongButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label.Location = new System.Drawing.Point(147, 166);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(298, 359);
            this.Label.TabIndex = 0;
            // 
            // MoButton
            // 
            this.MoButton.Location = new System.Drawing.Point(773, 166);
            this.MoButton.Name = "MoButton";
            this.MoButton.Size = new System.Drawing.Size(146, 73);
            this.MoButton.TabIndex = 1;
            this.MoButton.Text = "Mở";
            this.MoButton.UseVisualStyleBackColor = true;
            this.MoButton.Click += new System.EventHandler(this.MoButton_Click);
            // 
            // DongButton
            // 
            this.DongButton.Location = new System.Drawing.Point(773, 452);
            this.DongButton.Name = "DongButton";
            this.DongButton.Size = new System.Drawing.Size(146, 73);
            this.DongButton.TabIndex = 1;
            this.DongButton.Text = "Đóng";
            this.DongButton.UseVisualStyleBackColor = true;
            this.DongButton.Click += new System.EventHandler(this.DongButton_Click);
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 770);
            this.Controls.Add(this.DongButton);
            this.Controls.Add(this.MoButton);
            this.Controls.Add(this.Label);
            this.Name = "Bai01";
            this.Activated += new System.EventHandler(this.Bai01_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai01_FormClosing);
            this.Load += new System.EventHandler(this.Bai01_Load);
            this.Shown += new System.EventHandler(this.Bai01_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button MoButton;
        private System.Windows.Forms.Button DongButton;
    }
}