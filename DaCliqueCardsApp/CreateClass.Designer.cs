namespace DaCliqueCardsApp
{
    partial class CreateClass
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
            CreateClassLabel = new Label();
            CreateAClassGroupBox = new GroupBox();
            PlacesComboBox = new ComboBox();
            ClassTypesComboBox = new ComboBox();
            ClassDurationDateTimePicker = new DateTimePicker();
            DateLabel = new Label();
            ClassDateDateTimePicker = new DateTimePicker();
            AtendancesCountNumeric = new NumericUpDown();
            PlaceLabel = new Label();
            AtendancesCount = new Label();
            ClassDurationLabel = new Label();
            ClassTypeLabel = new Label();
            StudentsCheckListBox = new CheckedListBox();
            StudentNameText = new TextBox();
            SearchStudentButton = new Button();
            CreateClassButton = new Button();
            CreateAClassGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AtendancesCountNumeric).BeginInit();
            SuspendLayout();
            // 
            // CreateClassLabel
            // 
            CreateClassLabel.AutoSize = true;
            CreateClassLabel.Location = new Point(101, 9);
            CreateClassLabel.Name = "CreateClassLabel";
            CreateClassLabel.Size = new Size(143, 30);
            CreateClassLabel.TabIndex = 0;
            CreateClassLabel.Text = "Create a Class";
            // 
            // CreateAClassGroupBox
            // 
            CreateAClassGroupBox.Controls.Add(PlacesComboBox);
            CreateAClassGroupBox.Controls.Add(ClassTypesComboBox);
            CreateAClassGroupBox.Controls.Add(ClassDurationDateTimePicker);
            CreateAClassGroupBox.Controls.Add(DateLabel);
            CreateAClassGroupBox.Controls.Add(ClassDateDateTimePicker);
            CreateAClassGroupBox.Controls.Add(AtendancesCountNumeric);
            CreateAClassGroupBox.Controls.Add(PlaceLabel);
            CreateAClassGroupBox.Controls.Add(AtendancesCount);
            CreateAClassGroupBox.Controls.Add(ClassDurationLabel);
            CreateAClassGroupBox.Controls.Add(ClassTypeLabel);
            CreateAClassGroupBox.Location = new Point(12, 42);
            CreateAClassGroupBox.Name = "CreateAClassGroupBox";
            CreateAClassGroupBox.Size = new Size(433, 417);
            CreateAClassGroupBox.TabIndex = 1;
            CreateAClassGroupBox.TabStop = false;
            CreateAClassGroupBox.Text = "Class";
            // 
            // PlacesComboBox
            // 
            PlacesComboBox.FormattingEnabled = true;
            PlacesComboBox.Location = new Point(6, 283);
            PlacesComboBox.Name = "PlacesComboBox";
            PlacesComboBox.Size = new Size(419, 38);
            PlacesComboBox.TabIndex = 5;
            // 
            // ClassTypesComboBox
            // 
            ClassTypesComboBox.FormattingEnabled = true;
            ClassTypesComboBox.Location = new Point(6, 64);
            ClassTypesComboBox.Name = "ClassTypesComboBox";
            ClassTypesComboBox.Size = new Size(419, 38);
            ClassTypesComboBox.TabIndex = 4;
            // 
            // ClassDurationDateTimePicker
            // 
            ClassDurationDateTimePicker.CustomFormat = "HH:mm";
            ClassDurationDateTimePicker.Format = DateTimePickerFormat.Custom;
            ClassDurationDateTimePicker.Location = new Point(6, 212);
            ClassDurationDateTimePicker.Name = "ClassDurationDateTimePicker";
            ClassDurationDateTimePicker.ShowUpDown = true;
            ClassDurationDateTimePicker.Size = new Size(97, 35);
            ClassDurationDateTimePicker.TabIndex = 2;
            ClassDurationDateTimePicker.Value = new DateTime(2024, 2, 10, 0, 0, 0, 0);
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(6, 108);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(57, 30);
            DateLabel.TabIndex = 2;
            DateLabel.Text = "Date";
            // 
            // ClassDateDateTimePicker
            // 
            ClassDateDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            ClassDateDateTimePicker.Format = DateTimePickerFormat.Custom;
            ClassDateDateTimePicker.Location = new Point(6, 141);
            ClassDateDateTimePicker.Name = "ClassDateDateTimePicker";
            ClassDateDateTimePicker.ShowUpDown = true;
            ClassDateDateTimePicker.Size = new Size(186, 35);
            ClassDateDateTimePicker.TabIndex = 3;
            ClassDateDateTimePicker.Value = new DateTime(2024, 2, 11, 12, 0, 0, 0);
            // 
            // AtendancesCountNumeric
            // 
            AtendancesCountNumeric.Location = new Point(6, 366);
            AtendancesCountNumeric.Margin = new Padding(9, 12, 9, 12);
            AtendancesCountNumeric.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            AtendancesCountNumeric.Name = "AtendancesCountNumeric";
            AtendancesCountNumeric.Size = new Size(206, 35);
            AtendancesCountNumeric.TabIndex = 2;
            AtendancesCountNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // PlaceLabel
            // 
            PlaceLabel.AutoSize = true;
            PlaceLabel.Location = new Point(6, 250);
            PlaceLabel.Name = "PlaceLabel";
            PlaceLabel.Size = new Size(62, 30);
            PlaceLabel.TabIndex = 2;
            PlaceLabel.Text = "Place";
            // 
            // AtendancesCount
            // 
            AtendancesCount.AutoSize = true;
            AtendancesCount.Location = new Point(6, 324);
            AtendancesCount.Name = "AtendancesCount";
            AtendancesCount.Size = new Size(419, 30);
            AtendancesCount.TabIndex = 2;
            AtendancesCount.Text = "How many attendances should be checked?";
            // 
            // ClassDurationLabel
            // 
            ClassDurationLabel.AutoSize = true;
            ClassDurationLabel.Location = new Point(6, 179);
            ClassDurationLabel.Name = "ClassDurationLabel";
            ClassDurationLabel.Size = new Size(147, 30);
            ClassDurationLabel.TabIndex = 2;
            ClassDurationLabel.Text = "Class Duration";
            // 
            // ClassTypeLabel
            // 
            ClassTypeLabel.AutoSize = true;
            ClassTypeLabel.Location = new Point(6, 31);
            ClassTypeLabel.Name = "ClassTypeLabel";
            ClassTypeLabel.Size = new Size(109, 30);
            ClassTypeLabel.TabIndex = 1;
            ClassTypeLabel.Text = "Class Type";
            // 
            // StudentsCheckListBox
            // 
            StudentsCheckListBox.FormattingEnabled = true;
            StudentsCheckListBox.Location = new Point(476, 109);
            StudentsCheckListBox.Name = "StudentsCheckListBox";
            StudentsCheckListBox.Size = new Size(581, 334);
            StudentsCheckListBox.TabIndex = 6;
            StudentsCheckListBox.ThreeDCheckBoxes = true;
            StudentsCheckListBox.UseCompatibleTextRendering = true;
            // 
            // StudentNameText
            // 
            StudentNameText.Location = new Point(476, 12);
            StudentNameText.Name = "StudentNameText";
            StudentNameText.Size = new Size(581, 35);
            StudentNameText.TabIndex = 7;
            // 
            // SearchStudentButton
            // 
            SearchStudentButton.Location = new Point(476, 53);
            SearchStudentButton.Name = "SearchStudentButton";
            SearchStudentButton.Size = new Size(581, 50);
            SearchStudentButton.TabIndex = 8;
            SearchStudentButton.Text = "Search";
            SearchStudentButton.UseVisualStyleBackColor = true;
            SearchStudentButton.Click += SearchStudentButton_Click;
            // 
            // CreateClassButton
            // 
            CreateClassButton.Location = new Point(386, 465);
            CreateClassButton.Name = "CreateClassButton";
            CreateClassButton.Size = new Size(223, 77);
            CreateClassButton.TabIndex = 9;
            CreateClassButton.Text = "Create";
            CreateClassButton.UseVisualStyleBackColor = true;
            CreateClassButton.Click += CreateClassButton_Click;
            // 
            // CreateClass
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 570);
            Controls.Add(CreateClassButton);
            Controls.Add(SearchStudentButton);
            Controls.Add(StudentNameText);
            Controls.Add(StudentsCheckListBox);
            Controls.Add(CreateAClassGroupBox);
            Controls.Add(CreateClassLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreateClass";
            Text = "Create Class";
            Load += CheckCards_Load;
            CreateAClassGroupBox.ResumeLayout(false);
            CreateAClassGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AtendancesCountNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CreateClassLabel;
        private GroupBox CreateAClassGroupBox;
        private Label ClassTypeLabel;
        private Label DateLabel;
        private Label PlaceLabel;
        private Label AtendancesCount;
        private Label ClassDurationLabel;
        private NumericUpDown AtendancesCountNumeric;
        private DateTimePicker ClassDateDateTimePicker;
        private DateTimePicker ClassDurationDateTimePicker;
        private ComboBox PlacesComboBox;
        private ComboBox ClassTypesComboBox;
        private CheckedListBox StudentsCheckListBox;
        private TextBox StudentNameText;
        private Button SearchStudentButton;
        private Button CreateClassButton;
    }
}