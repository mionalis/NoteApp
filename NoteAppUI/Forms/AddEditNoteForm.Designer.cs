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
			SuspendLayout();
			// 
			// noteInfoUserControl1
			// 
			noteInfoUserControl1.Dock = DockStyle.Top;
			noteInfoUserControl1.Location = new Point(0, 0);
			noteInfoUserControl1.MinimumSize = new Size(505, 565);
			noteInfoUserControl1.Name = "noteInfoUserControl1";
			noteInfoUserControl1.Size = new Size(800, 650);
			noteInfoUserControl1.TabIndex = 0;
			// 
			// CancelButton
			// 
			CancelButton.Location = new Point(702, 656);
			CancelButton.Margin = new Padding(5);
			CancelButton.Name = "CancelButton";
			CancelButton.Size = new Size(94, 29);
			CancelButton.TabIndex = 1;
			CancelButton.Text = "Cancel";
			CancelButton.UseVisualStyleBackColor = true;
			// 
			// OKButton
			// 
			OKButton.Location = new Point(600, 656);
			OKButton.Name = "OKButton";
			OKButton.Size = new Size(94, 29);
			OKButton.TabIndex = 2;
			OKButton.Text = "OK";
			OKButton.UseVisualStyleBackColor = true;
			// 
			// AddEditNoteForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 690);
			Controls.Add(OKButton);
			Controls.Add(CancelButton);
			Controls.Add(noteInfoUserControl1);
			Name = "AddEditNoteForm";
			Text = "AddEditNoteForm";
			ResumeLayout(false);
		}

		#endregion

		private NoteInfoUserControl noteInfoUserControl1;
		private Button CancelButton;
		private Button OKButton;
	}
}