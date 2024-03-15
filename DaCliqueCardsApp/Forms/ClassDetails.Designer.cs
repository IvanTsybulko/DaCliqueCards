namespace DaCliqueCardsApp
{
    partial class ClassDetails
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
            DateLabel = new Label();
            StartsLabel = new Label();
            EndsLabel = new Label();
            PlaceLabel = new Label();
            CoachLabel = new Label();
            AttendancesLabel = new Label();
            ClassTypeLabel = new Label();
            StudentsListBox = new ListBox();
            SuspendLayout();
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(5, 9);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(57, 30);
            DateLabel.TabIndex = 0;
            DateLabel.Text = "Date";
            // 
            // StartsLabel
            // 
            StartsLabel.AutoSize = true;
            StartsLabel.Location = new Point(5, 51);
            StartsLabel.Name = "StartsLabel";
            StartsLabel.Size = new Size(64, 30);
            StartsLabel.TabIndex = 1;
            StartsLabel.Text = "Starts";
            // 
            // EndsLabel
            // 
            EndsLabel.AutoSize = true;
            EndsLabel.Location = new Point(5, 92);
            EndsLabel.Name = "EndsLabel";
            EndsLabel.Size = new Size(57, 30);
            EndsLabel.TabIndex = 2;
            EndsLabel.Text = "Ends";
            // 
            // PlaceLabel
            // 
            PlaceLabel.AutoSize = true;
            PlaceLabel.Location = new Point(5, 176);
            PlaceLabel.Name = "PlaceLabel";
            PlaceLabel.Size = new Size(62, 30);
            PlaceLabel.TabIndex = 3;
            PlaceLabel.Text = "Place";
            // 
            // CoachLabel
            // 
            CoachLabel.AutoSize = true;
            CoachLabel.Location = new Point(5, 216);
            CoachLabel.Name = "CoachLabel";
            CoachLabel.Size = new Size(71, 30);
            CoachLabel.TabIndex = 4;
            CoachLabel.Text = "Coach";
            // 
            // AttendancesLabel
            // 
            AttendancesLabel.AutoSize = true;
            AttendancesLabel.Location = new Point(5, 136);
            AttendancesLabel.Name = "AttendancesLabel";
            AttendancesLabel.Size = new Size(129, 30);
            AttendancesLabel.TabIndex = 5;
            AttendancesLabel.Text = "Attendances";
            // 
            // ClassTypeLabel
            // 
            ClassTypeLabel.AutoSize = true;
            ClassTypeLabel.Location = new Point(8, 260);
            ClassTypeLabel.Name = "ClassTypeLabel";
            ClassTypeLabel.Size = new Size(109, 30);
            ClassTypeLabel.TabIndex = 6;
            ClassTypeLabel.Text = "Class Type";
            // 
            // StudentsListBox
            // 
            StudentsListBox.FormattingEnabled = true;
            StudentsListBox.ItemHeight = 30;
            StudentsListBox.Location = new Point(487, 9);
            StudentsListBox.Name = "StudentsListBox";
            StudentsListBox.Size = new Size(644, 334);
            StudentsListBox.TabIndex = 7;
            // 
            // ClassDetails
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 379);
            Controls.Add(StudentsListBox);
            Controls.Add(ClassTypeLabel);
            Controls.Add(AttendancesLabel);
            Controls.Add(CoachLabel);
            Controls.Add(PlaceLabel);
            Controls.Add(EndsLabel);
            Controls.Add(StartsLabel);
            Controls.Add(DateLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ClassDetails";
            Text = "ClassDetails";
            Load += ClassDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DateLabel;
        private Label StartsLabel;
        private Label EndsLabel;
        private Label PlaceLabel;
        private Label CoachLabel;
        private Label AttendancesLabel;
        private Label ClassTypeLabel;
        private ListBox StudentsListBox;
    }
}