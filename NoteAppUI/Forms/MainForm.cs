namespace NoteAppUI
{
	using NoteApp;
	using NoteAppUI.Forms;
	using System.Windows.Forms;

	public partial class MainForm : Form
	{

		/// <summary>
		/// ��������� �������.
		/// </summary>
		private Note _selectedNote;

		/// <summary>
		/// ������ ��������� ������� � ������.
		/// </summary>
		private int _selectedNoteIndex = -1;

		/// <summary>
		/// ��������� ������ Project.
		/// </summary>
		private Project _project = new();

		public MainForm()
		{
			InitializeComponent();
		}

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

			_selectedNote = _project.Notes[NotesListbox.SelectedIndex];
			_selectedNoteIndex = NotesListbox.SelectedIndex;
			TitleLabel.Text = _project.Notes[NotesListbox.SelectedIndex].Title;
			CreatedTextBox.Text = _project.Notes[NotesListbox.SelectedIndex].CreationTime.ToString();
			ModifiedTextBox.Text = _project.Notes[NotesListbox.SelectedIndex].LastModifiedTime.ToString();
			NoteCategoryLabel.Text = _project.Notes[NotesListbox.SelectedIndex].Category.ToString();
			ContentTextBox.Text = _project.Notes[NotesListbox.SelectedIndex].Content;
		}

		/// <summary>
		/// ���������� ����� ���������� �������. 
		/// ���� ������������ ����� ������ ��, �� ������� ����������� � ������.
		/// </summary>
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
			_project.Notes.Add(addedNote);
		}

		/// <summary>
		/// ���������� ����� �������������� �������. 
		/// ���� ������������ ����� ������ ��, �� ��������� ����������� � ��������� �������.
		/// </summary>
		private void ShowEditNoteForm()
		{
			if (_selectedNote == null)
			{
				return;
			}

			var editNoteForm = new AddEditNoteForm();
			editNoteForm.Note = _selectedNote;
			editNoteForm.UpdateNoteInfo();
			editNoteForm.ShowDialog();

			if (editNoteForm.DialogResult != DialogResult.OK)
			{
				return;
			}

			var editedNote = editNoteForm.Note;
			_project.Notes[_selectedNoteIndex] = editedNote;
			NotesListbox.Items[_selectedNoteIndex] = editedNote.Title;
		}

		/// <summary>
		/// ���������� ���� �������� �������.
		/// ���� ������������ ����� ������ OK, �� ��������� ������� ��������� �� ������.
		/// </summary>
		private void ShowRemoveNoteForm()
		{
			var removeNoteForm = new RemoveNoteForm();

			if (_selectedNote == null)
			{
				return;
			}

			removeNoteForm.Note = _selectedNote;
			removeNoteForm.UpdateInfo();
			removeNoteForm.ShowDialog();

			if (removeNoteForm.DialogResult != DialogResult.OK)
			{
				return;
			}

			_project.Notes.Remove(_selectedNote);
			NotesListbox.Items.RemoveAt(_selectedNoteIndex);
		}
	}
}