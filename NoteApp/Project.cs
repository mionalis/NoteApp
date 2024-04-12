namespace NoteApp;

/// <summary>
/// Содержит список всех заметок, созданных в приложении.
/// </summary>
public class Project
{
	/// <summary>
	/// Список созданных заметок в приложении.
	/// </summary>
	public List<Note> Notes { get; set; } = new();

	/// <summary>
	/// Возвращает список заметок, отсортированных по убыванию
	/// по времени редактирования.
	/// </summary>
	/// <param name="notes">Список заметок.</param>
	/// <returns>Отсортированный список заметок.</returns>

	public List<Note> GetSortedNotes(List<Note> notes)
	{
		return notes.OrderByDescending(note => note.LastModifiedTime).ToList();
	}

	/// <summary>
	/// Возвращает список заметок одной категории, отсортированных по убыванию
	/// по времени редактирования.
	/// </summary>
	/// <param name="notes">Список заметок.</param>
	/// <param name="category">Выбранная категория.</param>
	/// <returns>Отсортированный список заметок одной категории.</returns>
	public List<Note> GetSortedNotes(List<Note> notes, NoteCategory category)
	{
		var filteredNotes = notes.Where(
				note => note.Category == category).ToList();

		var sortedFilteredNotes = GetSortedNotes(filteredNotes);

		return sortedFilteredNotes;
	}
}