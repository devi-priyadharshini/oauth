using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using AutoMapper;

namespace webserver.Controllers;

[ApiController]
[Route("[controller]")]

public class UserController: ControllerBase
{

    IMapper _mapper;
    public UserController(IMapper mapper)
    {
        _mapper = mapper;
    }

[Route("login")]
[HttpGet]
[Consumes("application/x-www-form-urlencoded")]
public ActionResult Login([FromQuery]ClientCredentialDto clientCredDto) 
{
       var clientID = _mapper.Map<ClientCredential>(clientCredDto);

    if(!string.IsNullOrEmpty(clientID.ClientId))
        clientID.ClientId = " Client ID received successfully";

    if(!string.IsNullOrEmpty(clientID.ClientSecret))
        clientID.ClientSecret = "Client Secret receives successfully";  

    var response = _mapper.Map<ClientCredentialDto>(clientID);
     return Ok(response);
}
}