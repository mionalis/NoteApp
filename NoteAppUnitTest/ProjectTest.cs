using NoteApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteAppUnitTests
{
	[TestFixture]
	public class ProjectTest
	{
		[Test]
		public void ProjectNotesSet_CorrectValue()
		{
			var project = new Project();
			var testProject = new List<Note> { new() };

			project.Notes = testProject;

			Assert.That(testProject, Is.EqualTo(project.Notes));
		}

		[Test]
		public void ProjectNotesGet_CorrectValue()
		{
			var expected = new List<Note> { new() };
			var project = new Project();

			project.Notes = expected;
			var actual = project.Notes;

			Assert.That(actual, Is.EqualTo(expected));
		}
	}
}
