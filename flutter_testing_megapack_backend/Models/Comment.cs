namespace flutter_testing_megapack_backend.Models;

public class Comment(int userId, int postId, string content, DateTime createdAt, bool isEdited)
{
    public int Id { get; set; }
    public int UserId { get; set; } = userId;
    public int PostId { get; set; } = postId;
    public string Content { get; set; } = content;
    public DateTime CreatedAt { get; set; } = createdAt;
    public bool IsEdited { get; set; } = isEdited;
}