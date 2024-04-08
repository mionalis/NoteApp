using NoteApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteAppUnitTests
{
	internal class NoteTest
	{
		[Test]
		public void NoteTitleSet_CorrectValue()
		{
			var note = new Note();
			var testTitle = "New Title";

			note.Title = testTitle;

			Assert.That(testTitle, Is.EqualTo(note.Category));
		}

		[Test]
		public void NoteContentSet_CorrectValue()
		{
			var note = new Note();
			var testContent = "New Content";

			note.Content = testContent;

			Assert.That(testContent, Is.EqualTo(note.Category));
		}

		[Test]
		public void NoteCategorySet_CorrectValue()
		{
			var note = new Note();
			var testCategory = NoteCategory.Work;

			note.Category = testCategory;

			Assert.That(testCategory, Is.EqualTo(note.Category));
		}

		[Test]
		public void NoteTitleGet_CorrectValue()
		{
			var expected = "Test Title";
			var note = new Note();

			note.Title = expected;
			var actual = note.Title;
			Assert.That(actual, Is.EqualTo(expected));
		}

		[Test]
		public void NoteContentGet_CorrectValue()
		{
			var expected = "New Content";
			var note = new Note();

			note.Content = expected;
			var actual = note.Content;

			Assert.That(actual, Is.EqualTo(expected));
		}

		[Test]
		public void NoteCategoryGet_CorrectValue()
		{
			var expected = NoteCategory.Work;
			var note = new Note();

			note.Category = expected;
			var actual = note.Category;

			Assert.That(actual, Is.EqualTo(expected));
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
	}
}
