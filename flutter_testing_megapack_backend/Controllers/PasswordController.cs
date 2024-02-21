using flutter_testing_megapack_backend.Data;
using flutter_testing_megapack_backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace flutter_testing_megapack_backend.Controllers;

[ApiController]
[Route("password")]
public class PasswordController : ControllerBase
{
    // Get password where password is equal to the given password
    [HttpPost]
    public ActionResult GetPassword([FromBody] string passwrd)
    {
        var megapackDbContext = new MegapackDbContext();
        var password = megapackDbContext.Passwords.FirstOrDefault(p => p.Passwrd == passwrd);
        
        if (password == null)
        {
            return NotFound(new { Message = "Password with password " + passwrd + " not found" });
        }
        
        return Ok(password);
    }
    
    // Add password
    [HttpPost("add")]
    public ActionResult AddPassword([FromBody] string passwrd)
    {
        var megapackDbContext = new MegapackDbContext();
        var password = new Password(passwrd);
    
        megapackDbContext.Add(password);
        megapackDbContext.SaveChanges();
    
        return Ok(new { Message = "Added password: " + passwrd });
    }
}