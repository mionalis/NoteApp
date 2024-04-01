namespace NoteAppUI
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			checkButton = new Button();
			TitleLabel = new Label();
			ContentLabel = new Label();
			CategoryLabel = new Label();
			IDLabel = new Label();
			LastModifiedTimeLabel = new Label();
			CreationTimeLabel = new Label();
			SuspendLayout();
			// 
			// checkButton
			// 
			checkButton.Location = new Point(295, 151);
			checkButton.Name = "checkButton";
			checkButton.Size = new Size(94, 29);
			checkButton.TabIndex = 1;
			checkButton.Text = "Check ";
			checkButton.UseVisualStyleBackColor = true;
			checkButton.Click += checkButton_Click;
			// 
			// TitleLabel
			// 
			TitleLabel.AutoSize = true;
			TitleLabel.Location = new Point(92, 71);
			TitleLabel.Name = "TitleLabel";
			TitleLabel.Size = new Size(38, 20);
			TitleLabel.TabIndex = 2;
			TitleLabel.Text = "Title";
			// 
			// ContentLabel
			// 
			ContentLabel.AutoSize = true;
			ContentLabel.Location = new Point(92, 91);
			ContentLabel.Name = "ContentLabel";
			ContentLabel.Size = new Size(61, 20);
			ContentLabel.TabIndex = 3;
			ContentLabel.Text = "Content";
			// 
			// CategoryLabel
			// 
			CategoryLabel.AutoSize = true;
			CategoryLabel.Location = new Point(92, 111);
			CategoryLabel.Name = "CategoryLabel";
			CategoryLabel.Size = new Size(69, 20);
			CategoryLabel.TabIndex = 4;
			CategoryLabel.Text = "Category";
			// 
			// IDLabel
			// 
			IDLabel.AutoSize = true;
			IDLabel.Location = new Point(92, 51);
			IDLabel.Name = "IDLabel";
			IDLabel.Size = new Size(24, 20);
			IDLabel.TabIndex = 5;
			IDLabel.Text = "ID";
			// 
			// LastModifiedTimeLabel
			// 
			LastModifiedTimeLabel.AutoSize = true;
			LastModifiedTimeLabel.Location = new Point(92, 131);
			LastModifiedTimeLabel.Name = "LastModifiedTimeLabel";
			LastModifiedTimeLabel.Size = new Size(129, 20);
			LastModifiedTimeLabel.TabIndex = 6;
			LastModifiedTimeLabel.Text = "LastModifiedTime";
			// 
			// CreationTimeLabel
			// 
			CreationTimeLabel.AutoSize = true;
			CreationTimeLabel.Location = new Point(92, 151);
			CreationTimeLabel.Name = "CreationTimeLabel";
			CreationTimeLabel.Size = new Size(98, 20);
			CreationTimeLabel.TabIndex = 7;
			CreationTimeLabel.Text = "CreationTime";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(570, 283);
			Controls.Add(CreationTimeLabel);
			Controls.Add(LastModifiedTimeLabel);
			Controls.Add(IDLabel);
			Controls.Add(CategoryLabel);
			Controls.Add(ContentLabel);
			Controls.Add(TitleLabel);
			Controls.Add(checkButton);
			Name = "MainForm";
			Text = "NoteApp";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button checkButton;
		private Label TitleLabel;
		private Label ContentLabel;
		private Label CategoryLabel;
		private Label IDLabel;
		private Label LastModifiedTimeLabel;
		private Label CreationTimeLabel;
	}
}