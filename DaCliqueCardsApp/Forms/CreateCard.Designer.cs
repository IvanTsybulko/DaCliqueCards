namespace DaCliqueCardsApp
{
    partial class CreateCard
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
            lastNameLabel = new Label();
            lastNameText = new TextBox();
            searchStudentButton = new Button();
            StudentsListBox = new ListBox();
            StartingDateDateTimePicker = new DateTimePicker();
            FromLabel = new Label();
            CardTypesListBox = new ListBox();
            ChooseCardLabel = new Label();
            CreateCardButton = new Button();
            SuspendLayout();
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(12, 9);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(69, 30);
            lastNameLabel.TabIndex = 0;
            lastNameLabel.Text = "Name";
            // 
            // lastNameText
            // 
            lastNameText.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameText.Location = new Point(12, 42);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(459, 35);
            lastNameText.TabIndex = 1;
            lastNameText.KeyDown += lastNameText_KeyDown;
            // 
            // searchStudentButton
            // 
            searchStudentButton.Cursor = Cursors.Hand;
            searchStudentButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchStudentButton.Location = new Point(12, 83);
            searchStudentButton.Name = "searchStudentButton";
            searchStudentButton.Size = new Size(459, 37);
            searchStudentButton.TabIndex = 2;
            searchStudentButton.Text = "Search";
            searchStudentButton.UseVisualStyleBackColor = true;
            searchStudentButton.Click += searchStudentButton_Click;
            // 
            // StudentsListBox
            // 
            StudentsListBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            StudentsListBox.FormattingEnabled = true;
            StudentsListBox.ItemHeight = 30;
            StudentsListBox.Location = new Point(12, 126);
            StudentsListBox.Name = "StudentsListBox";
            StudentsListBox.Size = new Size(459, 274);
            StudentsListBox.TabIndex = 3;
            // 
            // StartingDateDateTimePicker
            // 
            StartingDateDateTimePicker.CalendarFont = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            StartingDateDateTimePicker.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            StartingDateDateTimePicker.Location = new Point(486, 42);
            StartingDateDateTimePicker.Name = "StartingDateDateTimePicker";
            StartingDateDateTimePicker.Size = new Size(442, 35);
            StartingDateDateTimePicker.TabIndex = 4;
            // 
            // FromLabel
            // 
            FromLabel.AutoSize = true;
            FromLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            FromLabel.Location = new Point(486, 9);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(60, 30);
            FromLabel.TabIndex = 5;
            FromLabel.Text = "From";
            // 
            // CardTypesListBox
            // 
            CardTypesListBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CardTypesListBox.FormattingEnabled = true;
            CardTypesListBox.ItemHeight = 30;
            CardTypesListBox.Location = new Point(477, 126);
            CardTypesListBox.Name = "CardTypesListBox";
            CardTypesListBox.Size = new Size(451, 274);
            CardTypesListBox.TabIndex = 6;
            // 
            // ChooseCardLabel
            // 
            ChooseCardLabel.AutoSize = true;
            ChooseCardLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            ChooseCardLabel.Location = new Point(486, 90);
            ChooseCardLabel.Name = "ChooseCardLabel";
            ChooseCardLabel.Size = new Size(131, 30);
            ChooseCardLabel.TabIndex = 7;
            ChooseCardLabel.Text = "Choose Card";
            // 
            // CreateCardButton
            // 
            CreateCardButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CreateCardButton.Location = new Point(377, 406);
            CreateCardButton.Name = "CreateCardButton";
            CreateCardButton.Size = new Size(186, 60);
            CreateCardButton.TabIndex = 8;
            CreateCardButton.Text = "Create";
            CreateCardButton.UseVisualStyleBackColor = true;
            CreateCardButton.Click += CreateCardButton_Click;
            // 
            // CreateCard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(CreateCardButton);
            Controls.Add(ChooseCardLabel);
            Controls.Add(CardTypesListBox);
            Controls.Add(FromLabel);
            Controls.Add(StartingDateDateTimePicker);
            Controls.Add(StudentsListBox);
            Controls.Add(searchStudentButton);
            Controls.Add(lastNameText);
            Controls.Add(lastNameLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "CreateCard";
            Text = "New Card";
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lastNameLabel;
        private TextBox lastNameText;
        private Button searchStudentButton;
        private ListBox StudentsListBox;
        private DateTimePicker StartingDateDateTimePicker;
        private Label FromLabel;
        private ListBox CardTypesListBox;
        private Label ChooseCardLabel;
        private Button CreateCardButton;
    }
}