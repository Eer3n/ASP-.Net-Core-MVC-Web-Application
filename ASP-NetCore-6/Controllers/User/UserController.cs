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
}


