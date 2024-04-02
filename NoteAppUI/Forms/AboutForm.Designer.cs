namespace NoteAppUI.Forms
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
			NoteAppLabel = new Label();
			VersionLabel = new Label();
			AuthorLabel = new Label();
			EmailLabel = new Label();
			GithubLabel = new Label();
			EmailLinkLabel = new LinkLabel();
			GitHubLinkLabel = new LinkLabel();
			AppInfoLabel = new Label();
			SuspendLayout();
			// 
			// NoteAppLabel
			// 
			NoteAppLabel.AutoSize = true;
			NoteAppLabel.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
			NoteAppLabel.Location = new Point(12, 9);
			NoteAppLabel.Name = "NoteAppLabel";
			NoteAppLabel.RightToLeft = RightToLeft.Yes;
			NoteAppLabel.Size = new Size(152, 41);
			NoteAppLabel.TabIndex = 1;
			NoteAppLabel.Text = "NoteApp";
			// 
			// VersionLabel
			// 
			VersionLabel.AutoSize = true;
			VersionLabel.Location = new Point(12, 50);
			VersionLabel.Name = "VersionLabel";
			VersionLabel.Size = new Size(49, 20);
			VersionLabel.TabIndex = 2;
			VersionLabel.Text = "v.1.0.0";
			// 
			// AuthorLabel
			// 
			AuthorLabel.AutoSize = true;
			AuthorLabel.Location = new Point(12, 109);
			AuthorLabel.Name = "AuthorLabel";
			AuthorLabel.Size = new Size(184, 20);
			AuthorLabel.TabIndex = 3;
			AuthorLabel.Text = "Author: Varvara Borovkova";
			// 
			// EmailLabel
			// 
			EmailLabel.AutoSize = true;
			EmailLabel.Location = new Point(12, 179);
			EmailLabel.Name = "EmailLabel";
			EmailLabel.Size = new Size(143, 20);
			EmailLabel.TabIndex = 4;
			EmailLabel.Text = "e-mail for feedback:";
			// 
			// GithubLabel
			// 
			GithubLabel.AutoSize = true;
			GithubLabel.Location = new Point(12, 211);
			GithubLabel.Name = "GithubLabel";
			GithubLabel.Size = new Size(56, 20);
			GithubLabel.TabIndex = 5;
			GithubLabel.Text = "Github:";
			// 
			// EmailLinkLabel
			// 
			EmailLinkLabel.AutoSize = true;
			EmailLinkLabel.Location = new Point(161, 179);
			EmailLinkLabel.Name = "EmailLinkLabel";
			EmailLinkLabel.Size = new Size(246, 20);
			EmailLinkLabel.TabIndex = 6;
			EmailLinkLabel.TabStop = true;
			EmailLinkLabel.Text = "varvara.borovkova1405@gmail.com";
			// 
			// GitHubLinkLabel
			// 
			GitHubLinkLabel.AutoSize = true;
			GitHubLinkLabel.Location = new Point(74, 211);
			GitHubLinkLabel.Name = "GitHubLinkLabel";
			GitHubLinkLabel.Size = new Size(194, 20);
			GitHubLinkLabel.TabIndex = 7;
			GitHubLinkLabel.TabStop = true;
			GitHubLinkLabel.Text = "https://github.com/mionalis";
			// 
			// AppInfoLabel
			// 
			AppInfoLabel.AutoSize = true;
			AppInfoLabel.Location = new Point(12, 350);
			AppInfoLabel.Name = "AppInfoLabel";
			AppInfoLabel.Size = new Size(185, 20);
			AppInfoLabel.TabIndex = 8;
			AppInfoLabel.Text = "2024 Varvara Borovkova ⓒ";
			// 
			// AboutForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(540, 379);
			Controls.Add(AppInfoLabel);
			Controls.Add(GitHubLinkLabel);
			Controls.Add(EmailLinkLabel);
			Controls.Add(GithubLabel);
			Controls.Add(EmailLabel);
			Controls.Add(AuthorLabel);
			Controls.Add(VersionLabel);
			Controls.Add(NoteAppLabel);
			Name = "AboutForm";
			Text = "AboutForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label NoteAppLabel;
		private Label VersionLabel;
		private Label AuthorLabel;
		private Label EmailLabel;
		private Label GithubLabel;
		private LinkLabel EmailLinkLabel;
		private LinkLabel GitHubLinkLabel;
		private Label AppInfoLabel;
	}
}