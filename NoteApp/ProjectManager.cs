namespace NoteApp;

using Newtonsoft.Json;

public class ProjectManager
{
    /// <summary>
    /// Путь, по которому осуществляется сохранение и загрузка объекта класса Project.
    /// </summary>
    private const string FilePath = @"C:\Users\User\Documents\NoteApp.notes";
    
    /// <summary>
    /// Сериализует список заметок в файл.
    /// </summary>
    /// <param name="project">Объект класса Project, хранящий список созданных заметок.</param>
    public static void SaveToFile(Project project)
    {
        var serializedProject = JsonConvert.SerializeObject(project);
        File.WriteAllText(FilePath, serializedProject);
    }

    /// <summary>
    /// Десериализует список заметок из файла.
    /// </summary>
    /// <returns>Объект класса Project, хранящий список созданных заметок.</returns>>
    public static Project LoadFromFile()
    {
        if (!File.Exists(FilePath))
        {
            return null;
        }
        
        var jsonFileContent = File.ReadAllText(FilePath);
        var deserializedProject = JsonConvert.DeserializeObject<Project>(jsonFileContent);

        return deserializedProject;
    }
}