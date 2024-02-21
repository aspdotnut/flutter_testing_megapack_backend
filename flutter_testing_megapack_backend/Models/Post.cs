namespace flutter_testing_megapack_backend.Models;

public class Post( int userId, string title, string content, DateTime createdAt, bool isEdited)
{
    public int Id { get; set; }
    public int UserId { get; set; } = userId;
    public string Title { get; set; } = title;
    public string Content { get; set; } = content;
    public DateTime CreatedAt { get; set; } = createdAt;
    public bool IsEdited { get; set; } = isEdited;
}