using flutter_testing_megapack_backend.Data;
using flutter_testing_megapack_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace flutter_testing_megapack_backend.Controllers;

[ApiController]
[Route("forum")]
public class ForumController : ControllerBase
{
    // TODO: FIX THIS
    
    // // add user
    // [HttpPost("users/register")]
    // public ActionResult Register([FromBody] string name, [FromBody] string password)
    // {
    //     var megapackDbContext = new MegapackDbContext();
    //     var existingUser = megapackDbContext.Users.FirstOrDefault(u => u.Name == name);
    //     
    //     if (existingUser != null)
    //     {
    //         return NotFound(new { Message = "User with name " + name + " not found" });
    //     }
    //     
    //     var user = new User(name, password);
    //     
    //     megapackDbContext.Add(user);
    //     megapackDbContext.SaveChanges();
    //     
    //
    //     return RedirectToAction("Login", "Forum", new { name = name, password = password });
    // }
    //
    // // Get user id by name and password
    // [HttpPost("users/login")]
    // public ActionResult Login([FromBody] string name, [FromBody] string password)
    // {
    //     var megapackDbContext = new MegapackDbContext();
    //     var user = megapackDbContext.Users.FirstOrDefault(u => u.Name == name && u.Password == password);
    //     
    //     if (user == null)
    //     {
    //         return NotFound(new { Message = "User with name " + name + " and password " + password + " not found" });
    //     }
    //     
    //     return Ok(new { UserId = user.Id });
    // }
    //
    // // Get all posts
    // [HttpGet("posts")]
    // public ActionResult GetPosts()
    // {
    //     var megapackDbContext = new MegapackDbContext();
    //     var posts = megapackDbContext.Posts;
    //     
    //     return Ok(posts);
    // }
    //
    // // Add post
    // [HttpPost("posts")]
    // public ActionResult AddPost([FromBody] string title, [FromBody] string content, [FromBody] int userId)
    // {
    //     var megapackDbContext = new MegapackDbContext();
    //     var post = new Post(userId, title, content, DateTime.Now, false);
    //     
    //     megapackDbContext.Add(post);
    //     megapackDbContext.SaveChanges();
    //     
    //     return Ok(new { Message = "Added post: " + title });
    // }
    //
    // // Edit post
    // [HttpPut("posts/{id:int}")]
    // public ActionResult EditPost(int id, [FromBody] string title, [FromBody] string content)
    // {
    //     var megapackDbContext = new MegapackDbContext();
    //     var post = megapackDbContext.Posts.Find(id);
    //     
    //     if (post == null)
    //     {
    //         return NotFound(new { Message = "Post with id " + id + " not found" });
    //     }
    //     
    //     post.Title = title;
    //     post.Content = content;
    //     post.IsEdited = true;
    //     
    //     megapackDbContext.SaveChanges();
    //     
    //     return Ok(new { Message = "Edited post with id " + id });
    // }
    //
    // // Delete post
    // [HttpDelete("posts/{id:int}")]
    // public ActionResult DeletePost(int id)
    // {
    //     var megapackDbContext = new MegapackDbContext();
    //     var post = megapackDbContext.Posts.Find(id);
    //     
    //     if (post == null)
    //     {
    //         return NotFound(new { Message = "Post with id " + id + " not found" });
    //     }
    //     
    //     megapackDbContext.Remove(post);
    //     megapackDbContext.SaveChanges();
    //     
    //     return Ok(new { Message = "Deleted post with id " + id });
    // }
    //
    // // Get all comments
    // [HttpGet("comments")]
    // public ActionResult GetComments()
    // {
    //     var megapackDbContext = new MegapackDbContext();
    //     var comments = megapackDbContext.Comments;
    //     
    //     return Ok(comments);
    // }
    //
    // // Add comment
    // [HttpPost("comments")]
    // public ActionResult AddComment([FromBody] string content, [FromBody] int userId, [FromBody] int postId)
    // {
    //     var megapackDbContext = new MegapackDbContext();
    //     var comment = new Comment(userId, postId, content, DateTime.Now, false);
    //     
    //     megapackDbContext.Add(comment);
    //     megapackDbContext.SaveChanges();
    //     
    //     return Ok(new { Message = "Added comment: " + content });
    // }
    //
    // // Edit comment
    // [HttpPut("comments/{id:int}")]
    // public ActionResult EditComment(int id, [FromBody] string content)
    // {
    //     var megapackDbContext = new MegapackDbContext();
    //     var comment = megapackDbContext.Comments.Find(id);
    //     
    //     if (comment == null)
    //     {
    //         return NotFound(new { Message = "Comment with id " + id + " not found" });
    //     }
    //     
    //     comment.Content = content;
    //     comment.IsEdited = true;
    //     
    //     megapackDbContext.SaveChanges();
    //     
    //     return Ok(new { Message = "Edited comment with id " + id });
    // }
    //
    // // Delete comment
    // [HttpDelete("comments/{id:int}")]
    // public ActionResult DeleteComment(int id)
    // {
    //     var megapackDbContext = new MegapackDbContext();
    //     var comment = megapackDbContext.Comments.Find(id);
    //     
    //     if (comment == null)
    //     {
    //         return NotFound(new { Message = "Comment with id " + id + " not found" });
    //     }
    //     
    //     megapackDbContext.Remove(comment);
    //     megapackDbContext.SaveChanges();
    //     
    //     return Ok(new { Message = "Deleted comment with id " + id });
    // }
}