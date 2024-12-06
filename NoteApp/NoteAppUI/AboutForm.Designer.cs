namespace NoteAppUI
{
    partial class AboutForm
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
            TItleAppLabel = new Label();
            AuthorValueLabel = new Label();
            AuthorLabel = new Label();
            EmailValueLabel = new Label();
            EmailLabel = new Label();
            GitHubValueLabel = new Label();
            GitHubLabel = new Label();
            InfoLabel = new Label();
            VersionLabel = new Label();
            SuspendLayout();
            // 
            // TItleAppLabel
            // 
            TItleAppLabel.AutoSize = true;
            TItleAppLabel.Font = new Font("Segoe UI Black", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TItleAppLabel.Location = new Point(50, 9);
            TItleAppLabel.Name = "TItleAppLabel";
            TItleAppLabel.Size = new Size(272, 72);
            TItleAppLabel.TabIndex = 0;
            TItleAppLabel.Text = "NoteApp";
            // 
            // AuthorValueLabel
            // 
            AuthorValueLabel.AutoSize = true;
            AuthorValueLabel.Location = new Point(400, 200);
            AuthorValueLabel.Name = "AuthorValueLabel";
            AuthorValueLabel.Size = new Size(97, 41);
            AuthorValueLabel.TabIndex = 1;
            AuthorValueLabel.Text = "label2";
            // 
            // AuthorLabel
            // 
            AuthorLabel.AutoSize = true;
            AuthorLabel.Location = new Point(50, 200);
            AuthorLabel.Name = "AuthorLabel";
            AuthorLabel.Size = new Size(124, 41);
            AuthorLabel.TabIndex = 2;
            AuthorLabel.Text = "Author: ";
            // 
            // EmailValueLabel
            // 
            EmailValueLabel.AutoSize = true;
            EmailValueLabel.Location = new Point(400, 280);
            EmailValueLabel.Name = "EmailValueLabel";
            EmailValueLabel.Size = new Size(97, 41);
            EmailValueLabel.TabIndex = 3;
            EmailValueLabel.Text = "label4";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(50, 280);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(272, 41);
            EmailLabel.TabIndex = 4;
            EmailLabel.Text = "e-mail for feeback: ";
            // 
            // GitHubValueLabel
            // 
            GitHubValueLabel.AutoSize = true;
            GitHubValueLabel.Location = new Point(400, 360);
            GitHubValueLabel.Name = "GitHubValueLabel";
            GitHubValueLabel.Size = new Size(97, 41);
            GitHubValueLabel.TabIndex = 5;
            GitHubValueLabel.Text = "label6";
            // 
            // GitHubLabel
            // 
            GitHubLabel.AutoSize = true;
            GitHubLabel.Location = new Point(50, 360);
            GitHubLabel.Name = "GitHubLabel";
            GitHubLabel.Size = new Size(127, 41);
            GitHubLabel.TabIndex = 6;
            GitHubLabel.Text = "GitHub: ";
            // 
            // InfoLabel
            // 
            InfoLabel.AutoSize = true;
            InfoLabel.Location = new Point(50, 607);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(97, 41);
            InfoLabel.TabIndex = 7;
            InfoLabel.Text = "label8";
            // 
            // VersionLabel
            // 
            VersionLabel.AutoSize = true;
            VersionLabel.Location = new Point(50, 100);
            VersionLabel.Name = "VersionLabel";
            VersionLabel.Size = new Size(97, 41);
            VersionLabel.TabIndex = 8;
            VersionLabel.Text = "label9";
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1027, 666);
            Controls.Add(VersionLabel);
            Controls.Add(InfoLabel);
            Controls.Add(GitHubLabel);
            Controls.Add(GitHubValueLabel);
            Controls.Add(EmailLabel);
            Controls.Add(EmailValueLabel);
            Controls.Add(AuthorLabel);
            Controls.Add(AuthorValueLabel);
            Controls.Add(TItleAppLabel);
            Name = "AboutForm";
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TItleAppLabel;
        private Label AuthorValueLabel;
        private Label AuthorLabel;
        private Label EmailValueLabel;
        private Label EmailLabel;
        private Label GitHubValueLabel;
        private Label GitHubLabel;
        private Label InfoLabel;
        private Label VersionLabel;
    }
}