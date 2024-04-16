using Newtonsoft.Json;

namespace NoteApp;

/// <summary>
/// Описывает заметку.
/// </summary>
public class Note : ICloneable
{
	/// <summary>
	/// Заголовок заметки.
	/// </summary>
	private string _title = "Untitled";

	/// <summary>
	/// Содержание заметки.
	/// </summary>
	private string _content;

	/// <summary>
	/// Категория заметки.
	/// </summary>
	private NoteCategory _category;

	/// <summary>
	/// Создаёт экземпляр класса <see cref="Note"/>.
	/// </summary>
	/// <param name="title">Заголовок заметки.</param>
	/// <param name="content">Текст заметки.</param>
	/// <param name="category">Категория заметки.</param>
	/// <param name="creationTime">Время создания заметки.</param>
	/// <param name="lastModifiedTime">Время последнего изменения заметки.</param>
	[JsonConstructor]
	public Note(
		string title, 
		string content,
		NoteCategory category,
		DateTime creationTime, 
		DateTime lastModifiedTime)
	{
		Title = title;
		Content = content;
		Category = category;
		CreationTime = creationTime;
		LastModifiedTime = lastModifiedTime;
	}

	/// <summary>
	/// Создаёт экземпляр класса <see cref="Note"/>.
	/// </summary>
	/// <param name="title">Заголовок заметки.</param>
	/// <param name="content">Текст заметки.</param>
	/// <param name="category">Категория заметки.</param>
	public Note(string title, string content, NoteCategory category)
	{
		Title = title;
		Content = content;
		Category = category;
		LastModifiedTime = DateTime.Now;
	}

	/// <summary>
	/// Создаёт экземпляр класса <see cref="Note"/>.
	/// </summary>
	public Note()
	{
		CreationTime = DateTime.Now;
		LastModifiedTime = CreationTime;
	}

	/// <summary>
	/// Возвращает и задает заголовок заметки.
	/// </summary>
	public string Title
	{
		get => _title;
		set
		{
			var maxStringLength = 50;

			if (_title == ValueValidator.AssertStringOnLength(
				value,
				maxStringLength, 
				nameof(Title)))
			{
				return;
			}

			_title = value;
			LastModifiedTime = DateTime.Now;
		}
	}

	/// <summary>
	/// Возвращает и задает текст заметки.
	/// </summary>
	public string Content
	{
		get => _content;
		set
		{
			_content = value;
			LastModifiedTime = DateTime.Now;
		}
	}

	/// <summary>
	/// Возвращает и задает категорию заметки.
	/// </summary>
	public NoteCategory Category
	{
		get => _category;
		set
		{
			_category = value;
			LastModifiedTime = DateTime.Now;
		}
	}

	/// <summary>
	/// Возвращает и локально задает время последнего изменения заметки. Значение меняется при
	/// изменении названия, категории или текста заметки.
	/// </summary>
	public DateTime LastModifiedTime { get; private set; }

	/// <summary>
	/// Возвращает время создания заметки.
	/// </summary>
	public DateTime CreationTime { get; } = DateTime.Now;

	/// <summary>
	/// Реализует интерфейс ICloneable.
	/// </summary>
	/// <returns>Копия объекта класса Note.</returns>
	public object Clone()
	{
		return new Note(Title, Content, Category);
	}
}