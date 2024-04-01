namespace NoteAppUI
{
	using NoteApp;

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			Note = new Note("������ �������", "������, ����", NoteCategory.Home);

			Project.Notes.Add(Note);

			//���������� ���������� Project � ����.
			ProjectManager.SaveToFile(Project);
			
			//�������� ������������ ���������� Project �� ����� � ��������� ���������� deserializedProject.
			var deserializedProject = ProjectManager.LoadFromFile();
			//����� ������ �� �����.
			ShowNotesInfo(deserializedProject);
		}

		/// <summary>
		/// ���������� � ������ ��������� �������.
		/// </summary>
		private Note Note { get; set; }

		/// <summary>
		/// ���������� � ������ ��������� ������ Project.
		/// </summary>
		private Project Project { get; set; } = new();

		private void checkButton_Click(object sender, EventArgs e)
		{
			var deserializedProject = ProjectManager.LoadFromFile();
			ShowNotesInfo(deserializedProject);
		}

		/// <summary>
		/// ���������� ������ ������ ������� � ������ ��� �������� ������ �������
		/// <see cref="Project"/> � <see cref="ProjectManager"/>.
		/// <param name="deserializedProject">��������� ������ Project, �������� ������ � ���������.</param>>
		/// </summary>
		private void ShowNotesInfo(Project deserializedProject)
		{
			IDLabel.Text = deserializedProject.Notes[0].ID.ToString();
			TitleLabel.Text = deserializedProject.Notes[0].Title;
			ContentLabel.Text = deserializedProject.Notes[0].Content;
			CategoryLabel.Text = deserializedProject.Notes[0].Category.ToString();
			LastModifiedTimeLabel.Text = deserializedProject.Notes[0].LastModifiedTime.ToString();
			CreationTimeLabel.Text = deserializedProject.Notes[0].CreationTime.ToString();
		}
	}
}