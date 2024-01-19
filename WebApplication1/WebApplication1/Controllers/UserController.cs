
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;

namespace WebApplication1.Controllers {

[ApiController]
public class UserController : ControllerBase {

    private readonly ILogger<UserController> _logger;

    public UserController(ILogger<UserController> logger){

        this._logger = logger;

    }

} 

}