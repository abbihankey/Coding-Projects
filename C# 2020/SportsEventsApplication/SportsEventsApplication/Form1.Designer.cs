namespace SportsEventsApplication
{
    partial class sportEvent
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.soccerRadioButton = new System.Windows.Forms.RadioButton();
            this.footballRadioButton = new System.Windows.Forms.RadioButton();
            this.swimmingRadioButton = new System.Windows.Forms.RadioButton();
            this.tennisRadioButton = new System.Windows.Forms.RadioButton();
            this.cyclingRadioButton = new System.Windows.Forms.RadioButton();
            this.signUpButton = new System.Windows.Forms.Button();
            this.cyclingPictureBox = new System.Windows.Forms.PictureBox();
            this.tennisPictureBox = new System.Windows.Forms.PictureBox();
            this.swimmingPictureBox = new System.Windows.Forms.PictureBox();
            this.footballPictureBox = new System.Windows.Forms.PictureBox();
            this.soccerPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.cyclingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tennisPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soccerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(25, 22);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sport:";
            // 
            // soccerRadioButton
            // 
            this.soccerRadioButton.AutoSize = true;
            this.soccerRadioButton.Location = new System.Drawing.Point(100, 60);
            this.soccerRadioButton.Name = "soccerRadioButton";
            this.soccerRadioButton.Size = new System.Drawing.Size(59, 17);
            this.soccerRadioButton.TabIndex = 3;
            this.soccerRadioButton.TabStop = true;
            this.soccerRadioButton.Text = "Soccer";
            this.soccerRadioButton.UseVisualStyleBackColor = true;
            // 
            // footballRadioButton
            // 
            this.footballRadioButton.AutoSize = true;
            this.footballRadioButton.Location = new System.Drawing.Point(100, 84);
            this.footballRadioButton.Name = "footballRadioButton";
            this.footballRadioButton.Size = new System.Drawing.Size(62, 17);
            this.footballRadioButton.TabIndex = 4;
            this.footballRadioButton.TabStop = true;
            this.footballRadioButton.Text = "Football";
            this.footballRadioButton.UseVisualStyleBackColor = true;
            // 
            // swimmingRadioButton
            // 
            this.swimmingRadioButton.AutoSize = true;
            this.swimmingRadioButton.Location = new System.Drawing.Point(100, 108);
            this.swimmingRadioButton.Name = "swimmingRadioButton";
            this.swimmingRadioButton.Size = new System.Drawing.Size(72, 17);
            this.swimmingRadioButton.TabIndex = 5;
            this.swimmingRadioButton.TabStop = true;
            this.swimmingRadioButton.Text = "Swimming";
            this.swimmingRadioButton.UseVisualStyleBackColor = true;
            // 
            // tennisRadioButton
            // 
            this.tennisRadioButton.AutoSize = true;
            this.tennisRadioButton.Location = new System.Drawing.Point(100, 132);
            this.tennisRadioButton.Name = "tennisRadioButton";
            this.tennisRadioButton.Size = new System.Drawing.Size(57, 17);
            this.tennisRadioButton.TabIndex = 6;
            this.tennisRadioButton.TabStop = true;
            this.tennisRadioButton.Text = "Tennis";
            this.tennisRadioButton.UseVisualStyleBackColor = true;
            // 
            // cyclingRadioButton
            // 
            this.cyclingRadioButton.AutoSize = true;
            this.cyclingRadioButton.Location = new System.Drawing.Point(100, 156);
            this.cyclingRadioButton.Name = "cyclingRadioButton";
            this.cyclingRadioButton.Size = new System.Drawing.Size(59, 17);
            this.cyclingRadioButton.TabIndex = 7;
            this.cyclingRadioButton.TabStop = true;
            this.cyclingRadioButton.Text = "Cycling";
            this.cyclingRadioButton.UseVisualStyleBackColor = true;
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(100, 197);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(85, 22);
            this.signUpButton.TabIndex = 8;
            this.signUpButton.Text = "Sign Up!";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // cyclingPictureBox
            // 
            this.cyclingPictureBox.Image = global::SportsEventsApplication.Properties.Resources.cycling;
            this.cyclingPictureBox.Location = new System.Drawing.Point(219, 19);
            this.cyclingPictureBox.Name = "cyclingPictureBox";
            this.cyclingPictureBox.Size = new System.Drawing.Size(159, 200);
            this.cyclingPictureBox.TabIndex = 13;
            this.cyclingPictureBox.TabStop = false;
            // 
            // tennisPictureBox
            // 
            this.tennisPictureBox.Image = global::SportsEventsApplication.Properties.Resources.tennis;
            this.tennisPictureBox.Location = new System.Drawing.Point(219, 19);
            this.tennisPictureBox.Name = "tennisPictureBox";
            this.tennisPictureBox.Size = new System.Drawing.Size(159, 200);
            this.tennisPictureBox.TabIndex = 12;
            this.tennisPictureBox.TabStop = false;
            // 
            // swimmingPictureBox
            // 
            this.swimmingPictureBox.Image = global::SportsEventsApplication.Properties.Resources.swimming;
            this.swimmingPictureBox.Location = new System.Drawing.Point(219, 19);
            this.swimmingPictureBox.Name = "swimmingPictureBox";
            this.swimmingPictureBox.Size = new System.Drawing.Size(159, 197);
            this.swimmingPictureBox.TabIndex = 11;
            this.swimmingPictureBox.TabStop = false;
            // 
            // footballPictureBox
            // 
            this.footballPictureBox.Image = global::SportsEventsApplication.Properties.Resources.football2;
            this.footballPictureBox.Location = new System.Drawing.Point(219, 19);
            this.footballPictureBox.Name = "footballPictureBox";
            this.footballPictureBox.Size = new System.Drawing.Size(159, 197);
            this.footballPictureBox.TabIndex = 10;
            this.footballPictureBox.TabStop = false;
            // 
            // soccerPictureBox
            // 
            this.soccerPictureBox.Image = global::SportsEventsApplication.Properties.Resources.soccer;
            this.soccerPictureBox.Location = new System.Drawing.Point(219, 22);
            this.soccerPictureBox.Name = "soccerPictureBox";
            this.soccerPictureBox.Size = new System.Drawing.Size(159, 197);
            this.soccerPictureBox.TabIndex = 9;
            this.soccerPictureBox.TabStop = false;
            // 
            // sportEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 272);
            this.Controls.Add(this.cyclingPictureBox);
            this.Controls.Add(this.tennisPictureBox);
            this.Controls.Add(this.swimmingPictureBox);
            this.Controls.Add(this.footballPictureBox);
            this.Controls.Add(this.soccerPictureBox);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.cyclingRadioButton);
            this.Controls.Add(this.tennisRadioButton);
            this.Controls.Add(this.swimmingRadioButton);
            this.Controls.Add(this.footballRadioButton);
            this.Controls.Add(this.soccerRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nameLabel);
            this.Name = "sportEvent";
            this.Text = "Sport Event Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.cyclingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tennisPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soccerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton soccerRadioButton;
        private System.Windows.Forms.RadioButton footballRadioButton;
        private System.Windows.Forms.RadioButton swimmingRadioButton;
        private System.Windows.Forms.RadioButton tennisRadioButton;
        private System.Windows.Forms.RadioButton cyclingRadioButton;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.PictureBox soccerPictureBox;
        private System.Windows.Forms.PictureBox footballPictureBox;
        private System.Windows.Forms.PictureBox swimmingPictureBox;
        private System.Windows.Forms.PictureBox tennisPictureBox;
        private System.Windows.Forms.PictureBox cyclingPictureBox;
    }
}

