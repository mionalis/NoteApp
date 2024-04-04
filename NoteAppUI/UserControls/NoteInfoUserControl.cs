using NoteApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
	public partial class NoteInfoUserControl : UserControl
	{
		public NoteInfoUserControl()
		{
			InitializeComponent();
		}

		public Note Note { get; set; }

		public void UpdateNoteInfo()
		{
			CreatedTextBox.Text = Note.CreationTime.ToString();
			ModifiedTextBox.Text = Note.LastModifiedTime.ToString();
		}
	}
}
