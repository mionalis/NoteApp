namespace NoteAppUI
{
	partial class ListboxUserControl
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListboxUserControl));
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
			CategoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			CategoryComboBox.FormattingEnabled = true;
			CategoryComboBox.Location = new Point(132, 3);
			CategoryComboBox.Name = "CategoryComboBox";
			CategoryComboBox.Size = new Size(165, 28);
			CategoryComboBox.TabIndex = 1;
			// 
			// NotesListbox
			// 
			NotesListbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			NotesListbox.FormattingEnabled = true;
			NotesListbox.ItemHeight = 20;
			NotesListbox.Location = new Point(3, 37);
			NotesListbox.Name = "NotesListbox";
			NotesListbox.Size = new Size(294, 484);
			NotesListbox.TabIndex = 2;
			// 
			// AddNoteButton
			// 
			AddNoteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			AddNoteButton.BackColor = SystemColors.Control;
			AddNoteButton.FlatAppearance.BorderSize = 0;
			AddNoteButton.FlatStyle = FlatStyle.Flat;
			AddNoteButton.Image = (Image)resources.GetObject("AddNoteButton.Image");
			AddNoteButton.Location = new Point(3, 527);
			AddNoteButton.Name = "AddNoteButton";
			AddNoteButton.Size = new Size(48, 46);
			AddNoteButton.TabIndex = 3;
			AddNoteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			AddNoteButton.UseVisualStyleBackColor = false;
			AddNoteButton.Click += AddNoteButton_Click;
			// 
			// EditNoteButton
			// 
			EditNoteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			EditNoteButton.BackColor = SystemColors.Control;
			EditNoteButton.FlatAppearance.BorderSize = 0;
			EditNoteButton.FlatStyle = FlatStyle.Flat;
			EditNoteButton.Image = (Image)resources.GetObject("EditNoteButton.Image");
			EditNoteButton.Location = new Point(57, 527);
			EditNoteButton.Name = "EditNoteButton";
			EditNoteButton.Size = new Size(48, 46);
			EditNoteButton.TabIndex = 4;
			EditNoteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			EditNoteButton.UseVisualStyleBackColor = false;
			EditNoteButton.Click += EditNoteButton_Click;
			// 
			// DeleteNoteButton
			// 
			DeleteNoteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			DeleteNoteButton.BackColor = SystemColors.Control;
			DeleteNoteButton.FlatAppearance.BorderSize = 0;
			DeleteNoteButton.FlatStyle = FlatStyle.Flat;
			DeleteNoteButton.Image = (Image)resources.GetObject("DeleteNoteButton.Image");
			DeleteNoteButton.Location = new Point(111, 527);
			DeleteNoteButton.Name = "DeleteNoteButton";
			DeleteNoteButton.Size = new Size(48, 46);
			DeleteNoteButton.TabIndex = 5;
			DeleteNoteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			DeleteNoteButton.UseVisualStyleBackColor = false;
			// 
			// ListboxUserControl
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(DeleteNoteButton);
			Controls.Add(EditNoteButton);
			Controls.Add(AddNoteButton);
			Controls.Add(NotesListbox);
			Controls.Add(CategoryComboBox);
			Controls.Add(ShowCategoryLabel);
			MinimumSize = new Size(300, 540);
			Name = "ListboxUserControl";
			Size = new Size(300, 576);
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
