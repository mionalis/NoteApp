namespace NoteAppUI
{
	partial class NoteInfoUserControl
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			NoteTitleLabel = new Label();
			CategoryLabel = new Label();
			NoteCategoryLabel = new Label();
			CreatedLabel = new Label();
			CreatedComboBox = new ComboBox();
			ModifiedComboBox = new ComboBox();
			ModifiedLabel = new Label();
			NoteContentTextBox = new TextBox();
			SuspendLayout();
			// 
			// NoteTitleLabel
			// 
			NoteTitleLabel.AutoSize = true;
			NoteTitleLabel.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
			NoteTitleLabel.Location = new Point(0, 0);
			NoteTitleLabel.Name = "NoteTitleLabel";
			NoteTitleLabel.RightToLeft = RightToLeft.Yes;
			NoteTitleLabel.Size = new Size(166, 41);
			NoteTitleLabel.TabIndex = 0;
			NoteTitleLabel.Text = "Note Title";
			// 
			// CategoryLabel
			// 
			CategoryLabel.AutoSize = true;
			CategoryLabel.Location = new Point(3, 51);
			CategoryLabel.Name = "CategoryLabel";
			CategoryLabel.Size = new Size(72, 20);
			CategoryLabel.TabIndex = 1;
			CategoryLabel.Text = "Category:";
			// 
			// NoteCategoryLabel
			// 
			NoteCategoryLabel.AutoSize = true;
			NoteCategoryLabel.Location = new Point(81, 51);
			NoteCategoryLabel.Name = "NoteCategoryLabel";
			NoteCategoryLabel.Size = new Size(106, 20);
			NoteCategoryLabel.TabIndex = 2;
			NoteCategoryLabel.Text = "Note Category";
			// 
			// CreatedLabel
			// 
			CreatedLabel.AutoSize = true;
			CreatedLabel.Location = new Point(3, 82);
			CreatedLabel.Name = "CreatedLabel";
			CreatedLabel.Size = new Size(64, 20);
			CreatedLabel.TabIndex = 3;
			CreatedLabel.Text = "Created:";
			// 
			// CreatedComboBox
			// 
			CreatedComboBox.FormattingEnabled = true;
			CreatedComboBox.Location = new Point(81, 79);
			CreatedComboBox.Name = "CreatedComboBox";
			CreatedComboBox.Size = new Size(151, 28);
			CreatedComboBox.TabIndex = 4;
			// 
			// ModifiedComboBox
			// 
			ModifiedComboBox.FormattingEnabled = true;
			ModifiedComboBox.Location = new Point(351, 79);
			ModifiedComboBox.Name = "ModifiedComboBox";
			ModifiedComboBox.Size = new Size(151, 28);
			ModifiedComboBox.TabIndex = 6;
			// 
			// ModifiedLabel
			// 
			ModifiedLabel.AutoSize = true;
			ModifiedLabel.Location = new Point(260, 82);
			ModifiedLabel.Name = "ModifiedLabel";
			ModifiedLabel.Size = new Size(73, 20);
			ModifiedLabel.TabIndex = 5;
			ModifiedLabel.Text = "Modified:";
			// 
			// NoteContentTextBox
			// 
			NoteContentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			NoteContentTextBox.Location = new Point(0, 113);
			NoteContentTextBox.Multiline = true;
			NoteContentTextBox.Name = "NoteContentTextBox";
			NoteContentTextBox.Size = new Size(502, 450);
			NoteContentTextBox.TabIndex = 7;
			// 
			// NoteInfoUserControl
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(NoteContentTextBox);
			Controls.Add(ModifiedComboBox);
			Controls.Add(ModifiedLabel);
			Controls.Add(CreatedComboBox);
			Controls.Add(CreatedLabel);
			Controls.Add(NoteCategoryLabel);
			Controls.Add(CategoryLabel);
			Controls.Add(NoteTitleLabel);
			MinimumSize = new Size(505, 565);
			Name = "NoteInfoUserControl";
			Size = new Size(506, 566);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label NoteTitleLabel;
		private Label CategoryLabel;
		private Label NoteCategoryLabel;
		private Label CreatedLabel;
		private ComboBox CreatedComboBox;
		private ComboBox ModifiedComboBox;
		private Label ModifiedLabel;
		private TextBox NoteContentTextBox;
	}
}
