using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ToDoManager.Models;

namespace ToDoManager.Services
{
    /// <summary>
    /// JSON形式のTodoItemシリアライザ
    /// </summary>
    public class JsonTodoItemSerializer : ITodoItemSerializer
    {
        public void Save(string vFilePath, List<TodoItem> vItems)
        {
            var vJson = JsonConvert.SerializeObject(vItems, Formatting.Indented);
            File.WriteAllText(vFilePath, vJson);
        }

        public List<TodoItem> Load(string filePath)
        {
            var wJson = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<TodoItem>>(wJson);
        }
    }
}
