namespace NoteAppUI
{
	using NoteApp;

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			Note = new Note("Список покупок", "Молоко, хлеб", NoteCategory.Home);

			Project.Notes.Add(Note);

			//Сохранение экземпляра Project в файл.
			ProjectManager.SaveToFile(Project);
			
			//Загрузка сохраненного экземпляра Project из файла в локальную переменную deserializedProject.
			var deserializedProject = ProjectManager.LoadFromFile();
			//Вывод данных на экран.
			ShowNotesInfo(deserializedProject);
		}

		/// <summary>
		/// Возвращает и задает созданную заметку.
		/// </summary>
		private Note Note { get; set; }

		/// <summary>
		/// Возвращает и задает экземпляр класса Project.
		/// </summary>
		private Project Project { get; set; } = new();

		private void checkButton_Click(object sender, EventArgs e)
		{
			var deserializedProject = ProjectManager.LoadFromFile();
			ShowNotesInfo(deserializedProject);
		}

		/// <summary>
		/// Отображает данные первой заметки в списке для проверки работы классов
		/// <see cref="Project"/> и <see cref="ProjectManager"/>.
		/// <param name="deserializedProject">Экземпляр класса Project, хранящий список с заметками.</param>>
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