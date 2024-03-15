namespace DaCliqueCardsApp
{
    partial class CheckCards
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
            ChooseClassLabel = new Label();
            ChooseStudentsLabel = new Label();
            SearchStudentButton = new Button();
            StudentNameText = new TextBox();
            StudentsCheckListBox = new CheckedListBox();
            ChooseClassComboBox = new ComboBox();
            CheckCardsButton = new Button();
            SuspendLayout();
            // 
            // ChooseClassLabel
            // 
            ChooseClassLabel.AutoSize = true;
            ChooseClassLabel.Location = new Point(12, 9);
            ChooseClassLabel.Name = "ChooseClassLabel";
            ChooseClassLabel.Size = new Size(135, 30);
            ChooseClassLabel.TabIndex = 2;
            ChooseClassLabel.Text = "Choose Class";
            // 
            // ChooseStudentsLabel
            // 
            ChooseStudentsLabel.AutoSize = true;
            ChooseStudentsLabel.Location = new Point(12, 83);
            ChooseStudentsLabel.Name = "ChooseStudentsLabel";
            ChooseStudentsLabel.Size = new Size(168, 30);
            ChooseStudentsLabel.TabIndex = 4;
            ChooseStudentsLabel.Text = "Choose Students";
            // 
            // SearchStudentButton
            // 
            SearchStudentButton.Location = new Point(12, 157);
            SearchStudentButton.Name = "SearchStudentButton";
            SearchStudentButton.Size = new Size(1016, 50);
            SearchStudentButton.TabIndex = 11;
            SearchStudentButton.Text = "Search";
            SearchStudentButton.UseVisualStyleBackColor = true;
            SearchStudentButton.Click += SearchStudentButton_Click;
            // 
            // StudentNameText
            // 
            StudentNameText.Location = new Point(12, 116);
            StudentNameText.Name = "StudentNameText";
            StudentNameText.Size = new Size(1016, 35);
            StudentNameText.TabIndex = 10;
            // 
            // StudentsCheckListBox
            // 
            StudentsCheckListBox.FormattingEnabled = true;
            StudentsCheckListBox.Location = new Point(12, 213);
            StudentsCheckListBox.Name = "StudentsCheckListBox";
            StudentsCheckListBox.Size = new Size(1016, 304);
            StudentsCheckListBox.TabIndex = 9;
            StudentsCheckListBox.ThreeDCheckBoxes = true;
            StudentsCheckListBox.UseCompatibleTextRendering = true;
            // 
            // ChooseClassComboBox
            // 
            ChooseClassComboBox.FormattingEnabled = true;
            ChooseClassComboBox.Location = new Point(12, 42);
            ChooseClassComboBox.Name = "ChooseClassComboBox";
            ChooseClassComboBox.Size = new Size(1016, 38);
            ChooseClassComboBox.TabIndex = 12;
            ChooseClassComboBox.SelectedIndexChanged += ChooseClassComboBox_SelectedIndexChanged;
            // 
            // CheckCardsButton
            // 
            CheckCardsButton.Location = new Point(12, 523);
            CheckCardsButton.Name = "CheckCardsButton";
            CheckCardsButton.Size = new Size(1016, 50);
            CheckCardsButton.TabIndex = 13;
            CheckCardsButton.Text = "Check";
            CheckCardsButton.UseVisualStyleBackColor = true;
            CheckCardsButton.Click += CheckCardsButton_Click;
            // 
            // CheckCards
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 598);
            Controls.Add(CheckCardsButton);
            Controls.Add(ChooseClassComboBox);
            Controls.Add(SearchStudentButton);
            Controls.Add(StudentNameText);
            Controls.Add(StudentsCheckListBox);
            Controls.Add(ChooseStudentsLabel);
            Controls.Add(ChooseClassLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CheckCards";
            Text = "CheckCards";
            Load += CheckCards_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label ChooseClassLabel;
        private Label ChooseStudentsLabel;
        private Button SearchStudentButton;
        private TextBox StudentNameText;
        private CheckedListBox StudentsCheckListBox;
        private ComboBox ChooseClassComboBox;
        private Button CheckCardsButton;
    }
}