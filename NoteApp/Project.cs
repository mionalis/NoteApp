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
}