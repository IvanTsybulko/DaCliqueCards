namespace DaCliqueCardsApp
{
    partial class LogIn
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
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            UsernameText = new TextBox();
            PasswordText = new TextBox();
            LogInButton = new Button();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameLabel.Location = new Point(12, 9);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(111, 30);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordLabel.Location = new Point(12, 80);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(104, 30);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Password:";
            // 
            // UsernameText
            // 
            UsernameText.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameText.Location = new Point(12, 42);
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(248, 35);
            UsernameText.TabIndex = 2;
            UsernameText.KeyDown += UsernameText_KeyDown;
            // 
            // PasswordText
            // 
            PasswordText.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordText.Location = new Point(12, 113);
            PasswordText.Name = "PasswordText";
            PasswordText.PasswordChar = '*';
            PasswordText.Size = new Size(248, 35);
            PasswordText.TabIndex = 3;
            PasswordText.KeyDown += PasswordText_KeyDown;
            // 
            // LogInButton
            // 
            LogInButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LogInButton.Location = new Point(12, 154);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(248, 46);
            LogInButton.TabIndex = 4;
            LogInButton.Text = "Log In";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 227);
            Controls.Add(LogInButton);
            Controls.Add(PasswordText);
            Controls.Add(UsernameText);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UsernameLabel;
        private Label PasswordLabel;
        private TextBox UsernameText;
        private TextBox PasswordText;
        private Button LogInButton;
    }
}