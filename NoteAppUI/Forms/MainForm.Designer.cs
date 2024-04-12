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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			MenuStrip = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			exitToolStripMenuItem = new ToolStripMenuItem();
			editToolStripMenuItem = new ToolStripMenuItem();
			addNoteToolStripMenuItem = new ToolStripMenuItem();
			editNoteToolStripMenuItem = new ToolStripMenuItem();
			deleteNoteToolStripMenuItem = new ToolStripMenuItem();
			helpToolStripMenuItem = new ToolStripMenuItem();
			aboutToolStripMenuItem = new ToolStripMenuItem();
			CategoryLabel = new Label();
			NoteCategoryLabel = new Label();
			TitleLabel = new Label();
			DeleteNoteButton = new Button();
			EditNoteButton = new Button();
			AddNoteButton = new Button();
			NotesListbox = new ListBox();
			CategoryComboBox = new ComboBox();
			ShowCategoryLabel = new Label();
			ModifiedTextBox = new TextBox();
			CreatedTextBox = new TextBox();
			ContentTextBox = new TextBox();
			ModifiedLabel = new Label();
			CreatedLabel = new Label();
			splitContainer1 = new SplitContainer();
			MenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// MenuStrip
			// 
			MenuStrip.ImageScalingSize = new Size(20, 20);
			MenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
			MenuStrip.Location = new Point(0, 0);
			MenuStrip.Name = "MenuStrip";
			MenuStrip.Size = new Size(991, 28);
			MenuStrip.TabIndex = 0;
			MenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(46, 24);
			fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			exitToolStripMenuItem.Size = new Size(116, 26);
			exitToolStripMenuItem.Text = "Exit";
			exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
			// 
			// editToolStripMenuItem
			// 
			editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNoteToolStripMenuItem, editNoteToolStripMenuItem, deleteNoteToolStripMenuItem });
			editToolStripMenuItem.Name = "editToolStripMenuItem";
			editToolStripMenuItem.Size = new Size(49, 24);
			editToolStripMenuItem.Text = "Edit";
			// 
			// addNoteToolStripMenuItem
			// 
			addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
			addNoteToolStripMenuItem.Size = new Size(173, 26);
			addNoteToolStripMenuItem.Text = "Add Note";
			addNoteToolStripMenuItem.Click += AddNoteToolStripMenuItem_Click;
			// 
			// editNoteToolStripMenuItem
			// 
			editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
			editNoteToolStripMenuItem.Size = new Size(173, 26);
			editNoteToolStripMenuItem.Text = "Edit Note";
			editNoteToolStripMenuItem.Click += EditNoteToolStripMenuItem_Click;
			// 
			// deleteNoteToolStripMenuItem
			// 
			deleteNoteToolStripMenuItem.Name = "deleteNoteToolStripMenuItem";
			deleteNoteToolStripMenuItem.Size = new Size(173, 26);
			deleteNoteToolStripMenuItem.Text = "Delete Note";
			deleteNoteToolStripMenuItem.Click += DeleteNoteToolStripMenuItem_Click;
			// 
			// helpToolStripMenuItem
			// 
			helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
			helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			helpToolStripMenuItem.Size = new Size(55, 24);
			helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			aboutToolStripMenuItem.Size = new Size(133, 26);
			aboutToolStripMenuItem.Text = "About";
			aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
			// 
			// CategoryLabel
			// 
			CategoryLabel.AutoSize = true;
			CategoryLabel.Location = new Point(3, 63);
			CategoryLabel.Name = "CategoryLabel";
			CategoryLabel.Size = new Size(72, 20);
			CategoryLabel.TabIndex = 4;
			CategoryLabel.Text = "Category:";
			// 
			// NoteCategoryLabel
			// 
			NoteCategoryLabel.AutoSize = true;
			NoteCategoryLabel.Location = new Point(86, 63);
			NoteCategoryLabel.Name = "NoteCategoryLabel";
			NoteCategoryLabel.Size = new Size(69, 20);
			NoteCategoryLabel.TabIndex = 5;
			NoteCategoryLabel.Text = "Category";
			// 
			// TitleLabel
			// 
			TitleLabel.AutoSize = true;
			TitleLabel.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
			TitleLabel.Location = new Point(3, 13);
			TitleLabel.Name = "TitleLabel";
			TitleLabel.RightToLeft = RightToLeft.Yes;
			TitleLabel.Size = new Size(152, 41);
			TitleLabel.TabIndex = 6;
			TitleLabel.Text = "NoteApp";
			// 
			// DeleteNoteButton
			// 
			DeleteNoteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			DeleteNoteButton.BackColor = SystemColors.Control;
			DeleteNoteButton.FlatAppearance.BorderSize = 0;
			DeleteNoteButton.FlatStyle = FlatStyle.Flat;
			DeleteNoteButton.Image = (Image)resources.GetObject("DeleteNoteButton.Image");
			DeleteNoteButton.Location = new Point(120, 583);
			DeleteNoteButton.Name = "DeleteNoteButton";
			DeleteNoteButton.Size = new Size(48, 46);
			DeleteNoteButton.TabIndex = 12;
			DeleteNoteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			DeleteNoteButton.UseVisualStyleBackColor = false;
			DeleteNoteButton.Click += RemoveNoteButton_Click;
			// 
			// EditNoteButton
			// 
			EditNoteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			EditNoteButton.BackColor = SystemColors.Control;
			EditNoteButton.FlatAppearance.BorderSize = 0;
			EditNoteButton.FlatStyle = FlatStyle.Flat;
			EditNoteButton.Image = (Image)resources.GetObject("EditNoteButton.Image");
			EditNoteButton.Location = new Point(66, 583);
			EditNoteButton.Name = "EditNoteButton";
			EditNoteButton.Size = new Size(48, 46);
			EditNoteButton.TabIndex = 11;
			EditNoteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			EditNoteButton.UseVisualStyleBackColor = false;
			EditNoteButton.Click += EditNoteButton_Click;
			// 
			// AddNoteButton
			// 
			AddNoteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			AddNoteButton.BackColor = SystemColors.Control;
			AddNoteButton.FlatAppearance.BorderSize = 0;
			AddNoteButton.FlatStyle = FlatStyle.Flat;
			AddNoteButton.Image = (Image)resources.GetObject("AddNoteButton.Image");
			AddNoteButton.Location = new Point(12, 583);
			AddNoteButton.Name = "AddNoteButton";
			AddNoteButton.Size = new Size(48, 46);
			AddNoteButton.TabIndex = 10;
			AddNoteButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			AddNoteButton.UseVisualStyleBackColor = false;
			AddNoteButton.Click += AddNoteButton_Click;
			// 
			// NotesListbox
			// 
			NotesListbox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			NotesListbox.FormattingEnabled = true;
			NotesListbox.ItemHeight = 20;
			NotesListbox.Location = new Point(12, 46);
			NotesListbox.Name = "NotesListbox";
			NotesListbox.Size = new Size(444, 524);
			NotesListbox.TabIndex = 9;
			NotesListbox.SelectedIndexChanged += NotesListbox_SelectedIndexChanged;
			// 
			// CategoryComboBox
			// 
			CategoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			CategoryComboBox.FormattingEnabled = true;
			CategoryComboBox.Location = new Point(130, 13);
			CategoryComboBox.Name = "CategoryComboBox";
			CategoryComboBox.Size = new Size(326, 28);
			CategoryComboBox.TabIndex = 8;
			CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
			// 
			// ShowCategoryLabel
			// 
			ShowCategoryLabel.AutoSize = true;
			ShowCategoryLabel.Location = new Point(12, 13);
			ShowCategoryLabel.Name = "ShowCategoryLabel";
			ShowCategoryLabel.Size = new Size(112, 20);
			ShowCategoryLabel.TabIndex = 7;
			ShowCategoryLabel.Text = "Show Category:";
			// 
			// ModifiedTextBox
			// 
			ModifiedTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			ModifiedTextBox.Enabled = false;
			ModifiedTextBox.Location = new Point(345, 91);
			ModifiedTextBox.Name = "ModifiedTextBox";
			ModifiedTextBox.Size = new Size(163, 27);
			ModifiedTextBox.TabIndex = 17;
			// 
			// CreatedTextBox
			// 
			CreatedTextBox.Enabled = false;
			CreatedTextBox.Location = new Point(73, 91);
			CreatedTextBox.Name = "CreatedTextBox";
			CreatedTextBox.Size = new Size(163, 27);
			CreatedTextBox.TabIndex = 16;
			// 
			// ContentTextBox
			// 
			ContentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			ContentTextBox.BackColor = SystemColors.Window;
			ContentTextBox.Location = new Point(3, 124);
			ContentTextBox.Multiline = true;
			ContentTextBox.Name = "ContentTextBox";
			ContentTextBox.ReadOnly = true;
			ContentTextBox.Size = new Size(505, 505);
			ContentTextBox.TabIndex = 15;
			// 
			// ModifiedLabel
			// 
			ModifiedLabel.AutoSize = true;
			ModifiedLabel.Location = new Point(266, 94);
			ModifiedLabel.Name = "ModifiedLabel";
			ModifiedLabel.Size = new Size(73, 20);
			ModifiedLabel.TabIndex = 14;
			ModifiedLabel.Text = "Modified:";
			// 
			// CreatedLabel
			// 
			CreatedLabel.AutoSize = true;
			CreatedLabel.Location = new Point(3, 94);
			CreatedLabel.Name = "CreatedLabel";
			CreatedLabel.Size = new Size(64, 20);
			CreatedLabel.TabIndex = 13;
			CreatedLabel.Text = "Created:";
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 28);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(NotesListbox);
			splitContainer1.Panel1.Controls.Add(ShowCategoryLabel);
			splitContainer1.Panel1.Controls.Add(CategoryComboBox);
			splitContainer1.Panel1.Controls.Add(AddNoteButton);
			splitContainer1.Panel1.Controls.Add(EditNoteButton);
			splitContainer1.Panel1.Controls.Add(DeleteNoteButton);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(CreatedTextBox);
			splitContainer1.Panel2.Controls.Add(ModifiedTextBox);
			splitContainer1.Panel2.Controls.Add(CategoryLabel);
			splitContainer1.Panel2.Controls.Add(NoteCategoryLabel);
			splitContainer1.Panel2.Controls.Add(ContentTextBox);
			splitContainer1.Panel2.Controls.Add(TitleLabel);
			splitContainer1.Panel2.Controls.Add(ModifiedLabel);
			splitContainer1.Panel2.Controls.Add(CreatedLabel);
			splitContainer1.Size = new Size(991, 641);
			splitContainer1.SplitterDistance = 459;
			splitContainer1.TabIndex = 18;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(991, 669);
			Controls.Add(splitContainer1);
			Controls.Add(MenuStrip);
			MainMenuStrip = MenuStrip;
			MinimumSize = new Size(1000, 700);
			Name = "MainForm";
			Text = "NoteApp";
			FormClosing += MainForm_FormClosing;
			MenuStrip.ResumeLayout(false);
			MenuStrip.PerformLayout();
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip MenuStrip;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem addNoteToolStripMenuItem;
		private ToolStripMenuItem editNoteToolStripMenuItem;
		private ToolStripMenuItem deleteNoteToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem aboutToolStripMenuItem;
		private Label CategoryLabel;
		private Label NoteCategoryLabel;
		private Label TitleLabel;
		private ToolStripMenuItem exitToolStripMenuItem;
		private Button DeleteNoteButton;
		private Button EditNoteButton;
		private Button AddNoteButton;
		private ListBox NotesListbox;
		private ComboBox CategoryComboBox;
		private Label ShowCategoryLabel;
		private TextBox ModifiedTextBox;
		private TextBox CreatedTextBox;
		private TextBox ContentTextBox;
		private Label ModifiedLabel;
		private Label CreatedLabel;
		private SplitContainer splitContainer1;
	}
}