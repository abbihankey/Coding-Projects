namespace ColorApplication
{
    partial class colorApp
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
            this.GreenButton = new System.Windows.Forms.Button();
            this.RedButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GreenButton
            // 
            this.GreenButton.Location = new System.Drawing.Point(12, 45);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(109, 61);
            this.GreenButton.TabIndex = 0;
            this.GreenButton.Text = "Green";
            this.GreenButton.UseVisualStyleBackColor = true;
            // 
            // RedButton
            // 
            this.RedButton.Location = new System.Drawing.Point(145, 45);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(110, 61);
            this.RedButton.TabIndex = 1;
            this.RedButton.Text = "Red";
            this.RedButton.UseVisualStyleBackColor = true;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(278, 45);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(102, 61);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            // 
            // colorApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(392, 176);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.RedButton);
            this.Controls.Add(this.GreenButton);
            this.Name = "colorApp";
            this.Text = "Color App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Button RedButton;
        private System.Windows.Forms.Button ResetButton;
    }
}

