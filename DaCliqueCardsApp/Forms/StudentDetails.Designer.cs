namespace DaCliqueCardsApp
{
    partial class StudentDetails
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
            NameLabel = new Label();
            AgeLabel = new Label();
            PhoneNumberLabel = new Label();
            CardsListBox = new ListBox();
            CardDetailsButton = new Button();
            ActiveCardLabel = new Label();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(12, 9);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(69, 30);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name";
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Location = new Point(13, 53);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(50, 30);
            AgeLabel.TabIndex = 1;
            AgeLabel.Text = "Age";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(355, 9);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(154, 30);
            PhoneNumberLabel.TabIndex = 2;
            PhoneNumberLabel.Text = "Phone Number";
            // 
            // CardsListBox
            // 
            CardsListBox.FormattingEnabled = true;
            CardsListBox.ItemHeight = 30;
            CardsListBox.Location = new Point(11, 112);
            CardsListBox.Name = "CardsListBox";
            CardsListBox.Size = new Size(775, 364);
            CardsListBox.TabIndex = 3;
            // 
            // CardDetailsButton
            // 
            CardDetailsButton.Location = new Point(11, 495);
            CardDetailsButton.Name = "CardDetailsButton";
            CardDetailsButton.Size = new Size(775, 55);
            CardDetailsButton.TabIndex = 4;
            CardDetailsButton.Text = "Card Details";
            CardDetailsButton.UseVisualStyleBackColor = true;
            CardDetailsButton.Click += CardDetailsButton_Click;
            // 
            // ActiveCardLabel
            // 
            ActiveCardLabel.AutoSize = true;
            ActiveCardLabel.Location = new Point(355, 53);
            ActiveCardLabel.Name = "ActiveCardLabel";
            ActiveCardLabel.Size = new Size(119, 30);
            ActiveCardLabel.TabIndex = 5;
            ActiveCardLabel.Text = "Active Card";
            // 
            // StudentDetails
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 563);
            Controls.Add(ActiveCardLabel);
            Controls.Add(CardDetailsButton);
            Controls.Add(CardsListBox);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(AgeLabel);
            Controls.Add(NameLabel);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "StudentDetails";
            Load += StudentDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private Label AgeLabel;
        private Label PhoneNumberLabel;
        private ListBox CardsListBox;
        private Button CardDetailsButton;
        private Label ActiveCardLabel;
    }
}