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
			CreatedLabel = new Label();
			CreatedComboBox = new ComboBox();
			ModifiedComboBox = new ComboBox();
			ModifiedLabel = new Label();
			NoteContentTextBox = new TextBox();
			SuspendLayout();
			// 
			// CreatedLabel
			// 
			CreatedLabel.AutoSize = true;
			CreatedLabel.Location = new Point(3, 3);
			CreatedLabel.Name = "CreatedLabel";
			CreatedLabel.Size = new Size(64, 20);
			CreatedLabel.TabIndex = 3;
			CreatedLabel.Text = "Created:";
			// 
			// CreatedComboBox
			// 
			CreatedComboBox.FormattingEnabled = true;
			CreatedComboBox.Location = new Point(81, 0);
			CreatedComboBox.Name = "CreatedComboBox";
			CreatedComboBox.Size = new Size(155, 28);
			CreatedComboBox.TabIndex = 4;
			// 
			// ModifiedComboBox
			// 
			ModifiedComboBox.FormattingEnabled = true;
			ModifiedComboBox.Location = new Point(351, 0);
			ModifiedComboBox.Name = "ModifiedComboBox";
			ModifiedComboBox.Size = new Size(155, 28);
			ModifiedComboBox.TabIndex = 6;
			// 
			// ModifiedLabel
			// 
			ModifiedLabel.AutoSize = true;
			ModifiedLabel.Location = new Point(260, 3);
			ModifiedLabel.Name = "ModifiedLabel";
			ModifiedLabel.Size = new Size(73, 20);
			ModifiedLabel.TabIndex = 5;
			ModifiedLabel.Text = "Modified:";
			// 
			// NoteContentTextBox
			// 
			NoteContentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			NoteContentTextBox.Location = new Point(0, 38);
			NoteContentTextBox.Multiline = true;
			NoteContentTextBox.Name = "NoteContentTextBox";
			NoteContentTextBox.Size = new Size(505, 450);
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
			MinimumSize = new Size(505, 565);
			Name = "NoteInfoUserControl";
			Size = new Size(505, 566);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label CreatedLabel;
		private ComboBox CreatedComboBox;
		private ComboBox ModifiedComboBox;
		private Label ModifiedLabel;
		private TextBox NoteContentTextBox;
	}
}
