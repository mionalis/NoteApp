namespace NoteAppUnitTests
{
	using NoteApp;
	using NUnit.Framework;
	using Assert = NUnit.Framework.Legacy.ClassicAssert;

	[TestFixture]
	public class NoteTest
	{
		[Test]
		public void NoteTitleSet_CorrectValue()
		{
			var note = new Note();
			var testTitle = "New Title";

			note.Title = testTitle;

			Assert.AreEqual(testTitle, note.Title);
		}

		[Test]
		public void NoteContentSet_CorrectValue()
		{
			var note = new Note();
			var testContent = "New Content";

			note.Content = testContent;

			Assert.AreEqual(testContent, note.Content);
		}

		[Test]
		public void NoteCategorySet_CorrectValue()
		{
			var note = new Note();
			var testCategory = NoteCategory.Work;

			note.Category = testCategory;

			Assert.AreEqual(testCategory, note.Category);
		}

		[Test]
		public void NoteTitleGet_CorrectValue()
		{
			var expected = "Test Title";
			var note = new Note();

			note.Title = expected;
			var actual = note.Title;
			Assert.AreEqual(actual, expected);
		}

		[Test]
		public void NoteContentGet_CorrectValue()
		{
			var expected = "New Content";
			var note = new Note();

			note.Content = expected;
			var actual = note.Content;

			Assert.AreEqual(actual, expected);
		}

		[Test]
		public void NoteCategoryGet_CorrectValue()
		{
			var expected = NoteCategory.Work;
			var note = new Note();

			note.Category = expected;
			var actual = note.Category;

			Assert.AreEqual(actual, expected);
		}

		[Test]
		public void LastModifiedTimeGet_CorrectValue()
		{
			var note = new Note();

			Assert.AreEqual(DateTime.Now.Date, note.LastModifiedTime.Date);
		}

		[Test]
		public void CreationTimeGet_CorrectValue()
		{
			var note = new Note();

			Assert.AreEqual(DateTime.Now.Date, note.CreationTime.Date);
		}

		[Test]
		public void TestTitleSet_Longer50Symbols()
		{
			var wrongTitle = new string('A', 51);
			var note = new Note();
			Assert.Throws<ArgumentException>(
			() => { note.Title = wrongTitle; },
			"Должно возникать исключение, если название заметки длиннее 50 символов");
		}

		[Test]
		public void Clone_ReturnsSeparateInstanceWithSameValues()
		{
			string originalTitle = "Original Title";
			string originalContent = "Original Content";
			NoteCategory originalCategory = NoteCategory.Work;

			Note originalNote = new Note(originalTitle, originalContent, originalCategory);
			Note clonedNote = (Note)originalNote.Clone();

			Assert.AreEqual(originalNote, clonedNote);
		}
	}
}
