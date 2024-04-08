using Newtonsoft.Json;
using NoteApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assert = NUnit.Framework.Legacy.ClassicAssert;

namespace NoteAppUnitTests
{
	public class ProjectManagerTest
	{
		private const string TestFilePath = "testfile.json";

		[Test]
		public void SaveToFile_SavesProjectToFile()
		{
			var project = new Project();
			ProjectManager.SaveToFile(project);

			bool fileExists = File.Exists(TestFilePath);

			Assert.IsTrue(fileExists);
		}

		[Test]
		public void LoadFromFile_ReturnsDeserializedProject()
		{
			var project = new Project();

			ProjectManager.SaveToFile(project);

			var loadedProject = ProjectManager.LoadFromFile();
			
			Assert.AreEqual(project, loadedProject);
		}

		[Test]
		public void LoadFromFile_ReturnsNullIfFileDoesNotExist()
		{
			if (File.Exists(TestFilePath))
			{
				File.Delete(TestFilePath);
			}

			var loadedProject = ProjectManager.LoadFromFile();

			Assert.Null(loadedProject);
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
