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
		/// <summary>
		/// Отредактированная заметка.
		/// </summary>
		private Note _editedNote = new();

		public AddEditNoteForm()
		{
			InitializeComponent();
			CategoryComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));
		}

		/// <summary>
		/// Возвращает и задает заметку.
		/// </summary>
		public Note Note { get; set; }

		/// <summary>
		/// Обновляет данные заметки.
		/// </summary>
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
			try
			{
				_editedNote.Title = TitleTextBox.Text;
				TitleTextBox.BackColor = Color.White;
				OKButton.Enabled = true;
			}
			catch (ArgumentException)
			{
				TitleTextBox.BackColor = Color.LightPink;
				OKButton.Enabled = false;
				return;
			}
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

		private void CancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
