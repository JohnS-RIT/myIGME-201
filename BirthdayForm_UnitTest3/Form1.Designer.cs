namespace BirthdayForm_UnitTest3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.birthYearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorComboBox = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.birthYearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your age:";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(124, 33);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ageTextBox.Size = new System.Drawing.Size(500, 20);
            this.ageTextBox.TabIndex = 1;
            this.ageTextBox.Text = "0";
            // 
            // birthYearNumericUpDown
            // 
            this.birthYearNumericUpDown.Location = new System.Drawing.Point(176, 78);
            this.birthYearNumericUpDown.Name = "birthYearNumericUpDown";
            this.birthYearNumericUpDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.birthYearNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.birthYearNumericUpDown.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter your year of birth:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Favorite color?:";
            // 
            // colorComboBox
            // 
            this.colorComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.colorComboBox.FormattingEnabled = true;
            this.colorComboBox.Items.AddRange(new object[] {
            "Orange",
            "Orange",
            "Orange",
            "Orange",
            "Orange",
            "Orange",
            "Orange",
            "Orange",
            "Orange",
            "Orange",
            "Orange",
            "Orange",
            "Orange",
            "Orange",
            "Orange"});
            this.colorComboBox.Location = new System.Drawing.Point(124, 124);
            this.colorComboBox.Name = "colorComboBox";
            this.colorComboBox.Size = new System.Drawing.Size(121, 21);
            this.colorComboBox.TabIndex = 5;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(743, 452);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(35, 43);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.ImageLocation = "https://i.ytimg.com/vi/yXhz4F78s3Q/maxresdefault.jpg";
            this.pictureBox.Location = new System.Drawing.Point(28, 264);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(268, 160);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(790, 507);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.colorComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.birthYearNumericUpDown);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "It\'s your birthday...";
            ((System.ComponentModel.ISupportInitialize)(this.birthYearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.NumericUpDown birthYearNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox colorComboBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

