namespace DaCliqueCardsApp
{
    partial class AllClasses
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
            FromLabel = new Label();
            ToLabel = new Label();
            BegginingDateTimePicker = new DateTimePicker();
            EndDateTimePicker = new DateTimePicker();
            ClassesListBox = new ListBox();
            SearchButton = new Button();
            DetailsButton = new Button();
            PlaceComboBox = new ComboBox();
            SuspendLayout();
            // 
            // FromLabel
            // 
            FromLabel.AutoSize = true;
            FromLabel.Location = new Point(12, 9);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(60, 30);
            FromLabel.TabIndex = 0;
            FromLabel.Text = "From";
            // 
            // ToLabel
            // 
            ToLabel.AutoSize = true;
            ToLabel.Location = new Point(12, 80);
            ToLabel.Name = "ToLabel";
            ToLabel.Size = new Size(34, 30);
            ToLabel.TabIndex = 1;
            ToLabel.Text = "To";
            // 
            // BegginingDateTimePicker
            // 
            BegginingDateTimePicker.Location = new Point(12, 42);
            BegginingDateTimePicker.Name = "BegginingDateTimePicker";
            BegginingDateTimePicker.Size = new Size(342, 35);
            BegginingDateTimePicker.TabIndex = 2;
            BegginingDateTimePicker.Value = new DateTime(2024, 3, 7, 0, 0, 0, 0);
            // 
            // EndDateTimePicker
            // 
            EndDateTimePicker.Location = new Point(12, 113);
            EndDateTimePicker.Name = "EndDateTimePicker";
            EndDateTimePicker.Size = new Size(342, 35);
            EndDateTimePicker.TabIndex = 3;
            EndDateTimePicker.Value = new DateTime(2024, 3, 7, 23, 59, 59, 0);
            // 
            // ClassesListBox
            // 
            ClassesListBox.FormattingEnabled = true;
            ClassesListBox.ItemHeight = 30;
            ClassesListBox.Location = new Point(12, 221);
            ClassesListBox.Name = "ClassesListBox";
            ClassesListBox.Size = new Size(909, 334);
            ClassesListBox.TabIndex = 4;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(12, 154);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(909, 61);
            SearchButton.TabIndex = 5;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // DetailsButton
            // 
            DetailsButton.Location = new Point(12, 561);
            DetailsButton.Name = "DetailsButton";
            DetailsButton.Size = new Size(909, 61);
            DetailsButton.TabIndex = 6;
            DetailsButton.Text = "Open More Details";
            DetailsButton.UseVisualStyleBackColor = true;
            DetailsButton.Click += DetailsButton_Click;
            // 
            // PlaceComboBox
            // 
            PlaceComboBox.FormattingEnabled = true;
            PlaceComboBox.Location = new Point(504, 72);
            PlaceComboBox.Name = "PlaceComboBox";
            PlaceComboBox.Size = new Size(265, 38);
            PlaceComboBox.TabIndex = 7;
            // 
            // AllClasses
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 627);
            Controls.Add(PlaceComboBox);
            Controls.Add(DetailsButton);
            Controls.Add(SearchButton);
            Controls.Add(ClassesListBox);
            Controls.Add(EndDateTimePicker);
            Controls.Add(BegginingDateTimePicker);
            Controls.Add(ToLabel);
            Controls.Add(FromLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AllClasses";
            Text = "All Classes";
            Load += AllClasses_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FromLabel;
        private Label ToLabel;
        private DateTimePicker BegginingDateTimePicker;
        private DateTimePicker EndDateTimePicker;
        private ListBox ClassesListBox;
        private Button SearchButton;
        private Button DetailsButton;
        private ComboBox PlaceComboBox;
    }
}