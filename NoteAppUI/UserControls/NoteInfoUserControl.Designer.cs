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
			ModifiedLabel = new Label();
			NoteContentTextBox = new TextBox();
			CreatedTextBox = new TextBox();
			ModifiedTextBox = new TextBox();
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
			// CreatedTextBox
			// 
			CreatedTextBox.Location = new Point(85, 0);
			CreatedTextBox.Name = "CreatedTextBox";
			CreatedTextBox.Size = new Size(125, 27);
			CreatedTextBox.TabIndex = 8;
			// 
			// ModifiedTextBox
			// 
			ModifiedTextBox.Location = new Point(350, 0);
			ModifiedTextBox.Name = "ModifiedTextBox";
			ModifiedTextBox.Size = new Size(125, 27);
			ModifiedTextBox.TabIndex = 9;
			// 
			// NoteInfoUserControl
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(ModifiedTextBox);
			Controls.Add(CreatedTextBox);
			Controls.Add(NoteContentTextBox);
			Controls.Add(ModifiedLabel);
			Controls.Add(CreatedLabel);
			MinimumSize = new Size(505, 565);
			Name = "NoteInfoUserControl";
			Size = new Size(505, 566);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label CreatedLabel;
		private Label ModifiedLabel;
		private TextBox NoteContentTextBox;
		private TextBox CreatedTextBox;
		private TextBox ModifiedTextBox;
	}
}
