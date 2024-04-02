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
			noteInfoUserControl1 = new NoteInfoUserControl();
			CancelButton = new Button();
			OKButton = new Button();
			CategoryLabel = new Label();
			TitleLabel = new Label();
			TitleTextBox = new TextBox();
			CategoryComboBox = new ComboBox();
			SuspendLayout();
			// 
			// noteInfoUserControl1
			// 
			noteInfoUserControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			noteInfoUserControl1.Location = new Point(0, 103);
			noteInfoUserControl1.MinimumSize = new Size(505, 565);
			noteInfoUserControl1.Name = "noteInfoUserControl1";
			noteInfoUserControl1.Padding = new Padding(10, 0, 10, 10);
			noteInfoUserControl1.Size = new Size(800, 627);
			noteInfoUserControl1.TabIndex = 0;
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
			// 
			// CategoryComboBox
			// 
			CategoryComboBox.FormattingEnabled = true;
			CategoryComboBox.Location = new Point(90, 60);
			CategoryComboBox.Name = "CategoryComboBox";
			CategoryComboBox.Size = new Size(416, 28);
			CategoryComboBox.TabIndex = 10;
			// 
			// AddEditNoteForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 690);
			Controls.Add(CategoryComboBox);
			Controls.Add(TitleTextBox);
			Controls.Add(TitleLabel);
			Controls.Add(CategoryLabel);
			Controls.Add(OKButton);
			Controls.Add(CancelButton);
			Controls.Add(noteInfoUserControl1);
			MinimumSize = new Size(800, 700);
			Name = "AddEditNoteForm";
			Text = "AddEditNoteForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private NoteInfoUserControl noteInfoUserControl1;
		private Button CancelButton;
		private Button OKButton;
		private Label CategoryLabel;
		private Label TitleLabel;
		private TextBox TitleTextBox;
		private ComboBox CategoryComboBox;
	}
}