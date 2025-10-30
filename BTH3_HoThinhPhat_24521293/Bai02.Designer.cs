namespace BTH3_HoThinhPhat_24521293
{
    partial class Bai02
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
            this.PaintButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PaintButton
            // 
            this.PaintButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PaintButton.Location = new System.Drawing.Point(0, 724);
            this.PaintButton.Name = "PaintButton";
            this.PaintButton.Size = new System.Drawing.Size(1379, 128);
            this.PaintButton.TabIndex = 0;
            this.PaintButton.Text = "Paint";
            this.PaintButton.UseVisualStyleBackColor = true;
            this.PaintButton.Click += new System.EventHandler(this.PaintButton_Click);
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 852);
            this.Controls.Add(this.PaintButton);
            this.Name = "Bai02";
            this.Text = "Bai02";
            this.Resize += new System.EventHandler(this.Bai02_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PaintButton;
    }
}