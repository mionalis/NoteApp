using Newtonsoft.Json;
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
	public class ProjectManagerTest
	{
		private const string TestFilePath = @"C:\Users\User\Documents\NoteApp.notes";

		[Test]
		public void SaveToFile_SavesProjectToFile()
		{
			var project = new Project();
			ProjectManager.SaveToFile(project);

			bool fileExists = File.Exists(TestFilePath);

			Assert.That(fileExists, Is.True);
		}

		[Test]
		public void LoadFromFile_ReturnsDeserializedProject()
		{
			var project = new Project();

			ProjectManager.SaveToFile(project);

			var loadedProject = ProjectManager.LoadFromFile();
			
			Assert.That(loadedProject.Notes, Is.EqualTo(project.Notes));
		}

		[Test]
		public void LoadFromFile_ReturnsNullIfFileDoesNotExist()
		{
			if (File.Exists(TestFilePath))
			{
				File.Delete(TestFilePath);
			}

			var loadedProject = ProjectManager.LoadFromFile();

			Assert.That(loadedProject, Is.Null);
		}

		[TearDown]
		public void CleanUp()
		{
			if (File.Exists(TestFilePath))
			{
				File.Delete(TestFilePath);
			}
		}
	}
}
