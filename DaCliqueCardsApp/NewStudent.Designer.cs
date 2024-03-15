namespace DaCliqueCardsApp
{
    partial class NewStudent
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
            FirstNameText = new TextBox();
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            LastNameText = new TextBox();
            AgeLabel = new Label();
            AgeText = new TextBox();
            PhoneNumberLabel = new Label();
            PhoneNumberText = new TextBox();
            CreateStudentButton = new Button();
            SuspendLayout();
            // 
            // FirstNameText
            // 
            FirstNameText.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameText.Location = new Point(12, 42);
            FirstNameText.Name = "FirstNameText";
            FirstNameText.Size = new Size(175, 35);
            FirstNameText.TabIndex = 0;
            FirstNameText.KeyDown += FirstNameText_KeyDown;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            FirstNameLabel.Location = new Point(12, 9);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(113, 30);
            FirstNameLabel.TabIndex = 1;
            FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameLabel.Location = new Point(12, 97);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(112, 30);
            LastNameLabel.TabIndex = 3;
            LastNameLabel.Text = "Last Name";
            // 
            // LastNameText
            // 
            LastNameText.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameText.Location = new Point(12, 130);
            LastNameText.Name = "LastNameText";
            LastNameText.Size = new Size(175, 35);
            LastNameText.TabIndex = 2;
            LastNameText.KeyDown += LastNameText_KeyDown;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AgeLabel.Location = new Point(12, 190);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(50, 30);
            AgeLabel.TabIndex = 5;
            AgeLabel.Text = "Age";
            // 
            // AgeText
            // 
            AgeText.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AgeText.Location = new Point(12, 223);
            AgeText.Name = "AgeText";
            AgeText.Size = new Size(175, 35);
            AgeText.TabIndex = 4;
            AgeText.KeyDown += AgeText_KeyDown;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberLabel.Location = new Point(13, 285);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(154, 30);
            PhoneNumberLabel.TabIndex = 7;
            PhoneNumberLabel.Text = "Phone Number";
            // 
            // PhoneNumberText
            // 
            PhoneNumberText.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneNumberText.Location = new Point(13, 318);
            PhoneNumberText.Name = "PhoneNumberText";
            PhoneNumberText.Size = new Size(175, 35);
            PhoneNumberText.TabIndex = 6;
            PhoneNumberText.KeyDown += PhoneNumberText_KeyDown;
            // 
            // CreateStudentButton
            // 
            CreateStudentButton.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            CreateStudentButton.Location = new Point(13, 388);
            CreateStudentButton.Name = "CreateStudentButton";
            CreateStudentButton.Size = new Size(175, 50);
            CreateStudentButton.TabIndex = 8;
            CreateStudentButton.Text = "Create";
            CreateStudentButton.UseVisualStyleBackColor = true;
            CreateStudentButton.Click += CreateStudentButton_Click;
            // 
            // NewStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 450);
            Controls.Add(CreateStudentButton);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(PhoneNumberText);
            Controls.Add(AgeLabel);
            Controls.Add(AgeText);
            Controls.Add(LastNameLabel);
            Controls.Add(LastNameText);
            Controls.Add(FirstNameLabel);
            Controls.Add(FirstNameText);
            Name = "NewStudent";
            Text = "New Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FirstNameText;
        private Label FirstNameLabel;
        private Label LastNameLabel;
        private TextBox LastNameText;
        private Label AgeLabel;
        private TextBox AgeText;
        private Label PhoneNumberLabel;
        private TextBox PhoneNumberText;
        private Button CreateStudentButton;
    }
}