using ASP_NetCore_6.Dto;
using ASP_NetCore_6.Service;
using Microsoft.AspNetCore.Mvc;
using Quickwire.Attributes;

namespace ASP_NetCore_6.Controllers;

[RegisterService, InjectAllInitOnlyProperties]
public class UserController : Controller
{
    private UserService _userService { get; init; }

    [HttpGet, Route("/register")]
    public IActionResult Register() => View();

    [HttpPost, Route("/register")]
    public void RegisterNewUser(UserDto userDto)
    {
        var user = _userService.createFromDto(userDto);
    }

    [HttpGet, Route(("/login"))]
    public IActionResult Login() => View();
    
    [HttpPost, Route("/login")]
    public IActionResult RegisterNewUsers(UserDto userDto)
    {
        var user = _userService.findByEmailAndPassword(userDto.email, userDto.password);
        if (user == null)
        {
            //error mesg
        }
        HttpContext.Session.SetString("myUsername",user.username);
        
        return Redirect("/");
    }
}


