namespace flutter_testing_megapack_backend.Models;

public class TodoItem(string name, bool isDone)
{
    public int Id { get; set; }
    public string Name { get; set; } = name;
    public bool IsDone { get; set; } = isDone;
}


