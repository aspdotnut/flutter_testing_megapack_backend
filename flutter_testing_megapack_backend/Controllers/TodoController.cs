using flutter_testing_megapack_backend.Data;
using flutter_testing_megapack_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace flutter_testing_megapack_backend.Controllers;

[ApiController]
[Route("todo")]
public class TodoController : ControllerBase
{
    // Get all todo items
    [HttpGet]
    public ActionResult GetAllTodoItems()
    {
        var megapackDbContext = new MegapackDbContext();
        var todoItems = megapackDbContext.TodoItems;
        
        return Ok(todoItems);
    }
    
    // Add todo item
    [HttpPost]
    public ActionResult AddTodoItem([FromBody] string name)
    {
        var megapackDbContext = new MegapackDbContext();
        var todoItem = new TodoItem(name, false);
        
        megapackDbContext.Add(todoItem);
        megapackDbContext.SaveChanges();
        
        return Ok(new { Message = "Added todo item: " + name });
    }
    
    // Set todo item status
    [HttpPut("{id:int}")]
    public ActionResult SetTodoItemStatus(int id)
    {
        var megapackDbContext = new MegapackDbContext();
        var todoItem = megapackDbContext.TodoItems.Find(id);
        
        if (todoItem == null)
        {
            return NotFound(new { Message = "Todo item with id " + id + " not found" });
        }
        
        todoItem.IsDone = !todoItem.IsDone;
        
        megapackDbContext.SaveChanges();
        
        return Ok(new { Message = "Set todo item with id " + id + " to " + todoItem.IsDone });
    }
    
    // Delete todo item
    [HttpDelete("{id:int}")]
    public ActionResult DeleteTodoItem(int id)
    {
        var megapackDbContext = new MegapackDbContext();
        var todoItem = megapackDbContext.TodoItems.Find(id);
        
        if (todoItem == null)
        {
            return NotFound(new { Message = "Todo item with id " + id + " not found" });
        }
        
        megapackDbContext.Remove(todoItem);
        megapackDbContext.SaveChanges();
        
        return Ok(new { Message = "Deleted todo item with id " + id });
    }
}