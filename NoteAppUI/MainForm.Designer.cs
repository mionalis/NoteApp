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
			listboxBar1 = new ListboxBar();
			MenuStrip.SuspendLayout();
			SuspendLayout();
			// 
			// MenuStrip
			// 
			MenuStrip.ImageScalingSize = new Size(20, 20);
			MenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
			MenuStrip.Location = new Point(0, 0);
			MenuStrip.Name = "MenuStrip";
			MenuStrip.Size = new Size(898, 28);
			MenuStrip.TabIndex = 0;
			MenuStrip.Text = "menuStrip1";
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
			// listboxBar1
			// 
			listboxBar1.Location = new Point(12, 31);
			listboxBar1.Name = "listboxBar1";
			listboxBar1.Size = new Size(360, 671);
			listboxBar1.TabIndex = 1;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(898, 567);
			Controls.Add(listboxBar1);
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
		private ListboxBar listboxBar1;
	}
}