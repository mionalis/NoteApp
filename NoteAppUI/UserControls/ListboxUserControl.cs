using NoteApp;
using NoteAppUI.Forms;
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
	public partial class ListboxUserControl : UserControl
	{
		public ListboxUserControl()
		{
			InitializeComponent();
		}

		private void AddNoteButton_Click(object sender, EventArgs e)
		{
			var addNoteForm = new AddEditNoteForm();
			var note = new Note();
			addNoteForm.Note = note;
			addNoteForm.UpdateNoteInfo();
			addNoteForm.Show();
		}

		private void EditNoteButton_Click(object sender, EventArgs e)
		{
			var editNoteForm = new AddEditNoteForm();
			editNoteForm.Show();
		}
	}
}
