namespace NoteApp
{
	/// <summary>
	/// Генерирует ID объектов.
	/// </summary>
	public static class IDGenerator
	{
		/// <summary>
		/// Счетчик ID.
		/// </summary>
		private static int _counterID;

		/// <summary>
		/// При каждом вызове метода увеличивает значение счетчика на единицу.
		/// </summary>
		/// <returns>ID объекта.</returns>
		public static int GetNextID()
		{
			return _counterID++;
		}
	}
}
