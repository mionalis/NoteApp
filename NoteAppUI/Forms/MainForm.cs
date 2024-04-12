namespace NoteAppUI
{
	using Newtonsoft.Json.Bson;
	using NoteApp;
	using NoteAppUI.Forms;
	using System;
	using System.Diagnostics;
	using System.Windows.Forms;

	public partial class MainForm : Form
	{
		/// <summary>
		/// Выбранная заметка.
		/// </summary>
		private Note _selectedNote;

		/// <summary>
		/// Индекс выбранной заметки в списке.
		/// </summary>
		private int _selectedNoteIndex = -1;

		/// <summary>
		/// Экземпляр класса Project.
		/// </summary>
		private Project _project = new();

		/// <summary>
		/// Путь, по которому осуществляется сохранение и загрузка объекта класса Project.
		/// </summary>
		private const string FilePath = @"C:\Users\User\Documents\NoteApp.notes";

		public MainForm()
		{
			InitializeComponent();
			ClearNoteInfo();

			CategoryComboBox.Items.Add("All");

			foreach (var item in Enum.GetValues(typeof(NoteCategory)))
			{
				CategoryComboBox.Items.Add(item);
			}

			CategoryComboBox.SelectedIndex = 0;

			var project = ProjectManager.LoadFromFile(FilePath);

			if (project == null)
			{
				return;
			}

			var sortedNotes = _project.GetSortedNotes(project.Notes);

			foreach (var note in sortedNotes)
			{
				_project.Notes.Add(note);
				NotesListbox.Items.Add(note.Title);
			}

			if (project.SelectedNote != null)
			{ 
				NotesListbox.SelectedItem = project.SelectedNote.Title; 
			}
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

			var index = NotesListbox.SelectedIndex;
			_selectedNoteIndex = index;
			_selectedNote = _project.Notes[index];
			_project.SelectedNote = _selectedNote;
			ProjectManager.SaveToFile(_project, FilePath);

			TitleLabel.Text = _project.Notes[index].Title;
			CreatedTextBox.Text = _project.Notes[index].CreationTime.ToString();
			ModifiedTextBox.Text = _project.Notes[index].LastModifiedTime.ToString();
			NoteCategoryLabel.Text = _project.Notes[index].Category.ToString();
			ContentTextBox.Text = _project.Notes[index].Content;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			ProjectManager.SaveToFile(_project, FilePath);
		}

		/// <summary>
		/// Показывает форму добавления заметки. 
		/// Если пользователь нажал кнопку ОК, то заметка добавляется в список.
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

			SortNotesListBox(_project);
			ProjectManager.SaveToFile(_project, FilePath);
		}

		/// <summary>
		/// Показывает форму редактирования заметки. 
		/// Если пользователь нажал кнопку ОК, то изменения применяются к выбранной заметке.
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

			SortNotesListBox(_project);
		}

		/// <summary>
		/// Показывает окно удаления заметки.
		/// Если пользователь нажал кнопку OK, то выбранная заметка удаляется из списка.
		/// </summary>
		private void ShowRemoveNoteForm()
		{
			if (_selectedNote == null)
			{
				return;
			}

			var removingNoteMessage = $"Do you really want to remove this note: " +
				$"{_selectedNote.Title}?";

			DialogResult result = MessageBox.Show(
				removingNoteMessage,
				"Removing",
				MessageBoxButtons.OKCancel,
				MessageBoxIcon.Information);

			if (result != DialogResult.OK)
			{
				return;
			}

			_project.Notes.Remove(_selectedNote);
			NotesListbox.Items.RemoveAt(_selectedNoteIndex);
			ProjectManager.SaveToFile(_project, FilePath);
			ClearNoteInfo();
		}

		/// <summary>
		/// Очищает текстовые поля с информацией о выбранной заметке.
		/// </summary>
		private void ClearNoteInfo()
		{
			TitleLabel.Text = string.Empty;
			CreatedTextBox.Text = string.Empty;
			ModifiedTextBox.Text = string.Empty;
			NoteCategoryLabel.Text = string.Empty;
			ContentTextBox.Text = string.Empty;
		}

		private void SortNotesListBox(Project project)
		{
			var sortedNotes = project.GetSortedNotes(project.Notes);
			project.Notes = sortedNotes;
			NotesListbox.Items.Clear();

			foreach (var note in sortedNotes)
			{
				NotesListbox.Items.Add(note.Title);
			}
		}

		private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var filteredNotes = new List<Note>();

			if (CategoryComboBox.SelectedIndex == -1) 
			{ 
				return;
			}
			else if (CategoryComboBox.SelectedIndex == 0) 
			{
				filteredNotes = _project.Notes;
			}
			else
			{
				filteredNotes = _project.GetSortedNotes(
					_project.Notes,
					(NoteCategory)CategoryComboBox.SelectedItem);
			}

			NotesListbox.Items.Clear();
			foreach (var note in filteredNotes)
			{
				NotesListbox.Items.Add(note.Title);
			}
		}
	}
}