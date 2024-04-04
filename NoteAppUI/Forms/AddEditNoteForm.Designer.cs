namespace NoteAppUI.Forms
{
	partial class AddEditNoteForm
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
			CancelButton = new Button();
			OKButton = new Button();
			CategoryLabel = new Label();
			TitleLabel = new Label();
			TitleTextBox = new TextBox();
			CategoryComboBox = new ComboBox();
			ModifiedTextBox = new TextBox();
			CreatedTextBox = new TextBox();
			ContentTextBox = new TextBox();
			ModifiedLabel = new Label();
			CreatedLabel = new Label();
			SuspendLayout();
			// 
			// CancelButton
			// 
			CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			CancelButton.Location = new Point(694, 651);
			CancelButton.Margin = new Padding(5);
			CancelButton.Name = "CancelButton";
			CancelButton.Size = new Size(94, 29);
			CancelButton.TabIndex = 1;
			CancelButton.Text = "Cancel";
			CancelButton.UseVisualStyleBackColor = true;
			// 
			// OKButton
			// 
			OKButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			OKButton.Location = new Point(594, 651);
			OKButton.Name = "OKButton";
			OKButton.Size = new Size(94, 29);
			OKButton.TabIndex = 2;
			OKButton.Text = "OK";
			OKButton.UseVisualStyleBackColor = true;
			OKButton.Click += OKButton_Click;
			// 
			// CategoryLabel
			// 
			CategoryLabel.AutoSize = true;
			CategoryLabel.Location = new Point(12, 63);
			CategoryLabel.Name = "CategoryLabel";
			CategoryLabel.Size = new Size(72, 20);
			CategoryLabel.TabIndex = 7;
			CategoryLabel.Text = "Category:";
			// 
			// TitleLabel
			// 
			TitleLabel.AutoSize = true;
			TitleLabel.Location = new Point(12, 21);
			TitleLabel.Name = "TitleLabel";
			TitleLabel.Size = new Size(41, 20);
			TitleLabel.TabIndex = 8;
			TitleLabel.Text = "Title:";
			// 
			// TitleTextBox
			// 
			TitleTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			TitleTextBox.Location = new Point(90, 18);
			TitleTextBox.Name = "TitleTextBox";
			TitleTextBox.Size = new Size(698, 27);
			TitleTextBox.TabIndex = 9;
			TitleTextBox.TextChanged += TitleTextBox_TextChanged;
			// 
			// CategoryComboBox
			// 
			CategoryComboBox.FormattingEnabled = true;
			CategoryComboBox.Location = new Point(90, 60);
			CategoryComboBox.Name = "CategoryComboBox";
			CategoryComboBox.Size = new Size(416, 28);
			CategoryComboBox.TabIndex = 10;
			CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
			// 
			// ModifiedTextBox
			// 
			ModifiedTextBox.Enabled = false;
			ModifiedTextBox.Location = new Point(367, 104);
			ModifiedTextBox.Name = "ModifiedTextBox";
			ModifiedTextBox.Size = new Size(185, 27);
			ModifiedTextBox.TabIndex = 15;
			// 
			// CreatedTextBox
			// 
			CreatedTextBox.Location = new Point(90, 104);
			CreatedTextBox.Name = "CreatedTextBox";
			CreatedTextBox.Size = new Size(169, 27);
			CreatedTextBox.TabIndex = 14;
			// 
			// ContentTextBox
			// 
			ContentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			ContentTextBox.Location = new Point(12, 142);
			ContentTextBox.Multiline = true;
			ContentTextBox.Name = "ContentTextBox";
			ContentTextBox.Size = new Size(776, 501);
			ContentTextBox.TabIndex = 13;
			ContentTextBox.TextChanged += NoteContentTextBox_TextChanged;
			// 
			// ModifiedLabel
			// 
			ModifiedLabel.AutoSize = true;
			ModifiedLabel.Location = new Point(288, 107);
			ModifiedLabel.Name = "ModifiedLabel";
			ModifiedLabel.Size = new Size(73, 20);
			ModifiedLabel.TabIndex = 12;
			ModifiedLabel.Text = "Modified:";
			// 
			// CreatedLabel
			// 
			CreatedLabel.AutoSize = true;
			CreatedLabel.Location = new Point(15, 107);
			CreatedLabel.Name = "CreatedLabel";
			CreatedLabel.Size = new Size(64, 20);
			CreatedLabel.TabIndex = 11;
			CreatedLabel.Text = "Created:";
			// 
			// AddEditNoteForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 690);
			Controls.Add(ModifiedTextBox);
			Controls.Add(CreatedTextBox);
			Controls.Add(ContentTextBox);
			Controls.Add(ModifiedLabel);
			Controls.Add(CreatedLabel);
			Controls.Add(CategoryComboBox);
			Controls.Add(TitleTextBox);
			Controls.Add(TitleLabel);
			Controls.Add(CategoryLabel);
			Controls.Add(OKButton);
			Controls.Add(CancelButton);
			MinimumSize = new Size(800, 700);
			Name = "AddEditNoteForm";
			Text = "AddEditNoteForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button CancelButton;
		private Button OKButton;
		private Label CategoryLabel;
		private Label TitleLabel;
		private TextBox TitleTextBox;
		private ComboBox CategoryComboBox;
		private TextBox ModifiedTextBox;
		private TextBox CreatedTextBox;
		private TextBox ContentTextBox;
		private Label ModifiedLabel;
		private Label CreatedLabel;
	}
}