namespace NoteAppUI
{
	partial class ListboxBar
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
			ShowCategoryLabel = new Label();
			CategoryComboBox = new ComboBox();
			NotesListbox = new ListBox();
			AddNoteButton = new Button();
			EditNoteButton = new Button();
			DeleteNoteButton = new Button();
			SuspendLayout();
			// 
			// ShowCategoryLabel
			// 
			ShowCategoryLabel.AutoSize = true;
			ShowCategoryLabel.Location = new Point(3, 6);
			ShowCategoryLabel.Name = "ShowCategoryLabel";
			ShowCategoryLabel.Size = new Size(112, 20);
			ShowCategoryLabel.TabIndex = 0;
			ShowCategoryLabel.Text = "Show Category:";
			// 
			// CategoryComboBox
			// 
			CategoryComboBox.FormattingEnabled = true;
			CategoryComboBox.Location = new Point(132, 3);
			CategoryComboBox.Name = "CategoryComboBox";
			CategoryComboBox.Size = new Size(222, 28);
			CategoryComboBox.TabIndex = 1;
			// 
			// NotesListbox
			// 
			NotesListbox.FormattingEnabled = true;
			NotesListbox.ItemHeight = 20;
			NotesListbox.Location = new Point(3, 37);
			NotesListbox.Name = "NotesListbox";
			NotesListbox.Size = new Size(351, 444);
			NotesListbox.TabIndex = 2;
			// 
			// AddNoteButton
			// 
			AddNoteButton.Location = new Point(3, 487);
			AddNoteButton.Name = "AddNoteButton";
			AddNoteButton.Size = new Size(94, 29);
			AddNoteButton.TabIndex = 3;
			AddNoteButton.Text = "button1";
			AddNoteButton.UseVisualStyleBackColor = true;
			// 
			// EditNoteButton
			// 
			EditNoteButton.Location = new Point(103, 487);
			EditNoteButton.Name = "EditNoteButton";
			EditNoteButton.Size = new Size(94, 29);
			EditNoteButton.TabIndex = 4;
			EditNoteButton.Text = "button2";
			EditNoteButton.UseVisualStyleBackColor = true;
			// 
			// DeleteNoteButton
			// 
			DeleteNoteButton.Location = new Point(203, 487);
			DeleteNoteButton.Name = "DeleteNoteButton";
			DeleteNoteButton.Size = new Size(94, 29);
			DeleteNoteButton.TabIndex = 5;
			DeleteNoteButton.Text = "button3";
			DeleteNoteButton.UseVisualStyleBackColor = true;
			// 
			// ListboxBar
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(DeleteNoteButton);
			Controls.Add(EditNoteButton);
			Controls.Add(AddNoteButton);
			Controls.Add(NotesListbox);
			Controls.Add(CategoryComboBox);
			Controls.Add(ShowCategoryLabel);
			Name = "ListboxBar";
			Size = new Size(358, 537);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label ShowCategoryLabel;
		private ComboBox CategoryComboBox;
		private ListBox NotesListbox;
		private Button AddNoteButton;
		private Button EditNoteButton;
		private Button DeleteNoteButton;
	}
}
