namespace DaCliqueCardsApp
{
    partial class AllStudents
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
            StudentsListBox = new ListBox();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            SearchStudentButton = new Button();
            DetailsButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // StudentsListBox
            // 
            StudentsListBox.FormattingEnabled = true;
            StudentsListBox.ItemHeight = 30;
            StudentsListBox.Location = new Point(12, 137);
            StudentsListBox.Name = "StudentsListBox";
            StudentsListBox.Size = new Size(904, 364);
            StudentsListBox.TabIndex = 0;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(12, 9);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(69, 30);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 42);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(581, 35);
            NameTextBox.TabIndex = 2;
            // 
            // SearchStudentButton
            // 
            SearchStudentButton.Location = new Point(12, 83);
            SearchStudentButton.Name = "SearchStudentButton";
            SearchStudentButton.Size = new Size(904, 48);
            SearchStudentButton.TabIndex = 3;
            SearchStudentButton.Text = "Search";
            SearchStudentButton.UseVisualStyleBackColor = true;
            SearchStudentButton.Click += SearchStudentButton_Click;
            // 
            // DetailsButton
            // 
            DetailsButton.Location = new Point(12, 507);
            DetailsButton.Name = "DetailsButton";
            DetailsButton.Size = new Size(904, 48);
            DetailsButton.TabIndex = 4;
            DetailsButton.Text = "Open More Details";
            DetailsButton.UseVisualStyleBackColor = true;
            DetailsButton.Click += DetailsButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(435, 586);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // AllStudents
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 564);
            Controls.Add(button1);
            Controls.Add(DetailsButton);
            Controls.Add(SearchStudentButton);
            Controls.Add(NameTextBox);
            Controls.Add(NameLabel);
            Controls.Add(StudentsListBox);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AllStudents";
            Text = "AllStudents";
            Load += AllStudents_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox StudentsListBox;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Button SearchStudentButton;
        private Button DetailsButton;
        private Button button1;
    }
}