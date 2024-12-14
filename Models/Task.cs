namespace cloud_final_project.Models;
public class Task
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsCompleted { get; set; }

    // Constructor
    public Task(int id, string description, bool isCompleted)
    {
        Id = id;
        Name = description;
        IsCompleted = isCompleted;
    }
}

