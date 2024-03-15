namespace DaCliqueCardsApp
{
    partial class DeleteReschedule
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
            DeleteClassGroup = new GroupBox();
            DeleteClassButton = new Button();
            ChooseClassLabel = new Label();
            ChooseClassComboBox = new ComboBox();
            RescheduleClass = new GroupBox();
            RescheduleButton = new Button();
            newDatePicker = new DateTimePicker();
            NewDateLabel = new Label();
            DeleteClassGroup.SuspendLayout();
            RescheduleClass.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteClassGroup
            // 
            DeleteClassGroup.Controls.Add(DeleteClassButton);
            DeleteClassGroup.Location = new Point(12, 271);
            DeleteClassGroup.Name = "DeleteClassGroup";
            DeleteClassGroup.Size = new Size(421, 116);
            DeleteClassGroup.TabIndex = 0;
            DeleteClassGroup.TabStop = false;
            DeleteClassGroup.Text = "Delete Class";
            // 
            // DeleteClassButton
            // 
            DeleteClassButton.Location = new Point(112, 34);
            DeleteClassButton.Name = "DeleteClassButton";
            DeleteClassButton.Size = new Size(167, 52);
            DeleteClassButton.TabIndex = 3;
            DeleteClassButton.Text = "Delete";
            DeleteClassButton.UseVisualStyleBackColor = true;
            DeleteClassButton.Click += DeleteClassButton_Click;
            // 
            // ChooseClassLabel
            // 
            ChooseClassLabel.AutoSize = true;
            ChooseClassLabel.Location = new Point(12, 6);
            ChooseClassLabel.Name = "ChooseClassLabel";
            ChooseClassLabel.Size = new Size(135, 30);
            ChooseClassLabel.TabIndex = 2;
            ChooseClassLabel.Text = "Choose Class";
            // 
            // ChooseClassComboBox
            // 
            ChooseClassComboBox.FormattingEnabled = true;
            ChooseClassComboBox.Location = new Point(12, 39);
            ChooseClassComboBox.Name = "ChooseClassComboBox";
            ChooseClassComboBox.RightToLeft = RightToLeft.No;
            ChooseClassComboBox.Size = new Size(1006, 38);
            ChooseClassComboBox.TabIndex = 1;
            // 
            // RescheduleClass
            // 
            RescheduleClass.Controls.Add(RescheduleButton);
            RescheduleClass.Controls.Add(newDatePicker);
            RescheduleClass.Controls.Add(NewDateLabel);
            RescheduleClass.Location = new Point(12, 83);
            RescheduleClass.Name = "RescheduleClass";
            RescheduleClass.Size = new Size(421, 182);
            RescheduleClass.TabIndex = 1;
            RescheduleClass.TabStop = false;
            RescheduleClass.Text = "Reschedule Class";
            // 
            // RescheduleButton
            // 
            RescheduleButton.Location = new Point(112, 119);
            RescheduleButton.Name = "RescheduleButton";
            RescheduleButton.Size = new Size(167, 52);
            RescheduleButton.TabIndex = 6;
            RescheduleButton.Text = "Reshcedule";
            RescheduleButton.UseVisualStyleBackColor = true;
            RescheduleButton.Click += RescheduleButton_Click;
            // 
            // newDatePicker
            // 
            newDatePicker.CustomFormat = "yyyy-dd-MM HH:mm";
            newDatePicker.Format = DateTimePickerFormat.Custom;
            newDatePicker.Location = new Point(0, 64);
            newDatePicker.Name = "newDatePicker";
            newDatePicker.ShowUpDown = true;
            newDatePicker.Size = new Size(220, 35);
            newDatePicker.TabIndex = 2;
            newDatePicker.Value = DateTime.Today;
            // 
            // NewDateLabel
            // 
            NewDateLabel.AutoSize = true;
            NewDateLabel.Location = new Point(6, 31);
            NewDateLabel.Name = "NewDateLabel";
            NewDateLabel.Size = new Size(99, 30);
            NewDateLabel.TabIndex = 5;
            NewDateLabel.Text = "NewDate";
            // 
            // DeleteReschedule
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 428);
            Controls.Add(RescheduleClass);
            Controls.Add(ChooseClassLabel);
            Controls.Add(DeleteClassGroup);
            Controls.Add(ChooseClassComboBox);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "DeleteReschedule";
            RightToLeft = RightToLeft.Yes;
            Text = "Delete/Reschedule";
            Load += DeleteReschedule_Load;
            DeleteClassGroup.ResumeLayout(false);
            RescheduleClass.ResumeLayout(false);
            RescheduleClass.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox DeleteClassGroup;
        private Label ChooseClassLabel;
        private ComboBox ChooseClassComboBox;
        private Button DeleteClassButton;
        private GroupBox RescheduleClass;
        private DateTimePicker newDatePicker;
        private Label NewDateLabel;
        private Button RescheduleButton;
    }
}