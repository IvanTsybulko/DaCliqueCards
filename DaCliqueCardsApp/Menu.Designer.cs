namespace DaCliqueCardsApp
{
    partial class Menu
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
            NewCardButton = new Button();
            NewStudentButton = new Button();
            CreateClassButton = new Button();
            CheckCardsButton = new Button();
            DeleteRescheduleButton = new Button();
            AllClassesButton = new Button();
            AllStudentsButton = new Button();
            SuspendLayout();
            // 
            // NewCardButton
            // 
            NewCardButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NewCardButton.Location = new Point(97, 156);
            NewCardButton.Name = "NewCardButton";
            NewCardButton.Size = new Size(177, 70);
            NewCardButton.TabIndex = 1;
            NewCardButton.Text = "New Card";
            NewCardButton.UseVisualStyleBackColor = true;
            NewCardButton.Click += NewCardButton_Click;
            // 
            // NewStudentButton
            // 
            NewStudentButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            NewStudentButton.Location = new Point(280, 156);
            NewStudentButton.Name = "NewStudentButton";
            NewStudentButton.Size = new Size(177, 70);
            NewStudentButton.TabIndex = 2;
            NewStudentButton.Text = "New Student";
            NewStudentButton.UseVisualStyleBackColor = true;
            NewStudentButton.Click += NewStudentButton_Click;
            // 
            // CreateClassButton
            // 
            CreateClassButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CreateClassButton.Location = new Point(463, 156);
            CreateClassButton.Name = "CreateClassButton";
            CreateClassButton.Size = new Size(210, 70);
            CreateClassButton.TabIndex = 3;
            CreateClassButton.Text = "Create Class";
            CreateClassButton.UseVisualStyleBackColor = true;
            CreateClassButton.Click += CreateClassButton_Click_1;
            // 
            // CheckCardsButton
            // 
            CheckCardsButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            CheckCardsButton.Location = new Point(97, 232);
            CheckCardsButton.Name = "CheckCardsButton";
            CheckCardsButton.Size = new Size(177, 70);
            CheckCardsButton.TabIndex = 4;
            CheckCardsButton.Text = "Check Cards";
            CheckCardsButton.UseVisualStyleBackColor = true;
            CheckCardsButton.Click += CheckCardsButton_Click;
            // 
            // DeleteRescheduleButton
            // 
            DeleteRescheduleButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteRescheduleButton.Location = new Point(463, 232);
            DeleteRescheduleButton.Name = "DeleteRescheduleButton";
            DeleteRescheduleButton.Size = new Size(210, 70);
            DeleteRescheduleButton.TabIndex = 5;
            DeleteRescheduleButton.Text = "Delete/Reschedule";
            DeleteRescheduleButton.UseVisualStyleBackColor = true;
            DeleteRescheduleButton.Click += DeleteRescheduleButton_Click;
            // 
            // AllClassesButton
            // 
            AllClassesButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AllClassesButton.Location = new Point(280, 232);
            AllClassesButton.Name = "AllClassesButton";
            AllClassesButton.Size = new Size(177, 70);
            AllClassesButton.TabIndex = 6;
            AllClassesButton.Text = "All Classes";
            AllClassesButton.UseVisualStyleBackColor = true;
            AllClassesButton.Click += AllClassesButton_Click;
            // 
            // AllStudentsButton
            // 
            AllStudentsButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            AllStudentsButton.Location = new Point(280, 308);
            AllStudentsButton.Name = "AllStudentsButton";
            AllStudentsButton.Size = new Size(177, 70);
            AllStudentsButton.TabIndex = 7;
            AllStudentsButton.Text = "All Students";
            AllStudentsButton.UseVisualStyleBackColor = true;
            AllStudentsButton.Click += AllStudentsButton_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AllStudentsButton);
            Controls.Add(AllClassesButton);
            Controls.Add(DeleteRescheduleButton);
            Controls.Add(CheckCardsButton);
            Controls.Add(CreateClassButton);
            Controls.Add(NewStudentButton);
            Controls.Add(NewCardButton);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Button NewCardButton;
        private Button NewStudentButton;
        private Button CreateClassButton;
        private Button CheckCardsButton;
        private Button DeleteRescheduleButton;
        private Button AllClassesButton;
        private Button AllStudentsButton;
    }
}