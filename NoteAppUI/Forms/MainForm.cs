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
		/// ���������� � ������ ��������� �������.
		/// </summary>
		private Note Note { get; set; }

		private int SelectedNoteIndex { get; set; } = -1;

		/// <summary>
		/// ���������� � ������ ��������� ������ Project.
		/// </summary>
		private Project Project { get; set; } = new();

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void AddNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var addNoteForm = new AddEditNoteForm();
			addNoteForm.Show();
		}

		private void EditNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var editNoteForm = new AddEditNoteForm();
			editNoteForm.Show();
		}

		private void DeleteNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var aboutForm = new AboutForm();
			aboutForm.Show();
		}

		private void AddNoteButton_Click(object sender, EventArgs e)
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
			
			Note = addNoteForm.Note;
			NotesListbox.Items.Add(Note.Title);
			Project.Notes.Add(Note);
		}

		private void EditNoteButton_Click(object sender, EventArgs e)
		{
			var editNoteForm = new AddEditNoteForm();
			editNoteForm.Note = Note;
			editNoteForm.UpdateNoteInfo();
			editNoteForm.ShowDialog();

			if (editNoteForm.DialogResult != DialogResult.OK)
			{
				return;
			}
			
			Note = editNoteForm.Note;
			Project.Notes[SelectedNoteIndex] = Note;
			NotesListbox.Items[SelectedNoteIndex] = Note.Title;
		}

		private void DeleteNoteButton_Click(object sender, EventArgs e)
		{

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
	}
}