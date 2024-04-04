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

namespace NoteAppUI.Forms
{
	public partial class AddEditNoteForm : Form
	{
		public AddEditNoteForm()
		{
			InitializeComponent();
			CategoryComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));
		}

		public Note Note { get; set; }

		private Note _editedNote = new();

		public void UpdateNoteInfo()
		{
			TitleTextBox.Text = Note.Title;
			CategoryComboBox.SelectedItem = Note.Category;
			CreatedTextBox.Text = Note.CreationTime.ToString();
			ModifiedTextBox.Text = Note.LastModifiedTime.ToString();
			ContentTextBox.Text = Note.Content;
		}

		private void TitleTextBox_TextChanged(object sender, EventArgs e)
		{
			_editedNote.Title = TitleTextBox.Text;
		}

		private void NoteContentTextBox_TextChanged(object sender, EventArgs e)
		{
			_editedNote.Content = ContentTextBox.Text;
		}

		private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			_editedNote.Category = (NoteCategory)CategoryComboBox.SelectedItem;
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			Note = _editedNote;
			DialogResult = DialogResult.OK;
			Close();
		}
	}
}
