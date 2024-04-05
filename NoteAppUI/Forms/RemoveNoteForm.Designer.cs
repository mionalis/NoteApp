namespace NoteAppUI.Forms
{
	partial class RemoveNoteForm
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
			RemoveLabel = new Label();
			AcceptRemovingButton = new Button();
			CancelRemovingButton = new Button();
			SuspendLayout();
			// 
			// RemoveLabel
			// 
			RemoveLabel.AutoSize = true;
			RemoveLabel.Location = new Point(144, 55);
			RemoveLabel.Name = "RemoveLabel";
			RemoveLabel.Size = new Size(42, 20);
			RemoveLabel.TabIndex = 0;
			RemoveLabel.Text = "label";
			RemoveLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// AcceptRemovingButton
			// 
			AcceptRemovingButton.Location = new Point(203, 124);
			AcceptRemovingButton.Name = "AcceptRemovingButton";
			AcceptRemovingButton.Size = new Size(94, 29);
			AcceptRemovingButton.TabIndex = 1;
			AcceptRemovingButton.Text = "OK";
			AcceptRemovingButton.UseVisualStyleBackColor = true;
			AcceptRemovingButton.Click += AcceptRemovingButton_Click;
			// 
			// CancelRemovingButton
			// 
			CancelRemovingButton.Location = new Point(303, 124);
			CancelRemovingButton.Name = "CancelRemovingButton";
			CancelRemovingButton.Size = new Size(94, 29);
			CancelRemovingButton.TabIndex = 2;
			CancelRemovingButton.Text = "Cancel";
			CancelRemovingButton.UseVisualStyleBackColor = true;
			CancelRemovingButton.Click += CancelRemovingButton_Click;
			// 
			// RemoveNoteForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(601, 186);
			Controls.Add(CancelRemovingButton);
			Controls.Add(AcceptRemovingButton);
			Controls.Add(RemoveLabel);
			Name = "RemoveNoteForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "DeleteNoteForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label RemoveLabel;
		private Button AcceptRemovingButton;
		private Button CancelRemovingButton;
	}
}