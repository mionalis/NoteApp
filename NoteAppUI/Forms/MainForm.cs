namespace NoteAppUI
{
	using NoteApp;
	using NoteAppUI.Forms;
	using System.Windows.Forms;

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Возвращает и задает созданную заметку.
		/// </summary>
		private Note Note { get; set; }

		private int SelectedNoteIndex { get; set; } = -1;

		/// <summary>
		/// Возвращает и задает экземпляр класса Project.
		/// </summary>
		private Project Project { get; set; } = new();

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void AddNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowAddNoteForm();
		}

		private void EditNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowEditNoteForm();
		}

		private void DeleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ShowRemoveNoteForm();
		}

		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var aboutForm = new AboutForm();
			aboutForm.Show();
		}

		private void AddNoteButton_Click(object sender, EventArgs e)
		{
			ShowAddNoteForm();
		}

		private void EditNoteButton_Click(object sender, EventArgs e)
		{
			ShowEditNoteForm();
		}

		private void RemoveNoteButton_Click(object sender, EventArgs e)
		{
			ShowRemoveNoteForm();
		}

		private void NotesListbox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (NotesListbox.SelectedIndex == -1)
			{
				return;
			}

			Note = Project.Notes[NotesListbox.SelectedIndex];
			SelectedNoteIndex = NotesListbox.SelectedIndex;
			TitleLabel.Text = Project.Notes[NotesListbox.SelectedIndex].Title;
			CreatedTextBox.Text = Project.Notes[NotesListbox.SelectedIndex].CreationTime.ToString();
			ModifiedTextBox.Text = Project.Notes[NotesListbox.SelectedIndex].LastModifiedTime.ToString();
			NoteCategoryLabel.Text = Project.Notes[NotesListbox.SelectedIndex].Category.ToString();
			ContentTextBox.Text = Project.Notes[NotesListbox.SelectedIndex].Content;
		}

		private void ShowAddNoteForm()
		{
			var addNoteForm = new AddEditNoteForm();
			var note = new Note();
			addNoteForm.Note = note;
			addNoteForm.UpdateNoteInfo();
			addNoteForm.ShowDialog();

			if (addNoteForm.DialogResult != DialogResult.OK)
			{
				return;
			}

			var addedNote = addNoteForm.Note;
			NotesListbox.Items.Add(addedNote.Title);
			Project.Notes.Add(addedNote);
		}

		private void ShowEditNoteForm()
		{
			if (Note == null)
			{
				return;
			}

			var editNoteForm = new AddEditNoteForm();
			editNoteForm.Note = Note;
			editNoteForm.UpdateNoteInfo();
			editNoteForm.ShowDialog();

			if (editNoteForm.DialogResult != DialogResult.OK)
			{
				return;
			}

			var editedNote = editNoteForm.Note;
			Project.Notes[SelectedNoteIndex] = editedNote;
			NotesListbox.Items[SelectedNoteIndex] = editedNote.Title;
		}

		private void ShowRemoveNoteForm()
		{
			var removeNoteForm = new RemoveNoteForm();

			if (Note == null)
			{
				return;
			}

			removeNoteForm.Note = Note;
			removeNoteForm.UpdateInfo();
			removeNoteForm.ShowDialog();

			if (removeNoteForm.DialogResult != DialogResult.OK)
			{
				return;
			}

			Project.Notes.Remove(Note);
			NotesListbox.Items.RemoveAt(SelectedNoteIndex);
		}
	}
}