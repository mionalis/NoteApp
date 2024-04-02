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
			MenuStrip = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			editToolStripMenuItem = new ToolStripMenuItem();
			addNoteToolStripMenuItem = new ToolStripMenuItem();
			editNoteToolStripMenuItem = new ToolStripMenuItem();
			deleteNoteToolStripMenuItem = new ToolStripMenuItem();
			helpToolStripMenuItem = new ToolStripMenuItem();
			aboutToolStripMenuItem = new ToolStripMenuItem();
			ListboxUserControl = new ListboxUserControl();
			NoteInfoUserControl = new NoteInfoUserControl();
			CategoryLabel = new Label();
			NoteCategoryLabel = new Label();
			NoteAppLabel = new Label();
			MenuStrip.SuspendLayout();
			SuspendLayout();
			// 
			// MenuStrip
			// 
			MenuStrip.ImageScalingSize = new Size(20, 20);
			MenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
			MenuStrip.Location = new Point(0, 0);
			MenuStrip.Name = "MenuStrip";
			MenuStrip.Size = new Size(1057, 28);
			MenuStrip.TabIndex = 0;
			MenuStrip.Text = "menuStrip1";
			MenuStrip.ItemClicked += MenuStrip_ItemClicked;
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(46, 24);
			fileToolStripMenuItem.Text = "File";
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
			// 
			// editNoteToolStripMenuItem
			// 
			editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
			editNoteToolStripMenuItem.Size = new Size(173, 26);
			editNoteToolStripMenuItem.Text = "Edit Note";
			// 
			// deleteNoteToolStripMenuItem
			// 
			deleteNoteToolStripMenuItem.Name = "deleteNoteToolStripMenuItem";
			deleteNoteToolStripMenuItem.Size = new Size(173, 26);
			deleteNoteToolStripMenuItem.Text = "Delete Note";
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
			// 
			// ListboxUserControl
			// 
			ListboxUserControl.Dock = DockStyle.Left;
			ListboxUserControl.Location = new Point(0, 28);
			ListboxUserControl.Margin = new Padding(5);
			ListboxUserControl.MinimumSize = new Size(300, 540);
			ListboxUserControl.Name = "ListboxUserControl";
			ListboxUserControl.Padding = new Padding(10, 0, 10, 10);
			ListboxUserControl.Size = new Size(379, 641);
			ListboxUserControl.TabIndex = 1;
			ListboxUserControl.Load += listboxBar1_Load;
			// 
			// NoteInfoUserControl
			// 
			NoteInfoUserControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			NoteInfoUserControl.Location = new Point(379, 104);
			NoteInfoUserControl.MinimumSize = new Size(505, 565);
			NoteInfoUserControl.Name = "NoteInfoUserControl";
			NoteInfoUserControl.Padding = new Padding(10, 0, 10, 10);
			NoteInfoUserControl.Size = new Size(678, 565);
			NoteInfoUserControl.TabIndex = 2;
			NoteInfoUserControl.Load += noteInfoUserControl1_Load;
			// 
			// CategoryLabel
			// 
			CategoryLabel.AutoSize = true;
			CategoryLabel.Location = new Point(392, 76);
			CategoryLabel.Name = "CategoryLabel";
			CategoryLabel.Size = new Size(72, 20);
			CategoryLabel.TabIndex = 4;
			CategoryLabel.Text = "Category:";
			// 
			// NoteCategoryLabel
			// 
			NoteCategoryLabel.AutoSize = true;
			NoteCategoryLabel.Location = new Point(470, 76);
			NoteCategoryLabel.Name = "NoteCategoryLabel";
			NoteCategoryLabel.Size = new Size(69, 20);
			NoteCategoryLabel.TabIndex = 5;
			NoteCategoryLabel.Text = "Category";
			// 
			// NoteAppLabel
			// 
			NoteAppLabel.AutoSize = true;
			NoteAppLabel.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
			NoteAppLabel.Location = new Point(388, 28);
			NoteAppLabel.Name = "NoteAppLabel";
			NoteAppLabel.RightToLeft = RightToLeft.Yes;
			NoteAppLabel.Size = new Size(152, 41);
			NoteAppLabel.TabIndex = 6;
			NoteAppLabel.Text = "NoteApp";
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1057, 669);
			Controls.Add(NoteAppLabel);
			Controls.Add(NoteCategoryLabel);
			Controls.Add(CategoryLabel);
			Controls.Add(NoteInfoUserControl);
			Controls.Add(ListboxUserControl);
			Controls.Add(MenuStrip);
			MainMenuStrip = MenuStrip;
			Name = "MainForm";
			Text = "NoteApp";
			MenuStrip.ResumeLayout(false);
			MenuStrip.PerformLayout();
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
		private ListboxUserControl ListboxUserControl;
		private NoteInfoUserControl NoteInfoUserControl;
		private Label CategoryLabel;
		private Label NoteCategoryLabel;
		private Label NoteAppLabel;
	}
}