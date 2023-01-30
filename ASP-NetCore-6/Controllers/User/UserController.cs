using ASP_NetCore_6.Entity;
using ASP_NetCore_6.Enum;
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
    public void RegisterNewUser(User user)
    {
        user.country = "TC";
        user.Gender = Gender.FEMALE;
        user.surname = "Eren";
        _userService.characterCheck(user: user);
        _userService.CreateUser(user: user);
    }

}

// HOMEWORK
// it will be written in User service. A method will be written this page, user passwordss character size will be arranged min 20 max 35 if not will it fix return false
// register  