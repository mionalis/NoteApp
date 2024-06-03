namespace NoteApp;

using Newtonsoft.Json;

/// <summary>
/// Выполняет сериализацию и десериализацию данных.
/// </summary>
public static class ProjectManager
{ 
    /// <summary>
    /// Сериализует список заметок в файл.
    /// </summary>
    /// <param name="project">Объект класса Project, хранящий список созданных заметок.</param>
    public static void SaveToFile(Project project, string filePath)
    {
        var serializedProject = JsonConvert.SerializeObject(project);
        File.WriteAllText(filePath, serializedProject);
    }

    /// <summary>
    /// Десериализует список заметок из файла.
    /// </summary>
    /// <returns>Объект класса Project, хранящий список созданных заметок.</returns>>
    public static Project LoadFromFile(string filePath)
    {
        if (!File.Exists(filePath))
        {
            return null;
        }
        
        var jsonFileContent = File.ReadAllText(filePath);
        var deserializedProject = JsonConvert.DeserializeObject<Project>(jsonFileContent);

        return deserializedProject;
    }
}