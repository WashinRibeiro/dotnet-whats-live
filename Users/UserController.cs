using Microsoft.AspNetCore.Mvc;

namespace WhatsAppFinalApi.Users;

[ApiController, Route(template:"api/[controller]")]
public class UserController: ControllerBase
{
    [HttpGet]
    public IActionResult GetUser()
    {
        return Ok(UserFakeDb.Users);
    }
}