namespace DaCliqueCardsApp
{
    partial class CardDetails
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
            ClassesListBox = new ListBox();
            SuspendLayout();
            // 
            // ClassesListBox
            // 
            ClassesListBox.FormattingEnabled = true;
            ClassesListBox.ItemHeight = 30;
            ClassesListBox.Location = new Point(12, 12);
            ClassesListBox.Name = "ClassesListBox";
            ClassesListBox.Size = new Size(1066, 484);
            ClassesListBox.TabIndex = 0;
            // 
            // CardDetails
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 533);
            Controls.Add(ClassesListBox);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "CardDetails";
            Text = "CardDetails";
            Load += CardDetails_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox ClassesListBox;
    }
}