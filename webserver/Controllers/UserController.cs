using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace webserver.Controllers;

[ApiController]
[Route("[controller]")]

public class UserController: ControllerBase
{

[Route("login")]
[HttpGet]
public ActionResult Login()
{
    // 1. Create a random string of length with atleast 43 to 128 - Code Verifier
    // 2. Generate a hash code of the string - Code Challenge
    return Redirect("https://google.com");
}
}