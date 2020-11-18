namespace TaskMasterCreateAssignment
{
    partial class CreateAssignment
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.classTextBox = new System.Windows.Forms.TextBox();
            this.assignmentTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hourTextBox = new System.Windows.Forms.TextBox();
            this.minuteTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.meridiemComboBox = new System.Windows.Forms.ComboBox();
            this.enforcementGroupBox = new System.Windows.Forms.GroupBox();
            this.negativeRadioButton = new System.Windows.Forms.RadioButton();
            this.positiveRadioButton = new System.Windows.Forms.RadioButton();
            this.createButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.enforcementGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 11F);
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 11F);
            this.label2.Location = new System.Drawing.Point(35, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assignment Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 11F);
            this.label3.Location = new System.Drawing.Point(35, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Due Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 11F);
            this.label4.Location = new System.Drawing.Point(35, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Due Time:";
            // 
            // classTextBox
            // 
            this.classTextBox.Location = new System.Drawing.Point(130, 33);
            this.classTextBox.Name = "classTextBox";
            this.classTextBox.Size = new System.Drawing.Size(118, 20);
            this.classTextBox.TabIndex = 5;
            // 
            // assignmentTextBox
            // 
            this.assignmentTextBox.Location = new System.Drawing.Point(172, 73);
            this.assignmentTextBox.Name = "assignmentTextBox";
            this.assignmentTextBox.Size = new System.Drawing.Size(146, 20);
            this.assignmentTextBox.TabIndex = 6;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(130, 113);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 7;
            // 
            // hourTextBox
            // 
            this.hourTextBox.Location = new System.Drawing.Point(130, 153);
            this.hourTextBox.Name = "hourTextBox";
            this.hourTextBox.Size = new System.Drawing.Size(30, 20);
            this.hourTextBox.TabIndex = 8;
            // 
            // minuteTextBox
            // 
            this.minuteTextBox.Location = new System.Drawing.Point(172, 153);
            this.minuteTextBox.Name = "minuteTextBox";
            this.minuteTextBox.Size = new System.Drawing.Size(30, 20);
            this.minuteTextBox.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = ":";
            // 
            // meridiemComboBox
            // 
            this.meridiemComboBox.DropDownWidth = 30;
            this.meridiemComboBox.FormattingEnabled = true;
            this.meridiemComboBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.meridiemComboBox.Location = new System.Drawing.Point(210, 152);
            this.meridiemComboBox.Name = "meridiemComboBox";
            this.meridiemComboBox.Size = new System.Drawing.Size(40, 21);
            this.meridiemComboBox.TabIndex = 11;
            // 
            // enforcementGroupBox
            // 
            this.enforcementGroupBox.Controls.Add(this.negativeRadioButton);
            this.enforcementGroupBox.Controls.Add(this.positiveRadioButton);
            this.enforcementGroupBox.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enforcementGroupBox.Location = new System.Drawing.Point(38, 195);
            this.enforcementGroupBox.Name = "enforcementGroupBox";
            this.enforcementGroupBox.Size = new System.Drawing.Size(191, 66);
            this.enforcementGroupBox.TabIndex = 12;
            this.enforcementGroupBox.TabStop = false;
            this.enforcementGroupBox.Text = "Enforcement Type:";
            // 
            // negativeRadioButton
            // 
            this.negativeRadioButton.AutoSize = true;
            this.negativeRadioButton.Location = new System.Drawing.Point(102, 24);
            this.negativeRadioButton.Name = "negativeRadioButton";
            this.negativeRadioButton.Size = new System.Drawing.Size(83, 21);
            this.negativeRadioButton.TabIndex = 1;
            this.negativeRadioButton.TabStop = true;
            this.negativeRadioButton.Text = "Negative";
            this.negativeRadioButton.UseVisualStyleBackColor = true;
            // 
            // positiveRadioButton
            // 
            this.positiveRadioButton.AutoSize = true;
            this.positiveRadioButton.Location = new System.Drawing.Point(9, 24);
            this.positiveRadioButton.Name = "positiveRadioButton";
            this.positiveRadioButton.Size = new System.Drawing.Size(77, 21);
            this.positiveRadioButton.TabIndex = 0;
            this.positiveRadioButton.TabStop = true;
            this.positiveRadioButton.Text = "Positive";
            this.positiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            this.createButton.Enabled = false;
            this.createButton.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(38, 294);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 40);
            this.createButton.TabIndex = 13;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Calisto MT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(154, 294);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 40);
            this.cancelButton.TabIndex = 14;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CreateAssignment
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(364, 370);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.enforcementGroupBox);
            this.Controls.Add(this.meridiemComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.minuteTextBox);
            this.Controls.Add(this.hourTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.assignmentTextBox);
            this.Controls.Add(this.classTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateAssignment";
            this.Text = "Create/Edit Assignment";
            this.enforcementGroupBox.ResumeLayout(false);
            this.enforcementGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox classTextBox;
        private System.Windows.Forms.TextBox assignmentTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox hourTextBox;
        private System.Windows.Forms.TextBox minuteTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox meridiemComboBox;
        private System.Windows.Forms.GroupBox enforcementGroupBox;
        private System.Windows.Forms.RadioButton negativeRadioButton;
        private System.Windows.Forms.RadioButton positiveRadioButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

