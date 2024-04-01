using System.Reflection.Emit;

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
	public Note(string title, string content, NoteCategory category)
	{
		Title = title;
		Content = content;
		Category = category;
		CreationTime = DateTime.Now;
		LastModifiedTime = CreationTime;
		ID = IDGenerator.GetNextID();
	}

	/// <summary>
	/// Создаёт экземпляр класса <see cref="Note"/>.
	/// </summary>
	public Note()
	{
		CreationTime = DateTime.Now;
		LastModifiedTime = CreationTime;
		ID = IDGenerator.GetNextID();
	}

	/// <summary>
	/// Возвращает и задает заголовок заметки.
	/// </summary>
	public string Title
	{
		get => _title;
		set
		{
			var maxLength = 50;
			if (_title.Length > maxLength)
			{
				throw new ArgumentException(
					$"Invalid value in Title. Maximum string length exceeded: {maxLength}.");
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
	/// Возвращает и задает ID заметки.
	/// </summary>
	public int ID { get; set; }

	/// <summary>
	/// Возвращает и локально задает время последнего изменения заметки. Значение меняется при
	/// изменении названия, категории или текста заметки.
	/// </summary>
	public DateTime LastModifiedTime { get; private set; }

	/// <summary>
	/// Возвращает время создания заметки.
	/// </summary>
	public DateTime CreationTime { get; }

	/// <summary>
	/// Реализует интерфейс ICloneable.
	/// </summary>
	/// <returns>Копия объекта класса Note.</returns>
	public object Clone()
	{
		return new Note(Title, Content, Category);
	}
}