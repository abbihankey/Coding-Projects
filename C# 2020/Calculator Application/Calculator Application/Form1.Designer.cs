namespace Calculator_Application
{
    public partial class CalculatorApp
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
            this.addButton = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.firstLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.outLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.firstValBox = new System.Windows.Forms.TextBox();
            this.secondValBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(312, 12);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(106, 20);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // mulButton
            // 
            this.mulButton.Location = new System.Drawing.Point(312, 38);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(106, 22);
            this.mulButton.TabIndex = 1;
            this.mulButton.Text = "Multiply";
            this.mulButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(312, 66);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(106, 21);
            this.resetButton.TabIndex = 2;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Location = new System.Drawing.Point(12, 12);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(83, 13);
            this.firstLabel.TabIndex = 3;
            this.firstLabel.Text = "Enter first value:";
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Location = new System.Drawing.Point(10, 38);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(102, 13);
            this.secondLabel.TabIndex = 4;
            this.secondLabel.Text = "Enter second value:";
            // 
            // outLabel
            // 
            this.outLabel.AutoSize = true;
            this.outLabel.Location = new System.Drawing.Point(12, 66);
            this.outLabel.Name = "outLabel";
            this.outLabel.Size = new System.Drawing.Size(42, 13);
            this.outLabel.TabIndex = 5;
            this.outLabel.Text = "Output:";
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Location = new System.Drawing.Point(124, 66);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(184, 21);
            this.outputLabel.TabIndex = 6;
            // 
            // firstValBox
            // 
            this.firstValBox.Location = new System.Drawing.Point(124, 13);
            this.firstValBox.Name = "firstValBox";
            this.firstValBox.Size = new System.Drawing.Size(184, 20);
            this.firstValBox.TabIndex = 7;
            // 
            // secondValBox
            // 
            this.secondValBox.Location = new System.Drawing.Point(124, 40);
            this.secondValBox.Name = "secondValBox";
            this.secondValBox.Size = new System.Drawing.Size(184, 20);
            this.secondValBox.TabIndex = 8;
            // 
            // CalculatorApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 98);
            this.Controls.Add(this.secondValBox);
            this.Controls.Add(this.firstValBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.outLabel);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.firstLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.mulButton);
            this.Controls.Add(this.addButton);
            this.Name = "CalculatorApp";
            this.Text = "Calculator Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button mulButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label outLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox firstValBox;
        private System.Windows.Forms.TextBox secondValBox;
    }
}

